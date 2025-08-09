using System;

public class Assessment11
{
    public static double CalculateRate_using_Ref(ref double A, ref double IA, ref double T, out double result){
        result=(IA/(A*T))*100;
        return result;
    }
    public static void Main(string[] args)
    {
       Console.WriteLine("Welcome  to find the Rate of interest based on S.I, principal amount, Time");
       Console.WriteLine("Enter the Principle Amount: ");
       double Principle_Amount=double.Parse(Console.ReadLine());
       Console.WriteLine("Enter the Interest_amount: ");
       double Interest_Amount=double.Parse(Console.ReadLine());
       Console.WriteLine("Enter the Duration for Interest in years: ");
       double Time=double.Parse(Console.ReadLine());
       double result;
       Principle_Amount=0.0;
       Interest_Amount=0.0;
       Time=0.0;
        result=CalculateRate_using_Ref(ref Principle_Amount,ref Interest_Amount, ref Time, out result );
        
       Console.WriteLine($"The Rate of Interest is: {result}%");
    }
}

