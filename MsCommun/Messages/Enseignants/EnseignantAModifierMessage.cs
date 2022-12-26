using MsCommun.Messages.Enseignants.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsCommun.Messages.Enseignants
{
    public class EnseignantAModifierMessage : RabbitMqBaseMessage
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Guid NumeroExterne { get; set; }
        public SPECIALITE_ENSEIGNANT Specialite { get; set; }
        public NIVEAU_ETUDE Niveau { get; set; }
    }
}
