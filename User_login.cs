using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class User_login
    {
        private User user;
        private static User_login user_Login;

        public  User User { get => user; set => user = value; }

        public static User_login getIntance()
        {
            if (user_Login == null)
            {
                user_Login = new User_login();
            }
            return user_Login;
        }
    }
}
