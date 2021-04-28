using OrderBentoSystem.Model;
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
    public partial class Form_Order : Form
    {
        s_Student obj_Student = new s_Student();
        s_Restaurant obj_Restaurant = new s_Restaurant();
        s_OnDuty obj_OnDuty = new s_OnDuty();
        s_Order obj_Order = new s_Order();
        
        #region Function
        /// <summary>
        /// 設定小計
        /// </summary>
        public void setSubTotal()
        {
            // 顯示價格
            obj_Restaurant.GetSubTotal(txt_Quantity.Text);
            txt_Price.Text = s_Restaurant.Select_Menu.F_Price.ToString();
            txt_Quantity.Text = obj_Restaurant.quantity;
            txt_Subtotal.Text = obj_Restaurant.subtotal.ToString();
        }
        /// <summary>
        /// 設定值日生
        /// </summary>
        public void setOnDuty()
        {
            var data = obj_OnDuty.GetOnDutyForOrder(s_Student.Select_Class.C_Code);
            // data 應該寫到一個靜態變數存放(後續可以直接使用)
            lab_OnDuty.Text = data.S_Name;
        }
        /// <summary>
        /// 設定菜單
        /// </summary>
        public void setFoodMenu()
        {
            lBox_Menu.Items.Clear();
            foreach (var item in obj_Restaurant.OutPutMenu())
            {
                lBox_Menu.Items.Add(item);
            }
            if (lBox_Menu.Items.Count > 0)
            {
                lBox_Menu.SelectedIndex = 0;
                // 存放目前選取的資料
                obj_Restaurant.setSelectMenu(lBox_Menu.SelectedIndex);
            }
            else
            {
                // 沒有菜單
                lBox_Add.Items.Clear();
                txt_Price.Text = "";
                txt_Subtotal.Text = "";
            }
        }
        /// <summary>
        ///  設定加購項目
        /// </summary>
        public void setAdditional()
        {
            lBox_Add.Items.Clear();
            foreach (var item in obj_Restaurant.OutPutAdditional())
            {
                lBox_Add.Items.Add(item);
            }
            lBox_Add.SelectedIndex = 0;
            obj_Restaurant.setSelectAdditional(lBox_Add.SelectedIndex);
        }
        #endregion

        #region Form事件
        public Form_Order()
        {
            InitializeComponent();
        }

        private void Form_Order_Load(object sender, EventArgs e)
        {           
            #region 學生資料
            // 處理學生與班級資料
            rMessage msgInfo = new rMessage();
            // 取得資料
            msgInfo = obj_Student.GetInfo();
            if(!msgInfo.isSuccess)
            {
                MessageBox.Show(msgInfo.msg);
            }
            // 印出資料
            cBox_Class.Items.Clear();
            foreach (var itemClass in obj_Student.OutPutClass())
            {
                cBox_Class.Items.Add(itemClass);
            }
            // 觸發changed
            cBox_Class.SelectedIndex = 0;
            #endregion
            // ----------------------------------------------------------
            #region 餐廳
            // 處理餐廳與菜單資料
            msgInfo = obj_Restaurant.GetInfo();
            if (!msgInfo.isSuccess)
            {
                MessageBox.Show(msgInfo.msg);
            }
            cBox_Restaurant.Items.Clear();
            foreach (var itemRes in obj_Restaurant.OutPutRestaurant())
            {
                cBox_Restaurant.Items.Add(itemRes);
            }
            // 觸發changed
            cBox_Restaurant.SelectedIndex = 0;

            #endregion

            setFoodMenu();            
        }
        #endregion

        #region 班級下拉式選項
        private void cBox_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 指定目前選取的班級
            obj_Student.setSelectClass(cBox_Class.SelectedIndex);
            // 清空學生資料
            cBox_Student.Items.Clear();
            foreach (var itemStudent in obj_Student.OutPutStudent())
            {
                cBox_Student.Items.Add(itemStudent);
            }
            cBox_Student.SelectedIndex = 0;
            // 值日生設定
            setOnDuty();

            // 調整訂單編號
            obj_Order.GetOrder();
        }
        #endregion

        #region 學生下拉式選項
        private void cBox_Student_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 指定目前選取的學生
            obj_Student.setSelectStudent(cBox_Student.SelectedIndex);
        }
        #endregion

        #region 餐廳下拉式選項
        private void cBox_Restaurant_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 更新目前選取的資料
            obj_Restaurant.setSelectRestaurant(cBox_Restaurant.SelectedIndex);
            // 呼叫更新菜單(先判斷是否有項目)
            // if (lBox_Menu.Items.Count < 1) return;
            setFoodMenu();
        }
        #endregion

        #region 菜單列表
        private void lBox_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj_Restaurant.setSelectMenu(lBox_Menu.SelectedIndex);
            // 加購項目產生
            setAdditional();
            // 顯示價格
            setSubTotal();
        }
        #endregion

        #region 加購項目列表
        private void lBox_Add_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj_Restaurant.setSelectAdditional(lBox_Add.SelectedIndex);
            // 顯示價格
            setSubTotal();
        }
        #endregion

        #region 數量TextBox
        private void txt_Quantity_TextChanged(object sender, EventArgs e)
        {
            if (txt_Quantity.Text.Length > 0 && txt_Price.Text.Length > 0)
            {
                // 顯示價格
                setSubTotal();
            }
            else
            {
                txt_Quantity.Text = "1";
            }
        }
        #endregion

        private void btn_AddOrder_Click(object sender, EventArgs e)
        {
            OrderDetail odInfo = new OrderDetail();
            obj_Order.GetOrder();
            // 填入明細資料
            if(obj_Order.order != null) odInfo.O_Number = obj_Order.order.O_Number;
            odInfo.S_Code = s_Student.Select_Student.S_Code;
            odInfo.F_Code = s_Restaurant.Select_Menu.F_Code;
            odInfo.Quantity = Int32.Parse(txt_Quantity.Text);
            if(odInfo.Quantity > 100)
            {
                MessageBox.Show("請輸入正常數量!");
                return;
            }
            odInfo.Price = s_Restaurant.Select_Menu.F_Price;
            odInfo.Subtotal = Decimal.Parse(txt_Subtotal.Text);
            // 特別處理-1是無
            var addCode = s_Restaurant.Select_Additional.Add_Code;
            odInfo.Add_Code = addCode == "-1" ? "" : addCode;
            odInfo.AlreadyPaid = 0;
            obj_Order.orderDetail = odInfo;
            // 處理新增訂單動作
            var msgInfo = obj_Order.addOrder();
            MessageBox.Show(msgInfo.msg);
            // 重製數量
            txt_Quantity.Text = "1";
            this.setSubTotal();
            // 設定下一位同學
            var nowIdx = cBox_Student.SelectedIndex;
            if(nowIdx < cBox_Student.Items.Count -1)
            {
                cBox_Student.SelectedIndex = nowIdx + 1;
            }
        }
    }
}
