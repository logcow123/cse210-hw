using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        
        Cart cart = new Cart();

        cart.Add();
        cart.Add();

        cart.Display();

        double total = cart.CalcTotal();
        Console.WriteLine(total);
    }
}