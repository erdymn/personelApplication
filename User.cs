using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class User
    {
        private String username;
        private String password;
        private bool usertype;
        private bool rememberme;

        public User(String username,String password,bool rememberme,bool usertype){
            this.Username = username;
            this.Password =password;
            this.RememberMe = rememberme;
            this.Usertype = usertype;
        }
        public String Username { get => username;  set => username=value; }
        public String Password { get => password; set => password = value; }
        public bool RememberMe { get => rememberme; set => rememberme = value; }
        public bool Usertype { get => usertype; set => usertype = value; }

        public bool IsValid(String username,String password)
        {
            return this.Username.Equals(username) && this.Password.Equals((password));
        }
        public string To_String()
        {
            return Username + "," + Password + "," + (rememberme ? '1':'0')+ "," + (usertype ? '1':'0');
        }
    }
}
