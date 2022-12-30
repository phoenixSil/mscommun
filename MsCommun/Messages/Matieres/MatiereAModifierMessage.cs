﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsCommun.Messages.Matieres
{
    public class MatiereAModifierMessage : RabbitMqBaseMessage
    {
        public Guid NumeroExterne { get; set; }
        public int NbreHeureInitiale { get; set; }
        public string CodeMatiere { get; set; }
        public string Designation { get; set; }
        public double NoteDeValidation { get; set; }
        public string DesignationNiveau { get; set; }
        public string DesignationFiliere { get; set; }
        public string DesignationCycle { get; set; }
        public string NomEnseignant { get; set; }
        public string PrenomEnseignant { get; set; }
    }
}
