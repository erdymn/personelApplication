using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class Notes
    {
        private String name;
        private string txt;

        public Notes(string name,string txt)
        {
            this.Name = name;
            this.Txt = txt;

        }
        public String Name { get => name; set => name = value; }
        public String Txt { get => txt; set => txt = value; }
        public bool IsValidN(String name)
        {
            return this.Name.Equals(name);
        }
        public string To_Stttring()
        {
            return Name + "," +Txt;
        }
    }
}
