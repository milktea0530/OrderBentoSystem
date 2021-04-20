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
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void 開始訂購ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Order f_order = new Form_Order();
            f_order.ShowDialog(this);
        }

        private void 訂單明細ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_OrderDetail f_orderDetail = new Form_OrderDetail();
            f_orderDetail.ShowDialog(this);
        }

        private void 基本資料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Student f_student = new Form_Student();
            f_student.ShowDialog(this);
        }

        private void 值日生設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_OnDuty f_onDuty = new Form_OnDuty();
            f_onDuty.ShowDialog(this);
        }

        private void 餐廳資料ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Restaurant f_rest = new Form_Restaurant();
            f_rest.ShowDialog(this);
        }

        private void 菜單資料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_FoodMenu f_foodMenu = new Form_FoodMenu();
            f_foodMenu.ShowDialog(this);
        }

        private void 加購項目維護ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Additional f_add = new Form_Additional();
            f_add.ShowDialog(this);
        }
    }
}
