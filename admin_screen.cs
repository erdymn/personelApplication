using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class admin_screen : Form
    {
        public static List<User> userlist = new List<User>();
        private const string Userpath = @"data\user.csv";
        public admin_screen()
        {
            InitializeComponent();
            File_Operation.get_csv(userlist, Userpath);
            show_userlist();
        }
        private void exit_Click(object sender, EventArgs e)
        {  
            login_screen login_Screen = new login_screen();
            login_Screen.Show();
            this.Hide();
        }
        private void add__Click(object sender, EventArgs e)
        {
            confirm_lb.Visible = false;
            listView_user.Items.Clear();

            string username = txt_1.Text;
            string password = Encryption.ComputeSha256Hash(txt_2.Text);
            bool remember = false;
            string cb = usertype_cb.Text;
            bool usertype = cb=="Admin" ? true : false;

            foreach (User user in userlist)
            {
                if (user.IsValid(username, password))
                {
                    confirm_lb.Visible = true;
                    confirm_lb.Text = "User is already exist";
                    txt_1.Clear();
                    txt_2.Clear();
                    show_userlist();
                    return;
                }
            }
            if (username == "" || password == "") {
                confirm_lb.Visible = true;
                confirm_lb.Text = "unfilled area";
                show_userlist(); 
                return;
            }
            User user1 = new User(username, password, remember, usertype);
            userlist.Add(user1);
            File_Operation.set_csv(userlist, Userpath);
            txt_1.Clear();
            txt_2.Clear(); 
            show_userlist();
            confirm_lb.Text = "Loading Successfull";
            confirm_lb.Visible=true;
            return;
        }
        private void show_userlist()
        {
            listView_user.Items.Clear();
            foreach (User user in userlist)
            {
                string tmp;
                if (user.Usertype == true) { tmp = "Admin"; }
                else { tmp = "Normal User"; }

                listView_user.Items.Add(user.Username).SubItems.Add(tmp);
            }
        }
        private void update_btn_Click(object sender, EventArgs e)
        {
            confirm_lb.Visible = false;
            string username = txt_1.Text;
            string password = User_login.getIntance().User.Password;
            bool remmber = false;
            string cb = usertype_cb.Text;
            bool usertype = cb == "Admin" ? true : false;

            listView_user.SelectedItems[0].SubItems[0].Text = username;
            listView_user.SelectedItems[0].SubItems[1].Text = cb;

            User user = new User(username, password, remmber, usertype);
            userlist.Add(user);
            File_Operation.set_csv(userlist, Userpath);
            show_userlist();
        }
        private void passtouser(object sender, MouseEventArgs e)
        {
            add_btn.Enabled = false;
            update_btn.Enabled = true;
            dlt_btn.Enabled = true;
            txt_2.Enabled = false;
            txt_1.Enabled = false;
            txt_2.Text = "Disabled";

            string cb = usertype_cb.Text; ;
            txt_1.Text=listView_user.SelectedItems[0].SubItems[0].Text;
            cb= listView_user.SelectedItems[0].SubItems[1].Text;

        }

        private void tab_click(object sender, EventArgs e)
        {
            add_btn.Enabled = true;
            dlt_btn.Enabled = false;
            update_btn.Enabled = false;
            txt_2.Enabled = true;
            txt_1.Enabled = true;
            txt_1.Clear();
            txt_2.Clear();
        }

        private void dlt_btn_Click(object sender, EventArgs e)
        {
            //string cb = usertype_cb.Text; ;
            //txt_1.Text = listView_user.SelectedItems[0].SubItems[0].Text;
            //cb = listView_user.SelectedItems[0].SubItems[1].Text;
            //confirm_lb.Visible = false;

            //string username = txt_1.Text;
            //string password = User_login.getIntance().User.Password;
            //bool remmber = false;
            //bool usertype = cb == "Admin" ? true : false;

            //User user1 = new User(username, password, remmber, usertype);
           
            //foreach (User user in userlist)
            //{
            //    if (userlist.Contains(user1))
            //    { 
            //        userlist.Remove(user1);
            //        File_Operation.set_csv(userlist, Userpath);
            //    }
            //}
            //listView_user.Items.Clear();
            show_userlist();
        }
    }
}
