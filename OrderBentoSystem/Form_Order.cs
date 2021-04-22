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
            lBox_Menu.SelectedIndex = 0;
            // 存放目前選取的資料
            obj_Restaurant.setSelectMenu(lBox_Menu.SelectedIndex);
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
            if (lBox_Menu.Items.Count < 1) return;
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
            if(txt_Quantity.Text.Length >0)
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
    }
}
