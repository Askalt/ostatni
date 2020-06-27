using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
   public class RegisterEventArgs
    {
        public RegisterEventArgs(string login, string password, string re_password)
        {
            this.login = login;
            this.password = password;
            this.re_password = re_password;
        }

        public string login { get; set; }
        public string password { get; set; }
        public string re_password { get; set; }
    }
}
