
namespace MsCommun.Messages.Niveaux
{
    public class NiveauACreerMessage: RabbitMqBaseMessage
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int ValeurCycle { get; set; }
        public string Designation { get; set; }
        public Guid NumeroExterne { get; set; }
        public string DesignationFiliere { get; set; }
        public string DesignationCycle { get; set; }
    }
}
