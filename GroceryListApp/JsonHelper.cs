using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace GroceryListApp
{
    public static class JsonHelper
    {
        private static string filePath = "shoppinglist.json";

        public static void WriteProducts(List<Product> products)
        {
            string json = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static List<Product> ReadProducts()
        {
            if (!File.Exists(filePath)) return new List<Product>();
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Product>>(json);
        }
    }
}
