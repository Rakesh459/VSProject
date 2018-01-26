using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GlobalErrorHandler
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloService" in both code and config file together.
    public class HelloService : IHelloService
    {
        public string HelloMessage(string name)
        {
            
            //return hello concatinated with name
            //this is used to say hello
            return "Hello " + name;

            //returning hello from HUB

            //return hello from VS change
            //change in branch
            //change in branch in VS to push
        }
    }
}
