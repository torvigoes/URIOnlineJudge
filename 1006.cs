using System;


namespace URIOnlineJudge{
	class _1006{
		static void Main(string[] args){
			int n1 = Convert.ToInt32(Console.ReadLine());
			int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());
            int n4 = Convert.ToInt32(Console.ReadLine());
            int dif = (n1 * n2) - (n3 * n4);
            Console.WriteLine($"DIFERENCA = {dif}");
		}
	}
}