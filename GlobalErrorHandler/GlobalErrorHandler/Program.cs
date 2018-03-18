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
            //conflict 1
            //rebase 1
            //rebase2
            //merge 1
            //merge 2
            // added for merge conflict
            //added to make merge conflict to check rebase
            //added to make conflict and check how rebase works
            //comment to understand
            //always comment to understand
            PracticeEntities entity = new PracticeEntities();
            List<MainTable> main = entity.MainTables.Where(x => x.Id == 1).ToList();
            //opens the host so that it will be available to other
            using (ServiceHost host = new ServiceHost(typeof(HelloService)))
            {
                //added this on commit Added Test Table in EDMX model
                host.Open();
                Console.WriteLine("host Started");
                //for waiting for testing
                Console.ReadKey();
            }
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Marks { get; set; }

        public Student GetStudent()
        {
            return new Student { Id = 1, Name = "Rakesh", Marks = 20 };
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            return this.Id.Equals(student.Id) && this.Name.Equals(student.Name) && this.Marks.Equals(student.Marks);    
        }
    }


}
