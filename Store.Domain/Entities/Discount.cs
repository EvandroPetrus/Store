namespace Store.Domain.Entities
{
    public class Discount(decimal amount, DateTime expireDate) : Entity
    {
        public decimal Amount { get; private set; } = amount;

        public DateTime ExpireDate { get; private set; } = expireDate;

        public bool IsValid()
        {
            return DateTime.Compare(DateTime.Now, ExpireDate) < 0;
        }

        public decimal Value()
        {
            return IsValid() ? Amount : 0;
        }
    }
}