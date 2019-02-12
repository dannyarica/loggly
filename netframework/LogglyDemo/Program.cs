using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogglyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //log4net.Config.XmlConfigurator.Configure();
            var account = new Account
            {
                AccountId = 2706,
                Identifier = Guid.NewGuid().ToString(),
                Name = "Luis Fonsi",
                Phone = "+51944589632"
            };


            var logger = LogManager.GetLogger(typeof(Program));
            
            //Send plaintext
            
            logger.Info(JsonConvert.SerializeObject(account));

            //Send an exception
            //logger.Error("your log message", new Exception("your exception message"));

            Console.ReadKey();
        }
    }
}
