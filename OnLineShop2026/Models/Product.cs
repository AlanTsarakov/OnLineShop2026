namespace OnLineShop2026.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        
        public Product(string name, string description, decimal cost)
        {
            Name = name;
            Description = description;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"Товар {Name}, Описание {Description}, Цена {Cost}";
        }

    }
}
