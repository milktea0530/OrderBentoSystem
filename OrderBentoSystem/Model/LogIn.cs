using System;

namespace OrderBentoSystem.Model
{
    public class LogIn
    {
        private String Account;
        private String Password;
        private String Title;
        private String S_Code;
        private String S_Name;
        private String C_Code;

        public String account {
            get => Account;
            set => Account = value;
        }

        public String password
        {
            get => Password;
            set => Password = value;
        }

        public String title
        {
            get => Title;
            set => Title = value;
        }

        public String s_Code
        {
            get => S_Code;
            set => S_Code = value;
        }

        public String s_Name
        {
            get => S_Name;
            set => S_Name = value;
        }

        public String c_Code
        {
            get => C_Code;
            set => C_Code = value;
        }
    }
}
