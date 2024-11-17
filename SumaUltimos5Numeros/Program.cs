using SumaUltimos5Numeros;

internal class Program
{
    private static void Main(string[] args)
    {
        //3) Desarrollar un programa que permita ingresar 10 números y luego muestre la suma de los últimos 5 números ingresados.
        SumaUltimosNumeros numeros = new SumaUltimosNumeros();
        numeros.SumarUltimos5Digitos();
    }
}