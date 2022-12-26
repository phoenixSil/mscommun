using MsCommun.Messages.Enseignants.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsCommun.Messages.Enseignants
{
    public class EnseignantASupprimerMessage : RabbitMqBaseMessage
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
