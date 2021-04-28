using OrderBentoSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBentoSystem.Services
{
    public class s_Restaurant : Entities
    {
        #region 存放資料的欄位與屬性設定
        private List<Proc_GetRestaurant_Result> List_Restaurant = null;
        private List<Proc_GetFood_Result> List_Menu = null;
        private List<Additional> List_Additional = new List<Additional>();
        public List<Proc_GetRestaurant_Result> list_Restaurant
        {
            get => this.List_Restaurant;
            set => this.List_Restaurant = value;
        }
        public List<Proc_GetFood_Result> list_Menu
        {
            get => this.List_Menu;
            set => this.List_Menu = value;
        }
        public List<Additional> list_Additional
        {
            get => this.List_Additional;
            set => this.List_Additional = value;
        }
        #endregion

        #region 存放篩選後的資料 
        public List<Proc_GetFood_Result> Filter_Mune = null;
        public List<Additional> Filter_Additional = new List<Additional>();
        #endregion

        #region 存放當下選擇的資料
        public static Proc_GetRestaurant_Result Select_Restaurant = null;
        public static Proc_GetFood_Result Select_Menu = null;
        public static Additional Select_Additional = new Additional();
        #endregion

        #region 小計的欄位與屬性設定
        private int Quantity = 1;
        public string quantity
        {
            get => this.Quantity.ToString();
            set {
                int q = 0;
                Int32.TryParse(value, out q);
                this.Quantity = q;
            }
        }
        private double Subtotal;
        public double subtotal
        {
            get => this.Subtotal;
            set => this.Subtotal = value;
        }
        #endregion

        #region 選擇的資料修改時要跟著調整資料集
        // 餐廳資料
        public void setSelectRestaurant(int Index)
        {
            Select_Restaurant = List_Restaurant[Index];
        }
        // 食物資料
        public void setSelectMenu(int Index)
        {
            Select_Menu = Filter_Mune[Index];
        }
        // 加購項目 
        public void setSelectAdditional(int Index)
        {
            Select_Additional = Filter_Additional[Index];
        }
        // 加購項目 
        public void setSelectAdditional1(int Index)
        {
            Select_Additional = List_Additional[Index];
        }
        #endregion

        #region 取得餐廳+菜單+加購項目資料
        /// <summary>
        /// 取得資料
        /// </summary>
        /// <returns></returns>
        public rMessage GetInfo()
        {
            rMessage msgInfo = new rMessage();
            try
            {
                // 取得餐廳資料
                var temp_Restaurant = context.Proc_GetRestaurant("");
                // 轉換List
                List_Restaurant = temp_Restaurant.ToList();

                // 取得食物資料
                var temp_Menu = context.Proc_GetFood("");
                List_Menu = temp_Menu.ToList();

                // 加購項目
                List_Additional = context.Additional.ToList();

                msgInfo.isSuccess = true;
            }
            catch (Exception)
            {
                msgInfo.isSuccess = false;
                msgInfo.msg = "查詢餐廳與菜單發生錯誤!!";
            }
            return msgInfo;
        }
        #endregion

        #region 輸出餐廳, 菜單, 加購項目
        /// <summary>
        /// 輸出餐廳
        /// </summary>
        /// <returns></returns>
        public List<string> OutPutRestaurant()
        {
            List<string> data = new List<string>();
            foreach (var Restaurant in List_Restaurant)
            {
                data.Add(Restaurant.Res_Name);
            }
            return data;
        }
        /// <summary>
        /// 輸出菜單
        /// </summary>
        /// <returns></returns>
        public List<string> OutPutMenu()
        {
            List<string> data = new List<string>();
            Filter_Mune = List_Menu.Where(r => r.Res_Code == Select_Restaurant.Res_Code).ToList();
            // 這邊需要特別去判斷所選餐廳
            foreach (var item in Filter_Mune)
            {
                data.Add(item.F_Name);
            }
            return data;
        }
       
        public List<string> OutPutAdditional()
        {
            List<string> data = new List<string>();
            // 如果有一種以上的加購項目需要拆解
            var split_add = Select_Menu.Add_Code.Split('|');
            Filter_Additional.Clear();
            // 加入一筆加購項目是沒有的資料
            Additional addFirst = new Additional();
            addFirst.Add_Code = "-1";
            addFirst.Add_Name = "無";
            addFirst.Add_Price = 0;
            Filter_Additional.Add(addFirst);
            data.Add(addFirst.Add_Name);
            // 取得餐點的加購項目
            foreach (var add in split_add)
            {
                // 取得所有的加購項目
                var temp_data = List_Additional.Where(m => m.Add_Code == add).ToList();
                // 個別寫入資料集
                foreach (var item in temp_data)
                {
                    Filter_Additional.Add(item);
                    data.Add(item.Add_Name);
                }
            }
            return data;
        }

        public List<string> OutPutAdditional1()
        {
            List<string> data = new List<string>();    
            foreach (var item in list_Additional)
            {
                data.Add($"{item.Add_Name}:{Convert.ToInt32(item.Add_Price)}元");
            }
            return data;
        }
        #endregion

        #region 計算小計
            public void GetSubTotal(string q)
        {
            Int32.TryParse(q, out Quantity);
            Subtotal = Convert.ToDouble(Select_Menu.F_Price + Select_Additional.Add_Price) * Quantity;
        }
        #endregion

        #region 修改餐廳資料
        /// <summary>
        /// 修改餐廳資料
        /// </summary>
        /// <param name="name">餐廳名稱</param>
        /// <param name="addr">地址</param>
        /// <param name="tel">電話</param>
        /// <returns></returns>
        public rMessage UpdateRestaurant(string name, string addr, string tel)
        {
            rMessage msgInfo = new rMessage();
            try
            {
                var updateRes = context.Restaurant.Where(r => r.Res_Code == Select_Restaurant.Res_Code).First();
                updateRes.Addr = addr;
                updateRes.Res_Name = name;
                updateRes.Tel = tel;

                context.SaveChanges();

                msgInfo.isSuccess = true;
                msgInfo.msg = "餐廳資料修改成功!";
            }
            catch (Exception)
            {
                msgInfo.isSuccess = false;
                msgInfo.msg = "餐廳資料修改發生錯誤!";
            }
            return msgInfo;
        }
        #endregion

        #region 建立餐廳資料
        /// <summary>
        /// 建立餐廳資料
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public rMessage addRestaurant(Restaurant data)
        {
            rMessage msgInfo = new rMessage();
            try
            {
                // 製作編號
                var count = context.Restaurant.Count() + 1;
                data.Res_Code = $"S{count}";
                if(count < 10)
                {
                    data.Res_Code = $"S0{count}";
                }
                // 資料寫入資料表
                context.Restaurant.Add(data);
                context.SaveChanges();
                msgInfo.isSuccess = true;
                msgInfo.msg = "成功建立餐廳資料!";
            }
            catch (Exception)
            {
                msgInfo.isSuccess = false;
                msgInfo.msg = "建立餐廳發生錯誤!";
            }          
            return msgInfo;
        }
        #endregion

        public int GetAddIndex()
        {
            var index = list_Additional.FindIndex(a => a.Add_Code == Select_Menu.Add_Code);
            return index;
        }
        /// <summary>
        /// 修改菜品
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        public rMessage UpdateFood(string name, int price)
        {
            rMessage msgInfo = new rMessage();
            try
            {
                context.Proc_UpdateFood(name, price, Select_Additional.Add_Code, Select_Menu.F_Code);

                msgInfo.isSuccess = true;
                msgInfo.msg = "餐點修改完成!";
            }
            catch (Exception e)
            {
                msgInfo.isSuccess = false;
                msgInfo.msg = "餐點修改失敗!";
            }      
            return msgInfo;
        }
        /// <summary>
        /// 新增菜品
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public rMessage AddFood(Food data)
        {
            rMessage msgInfo = new rMessage();
            try
            {
                // 製作編號
                var count = context.Food.Count() + 1;
                data.F_Code = $"P{count}";
                if (count < 10)
                {
                    data.F_Code = $"P0{count}";
                }
                context.Food.Add(data);
                context.SaveChanges();
                msgInfo.isSuccess = true;
                msgInfo.msg = "餐點新增完成!";
            }
            catch (Exception)
            {
                msgInfo.isSuccess = false;
                msgInfo.msg = "餐點新增失敗!";
            }
            return msgInfo;
        }
        /// <summary>
        /// 修改加購項目
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        public rMessage UpdateAdditional(string name, int price)
        {
            rMessage msgInfo = new rMessage();
            try
            {
                var data = context.Additional.Where(m => m.Add_Code == Select_Additional.Add_Code).First();
                data.Add_Name = name;
                data.Add_Price = price;
                context.SaveChanges();

                msgInfo.isSuccess = true;
                msgInfo.msg = "加購項目修改成功!";
            }
            catch (Exception)
            {

                msgInfo.isSuccess = false;
                msgInfo.msg = "加購項目修改失敗!";
            }
            return msgInfo;
        }
        /// <summary>
        /// 新增加購項目
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public rMessage cAdditional(Additional data)
        {
            rMessage msgInfo = new rMessage();
            try
            {
                // 設定編號
                var count = context.Additional.Count() + 1;
                data.Add_Code = $"A1{count}";
                if (count < 10)
                {
                    data.Add_Code = $"A10{count}";
                }
                // 寫入資料
                context.Additional.Add(data);
                context.SaveChanges();

                msgInfo.isSuccess = true;
                msgInfo.msg = "加購項目新增成功!";
            }
            catch (Exception)
            {
                msgInfo.isSuccess = false;
                msgInfo.msg = "加購項目新增失敗!";
            }

            return msgInfo;
        }
    }
}
