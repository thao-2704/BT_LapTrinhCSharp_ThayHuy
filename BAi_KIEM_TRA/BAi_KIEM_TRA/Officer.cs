using System;
using System.Collections.Generic;
using System.Text;

namespace BAi_KIEM_TRA
{
    public class Officer
    {
        private string name, gender, address;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public Officer()
        {

        }
        public Officer(string name, int age, string gender, string address)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Address = address;
        }

    }
}
