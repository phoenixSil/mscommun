
using MsCommun.Messages.Utils;

namespace MsCommun.Messages
{
    public class RabbitMqBaseMessage
    {
        public TypeMessage Type { get; set; }
        public DesignationService Service { get; set; }
    }
}
