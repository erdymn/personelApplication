using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class main_screen : Form
    {
        private const string Userpath = @"data\user.csv";
        private const string Personpath = @"data\person.csv";
        private const string Notespath = @"data\notes.csv";
        public static List<Person> people = new List<Person>();
        public static List<User> userlist = new List<User>();
        public static List<Notes> notelist = new List<Notes>();

        public main_screen()
        {
            InitializeComponent();
            File_Operation.getp_csv(people, Personpath);
            File_Operation.getn_csv(notelist, Notespath);
            show_userlist();

        }
        private void save_btn_Click(object sender, EventArgs e)//*export*//
        {
            string[] lines = System.IO.File.ReadAllLines(Userpath);
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Psv dosyaları PSV|.pvs";

            if (sd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sd.FileName);
                foreach (string s in lines)
                {
                    sw.WriteLine(s);
                }
                sw.Close();
            }
        }
        private void show_userlist()
        {
            personlist.Items.Clear();
            foreach (Person person in people)
            {
                ListViewItem item = new ListViewItem(person.Name);
                item.SubItems.Add(person.Surname);
                item.SubItems.Add(person.Phonenumber);
                item.SubItems.Add(person.Address);
                item.SubItems.Add(person.Description);
                item.SubItems.Add(person.Email);
                personlist.Items.Add(item);
            }
            foreach (Notes note in notelist)
            {
                notename_list.Items.Add(note.Name);
            }

        }
        private void passtouser(object sender, MouseEventArgs e)
        {
            name_txt.Text = personlist.SelectedItems[0].SubItems[0].Text;
            surname_txt.Text = personlist.SelectedItems[0].SubItems[1].Text;
            phone_txt.Text = personlist.SelectedItems[0].SubItems[2].Text;
            address_txt.Text = personlist.SelectedItems[0].SubItems[3].Text;
            description_txt.Text = personlist.SelectedItems[0].SubItems[4].Text;
            mail_txt.Text = personlist.SelectedItems[0].SubItems[5].Text;
        }
        private void note_save_Click_1(object sender, EventArgs e)
        {
            notelist.Clear();

            string nname = notename_txt.Text;
            string note = note_txt.Text;

            Notes notee=new Notes(nname,note);
            notelist.Add(notee);
            File_Operation.setn_csv(notelist,Notespath);
            show_userlist();
        }
        private void note_update_Click(object sender, EventArgs e)
        {

        }

        private void note_del_Click(object sender, EventArgs e)
        {

        }

        private void pbook_add_btn_Click(object sender, EventArgs e)
        {
            string name = name_txt.Text;
            string surname = surname_txt.Text;
            string phonenumber = phone_txt.Text;
            string address = address_txt.Text;
            string email = mail_txt.Text;
            string description = description_txt.Text;
            Person person = new Person(name, surname, phonenumber, address, description, email);
            people.Add(person);
            File_Operation.setp_csv(people, Personpath);
            show_userlist();
        }

        private void pbook_update_btn_Click(object sender, EventArgs e)
        {
            string name = name_txt.Text;
            string surname = surname_txt.Text;
            string phonenumber = phone_txt.Text;
            string address = address_txt.Text;
            string email = mail_txt.Text;
            string description = description_txt.Text;

            Person person = new Person(name, surname, phonenumber, address, description, email);

            for (int i = 0; i < people.Count; i++)
            {
                Person person1 = people[i];

                if (person1.IsValidP(name, surname, phonenumber))
                {

                    File_Operation.setp_csv(people,Personpath);
                }
            }

            show_userlist();
            personlist.SelectedItems[0].SubItems[0].Text = name;
            personlist.SelectedItems[0].SubItems[1].Text = surname;
            personlist.SelectedItems[0].SubItems[2].Text = phonenumber;
            personlist.SelectedItems[0].SubItems[3].Text = address;
            personlist.SelectedItems[0].SubItems[4].Text = description;
            personlist.SelectedItems[0].SubItems[5].Text = email;
        }

        private void pbook_del_btn_Click(object sender, EventArgs e)
        {
            string name = name_txt.Text;
            string surname = surname_txt.Text;
            string phonenumber = phone_txt.Text;
            string address = address_txt.Text;
            string email = mail_txt.Text;
            string description = description_txt.Text;

            Person person = new Person(name, surname, phonenumber, address, description, email);

            for (int i = 0; i < people.Count; i++)
            {
                Person person1 = people[i];

                if (person1.IsValidP(name, surname, phonenumber))
                {
                    people.RemoveAt(people.IndexOf(person1));
                    File_Operation.setp_csv(people, Personpath);
                }
            }

            show_userlist();

            personlist.SelectedItems[0].SubItems[0].Text = name;
            personlist.SelectedItems[0].SubItems[1].Text = surname;
            personlist.SelectedItems[0].SubItems[2].Text = phonenumber;
            personlist.SelectedItems[0].SubItems[3].Text = address;
            personlist.SelectedItems[0].SubItems[4].Text = description;
            personlist.SelectedItems[0].SubItems[5].Text = email;
        }

        private void signout_Click(object sender, EventArgs e)
        {
            login_screen form1 = new login_screen();
            form1.Show();
            this.Hide();
        }

        private void passtoouser(object sender, MouseEventArgs e)
        { 
            name_txt.Text = notename_list.SelectedItems[0].SubItems[0].Text;
            foreach(Notes note in notelist)
            {
                if (note.IsValidN(name_txt.Text)) { note_txt.Text = note.Txt; }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
