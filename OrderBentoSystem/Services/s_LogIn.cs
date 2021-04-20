using OrderBentoSystem.Model;
using OrderBentoSystem.GlobalVar;
using System.Linq;

namespace OrderBentoSystem.Services
{
    public class s_LogIn : Entities
    {
        // 登入判斷與寫入登入(靜態)資料
        public rMessage UserConfirmation(string account, string password)
        {
            rMessage msgInfo = new rMessage();

            #region 判斷學生身分
            // 判斷學生登入
            var checkStdAccount = context.StudentInfo.Where(info => info.S_Code == account).Any();
            // 確認是學生
            if (checkStdAccount)
            {
                // 判斷密碼正確
                StudentInfo checkStdLogin = context.StudentInfo.Where(m => m.S_Code == account && m.Pword == password).FirstOrDefault();
                // 找不到學生資料(密碼錯誤)
                if(checkStdLogin == null)
                {
                    msgInfo.isSuccess = false;
                    msgInfo.msg = "密碼錯誤!!";
                    return msgInfo;
                }
                // 確認是學生資料
                // 寫入靜態資料
                G_LogIn.LogInData.account = account;
                G_LogIn.LogInData.password = password;
                G_LogIn.LogInData.title = "學生";
                G_LogIn.LogInData.s_Code = checkStdLogin.S_Code;
                G_LogIn.LogInData.s_Name = checkStdLogin.S_Name;
                G_LogIn.LogInData.c_Code = checkStdLogin.C_Code;

                msgInfo.isSuccess = true;
                return msgInfo;
            }
            #endregion

            #region 判斷管理者身分
            // 判斷管理者身分
            var checkSysAccount = context.Sys_Account.Where(info => info.Account == account).Any();
            if (checkSysAccount)
            {
                // 判斷密碼正確
                var checkSysLogin = context.Sys_Account.Where(m => m.Account == account && m.Password == password).FirstOrDefault();
                // 找不到管理者資料(密碼錯誤)
                if (checkSysLogin == null)
                {
                    msgInfo.isSuccess = false;
                    msgInfo.msg = "密碼錯誤!!";
                    return msgInfo;
                }
                // 確認是管理者資料
                // 寫入靜態資料
                G_LogIn.LogInData.account = account;
                G_LogIn.LogInData.password = password;
                G_LogIn.LogInData.title = checkSysLogin.Title;
                G_LogIn.LogInData.s_Code = "";
                G_LogIn.LogInData.s_Name = "";
                G_LogIn.LogInData.c_Code = "";

                msgInfo.isSuccess = true;
                return msgInfo;
            }
            #endregion

            msgInfo.isSuccess = false;
            msgInfo.msg = "帳號不存在!";
            return msgInfo;
        }
    }
}
