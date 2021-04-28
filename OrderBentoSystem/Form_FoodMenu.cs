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
    public partial class Form_FoodMenu : Form
    {
        s_Restaurant obj_Res = new s_Restaurant();

        public Form_FoodMenu()
        {
            InitializeComponent();
        }

        #region Function
        /// <summary>
        ///  印出餐廳資料
        /// </summary>
        public void setRestaurant()
        {
            // 印出餐廳資料
            cbb_Restaurant.Items.Clear();
            foreach (var item in obj_Res.OutPutRestaurant())
            {
                cbb_Restaurant.Items.Add(item);
            }
            cbb_Restaurant.SelectedIndex = 0;
        }

        /// <summary>
        /// 取得食物資料
        /// </summary>
        public void setFoodMenu()
        {
            lBox_FoodMenu.Items.Clear();
            foreach (var item in obj_Res.OutPutMenu())
            {
                lBox_FoodMenu.Items.Add(item);
            }
            if (lBox_FoodMenu.Items.Count > 0)
            {
                lBox_FoodMenu.SelectedIndex = 0;
                // 存放目前選取的資料
                obj_Res.setSelectMenu(lBox_FoodMenu.SelectedIndex);
            }
            else
            {
                txt_Code.Text = "";
                txt_Name.Text = "";
                txt_Price.Text = "";
            }
        }
        /// <summary>
        /// 設定加購資料
        /// </summary>
        public void setAdditional()
        {
            cbb_Add.Items.Clear();
            foreach (var item in obj_Res.OutPutAdditional1())
            {
                cbb_Add.Items.Add(item);
            }
            // 預設位置為該品項的加購項目位置
            if (lBox_FoodMenu.Items.Count > 0)
            {                           
                cbb_Add.SelectedIndex = obj_Res.GetAddIndex();            
            }
        }
        /// <summary>
        /// 重新讀取資料
        /// </summary>
        public void ReLoadData()
        {
            // 取得資料
            var msgInfo = obj_Res.GetInfo();
            // 確認是否有發生例外錯誤
            if (!msgInfo.isSuccess)
            {
                MessageBox.Show(msgInfo.msg);
                return;
            }
            // 填入加購資料
            this.setAdditional();
            // 填入餐廳資料
            this.setRestaurant();
        }
        #endregion

        private void Form_FoodMenu_Load(object sender, EventArgs e)
        {
            this.ReLoadData();
        }
        
        /// <summary>
        /// 餐廳下拉式資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbb_Restaurant_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 紀錄目前選擇的餐廳資料
            obj_Res.setSelectRestaurant(cbb_Restaurant.SelectedIndex);
            // 填入菜單資料
            this.setFoodMenu();
        }

        /// <summary>
        /// 食物清單
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lBox_FoodMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 紀錄目前選擇的食物
            obj_Res.setSelectMenu(lBox_FoodMenu.SelectedIndex);
            // 填入資料
            // 取得資料
            txt_Code.Text = s_Restaurant.Select_Menu.F_Code;
            txt_Name.Text = s_Restaurant.Select_Menu.F_Name;
            txt_Price.Text = (Convert.ToInt32(s_Restaurant.Select_Menu.F_Price)).ToString();
            // 加購項目
            // 預設位置為該品項的加購項目位置
            if (lBox_FoodMenu.Items.Count > 0)
            {
                cbb_Add.SelectedIndex = obj_Res.GetAddIndex();
            }
        }

        /// <summary>
        /// 加購下拉式資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbb_Add_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 記錄目前選擇的食物
            obj_Res.setSelectAdditional1(cbb_Add.SelectedIndex);
        }

        /// <summary>
        /// 修改資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            // 紀錄目前餐廳+菜單的索引值(修改後重新讀取資料要回到目前的資料)
            var r_index = cbb_Restaurant.SelectedIndex;
            var f_index = lBox_FoodMenu.SelectedIndex;
            // 取得值
            var name = txt_Name.Text;
            var price = 0;
            Int32.TryParse(txt_Price.Text, out price);
            // 執行修改
            var msgInfo = obj_Res.UpdateFood(name, price);
            MessageBox.Show(msgInfo.msg);
            if (!msgInfo.isSuccess) return;
            // 重新取得資料
            this.ReLoadData();
            // 回到預設資料
            cbb_Restaurant.SelectedIndex = r_index;
            lBox_FoodMenu.SelectedIndex = f_index;
        }

        /// <summary>
        /// 新增資料(清空)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Create_Click(object sender, EventArgs e)
        {
            txt_Code.Text = "";
            txt_Name.Text = "";
            txt_Price.Text = "";
        }

        /// <summary>
        /// 新增資料(儲存)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CreateSave_Click(object sender, EventArgs e)
        {
  
            DialogResult d_result = MessageBox.Show($"您確定加入菜品到{s_Restaurant.Select_Restaurant.Res_Name}嗎?", "提示訊息",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d_result != DialogResult.Yes)
            {
                return;
            }
            if(txt_Name.Text.Length < 1)
            {
                MessageBox.Show("請輸入菜品名稱");
                return;
            }
            if (txt_Price.Text.Length < 1)
            {
                MessageBox.Show("請輸入價格");
                return;
            }
            var r_index = cbb_Restaurant.SelectedIndex;
            int price = 0;
            Int32.TryParse(txt_Price.Text, out price);

            Food data = new Food();
            data.F_Name = txt_Name.Text;
            data.F_Price = price;
            data.Add_Code = s_Restaurant.Select_Additional.Add_Code;
            data.Res_Code = s_Restaurant.Select_Restaurant.Res_Code;

            var msgInfo = obj_Res.AddFood(data);
            MessageBox.Show(msgInfo.msg);
            if (!msgInfo.isSuccess) return;
            // 重新取得資料
            this.ReLoadData();
            // 回到預設資料
            cbb_Restaurant.SelectedIndex = r_index;
        }
    }
}
