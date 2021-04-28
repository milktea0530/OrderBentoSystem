using OrderBentoSystem.GlobalVar;
using OrderBentoSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBentoSystem.Services
{
    public class s_OnDuty : Entities
    {
        #region 存放值日生的欄位與屬性
        private List<Proc_GetOnDuty_Result> List_OnDuty = null;
        public List<Proc_GetOnDuty_Result> list_Onduty
        {
            get => this.List_OnDuty;
            set => this.List_OnDuty = value;
        }
        #endregion

        // 紀錄當前班級的值日生
        public static Proc_GetOnDuty_Result Now_OnDuty = new Proc_GetOnDuty_Result();

        #region 取得值日生資料
        public Proc_GetOnDuty_Result GetOnDutyForOrder(string C_Code)
        {
            // Proc_GetOnDuty_Result data = new Proc_GetOnDuty_Result();
            var onDutyDate = DateTime.Now.ToString("yyyy/MM/dd");
            Now_OnDuty = context.Proc_GetOnDuty(C_Code, "", onDutyDate).FirstOrDefault();
            return Now_OnDuty;
        }

        /// <summary>
        /// 取得值日生資料
        /// </summary>
        /// <returns></returns>
        public rMessage GetOnDuty(string onDutyDate)
        {
            rMessage rMsg = new rMessage();
            string s_Code = G_LogIn.LogInData.s_Code == null ? "" : G_LogIn.LogInData.s_Code;
            string c_Code = G_LogIn.LogInData.c_Code == null ? "" : G_LogIn.LogInData.c_Code;
            try
            {
                List_OnDuty = context.Proc_GetOnDuty(c_Code, s_Code, onDutyDate).ToList();
                rMsg.isSuccess = true;
            }
            catch (Exception)
            {
                rMsg.isSuccess = false;
                rMsg.msg = "查詢時發生錯誤,請重新執行程式!";
            }         
            return rMsg;
        }
        #endregion

        #region 輸出值日生資料
        /// <summary>
        /// 輸出值日生資料
        /// </summary>
        /// <returns></returns>
        public List<string> GetOuputData()
        {
            List<string> data = new List<string>();
            foreach (var item in List_OnDuty)
            {
                data.Add($"{item.C_Name} {item.S_Code}{item.S_Name}");
            }
            return data;
        }
        #endregion

        #region 自動產生值日生
        /// <summary>
        /// 產生值日生
        /// </summary>
        /// <param name="onDutyDate"></param>
        public void CreatOnDuty(string onDutyDate)
        {
            // 如果已經有值日生就離開程式
            var isCheck = context.Proc_GetOnDuty("", "", onDutyDate);
            if (isCheck.Count() > 0) return;
            // 假如是假日也不需要執行

            // 取得班級
            var GetClassList = context.ClassInfo.Select(m => m.C_Code).ToList();
            foreach (var ClassItem in GetClassList)
            {
                // 取得目前的值日生數目
                var GetCount = context.OnDutyInfo.Where(m => m.C_Code == ClassItem).Count();
                // 取得班級清單
                var GetStudentList = context.StudentInfo.Where(m => m.C_Code == ClassItem).ToList();
                // 取得班級人數
                var GetClassStdNum = GetStudentList.Count();
                // 今天要當值日生的索引(每天自動遞增)
                var CurrentOnDutyIndex = GetCount % GetClassStdNum;
                // 建立資料
                OnDutyInfo DataModel = new OnDutyInfo();
                DataModel.S_Code = GetStudentList[CurrentOnDutyIndex].S_Code;
                DataModel.C_Code = GetStudentList[CurrentOnDutyIndex].C_Code;
                DataModel.OnDuty_Date = Convert.ToDateTime(onDutyDate);
                // 寫入資料庫Model
                context.OnDutyInfo.Add(DataModel);
                context.SaveChanges();
            }
            #endregion
        }
    }
}
