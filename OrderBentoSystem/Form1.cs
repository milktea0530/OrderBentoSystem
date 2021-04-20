using OrderBentoSystem.GlobalVar;
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
    public partial class Form1 : Form
    {
        s_LogIn obj_Login = new s_LogIn();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string account = txt_Account.Text;
            string password = txt_Password.Text;
            if (account.Length < 1) 
            {
                MessageBox.Show("請輸入帳號");
                return;
            }
            if (password.Length < 1) {
                MessageBox.Show("請輸入密碼");
                return;
            }
            rMessage msgInfo = new rMessage();
            // 檢查登入資料
            msgInfo = obj_Login.UserConfirmation(account, password);
            // 如果回傳的訊息是失敗的
            if (!msgInfo.isSuccess)
            {
                MessageBox.Show(msgInfo.msg);
                return;
            }
            // 已確認登入資料
            // 打開視窗
            Form_Menu f = new Form_Menu();
            f.ShowDialog(this);
            if (f.DialogResult == DialogResult.Cancel)
            {
                // 清空登入資料
                G_LogIn.ClearLogInData();
                MessageBox.Show("登出成功");
            }
        }

        // 自動產生每天值日生
        // 個別取出每班的值日生筆數 => 天數
        // 筆數(天數) / 班級總人數 = 當天值日生的號碼+1
        // ex 1班有4筆值日生資料 且有10人 => 4 / 10 = 4 + 1 (第五位同學要當值日生)
        //  
    }
}
