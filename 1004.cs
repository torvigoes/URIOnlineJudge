using System;


namespace URIOnlineJudge{
	class _1004{
		static void Main(string[] args){
			double n1 = Convert.ToDouble(Console.ReadLine());
			double n2 = Convert.ToDouble(Console.ReadLine());
            double media = ((n1 * 3.5) + (n2 * 7.5)) / 11;
            Console.WriteLine($"MEDIA = {media.ToString("0.00000")}");
		}
	}
}