using MsCommun.Messages.Enseignants.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsCommun.Messages.Enseignants
{
    public class EnseignantACreerMessage : RabbitMqBaseMessage
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Guid NumeroExterne { get; set; }
        public SPECIALITE_ENSEIGNANT Specialite { get; set; }
        public NIVEAU_ETUDE Niveau { get; set; }
    }
}
