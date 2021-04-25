using OrderBentoSystem.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderBentoSystem.Services
{
    public class s_Order : Entities
    {
        // 存放目前的訂單主表資料(查詢OD專用)
        private Proc_GetOrder_Result OrderInfo = new Proc_GetOrder_Result();
        public Proc_GetOrder_Result orderInfo
        {
            get => this.OrderInfo;
            set => this.OrderInfo = value;
        }
        // 存放目前的訂單明細資料(查詢OD專用)
        private List<Proc_GetOrderDetail_Result> List_OrderDetailInfo = new List<Proc_GetOrderDetail_Result>();
        public List<Proc_GetOrderDetail_Result> list_OrderDetailInfo
        {
            get => this.List_OrderDetailInfo;
            set => this.List_OrderDetailInfo = value;
        }
        // 目前選擇的訂單明細項目
        private Proc_GetOrderDetail_Result SelectOrderDetailInfo = new Proc_GetOrderDetail_Result();
        // 設定目前選擇的訂單明細項目
        public void SetSelectODInfo(int Index)
        {
            this.SelectOrderDetailInfo = List_OrderDetailInfo[Index];
        }

        // 存放目前的訂單明細統計資料(查詢OD專用)
        private List<Proc_GetODStatistics_Result> List_ODStatistics = new List<Proc_GetODStatistics_Result>();
        public List<Proc_GetODStatistics_Result> list_ODStatistics
        {
            get => this.List_ODStatistics;
            set => this.List_ODStatistics = value;
        }


        // 存放目前的訂單主表(加入訂單使用)
        private Orders Orders = new Orders();
        public Orders order
        {
            get => this.Orders;
            set => this.Orders = value;
        }
        // 存放目前的訂單明細(加入或是選取時可使用)
        private OrderDetail OrderDetail = new OrderDetail();
        public OrderDetail orderDetail
        {
            get => this.OrderDetail;
            set => this.OrderDetail = value;
        }


        /// <summary>
        /// 小計
        /// </summary>
        /// <param name="OrderNumber"></param>
        /// <returns></returns>
        public double Cal_OrderAmount()
        {
            double Amount = 0.0;
            // 取得特定訂單的所有明細
            var getOrderDetail = context.OrderDetail.Where(od => od.O_Number == Orders.O_Number).ToList();
            // 訂單明細少於1就直接回傳0
            if (getOrderDetail.Count < 1) return Amount;
            // 所有訂單明細的小計加總起來
            foreach (var Detail in getOrderDetail)
            {
                Amount += (double)Detail.Subtotal;
            }
         
            return Amount;
        }

        public double Cal_OrderAmount2()
        {
            double Amount = 0.0;
            // 取得特定訂單的所有明細
            var getOrderDetail = context.OrderDetail.Where(od => od.O_Number == OrderInfo.O_Number).ToList();
            // 訂單明細少於1就直接回傳0
            if (getOrderDetail.Count < 1) return Amount;
            // 所有訂單明細的小計加總起來
            foreach (var Detail in getOrderDetail)
            {
                Amount += (double)Detail.Subtotal;
            }

            return Amount;
        }

        /// <summary>
        /// 取得訂單資料(OD用)
        /// </summary>
        /// <returns></returns>
        public rMessage GetOrderInfo()
        {
            rMessage msgInfo = new rMessage();
            try
            {
                // 取得日期
                var OrderDate = DateTime.Now.ToString("yyyyMMdd");
                var ClassCode = s_Student.Select_Class.C_Code;
                // 組合訂單號碼
                var orderNum = OrderDate + ClassCode;
                // 取出訂單
                OrderInfo = context.Proc_GetOrder(orderNum).FirstOrDefault();
                if (OrderInfo == null)
                {
                    msgInfo.isSuccess = false;
                    msgInfo.msg = "目前無訂單資料";
                    return msgInfo;
                };
                // 確認有訂單開始取出明細
                List_OrderDetailInfo = context.Proc_GetOrderDetail(OrderInfo.O_Number, "").ToList();
                // 取出統計資料
                List_ODStatistics = context.Proc_GetODStatistics(OrderInfo.O_Number).ToList();
                msgInfo.isSuccess = true;
                msgInfo.msg = "成功取得訂單資料";
            }
            catch (Exception)
            {
                msgInfo.isSuccess = false;
                msgInfo.msg = "取得訂單資料發生問題!";
            }
            return msgInfo;
        }

        // 取得訂單
        public void GetOrder()
        {
            // 取得日期
            var OrderDate = DateTime.Now.ToString("yyyyMMdd");
            var ClassCode = s_Student.Select_Class.C_Code;
            // 組合訂單號碼
            var orderNum = OrderDate + ClassCode;
            // 取出資料
            Orders = context.Orders.Where(m => m.O_Number.Contains(orderNum) && m.IsFinish == 0).FirstOrDefault();
        }

        // 寫入訂單資料
        public rMessage addOrder()
        {
            rMessage msgInfo = new rMessage();
            try
            {
                // 第一次加入訂單, 切換班級也要清除訂單號碼(UI要去存放與清除)
                if (Orders == null || Orders.O_Number == "")
                {
                    Orders = new Orders();
                    // 建立訂單號碼
                    var getDate = DateTime.Now.ToString("yyyyMMdd");
                    var getDateType = DateTime.Now;
                    var ClassCode = s_Student.Select_Class.C_Code;
                    Orders.O_Number = getDate + ClassCode;
                    Orders.O_Date = Convert.ToDateTime(getDateType);
                    Orders.C_Code = s_Student.Select_Class.C_Code;
                    Orders.OnDuty = s_OnDuty.Now_OnDuty.S_Code;
                    Orders.IsFinish = 0;
                    Orders.Amount = orderDetail.Subtotal;                    
                }
                OrderDetail.O_Number = Orders.O_Number;

                // 判斷今天是否已經有完成的訂單
                var isFinishOrder = context.Orders.Where(m => m.O_Number == Orders.O_Number
                    && m.IsFinish == 1).Count();
                // 有完成的訂單要再重新調整訂單號碼
                if (isFinishOrder >= 1)
                {
                    // 原訂單號碼再補上數量
                    Orders.O_Number += "-" + isFinishOrder + 1;
                    // orderDetail.OrderNumber = order.OrderNumber;
                }
                // 加入明細資料(因為方便先計算總金額所以才先寫進去,但要注意如果訂單加入失敗需要移除該明細)
                context.OrderDetail.Add(OrderDetail);
                // 判斷是否已經有訂單資料
                var isOrder = context.Orders.Where(m => m.O_Number == Orders.O_Number
                    && m.IsFinish == 0).Any();
                if (!isOrder)
                {
                    // 沒有:加入訂單資料
                    context.Orders.Add(Orders);
                }
                else
                {
                    // 有:修改訂單的總金額
                    var amount = Cal_OrderAmount();
                    // 補上最新加入的明細資料小計
                    if (OrderDetail != null)
                    {
                        amount += (double)OrderDetail.Subtotal;
                    }
                    // 取出資料並修改總金額,First是沒有資料就會報錯要小心
                    var updateOrder = context.Orders.Where(o => o.O_Number == Orders.O_Number).First();
                    updateOrder.Amount = (decimal)amount;
                }
                // 執行上面做的資料庫操作
                context.SaveChanges();
                msgInfo.isSuccess = true;
                msgInfo.msg = "訂單加入成功!";
            }
            catch (Exception)
            {
                msgInfo.isSuccess = false;
                msgInfo.msg = "訂單加入失敗!";
            }         
            return msgInfo;
        }

        /// <summary>
        /// 移除明細
        /// </summary>
        /// <param name="AllRemove"></param>
        /// <returns></returns>
        public rMessage Remove_OrderDetail(bool AllRemove)
        {
            rMessage msgInfo = new rMessage();
            try
            {
                if (OrderInfo.O_Number == null || OrderInfo.O_Number == "")
                {
                    msgInfo.msg = "訂單號碼遺失, 請重新操作";
                    msgInfo.isSuccess = false;
                    return msgInfo;
                }
                // 判斷訂單明細是否全部移除
                if (AllRemove)
                {
                    //// 取出範圍
                    var d_data = context.OrderDetail.Where(od => od.O_Number == OrderInfo.O_Number).ToList();
                    context.OrderDetail.RemoveRange(d_data);
                }
                else
                {
                    // 取出單筆
                    var d_data = context.OrderDetail.Where(od => od.id == SelectOrderDetailInfo.id &&
                                                    od.O_Number == SelectOrderDetailInfo.O_Number).First();
                    context.OrderDetail.Remove(d_data);
                }
                // 執行修改
                context.SaveChanges();

                //// 更新訂單主表總金額
                var UpdateOrder = context.Orders.Where(m => m.O_Number == OrderInfo.O_Number && m.IsFinish == 0).First();
                UpdateOrder.Amount = (decimal)Cal_OrderAmount2();
                // 執行修改
                context.SaveChanges();

                msgInfo.isSuccess = true;
                msgInfo.msg = "訂單明細刪除成功";
            }
            catch (Exception)
            {
                msgInfo.isSuccess = false;
                msgInfo.msg = "訂單明細刪除失敗!";
            } 
            return msgInfo;
        }

        public void OrderSave()
        {
            if (List_OrderDetailInfo.Count >0)
            {
                string strFilePath = @"C:\Users\iii\Desktop\";
                // 產生隨機數字
                Random myRnd = new Random();
                // 範圍1000~9999
                int myNum = myRnd.Next(1000, 9999);
                string strFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + myNum + ".txt";
                string strFullPathName = strFilePath + strFileName;

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.InitialDirectory = strFullPathName;
                sfd.FileName = strFileName;
                sfd.Filter = "Text File|*.txt";
                // 不OK就取消
                if (sfd.ShowDialog() == DialogResult.Cancel) return;

                strFullPathName = sfd.FileName;
                List<string> list_MenuOutput = new List<string>();

                list_MenuOutput.Add("<<++++         拉麵訂購單        ++++>>");
                list_MenuOutput.Add("--------------------------------------");
                list_MenuOutput.Add($"訂購日期:{OrderInfo.O_Date}");
                list_MenuOutput.Add($"值日生:{OrderInfo.S_Name}");
                list_MenuOutput.Add($"訂購班級:{OrderInfo.C_Name}");
                list_MenuOutput.Add($"訂購品項: 共{List_OrderDetailInfo.Count}項");
                list_MenuOutput.Add($"匯出時間:{DateTime.Now}");
                list_MenuOutput.Add("=======================================");

                foreach (var item in List_OrderDetailInfo)
                {
                    string ResName = item.Res_Name;
                    string FoodName = item.F_Name;
                    int? Quantity = item.Quantity;
                    decimal? Price = item.Price;
                    string Additioal = item.Add_Name;
                    string strInfo = string.Format("{0} {1} {2}個 單價{3}元 {4}"
                        , ResName, FoodName, Quantity, Price, Additioal);
                    list_MenuOutput.Add(strInfo);
                }
                list_MenuOutput.Add("=======================================");
                list_MenuOutput.Add($"總價: {OrderInfo.Amount}");
                list_MenuOutput.Add("--------------------------------------");

                File.WriteAllLines(strFullPathName, list_MenuOutput, Encoding.UTF8);
                MessageBox.Show("存檔成功 !!");
            }
        }

        public rMessage FinishOrder()
        {
            rMessage msgInfo = new rMessage();
            try
            {
                var data = context.Orders.Where(o => o.O_Number == OrderInfo.O_Number).First();
                data.IsFinish = 1;
                context.SaveChanges();
                msgInfo.isSuccess = true;
                msgInfo.msg = "訂單已修改為完成!";
            }
            catch (Exception)
            {
                msgInfo.isSuccess = false;
                msgInfo.msg = "訂單修改完成時發生錯誤!";
            }          
            return msgInfo;
        }
    }
}
