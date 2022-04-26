using System;
using System.Collections.Generic;
using System.Text;

namespace BAi_KIEM_TRA
{
    class Manager_officer
    {
        private List<Officer> officers;

        public Manager_officer()
        {
            this.officers = new List<Officer>();

        }
        public void addOfficer(Officer officer)
        {
            this.officers.Add(officer);
        }
        public void search_OfficerByName(String Name)
        {
            if (officers != null && officers.Count > 0)
            {
                foreach (var officer in officers)
                {
                    if (officer.Name.Equals(Name))
                    {
                        Console.WriteLine(officer);
                    }
                }
            }
        }
        public void Show_officer()
        {
            foreach (var officer in officers)
            {
                Console.WriteLine(officer);
                Console.WriteLine("************************************************");
            }
        }
    }
}
