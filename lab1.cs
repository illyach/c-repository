using System;

public class Program
{
    public static void Main()
    {
        // int U;
        // int R;
        // int I;
        double U;
        double R;
        double I;
        double isOKU = false;

        Console.WriteLine("Ведите напругу");
        string strU = Console.ReadLine();
        U = int.Parse(strU);

        if (double.TryParse(strU, out U))
        {
            Console.WriteLine("error");
            Console.ReadLine();
            return;
        };

        Console.WriteLine("Ведите опiр");
        string strR = Console.ReadLine();
        R = double.Parse(strR);   //R = double.Parse(strR);


        if (R > 0)
        {
            Console.WriteLine("Error");
            Console.ReadLine();
            return;
        };


        (double)I = U / R;
        Console.WriteLine("сила струму, I=(0), R=(0)", I, R);
        //або так Console.WriteLine("сила струму, I=(I), R=(R)");
        //або так Console.WriteLine("сила струму, I= " + I , R=(R)");




        Console.ReadLine();

    }
}