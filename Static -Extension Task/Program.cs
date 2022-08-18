using Static__Extension_Task.Models.Static_Class;
using System;
using Static__Extension_Task.Models;

namespace Static__Extension_Task
{
    class Program: Student
    {
        static void Main(string[] args)
        {
            string Str = Console.ReadLine();
            Console.WriteLine(Str.ToCapitalize());
            
        }
       public static void Menu()
        {
            Student kamran = new Student();
             kamran.Fullname = Console.ReadLine();
            kamran.GroupNo = Console.ReadLine();
            kamran.Age = int.Parse(Console.ReadLine());

            Console.ReadLine
            if (CheckGroupNo(kamran.Fullname) == true && CheckFullname(kamran.GroupNo) == true && kamran.Age!=0)
            {
                Console.WriteLine(kamran.Fullname + kamran.GroupNo + kamran.Age);
            }
            else
            {
                Menu();
            }
            Console.WriteLine();
        }

        private static bool CheckGroupNo()
        {
            throw new NotImplementedException();
        }
    }
}
