namespace Store.Domain.Entities
{
    public class Customer(string name, string email) : Entity
    {

        public string Name { get; private set; } = name;
        public string Email { get; private set; } = email;
    }
}