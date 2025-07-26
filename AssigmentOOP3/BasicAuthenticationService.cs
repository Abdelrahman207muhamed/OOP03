using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOOP3
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string username, string password)
        {
            if (username == "Abdelrahman" && password == "012121012") return true;
            else if (username=="Mahmoud" && password =="342004") return true;
            else return false;
        }

        public bool AuthorizeUser(string username, string role)
        {

            if (username == "Abdelrahman" && role == "BackEnd") return true;
            else if (username == "Mahmoud" && role == "FrontEnd") return true;
            else return false; 
        }
    }
}
