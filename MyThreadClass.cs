using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LaudicoThread
{
    class MyThreadClass
    {


        public static void Thread1()
        {
            for (int i = 0; i <= 5; i++)
            {

                Thread.Sleep(1500);
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread : " + thread.Name + " = " + i);
              
            }

        }
        private void method()
        {
            Console.WriteLine("");
        }
    }
}
