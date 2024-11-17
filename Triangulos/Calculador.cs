using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos
{
    internal class Calculador
    {


        public void CalcularAreaDelTriangulo()
        {
            int a;
            int b;
            int c;
            int triangulosQueExcedenValorLimite = 0;
            int triangulosQueNOExcedenValorLimite = 0;
            int areaDelTriangulo;
            int cantidadDeTriangulosAIngresar;
            const int valorLimiteDelArea = 20;
            string valorIngresadoPorConsola = string.Empty;


            try
            {
                Console.WriteLine("Ingrese La cantidad de Triangulos que desea ingresar");
                valorIngresadoPorConsola = Console.ReadLine();
                if (!int.TryParse(valorIngresadoPorConsola, out cantidadDeTriangulosAIngresar))
                {
                    return;
                }


                //comenzamos el bucle para solicitar el ingreso de datos
                for (int i = 1; i <= cantidadDeTriangulosAIngresar; i++)
                {
                    // Lo primero que vamos hacer es solicitar y validar los datos solicitados
                    Console.WriteLine($"Triangulo #{i}");
                    Console.WriteLine("Ingrese la medida del primer lado del triangulo");
                    valorIngresadoPorConsola = Console.ReadLine();

                    //validamos que ingresaron el dato correctamente
                    if (!int.TryParse(valorIngresadoPorConsola, out a))
                    {
                        Console.WriteLine("Los lados de un triangulo solo pueden ser numericos");
                        return;
                    }

                    Console.WriteLine("Ingrese la medida del Segundo lado del triangulo");
                    valorIngresadoPorConsola = Console.ReadLine();

                    //validamos que ingresaron el dato correctamente
                    if (!int.TryParse(valorIngresadoPorConsola, out b))
                    {
                        Console.WriteLine("Los lados de un triangulo solo pueden ser numericos");
                        return;
                    }

                    Console.WriteLine("Ingrese la medida del Tercer lado del triangulo");
                    valorIngresadoPorConsola = Console.ReadLine();

                    //validamos que ingresaron el dato correctamente
                    if (!int.TryParse(valorIngresadoPorConsola, out c))
                    {
                        Console.WriteLine("Los lados de un triangulo solo pueden ser numericos");
                        return;
                    }

                    areaDelTriangulo = (a+b+c) / 2;
                    if (areaDelTriangulo > valorLimiteDelArea)
                    {
                        triangulosQueExcedenValorLimite++;
                    }
                    else
                    {
                        triangulosQueNOExcedenValorLimite++;
                    }
                }
                Console.WriteLine($"Triangulos que exceden el valor limite de {valorLimiteDelArea} : {triangulosQueExcedenValorLimite}");
                Console.WriteLine($"Triangulos que no exceden el valor limite de {valorLimiteDelArea} : {triangulosQueNOExcedenValorLimite}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




        }
    }
}
