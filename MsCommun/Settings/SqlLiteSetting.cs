using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsCommun.Settings
{
    public class SqlLiteSetting
    {
        public string Database { get; set; }
        public string ConnectionString => $"Data Source={Database}.db";
    }
}
