using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Attendance
{
    //enum BannedUsers
    //{
    //    Jack,
    //    Steven,
    //    Mathew
    //}
    class User
    {
        public event Action<string> Banned;

        public void OnlineAtt(string user)
        {

            if (user == "Jack" || user == "Steven" || user == "Mathew")
            {
                this.Banned(user);
            }
            else
            {
                Console.WriteLine($"Welcome {user}");
            }
        }
    }

}