using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsCommun.Settings
{
    public class RabbitMQSettings 
    { 
        public string Port { get; init; }
        public string Host { get; init; }
        public string ServiceName { get; set; }
    }
}
