using System;


namespace URIOnlineJudge{
	class _1009{
		static void Main(string[] args){
            
            string input = Console.ReadLine();
            string[] c1 = input.Split(' ');

            string input2 = Console.ReadLine();
            string[] c2 = input2.Split(' ');


            int codigo1 = int.Parse(c1[0]);
            int n1 = int.Parse(c1[1]);
            double v1 = double.Parse(c1[2]);

            int codigo2 = int.Parse(c2[0]);
            int n2 = int.Parse(c2[1]);
            double v2 = double.Parse(c2[2]);

            double valor1 = v1 * n1;
            double valor2 = v2 * n2;
            double total = valor1 + valor2;
            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("0.00")}");

		}
	}
}
