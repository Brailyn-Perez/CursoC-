using Triangulos;

internal class Program
{
    private static void Main(string[] args)
    {
        //1) Dado un conjunto de datos representando las dimensiones de triángulos.
        //calcular y contar aquellos cuya área excede un valor límite.

        Calculador calcu = new Calculador();
        calcu.CalcularAreaDelTriangulo();
    }
}