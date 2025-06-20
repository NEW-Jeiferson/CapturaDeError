using System;


namespace CapturaDeError
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escribe Un Numero");
                int Numero = int.Parse(Console.ReadLine());
                Console.WriteLine("El numero es : " + Numero);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error de Capa 8, intruducir un Numero");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio Un Error" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Proceso Finalizado");
            }
            
        }
        
            
    }
}