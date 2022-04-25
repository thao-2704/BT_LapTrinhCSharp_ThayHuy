using System;
using System.Collections.Generic;
using System.Text;

namespace BAi_KIEM_TRA
{
    class Woker : Officer
    {
        private int level;
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        public Woker(string nameWorker, int ageWorker)
        {

        }
        public Woker(string name, int age, string gender, string address, int levelWorker) : base(name, age, gender, address)
        {
            this.Level = level;
        }
        public override string ToString()
        {
            return Name + "\n" + Age + "\n" + Gender + "\n" + Address + "\n" + Level;
        }
    }
}
