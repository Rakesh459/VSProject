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
            PracticeEntities entity = new PracticeEntities();
            List<MainTable> main = entity.MainTables.Where(x => x.Id == 1).ToList();
            //opens the host so that it will be available to other
            using (ServiceHost host = new ServiceHost(typeof(HelloService)))
            {
                //added this on commit Added Test Table in EDMX model
                host.Open();
                Console.WriteLine("host Started");
                //for waiting
                Console.ReadKey();
            }
        }
    }
}
