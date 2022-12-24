namespace MsCommun.Messages.Niveaux
{
    public class NiveauASupprimerMessage: RabbitMqBaseMessage
    {
        public Guid NumeroExterne { get; set; }
    }
}
