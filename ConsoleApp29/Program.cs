using ConsoleApp29.Models;
using System;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            User users = new User();
            users.ShowInfo();
            Student student1 = new Student("Amanov Semseddin",45);
            Student student2 = new Student("Imanov Novruz",67);
            Student student3 = new Student("Esedov Nahid",80);
            Student student4 = new Student("Qedirov Eyyub",30);
            Student student5 = new Student("Kerimov Rahim",70);
            Console.WriteLine("-----------meniu------------");
            int choose = 0;
            do
            {
                switch (choose)
                {
                    case 1:
                        users.ShowInfo();
                        break;
                    case 2:
                }

            } while (true);
        }
    }
}
