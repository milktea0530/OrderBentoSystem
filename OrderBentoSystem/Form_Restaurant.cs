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
    public partial class Form_Restaurant : Form
    {
        s_Restaurant obj_res = new s_Restaurant();

        public Form_Restaurant()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 印出餐廳資料
        /// </summary>
        public void SetRestaurant()
        {
            // 印出餐廳資料
            lBox_RestaurantList.Items.Clear();
            foreach (var item in obj_res.OutPutRestaurant())
            {
                lBox_RestaurantList.Items.Add(item);
            }
            lBox_RestaurantList.SelectedIndex = 0;
        }

        private void Form_Restaurant_Load(object sender, EventArgs e)
        {
            // 取得餐廳資料
            obj_res.GetInfo();
            // 印出餐廳資料
            this.SetRestaurant();
        }

        /// <summary>
        /// 選取餐廳時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lBox_RestaurantList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 紀錄目前選擇的餐廳資料
            obj_res.setSelectRestaurant(lBox_RestaurantList.SelectedIndex);
            // 更新餐廳資料
            txt_Code.Text = s_Restaurant.Select_Restaurant.Res_Code;
            txt_Name.Text = s_Restaurant.Select_Restaurant.Res_Name;
            txt_Addr.Text = s_Restaurant.Select_Restaurant.Addr;
            txt_Phone.Text = s_Restaurant.Select_Restaurant.Tel;
        }

        /// <summary>
        /// 更新餐廳資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            var index = lBox_RestaurantList.SelectedIndex;
            var name = txt_Name.Text;
            var addr = txt_Addr.Text;
            var tel = txt_Phone.Text;
            if(name.Length < 1)
            {
                MessageBox.Show("請輸入餐廳名稱!");
                return;
            }
            if(txt_Code.Text.Length < 1)
            {
                MessageBox.Show("餐廳代碼遺失,請重新讀取資料!");
                return;
            }
            var msgInfo = obj_res.UpdateRestaurant(name, addr, tel);
            MessageBox.Show(msgInfo.msg);
            if (!msgInfo.isSuccess) return;
            // 取得餐廳資料
            obj_res.GetInfo();
            // 印出餐廳資料
            this.SetRestaurant();
            lBox_RestaurantList.SelectedIndex = index;
        }

        /// <summary>
        /// 建立餐廳資料的清空欄位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Create_Click(object sender, EventArgs e)
        {
            // 清空欄位
            txt_Code.Text = "";
            txt_Name.Text = "";
            txt_Addr.Text = "";
            txt_Phone.Text = "";
        }

        /// <summary>
        /// 建立餐廳資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CreateSave_Click(object sender, EventArgs e)
        {
            Restaurant model = new Restaurant();
            // 取得資料
            model.Res_Name = txt_Name.Text;
            model.Addr = txt_Addr.Text;
            model.Tel = txt_Phone.Text;
            if(model.Res_Name.Length < 1)
            {
                MessageBox.Show("請輸入餐廳名稱!");
                return;
            }
            // 建立資料
            var msgInfo = obj_res.addRestaurant(model);
            MessageBox.Show(msgInfo.msg);
            if (!msgInfo.isSuccess) return;
            // 取得餐廳資料
            obj_res.GetInfo();
            // 印出餐廳資料
            this.SetRestaurant();
        }
    }
}
