using _17AprelTaskHome.Models;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Catagory catagory = new Catagory()
        {
            Name = "Mercedes"
        };
        Product product = new Product()
        {
            Name="E240"
        };

       
        
        string json=JsonConvert.SerializeObject(product);   
        
    }
}