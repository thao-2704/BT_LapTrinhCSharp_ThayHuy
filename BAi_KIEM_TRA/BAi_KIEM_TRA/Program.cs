using System;

namespace BAi_KIEM_TRA
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Manager_officer mg_offic = new Manager_officer();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Application Manager Officer!");
                Console.WriteLine("Choose 1: To insert officer!");
                Console.WriteLine("Choose 2: To search officer by name!");
                Console.WriteLine("Choose 3: To show information officers!");
                Console.WriteLine("Choose 4: To exit!");
                Console.Write("Enter your choose : ");

                string choose = Console.ReadLine();
                switch (choose)
                {
                     case "1":
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Enter 1: to insert Enginner!");
                            Console.WriteLine("Enter 2: to insert Worker!");
                            Console.WriteLine("Enter 3: to insert Staff!");
                            Console.WriteLine("Enter 0: Back!");
                            Console.Write("Enter your choose : ");
                            string type = Console.ReadLine();
                            switch (type)
                            {
                                case "1":
                                    Console.Write("Enter name: ");
                                    string nameEnginner = Console.ReadLine();

                                    Console.Write("Enter age: ");
                                    int ageEnginner = int.Parse(Console.ReadLine());

                                    Console.Write("Enter gender: ");
                                    string genderEnginner = Console.ReadLine();

                                    Console.Write("Enter address: ");
                                    string addressEnginner = Console.ReadLine();

                                    Console.Write("Enter branch: ");
                                    string branchEnginner = Console.ReadLine();

                                    mg_offic.addOfficer(new Engineer(nameEnginner, ageEnginner, genderEnginner, addressEnginner, branchEnginner));
                                    mg_offic.Show_officer();
                                    break;

                                case "2":
                                    Console.Write("Enter name: ");
                                    string nameWorker = Console.ReadLine();

                                    Console.Write("Enter age: ");
                                    int ageWorker = int.Parse(Console.ReadLine());

                                    Console.Write("Enter gender: ");
                                    string genderWorker = Console.ReadLine();

                                    Console.Write("Enter address: ");
                                    string addressWorker = Console.ReadLine();

                                    Console.Write("Enter level: ");
                                    int levelWorker = int.Parse(Console.ReadLine());

                                    mg_offic.addOfficer(new Woker(nameWorker, ageWorker, genderWorker, addressWorker, levelWorker));
                                    mg_offic.Show_officer();
                                    break;

                                case "3":
                                    Console.Write("Enter name: ");
                                    string nameStaff = Console.ReadLine();

                                    Console.Write("Enter age: ");
                                    int ageStaff = int.Parse(Console.ReadLine());

                                    Console.Write("Enter gender: ");
                                    string genderStaff = Console.ReadLine();

                                    Console.Write("Enter address: ");
                                    string addressStaff = Console.ReadLine();

                                    Console.Write("Enter task: ");
                                    string taskStaff = Console.ReadLine();

                                    mg_offic.addOfficer(new Staff(nameStaff, ageStaff, genderStaff, addressStaff, taskStaff));
                                    break;
                                default:
                                    Console.Write("Invalid");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                    case "2":
                        Console.Write("Enter your to search: ");
                        string name_search = Console.ReadLine();
                        mg_offic.search_OfficerByName(name_search);
                        break;

                    case "3":
                        mg_offic.Show_officer();
                        break;

                    case "4":
                        Console.Write("Exit!");
                        return;

                    default:
                        Console.Write("Invalid!");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
 
