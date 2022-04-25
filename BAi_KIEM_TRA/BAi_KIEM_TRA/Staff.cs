using System;
using System.Collections.Generic;
using System.Text;

namespace BAi_KIEM_TRA
{
    class Staff : Officer
    {
        private string job;
        public string Job
        {
            get { return job; }
            set { job = value; }
        }
        public Staff() 
        {

        }
        public Staff(string name, int age, string gender, string address) : base(name, age, gender, address)
        {
            this.Job = job;
        }
        public override string ToString()
        {
            return Name + "\n" + Age + "\n" + Gender + "\n" + Address + "\n" + Job;
        }
    }
}
