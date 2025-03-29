using System;
using System.Threading;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello FinalProject World!");
        GetRandomNoteAvtivity myActivity = new GetRandomNoteAvtivity();

        Scale myScale1 = new Scale("C", true);
        Scale myScale2 = new Scale("A", false);
        Scale myScale3 = new Scale("D", true);

        Console.WriteLine(myScale1.IsSameScale(myScale2.GetScale()));
        Console.WriteLine(myScale1.IsSameScale(myScale3.GetScale()));
    }
}