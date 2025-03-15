namespace Domain.Model
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }
}
