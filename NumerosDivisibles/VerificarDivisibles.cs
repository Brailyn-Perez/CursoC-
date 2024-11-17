using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosDivisibles
{
    internal class VerificarDivisibles
    {
        //2) Crear un programa que cuente cuántos números, de un conjunto de 10, son divisibles por 3 o por 5.
        public void verificarDivisibles()
        {
            int numeros;
            string valorIntroducidoPorConsola = string.Empty;

            //definimos las listas
            List<int> listaNumerosDivisibles3 = new List<int>();
            List<int> listaNumerosDivisibles5 = new List<int>();

            //lista de numeros no divisibles entre 3 y 5
            List<int> listanumerosNoDivisibles = new List<int>();

            Console.WriteLine("Por favor ingrese 10 numeros");

            for (int i = 1; i <= 10; i++)
            {
                valorIntroducidoPorConsola = Console.ReadLine();
                if (string.IsNullOrEmpty(valorIntroducidoPorConsola))
                {
                    Console.WriteLine("Por favor ingrese 10 numeros");
                    return;
                }
                if (int.TryParse(valorIntroducidoPorConsola, out numeros))
                {
                    if (numeros % 5 == 0)
                    {
                        listaNumerosDivisibles5.Add(numeros);
                    }
                    else if (numeros % 3 == 0)
                    {
                        listaNumerosDivisibles3.Add(numeros);
                    }
                    else
                    {
                        listanumerosNoDivisibles.Add(numeros);
                    }
                }
                else 
                {
                    Console.WriteLine("Por favor ingrese 10 numeros");
                    return;
                }
            }
            //imprimimos los numeros exactos divisibles al final
            Console.WriteLine("----------------------------3---------------------------");
            foreach (var item in listaNumerosDivisibles3)
            {
                Console.WriteLine($"Numeros  divisibles a 3: {item}");
            }
            Console.WriteLine("----------------------------5---------------------------");
            foreach (var item in listaNumerosDivisibles5)
            {
                Console.WriteLine($"Numeros  divisibles a 5: {item}");
            }
            Console.WriteLine("----------------------------no---------------------------");
            foreach (var item in listanumerosNoDivisibles)
            {
                Console.WriteLine($"Numeros no divisibles a 3 y 5: {item}");
            }
        }
    }
}
