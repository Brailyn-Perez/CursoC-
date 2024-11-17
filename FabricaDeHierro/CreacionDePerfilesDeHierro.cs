using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace FabricaDeHierro
{
    internal class CreacionDePerfilesDeHierro
    {
        public void Calcular()
        {
            int x = 1;
            int cantidad = 0;
            int CantidadPerfilesNoAptos = 0;
            int n = 0;
            float largo = 0;
            string valor = String.Empty;

            try
            {
                //Aqui solicitamos la cantidad de Perfiles de Hierro
                Console.WriteLine("Ingrese la cantidad de Perfiles en Hierro que quiere fabricar");
                valor = Console.ReadLine();

                //validamos que el campo no se nos envie vacio o null
                if (string.IsNullOrEmpty(valor))
                {
                    Console.WriteLine("El valor no puede estar vacio");
                    return;
                }


                if (int.TryParse(valor, out n))
                {
                    while (x <= n)
                    {

                        //Solicitamos los datos del largo de la placa de hierro
                        Console.WriteLine($"Ingrese el largo de la pieza {x}");
                        valor = Console.ReadLine();

                        if (string.IsNullOrEmpty(valor))
                        {
                            Console.WriteLine("No se permiten datos vacios");
                            return;
                        }
                        if (!float.TryParse(valor, out largo))
                        {
                            Console.WriteLine("no se aceptan letras");
                            return;
                        }
                        else
                        {
                            if (largo >= 1.20 && largo <= 1.30)
                            {
                                cantidad++;
                            }
                            else
                            {
                                Console.WriteLine("Debe Ingresar una cantidad que se encuentre entre 1.20 y 1.30");
                                CantidadPerfilesNoAptos++;
                            }
                        }
                        x++;
                    }
                    Console.WriteLine($"La cantidad de perfile aptos es de: {cantidad}, la de los no aptos es de: {CantidadPerfilesNoAptos}");
                }
                else
                {
                    Console.WriteLine("Solo se permiten Numeros!");
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
