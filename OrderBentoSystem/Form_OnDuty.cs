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
    public partial class Form_OnDuty : Form
    {
        s_OnDuty obj_OnDuty = new s_OnDuty();
        string onDutyDate = "";

        /// <summary>
        /// 更新值日生
        /// </summary>
        public void UpdateOnDuty()
        {
            // 取得值日生資料
            onDutyDate = Dtp_值日.Value.ToString("yyyy/MM/dd");
            var msgInfo = obj_OnDuty.GetOnDuty(onDutyDate);
            if (!msgInfo.isSuccess)
            {
                MessageBox.Show(msgInfo.msg);
                return;
            }
            // 輸出值日生資料
            lBox_OnDuty.Items.Clear();
            foreach (var item in obj_OnDuty.GetOuputData())
            {
                lBox_OnDuty.Items.Add(item);
            }
        }

        public Form_OnDuty()
        {
            InitializeComponent();
        }

        private void Form_OnDuty_Load(object sender, EventArgs e)
        {
            UpdateOnDuty();
        }

        private void Dtp_值日_ValueChanged(object sender, EventArgs e)
        {
            UpdateOnDuty();
        }

        private void lBox_OnDuty_SelectedIndexChanged(object sender, EventArgs e)
        {
            //obj_OnDuty
            var selectOnDuty = obj_OnDuty.list_Onduty[lBox_OnDuty.SelectedIndex];
        }
    }
}
