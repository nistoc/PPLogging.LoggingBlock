using System;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace RetryLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            var simpleDictData = new Dictionary<string, object>
            {
                {"текущая дата", DateTime.Now.ToLongDateString()},
                {"текущее время", DateTime.Now.ToLongTimeString()}
            };

            UserDeclarativeLogger(simpleDictData);
        }

        private static void UserDeclarativeLogger(Dictionary<string, object> simpleDictData)
        {
            var logWriterFactory = new LogWriterFactory();
            var logWriter = logWriterFactory.Create();

            logWriter.Write("пишем лог через логер-по-умолчанию", simpleDictData);
            logWriter.Dispose();
        }

       
    }
}
