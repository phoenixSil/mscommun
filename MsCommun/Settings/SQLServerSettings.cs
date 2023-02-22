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
        public bool TrusterdConnection { get;  set; }
        public bool MultipleActiveResultSets { get;  set; }
        public string Utilisateur { get; set; }
        public string MotDePasse { get; set; }
    }
}
