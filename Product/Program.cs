namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = GetProductsFromDatabase();

            var groupedProducts = products.GroupBy(product => product.Category);

            foreach (var group in groupedProducts)
            {
                Console.WriteLine($"{group.Key}:");
                foreach (var product in group)
                {
                    Console.WriteLine($" - {product.Name}: {product.Price}");
                }
            }
        }

        static List<Product> GetProductsFromDatabase()
        {
            return new List<Product> {
            new Product { Name = "Apple", Category = "Fruit", Price = 1.0 },
            new Product { Name = "Orange", Category = "Fruit", Price = 1.5 },
            new Product { Name = "Carrot", Category = "Vegetable", Price = 0.5 },
            new Product { Name = "Broccoli", Category = "Vegetable", Price = 1.0 }};
        }
    }
}