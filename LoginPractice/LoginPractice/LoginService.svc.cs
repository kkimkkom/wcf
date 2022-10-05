using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LoginPractice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class LoginService : ILogin
    {
        string usernameDB = "hello@gmail.com";
        string passwordDB = "hello123";

        public string Login(string username, string password)
        {
            if (username.Equals(usernameDB) && password.Equals(passwordDB))
                return "Login successful";
            else return "Failed";
        }

    }
}
