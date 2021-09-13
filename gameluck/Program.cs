using System;

namespace Practicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            bool cancelar = false; // condición para cancelar el do-while.
            int contador = 0; // para validaciones
            int numero = 0; // numero que inserte el usuario desde el método.
            int vida = 3; // vidas del usuario.

            int azar = random.Next(1, 10000);

            do
            {
                Console.WriteLine("Inserte un numero al azar");
                if (validar())
                {
                    if (numero == azar && vida > 0)
                    {
                        Console.WriteLine("¡Le pegaste al número campeon!");
                        Console.WriteLine("El número era: " + azar);

                        cancelar = true;
                    }
                    else if (numero != azar)
                    {
                        if (vida == 0)
                        {
                            Console.WriteLine("Te quedaste sin vidas, game ova");
                            Console.WriteLine("El numero era: " + azar);

                            cancelar = true;
                        }
                        vida--;
                    }
                }

            } while (!cancelar);

            //Método para manejar los errores de inserción. Ej: si el usuario inserta una letra.
            bool validar()
            { 
                try
                {
                    numero = Convert.ToInt32(Console.ReadLine());
                    return true;
                }
                catch (Exception err)
                {
                    contador++;

                    if (contador == 3)
                    {
                        cancelar = true;
                        Console.WriteLine("TE LA MANDASTE MUCHO, CHAU");
                        Console.WriteLine("ERROR TIPO DE DATO: " + err);
                    }
                    else
                    {
                        Console.WriteLine("No, no, no. ESO NO VA AHI");
                    }

                    return false;
                }
            }
            
        }
    }
}

