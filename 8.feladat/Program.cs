using Adatok.Data;
using Adatok.Models;


public class Program
{
    public static void Main(string[] args)
    {
        string[] sorok = File.ReadAllLines(@"c:\adat\8.csv");
        foreach (var sor in sorok)
        {
            string[] values = sor.Split(";");
            foreach ( string value in values)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
    
    
}