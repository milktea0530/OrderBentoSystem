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
using OrderBentoSystem.GlobalVar;

namespace OrderBentoSystem
{
    public partial class Form_Student : Form
    {
        s_Student obj_std = new s_Student();

        public Form_Student()
        {
            InitializeComponent();
        }

        private void Form_Student_Load(object sender, EventArgs e)
        {
            var msgInfo = obj_std.GetInfo();
            if (!msgInfo.isSuccess)
            {
                MessageBox.Show(msgInfo.msg);
                return;
            }
            // 取出資料
            var std_data = obj_std.list_Student.FirstOrDefault();
            // 這邊需要調整規則
            if (G_LogIn.LogInData.onDuty) std_data = obj_std.list_Student.Where(m => m.S_Code == G_LogIn.LogInData.s_Code).FirstOrDefault();
            txt_Address.Text = std_data.Addr;
            txt_Email.Text = std_data.Email;
            txt_Phone.Text = std_data.Phone;
            txt_Password.Text = std_data.Pword;
            cbb_Class.Items.Clear();
            foreach (var classItem in obj_std.OutPutClass())
            {
                cbb_Class.Items.Add(classItem);
            }
            cbb_Class.SelectedIndex = 0;

            cbb_StdCode.Items.Clear();
            foreach (var stdItem in obj_std.OutPutStudent(G_LogIn.LogInData.s_Code, G_LogIn.LogInData.c_Code))
            {
                cbb_StdCode.Items.Add(stdItem);
            }

            cbb_StdCode.SelectedIndex = 0;
            obj_std.setSelectStudent(cbb_StdCode.SelectedIndex);
        }

        private void cbb_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (G_LogIn.LogInData.title == "學生") return;
            // 修改目前的選擇班級
            obj_std.setSelectClass(cbb_Class.SelectedIndex);
            // 清空資料
            cbb_StdCode.Items.Clear();
            // 重新設定學生資料
            foreach (var stdItem in obj_std.OutPutStudent(G_LogIn.LogInData.s_Code, G_LogIn.LogInData.c_Code))
            {
                cbb_StdCode.Items.Add(stdItem);
            }
            // 重新選定第1筆資料
            cbb_StdCode.SelectedIndex = 0;
            // 修改目前選擇的學生
            obj_std.setSelectStudent(cbb_StdCode.SelectedIndex);
            // 修改學生的資料
            var std_data = obj_std.GetOneStdData();
            txt_Address.Text = std_data.Addr;
            txt_Email.Text = std_data.Email;
            txt_Phone.Text = std_data.Phone;
            txt_Password.Text = std_data.Pword;
        }

        private void cbb_StdCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (G_LogIn.LogInData.title == "學生") return;
            // 修改目前的選擇學生
            obj_std.setSelectStudent(cbb_StdCode.SelectedIndex);
            // 修改學生的資料
            var std_data = obj_std.GetOneStdData();
            txt_Address.Text = std_data.Addr;
            txt_Email.Text = std_data.Email;
            txt_Phone.Text = std_data.Phone;
            txt_Password.Text = std_data.Pword;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var addr = txt_Address.Text;
            var phone = txt_Phone.Text;
            var paword = txt_Password.Text;
            var email = txt_Email.Text;
            if (paword.Length < 1)
            {
                MessageBox.Show("請輸入密碼!");
                return;
            }
            var msgInfo = obj_std.UpdateStdInfo(addr, email, phone, paword);
            MessageBox.Show(msgInfo.msg);
        }
    }
}
