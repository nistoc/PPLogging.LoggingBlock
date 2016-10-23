using System;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging.Formatters;
using Microsoft.Practices.EnterpriseLibrary.Logging.TraceListeners;

namespace RetryLearning
{
    class SimpleLogger
    {
        /// <summary>
        /// Настраиваем логгер
        /// </summary>
        public LoggingConfiguration Configure()
        {
            //Formatter
            var textFormatter = new TextFormatter();

            //Trace Listener - создаём и натсроиваем Файловый-Listener, который будет принимать и записывать логи 
            // в указаннй файл, в уканном формате
            var flatFileTraceListener = new FlatFileTraceListener(
$@"{AppDomain.CurrentDomain.BaseDirectory}\Logs\FlatFile.log",
@"
^^^^^^^^^^^^^^^^^^^^^^^^",
@"\----------------------/
",
textFormatter);

            //Build Configuration
            var config = new LoggingConfiguration();
            config.AddLogSource("DiskFiles", SourceLevels.All, true)
                .AddTraceListener(flatFileTraceListener);

            return config;
        }


    }
}
