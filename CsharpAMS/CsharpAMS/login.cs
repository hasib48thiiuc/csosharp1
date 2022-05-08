using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAMS
{
    public class login
    {
        AMSdbcontext ams = new AMSdbcontext();
        user User = new user();

        public void Login()
        {
            Console.WriteLine("Enter Your UserName:");
            var UserName = Console.ReadLine();
            Console.WriteLine("Enter Your PassWord:");
            var PassWord = Console.ReadLine();

            List<user> Users = ams.users.ToList();

            for (int i = 0; i <= Users.Count; i++)
            {
                if (i == Users.Count)
                {
                    Console.WriteLine("Login Failed");
                    break;

                }
                if (Users[i].username == UserName)

                {
                    if (Users[i].password == PassWord)
                    {
                        Console.WriteLine("Login Success");
                        Thread.Sleep(500);

                    }

                }


            }
        }

    }
}
