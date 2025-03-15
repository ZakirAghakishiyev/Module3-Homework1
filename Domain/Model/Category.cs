namespace Domain.Model
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }=new List<Product>();
    }
}
