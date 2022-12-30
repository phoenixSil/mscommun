using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsCommun.Messages.Matieres
{
    public class MatiereASupprimerMessage: RabbitMqBaseMessage
    {
        public Guid Id { get; set; }
    }
}
