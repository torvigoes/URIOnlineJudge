using System;


namespace URIOnlineJudge{
	class _1007{
		static void Main(string[] args){
		    int nf, ht;
		    double wageHour;

		    nf = Convert.ToInt32(Console.ReadLine());
		    ht = Convert.ToInt32(Console.ReadLine());
		    wageHour = Convert.ToDouble(Console.ReadLine());

		    double wage = wageHour * ht;

		    Console.WriteLine($"NUMBER = {nf}");
		    Console.WriteLine($"SALARY = U$ {wage.ToString("0.00")}");


		}
	}
}
