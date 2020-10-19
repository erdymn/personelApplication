using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class File_Operation
    {
        public static void set_csv(List<User> users,string path)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach(User user in users)
                {
                    writer.WriteLine(user.To_String());
                }
            }

        }
        public static void setp_csv(List<Person> users, string path)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (Person user in users)
                {
                    writer.WriteLine(user.To_Sttring());
                }
            }

        }
        public static void get_csv(List<User> users, string path)
        {
            using(var reader=new StreamReader(path))
            {
               while (!reader.EndOfStream)
                {
                    string line =reader.ReadLine();
                    var values = line.Split(',');
                    string username = values[0];
                    string password = values[1];
                    bool remmber = values[2].Equals("1")?true:false;
                    bool usertype = values[3].Equals("1")?true:false;
                    users.Add(new User(username,password,remmber,usertype));
                }
            }
        }
        public static void getp_csv(List<Person> users, string path)
        {
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    var values = line.Split(',');
                    string name = values[0];
                    string surname = values[1];
                    string phonenumber = values[2];
                    string address = values[3];
                    string description = values[4];
                    string mail = values[5];
                    users.Add(new Person(name, surname,phonenumber,address,description,mail));
                }
            }
        }
        public static void setn_csv(List<Notes> users, string path)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (Notes user in users)
                {
                    writer.WriteLine(user.To_Stttring());
                }
            }

        }
        public static void getn_csv(List<Notes> users, string path)
        {
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    var values = line.Split(',');
                    string name = values[0];
                    string txt = values[1];
                    users.Add(new Notes(name,txt));
                }
            }
        }

    }
}
