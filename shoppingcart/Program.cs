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
            int errorCount = 0;

            Console.WriteLine("Bienvenido a shoppingcart, a continuación ingresa tu nombre de usuario");
            username = Console.ReadLine();
           
            do
            {
                Console.WriteLine("***** Menu ******");
                Console.WriteLine("1- Añadir camisa al carro de compras");
                Console.WriteLine("2- Eliminar camisa del carro de compras");
                Console.WriteLine("3- Salir");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            new Shirt();
                            showCartStatus();
                            break;
                        case 2:
                            if (Shirt.Quantity == 0)
                            {
                                Console.WriteLine("No existe ningún producto en el carrito de compras");
                            }
                            else
                            {
                                Shirt.DeleteQuiatityShirts();
                                showCartStatus();
                            }
                            break;
                        case 3:
                            Console.Clear();
                            confirmExit();
                            break;
                    }
                }
                catch (Exception err) 
                {
                    errorCount++;
                    if(errorCount == 2)
                    {
                        Console.WriteLine("Error, muchos intentos vuelva a iniciar el programa");
                        reset = true;
                    }
                    else
                    {
                        Console.WriteLine("Se produjo un error, por favor cumpla con las consignas");
                        Console.WriteLine("Test: " + err);
                    }
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
            void confirmExit()
            {
                string option;
                Console.WriteLine("¿Estas seguro de salir? (Si / No) S/N");
                option = Console.ReadLine();
                if (option.Equals("S"))
                {
                    reset = true;
                }
                else
                {
                    reset = false;
                }

            }
        }
}   } 