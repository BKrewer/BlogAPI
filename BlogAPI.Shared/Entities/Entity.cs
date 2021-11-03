using Flunt.Notifications;

namespace BlogAPI.Shared.Entities
{
    public abstract class Entity : Notifiable<Notification>
    {
        public int Id { get; private set; }
    }
}
