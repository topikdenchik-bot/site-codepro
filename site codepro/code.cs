using System;
using OnlineShop;

class Program
{
    static void Main()
    {
        Product phone = new Product(1, "Телефон", 15000);
        Product laptop = new Product(2, "Ноутбук", 50000);

        Cart cart = new Cart();

        cart.AddProduct(phone);
        cart.AddProduct(laptop);

        Console.WriteLine("Товары в корзине:");
        foreach (var product in cart.GetProducts())
        {
            Console.WriteLine($"{product.Name} - {product.Price} ₽");
        }

        Console.WriteLine($"Итого: {cart.GetTotalPrice()} ₽");
    }
}
