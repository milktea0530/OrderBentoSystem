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
    public partial class Form_Additional : Form
    {
        s_Restaurant obj_Res = new s_Restaurant();
        string name = "";
        int price = 0;

        public Form_Additional()
        {
            InitializeComponent();
        }

        public void setAdditional()
        {
            lBox_Additional.Items.Clear();
            foreach (var item in obj_Res.OutPutAdditional1())
            {
                lBox_Additional.Items.Add(item);
            }
            lBox_Additional.SelectedIndex = 0;
        }

        public void ReloadData()
        {
            var msgInfo = obj_Res.GetInfo();
            if (!msgInfo.isSuccess)
            {
                MessageBox.Show(msgInfo.msg);
                return;
            }
            setAdditional();
        }

        public bool CheckField()
        {
            name = txt_Name.Text;
            var isNum = Int32.TryParse(txt_Price.Text, out price);
            if (name.Length < 1)
            {
                MessageBox.Show("請輸入加購項目名稱!");
                return false;
            }
            if (!isNum)
            {
                MessageBox.Show("請輸入整數格式!");
                return false;
            }
            return true;
        }

        private void Form_Additional_Load(object sender, EventArgs e)
        {
            this.ReloadData();
        }

        private void lBox_Additional_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 存取目前選擇的資料
            obj_Res.setSelectAdditional1(lBox_Additional.SelectedIndex);
            // 填入值
            txt_Code.Text = s_Restaurant.Select_Additional.Add_Code;
            txt_Name.Text = s_Restaurant.Select_Additional.Add_Name;
            txt_Price.Text= Convert.ToInt32(s_Restaurant.Select_Additional.Add_Price).ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var index = lBox_Additional.SelectedIndex;
            // 欄位判斷
            if (!this.CheckField()) return;
            // 異動資料
            var msgInfo = obj_Res.UpdateAdditional(name, price);
            MessageBox.Show(msgInfo.msg);
            if (!msgInfo.isSuccess) return;
            // 重新讀取資料
            this.ReloadData();
            // 重新鎖定最後修改的資料
            lBox_Additional.SelectedIndex = index;
        }  

        private void btn_Create_Click(object sender, EventArgs e)
        {
            txt_Code.Text = "";
            txt_Name.Text = "";
            txt_Price.Text = "";
        }

        private void btn_CreateSave_Click(object sender, EventArgs e)
        {
            Additional data = new Additional();
            // 欄位判斷
            if (!this.CheckField()) return;
            data.Add_Name = name;
            data.Add_Price = price;
            // 異動資料
            var msgInfo = obj_Res.cAdditional(data);
            MessageBox.Show(msgInfo.msg);
            if (!msgInfo.isSuccess) return;
            // 重新讀取資料
            this.ReloadData();
            lBox_Additional.SelectedIndex = 0;
        }
    }
}
