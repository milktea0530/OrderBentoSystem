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

        public Form_Order()
        {
            InitializeComponent();
        }

        private void Form_Order_Load(object sender, EventArgs e)
        {
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

            // ----------------------------------------------------------
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
        }

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
        }

        private void cBox_Student_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 指定目前選取的學生
            obj_Student.setSelectStudent(cBox_Student.SelectedIndex);
        }

        private void cBox_Restaurant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
