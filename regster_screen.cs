using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace OOP_Project
{
    public partial class regster_screen : Form
    {
        public static List<User> userlist = new List<User>();
        private const string Userpath = @"data\user.csv";
        public regster_screen()
        {
            InitializeComponent();
            File_Operation.get_csv(userlist, Userpath);
        }   
        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
            login_screen form1 = new login_screen();
            form1.Show();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            string username = txt_1.Text;
            string password =Encryption.ComputeSha256Hash(txt_2.Text);
            bool remember = false;
            bool usertype = false;

            for (int i = 0; i < userlist.Count; i++)
            {
                User user = userlist[i];

                if (user.IsValid(username, password))
                {
                    MessageBox.Show("User is already exist");
                    txt_1.Clear();
                    txt_2.Clear();
                    txt_3.Clear();
                }
                else
                { 
                    User user1 = new User(username,password,remember,usertype);
                    userlist.Add(user1); 
                    File_Operation.set_csv(userlist,Userpath);
                    log_lbl.Visible = true;
                    log_lbl.Text="Loading Successfull";
                    log_lbl.ForeColor = Color.Green;
                    t_register.Start();
                    return;
                }
            }
        }
        private void conf_tick(object sender, EventArgs e)
        {
            if (txt_2.Text == txt_3.Text) 
            { 
                lb_4.Text = "Confirmed";
                lb_4.ForeColor = Color.Green;
            }
            else
            {
                lb_4.Text = "Not Confirmed";
                lb_4.ForeColor = Color.Red;
            }
        }
        private void t_register_Tick(object sender, EventArgs e)
        {
            user_login();
        }
        private void user_login()
        {
            login_screen login_Screen = new login_screen();
            login_Screen.Show();
            this.Hide();
            t_register.Stop();
        }
    }
}
