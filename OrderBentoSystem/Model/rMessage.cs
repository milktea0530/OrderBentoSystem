using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBentoSystem.Model
{
    public class rMessage
    {
        private bool IsSuccess;
        private string Msg;

        public bool isSuccess
        {
            get => IsSuccess;
            set => IsSuccess = value;
        }

        public string msg
        {
            get => Msg;
            set => Msg = value;
        }
    }
}
