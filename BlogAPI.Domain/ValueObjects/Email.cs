using BlogAPI.Shared.ValueObjects;
using Flunt.Validations;

namespace BlogAPI.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;

            AddNotifications(new Contract<Email>()
                .Requires()
                .IsEmail(Address, "E-mail inválido")
            );
        }

        public string Address { get; private set; }
    }
}
