using System;
using System.Collections.Generic;
using System.Text;

namespace BAi_KIEM_TRA
{
    public class Engineer : Officer
    {
        private string branch;
        public string Branch
        {
            get { return branch; }
            set { branch = value; }
        }
        public Engineer()
        {
        }
        public Engineer(string name, int age, string gender, string address) : base(name, age, gender, address)
        {
            this.Branch = branch;
        }
        public override string ToString()
        {
            return Name + "\n" + Age + "\n" + Gender + "\n" + Address + "\n" +Branch ;
        }
    }
}
