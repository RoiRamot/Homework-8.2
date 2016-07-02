using System;
using System.Threading;

namespace MailSystem
{
    class Program
    {
        private static void Main()
        {
            MailManager prograMailManager = new MailManager();

            prograMailManager.MailArrived += (sender, args) =>
            {
            };

            var timer = new Timer(state => prograMailManager.SimulateMailArrival(), null, 0, 1000);
            Console.ReadLine();
        }

    }
}
