using NUnit.Framework;
using GlobalErrorHandler;
using System.Reflection;
using System;

namespace GlobalErrorHandlerTests
{

    #region 1st Test Case
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod2([Values(1, 2)] int x)
        {
            Assert.Pass();
        }

        [Test]
        public void TestGetStudents()
        {
            Student studentExpected = new Student { Id = 1, Name = "Rakesh", Marks = 20 };
            Student studentActual = studentExpected.GetStudent();

          Assert.IsTrue(Compare(studentExpected, studentActual));

            Assert.AreEqual(studentExpected, studentActual);
        }

        public static bool Compare<T>(T obj1,T obj2)
        {
            Type type = typeof(T);
            foreach (PropertyInfo property in type.GetProperties())
            {
                if (property.Name != "ExtensionData")
                {
                    string Objval1 = string.Empty;
                    string Objval2 = string.Empty;
                    if(type.GetProperty(property.Name).GetValue(obj1,null) !=null)
                    {
                        Objval1 = type.GetProperty(property.Name).GetValue(obj1, null).ToString();
                    }
                    if (type.GetProperty(property.Name).GetValue(obj2, null) != null)
                    {
                        Objval2 = type.GetProperty(property.Name).GetValue(obj2, null).ToString();
                    }

                    if(Objval1.Trim() != Objval2.Trim())
                    {
                        return false;
                    }

                }

            }
            return true;

        }
    }
    #endregion

}
