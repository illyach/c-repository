using System;
					
public class Program
{
	public static void Main()
	{
        double N;
        double K;
        double Ak;
        
        Console.WriteLine("input numbers of n");
            string strN = Console.ReadLine();
 		            N = double.Parse(strN);


        Console.WriteLine ("input numbers of k");
               string strK = Console.ReadLine();
                		    K = double.Parse(strK);

            if(K >= N >= 0){
                 Console.WriteLine("its true");
                 return;
            }else{
                Console.WriteLine("Erorr!! Error Error !!!");
                 return;
            }

            Console.WriteLine("k is " + K);
            Console.WriteLine("n is " + N);

           (double)Ak = 

	}
}


using System;
					
public class Program
{
	public static void Main()
	{
        int nn;
        int nk;
        int k;
        double res;

        nn = Parse.(Console.ReadLine());
        nk = Parse.(Console.ReadLine());

        for ( k = nn; k <= nk; k++ ){
            // res += 2*pow(k, 2) //pow степень второй   есть еще res += 2*Math выбираем что нужно
            
            res += 2*Math.Pow(k,2);
            
        }
        
        Console.WriteLine(res);
        Console.ReadLine();


	}
}