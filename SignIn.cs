using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeApp
{
    public class SignIn
    {
        public string Autentication(string username, string password)
        {
            string msg;
            if((string.IsNullOrEmpty(username)) || string.IsNullOrEmpty(password))
            {
                msg = "User name and password required";
            }
            else
            {
                if((username=="admin") &&(password =="admin@1234"))
                {
                    msg = "Autentication Pass";
                }
                else
                {
                    msg = "Autentication Fail";
                }
                
            }
            return msg;
        }
    }
}
