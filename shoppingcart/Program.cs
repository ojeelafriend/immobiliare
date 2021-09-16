using System;

namespace shoppingcart
{
    class Program
    {
        static void Main(string[] args)
        {
            bool reset = false;
            string username;
            int option;

            Console.WriteLine("Bienvenido a shoppingcart, a continuación ingresa tu nombre de usuario");
            username = Console.ReadLine();

            do {
                Console.WriteLine("***** Menu ******");
                Console.WriteLine("1- Añadir camisa al carro de compras");
                Console.WriteLine("2- Eliminar camisa del carro de compras");
                Console.WriteLine("3- Salir");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        new Shirt();
                        showCartStatus();
                        break;
                    case 2:
                        Shirt.DeleteQuiatityShirts();
                        showCartStatus();
                        break;
                    case 3:
                        reset = true;
                        break;
                }
            } while (!reset);

            void showCartStatus()
            { 
                Console.WriteLine("******** Carrito de " + username + " ************");
                Console.WriteLine("- Cantidad de camisas en el carro de compras: " + Shirt.Quantity);
                Console.WriteLine("- Precio unitario: " + Shirt.Price);
                Console.WriteLine("- Precio total sin descuento: $" + Shirt.TotalPrice);
                Console.WriteLine("- Descuento aplicado: " + Shirt.DiscoutType);
                Console.WriteLine("- Precio final con descuento: " + Shirt.EvaluateDiscountRate());
            }
        }
    }
}
