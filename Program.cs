using System;
class product{
    public int id;
    public string name;
    public double price;
    
    public product()
    {
        id = 1001;
        name = "Acer nitro 5";
        price = 2000.00f;
    }
    public override string ToString()
    {
         return string.Format("Laptop you choose is {0} code is {1} and price is: {2}",name, id, price);
    }
}
class Laptop : product {
    public string ram;
    public string cpu;    

    public Laptop()
    {
        ram = "8gb";          
        cpu = "intel core i5 11400h";
    }
    
}
class Book : product{
    public string information_author;
    public Book()
    {
        information_author = "nullll";
    }
    
}

public class testproduct{
    public static void Main(string[] args)
    {
        Laptop laptop = new Laptop();
        Console.WriteLine("Information of product is : "+laptop.ToString());
        Book book = new Book();
        Console.WriteLine(book);
    }
}