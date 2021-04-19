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
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            Form_Menu f = new Form_Menu();
            f.ShowDialog(this);
        }

        // 自動產生每天值日生
        // 個別取出每班的值日生筆數 => 天數
        // 筆數(天數) / 班級總人數 = 當天值日生的號碼+1
        // ex 1班有4筆值日生資料 且有10人 => 4 / 10 = 4 + 1 (第五位同學要當值日生)
        //  
    }
}
