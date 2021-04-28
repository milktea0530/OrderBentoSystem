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
    public class s_Student : Entities
    {
        private List<Proc_GetClass_Result> List_Class = null;
        private List<Proc_GetStudent_Result> List_Student = null;
        // 紀錄篩選過後的資料
        private List<Proc_GetStudent_Result> FilterListStd = null;
        // 屬性設定
        public List<Proc_GetClass_Result> list_Class
        {
            get => this.List_Class;
            set => this.List_Class = value;
        }
        public List<Proc_GetStudent_Result> list_Student
        {
            get => this.List_Student;
            set => this.List_Student = value;
        }
        // 存放選擇的資料(靜態)
        public static Proc_GetClass_Result Select_Class = null;
        public static Proc_GetStudent_Result Select_Student = null;

        // UI的下拉式修改資料要跟著調整選擇的資料
        // 班級資料
        public void setSelectClass(int Index)
        {
            Select_Class = List_Class[Index];
        }
        // 學生資料
        public void setSelectStudent(int Index)
        {
            Select_Student = FilterListStd[Index];
        }

        /// <summary>
        /// 取得班級與學生資料
        /// </summary>
        /// <returns></returns>
        public rMessage GetInfo()
        {
            rMessage msgInfo = new rMessage();
            try
            {
                // 取出班級資料
                var temp_Class = context.Proc_GetClass(G_LogIn.LogInData.c_Code);
                List_Class = temp_Class.ToList();
                // 如果是值日生 撈出自己班的學生
                if (G_LogIn.LogInData.onDuty)
                {
                    var temp_Std = context.Proc_GetStudent(G_LogIn.LogInData.c_Code, "");
                    List_Student = temp_Std.ToList();
                }
                // 如果是學生 只撈出自己的身分
                if (!G_LogIn.LogInData.onDuty)
                {
                    var temp_Std = context.Proc_GetStudent(G_LogIn.LogInData.c_Code, G_LogIn.LogInData.s_Code);
                    List_Student = temp_Std.ToList();
                }
                // 如果是管理的帳戶會因為學號與班級代碼都是空所以會查出所有資料
                msgInfo.isSuccess = true;
            }
            catch (Exception)
            {
                msgInfo.isSuccess = false;
                msgInfo.msg = "取得班級與學生資料發生錯誤!!";
            }         
            return msgInfo;
        }

        /// <summary>
        /// 輸出班級
        /// </summary>
        /// <returns></returns>
        public List<string> OutPutClass()
        {
            List<string> data = new List<string>();
            foreach (var item in List_Class)
            {
                data.Add(item.C_Name);
            }
            return data;
        }

        /// <summary>
        /// 輸出學生
        /// </summary>
        /// <returns></returns>
        public List<string> OutPutStudent()
        {
            List<string> data = new List<string>();
            FilterListStd = List_Student.Where(std => std.C_Code == Select_Class.C_Code).ToList();
            // 這邊需要特別去判斷所選班級 (管理值需要篩選)
            foreach (var item in FilterListStd)
            {
                data.Add(item.S_Name);
            }
            return data;
        }

        /// <summary>
        /// 輸出學生
        /// </summary>
        /// <param name="stdCode">學號</param>
        /// <param name="classCode">班級</param>
        /// <returns></returns>
        public List<string> OutPutStudent(string stdCode, string classCode)
        {
            List<string> data = new List<string>();
            // 如果有傳入學號與班級就去找該學生資料
            if(stdCode != "" && classCode != "")
            {
                FilterListStd = List_Student.Where(std => std.C_Code == classCode
                                         && std.S_Code == stdCode).ToList();
            }
            else
            {
                // 如果都沒有資料查詢所有班級的學生
                FilterListStd = List_Student.Where(std => std.C_Code == Select_Class.C_Code).ToList();
            }            
            foreach (var item in FilterListStd)
            {
                data.Add(item.S_Name);
            }
            return data;
        }

        // 取得單一筆學生資料
        public Proc_GetStudent_Result GetOneStdData()
        {
            Proc_GetStudent_Result model = new Proc_GetStudent_Result();
            model = List_Student.Where(s => s.C_Code == Select_Class.C_Code
                                    && s.S_Code == Select_Student.S_Code).FirstOrDefault();
            return model;
        }

        /// <summary>
        /// 修改學生基本資料
        /// </summary>
        /// <param name="Addr">地址</param>
        /// <param name="Email"></param>
        /// <param name="Phone">電話</param>
        /// <param name="Password">密碼</param>
        /// <returns></returns>
        public rMessage UpdateStdInfo(string Addr, string Email, string Phone, string Password)
        {
            rMessage msgInfo = new rMessage();
            try
            {
                var stdData = context.StudentInfo.Where(s => s.S_Code == Select_Student.S_Code).First();
                stdData.Addr = Addr;
                stdData.Email = Email;
                stdData.Phone = Phone;
                stdData.Pword = Password;
                context.SaveChanges();

                msgInfo.isSuccess = true;
                msgInfo.msg = "已成功修改資料!";
            }
            catch (Exception)
            {
                msgInfo.isSuccess = false;
                msgInfo.msg = "修改資料時發生錯誤!";
            }        
            return msgInfo;
        }
    }
}
