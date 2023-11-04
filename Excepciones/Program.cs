using System;
FileStream file = null;
try
{
    double n1, n2, division;

    Console.WriteLine("Escriba primer numero:");
    n1 = double.Parse(Console.ReadLine()); //Capturamos el valor ingresado
    Console.WriteLine("Escriba segundo numero:");
    n2 = double.Parse(Console.ReadLine());
    division = n1 / n2;

    Console.WriteLine($"La division es {division}");
    file = File.Open("archivo.txt", FileMode.Open);
} catch(InvalidOperationException e)
{
    Console.WriteLine("InvalidOperationException");
    Console.WriteLine(e.Message);
} catch(IOException e)
{
    Console.WriteLine("IOException");
    Console.WriteLine(e.Message);
} catch (Exception e)
{
    Console.WriteLine("Exception");
    Console.WriteLine(e.Message);
} finally
{
    if (file != null)
    {
        file.Close();
        Console.WriteLine("Se ha cerrado el archivo");
    }
    Console.WriteLine("Saliendo de finally...");
}