using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class login_screen : Form
    {
        public static List<User> userlist = new List<User>();
        private const string Userpath = @"data\user.csv";
        public login_screen()
        {
            InitializeComponent();
            File_Operation.get_csv(userlist,Userpath);
            Check_Remmber();
        }
        private void login_Click(object sender, EventArgs e)
        {
            string username = txt_1.Text;
            string password = Encryption.ComputeSha256Hash(txt_2.Text);
            bool rememberMe=checkB_1.Checked;

            for (int i = 0; i < userlist.Count; i++)
            {
                User user = userlist[i];

                if (user.IsValid(username, password))
                {
                    user.RememberMe = rememberMe;
                    User_login.getIntance().User=user;
                    File_Operation.set_csv(userlist, Userpath);

                    lb_1.Visible = true;
                    lb_1.Text = "Succesfull";
                    lb_1.ForeColor = Color.Green;
                    

                    if (user.Usertype==true)
                    {
                        progressBar1.Visible = true;
                        t_2.Enabled = true;
                        return;
                    }
                    else
                    {
                        progressBar1.Visible = true;
                        t_1.Enabled = true;
                        return;
                    } 
                }
                else
                    lb_1.Visible = true;
                    lb_1.Text = "Failed";
                    lb_1.ForeColor = Color.Red;
            }
        }
        private void Check_Remmber()
        {
            foreach (User user in userlist)
            {
                if (user.RememberMe)
                {
                    User_login.getIntance().User = user;
                    t_1.Interval = 10;
                    t_2.Interval = 10;
                    t_1.Start();
                    if (user.Usertype) { t_2.Start();return; }
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txt_1_Click(object sender, EventArgs e)
        {
            txt_1.Clear();
        }
        private void txt_2_Click(object sender, EventArgs e)
        {
            txt_2.Clear();
        }
        private void u_login_Tick(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value += 1;
            if (progressBar1.Value==progressBar1.Maximum)
            {               
                t_1.Stop();
                main_screen m_screen = new main_screen();
                m_screen.Show();
                this.Hide();
            }
        }
        private void a_login_Tick(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value += 1;
            if (progressBar1.Value==progressBar1.Maximum)
            {
                t_2.Stop();
                admin_screen admin_Screen = new admin_screen();
                admin_Screen.Show();
                this.Hide();
            }
        }

        private void register_Click(object sender, EventArgs e)
        {            
            regster_screen form3 = new regster_screen();
            form3.Show();
            this.Hide();
        }

    }
}
