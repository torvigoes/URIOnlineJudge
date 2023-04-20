using System;


namespace URIOnlineJudge{
	class _1005{
		static void Main(string[] args){
			double n1 = Convert.ToDouble(Console.ReadLine());
			double n2 = Convert.ToDouble(Console.ReadLine());
            double n3 = Convert.ToDouble(Console.ReadLine());
            double media = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;
            Console.WriteLine($"MEDIA = {media.ToString("0.0")}");
		}
	}
}