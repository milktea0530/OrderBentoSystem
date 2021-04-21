using OrderBentoSystem.Model;

namespace OrderBentoSystem.GlobalVar
{
    public static class G_LogIn
    {
        // 紀錄登入資料
        public static LogIn LogInData = new LogIn();

        // 登出:清除登入(靜態)資料
        public static void ClearLogInData()
        {
            LogInData.account = "";
            LogInData.password = "";
            LogInData.title = "";
            LogInData.s_Code = "";
            LogInData.s_Name = "";
            LogInData.c_Code = "";
            LogInData.onDuty = false;
        }

        // 輸出資訊
        public static string OutPutUserInfo()
        {
            return $"{LogInData.title} {LogInData.s_Name}";
        }
    }
}
