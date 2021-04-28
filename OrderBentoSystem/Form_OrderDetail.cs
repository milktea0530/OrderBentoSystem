using OrderBentoSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderBentoSystem
{
    public partial class Form_OrderDetail : Form
    {
        s_Student obj_Std = new s_Student();
        s_Order obj_Order = new s_Order();

        /// <summary>
        /// 設定班級下拉資料
        /// </summary>
        public void SetClassData()
        {
            cBox_Class.Items.Clear();
            foreach (var item in obj_Std.OutPutClass())
            {
                cBox_Class.Items.Add(item);
            }
            cBox_Class.SelectedIndex = 0;
            // 設定目前選擇的班級
            obj_Std.setSelectClass(cBox_Class.SelectedIndex);
        }

        /// <summary>
        /// 設定訂單資料
        /// </summary>
        public void SetOrder()
        {
            lbl_OrderDate.Text = obj_Order.orderInfo.O_Date.ToString();
            lab_OnDuty.Text = obj_Order.orderInfo.S_Name;
            lbl_Amount.Text = obj_Order.orderInfo.Amount.ToString();
        }

        /// <summary>
        /// 設定訂單明細資料
        /// </summary>
        public void SetOrderDetail()
        {
            lBox_OrderDetail.Items.Clear();
            foreach (var item in obj_Order.list_OrderDetailInfo)
            {
                lBox_OrderDetail.Items.Add($"{item.S_Name} : {item.Res_Name} " +
                    $"{item.F_Name} {item.Add_Name} " +
                    $"{item.Quantity}個 {item.Subtotal}元");
            }
        }

        /// <summary>
        /// 設定訂單統計表
        /// </summary>
        public void SetODStatistics()
        {
            lBox_Statistics.Items.Clear();
            foreach (var item in obj_Order.list_ODStatistics)
            {
                lBox_Statistics.Items.Add($"{item.Res_Name} {item.F_Name}" +
                    $" {item.Add_Name} {item.Quantity}個 {item.Subtotal}元");
            }
        }
        /// <summary>
        /// 清空資料
        /// </summary>
        public void ClearData()
        {
            lbl_OrderDate.Text = "";
            lab_OnDuty.Text = "";
            lbl_Amount.Text = "";
            lBox_OrderDetail.Items.Clear();
            lBox_Statistics.Items.Clear();
        }

        public Form_OrderDetail()
        {
            InitializeComponent();
        }

        private void Form_OrderDetail_Load(object sender, EventArgs e)
        {
            // 取得班級資料
            obj_Std.GetInfo();
            // 設定班級下拉資料
            this.SetClassData();
        }

        private void btn_OrderDetailClear_Click(object sender, EventArgs e)
        {
            if(lBox_OrderDetail.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇欲刪除的訂單明細");
                return;
            }
            DialogResult d_result = MessageBox.Show("您確定要移除所選的明細項目嗎?", "提示訊息",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d_result != DialogResult.Yes)
            {
                return;
            }
            obj_Order.SetSelectODInfo(lBox_OrderDetail.SelectedIndex);
            var msgInfo = obj_Order.Remove_OrderDetail(false);
            MessageBox.Show(msgInfo.msg);
            // 重新讀取訂單資料
            OrderFun();
        }

        private void btn_OrderDetailAllClear_Click(object sender, EventArgs e)
        {
            if (lBox_OrderDetail.Items.Count < 1)
            {
                MessageBox.Show("目前沒有可以刪除的訂單明細!");
                return;
            }
            DialogResult d_result = MessageBox.Show("您確定要清除全部明細項目嗎?", "提示訊息", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(d_result != DialogResult.Yes)
            {
                return;
            }
            // obj_Order.SetSelectODInfo(lBox_OrderDetail.SelectedIndex);
            var msgInfo = obj_Order.Remove_OrderDetail(true);
            MessageBox.Show(msgInfo.msg);
            // 重新讀取訂單資料
            OrderFun();
        }

        private void cBox_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj_Std.setSelectClass(cBox_Class.SelectedIndex);
            // 取得訂單資料
            OrderFun();
        }

        public void OrderFun()
        {
            var msgInfo = obj_Order.GetOrderInfo();
            if (!msgInfo.isSuccess)
            {
                MessageBox.Show(msgInfo.msg);
                ClearData();
                return;
            }
            // 設定訂單資料
            SetOrder();
            // 設定訂單明細資料
            SetOrderDetail();
            // 設定訂單統計資料
            SetODStatistics();
        }

        private void btn_OrderFinish_Click(object sender, EventArgs e)
        {
            DialogResult d_result = MessageBox.Show("您確定要完成此次的訂單嗎?", "提示訊息",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d_result != DialogResult.Yes)
            {
                return;
            }
            var msgInfo = obj_Order.FinishOrder();
            MessageBox.Show(msgInfo.msg);
            if(msgInfo.isSuccess)
            {
                // 重新更新畫面(完成的訂單是不能在這裡查詢)
                OrderFun();
            }
        }

        private void btn_OrderSave_Click(object sender, EventArgs e)
        {
            obj_Order.OrderSave();
        }
    }
}
