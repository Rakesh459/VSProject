using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace GlobalErrorHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(HelloService)))
            {
                host.Open();
                Console.WriteLine("host Started");
                Console.ReadKey();
            }
        }
    }
}
