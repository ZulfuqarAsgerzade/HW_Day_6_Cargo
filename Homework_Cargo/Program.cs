using Homework_Cargo.Model;
using System.Runtime.CompilerServices;

public class Program
{
    public static void Main()
    {
        // Client
        Client client = new Client("Zulfugar", "Asgarzade");

        // Category
        Category category= new Category("clothes");

        // Product
        Product product = new Product("t-shirt", category, 10);

        // Order
        Order order = new Order(client);

        // Worker
        Worker worker = new Worker("Malik", "Huseynli");
        worker.addOrder(order);

        // Add worker for order
        order.Worker = worker;

        // Supplier
        Supplier supplier = new Supplier("Amid", "Hashimov");
        supplier.addOrder(order);
        
       
    }
}