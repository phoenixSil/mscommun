using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsCommun.Settings
{
    public class SQLServerSettings
    {
        public string Database { get; set; }
        public string Server { get; set; }
        public object TrusterdConnection { get;  set; }
        public object MultipleActiveResultSets { get;  set; }
    }
}
