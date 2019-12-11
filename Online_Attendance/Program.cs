using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Attendance
{
    class Programm
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please enter  Name");
                string user = Console.ReadLine();
                User ob = new User();
                ob.Banned += Ob_Banned;
                ob.OnlineAtt(user);
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        private static void Ob_Banned(string obj)
        {
            Console.WriteLine($" {obj} is banned");
        }
    }
}