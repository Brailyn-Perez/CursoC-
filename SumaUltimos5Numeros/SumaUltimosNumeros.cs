using System;

namespace SumaUltimos5Numeros
{
    internal class SumaUltimosNumeros
    {
        public void SumarUltimos5Digitos()
        {
            int numeros = 0;
            int numeroSumados = 0;
            string valorIngresado = string.Empty;
            int[] listaNumeros = new int[10]; // Almacena los 10 números ingresados

            try
            {
                Console.WriteLine("Ingrese 10 números para sumar los últimos 5:");
                for (int i = 0; i < 10; i++) // Corregido para usar índice desde 0
                {
                    do
                    {
                        Console.Write($"Número {i + 1}: ");
                        valorIngresado = Console.ReadLine();

                        // Validación de entrada
                        if (string.IsNullOrEmpty(valorIngresado))
                        {
                            Console.WriteLine("El campo no puede estar vacío. Inténtelo nuevamente.");
                            continue;
                        }

                        if (int.TryParse(valorIngresado, out numeros))
                        {
                            listaNumeros[i] = numeros; // Agrega el número al array
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ingrese solo números válidos.");
                        }

                    } while (true);
                }

                // Sumar los últimos 5 números (índices 5 a 9)
                for (int i = 5; i < 10; i++)
                {
                    numeroSumados += listaNumeros[i];
                }

                Console.WriteLine($"La suma de los últimos 5 números es: {numeroSumados}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
            }
        }
    }
}
