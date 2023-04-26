using System;


namespace URIOnlineJudge{
	class _1008{
		static void Main(string[] args){

		    double salario, vendas;
            string vendedor;

		    vendedor = Console.ReadLine();
		    salario = Convert.ToDouble(Console.ReadLine());
		    vendas = Convert.ToDouble(Console.ReadLine());

            double comissao = vendas * 0.15;
            double salarioTotal = salario + comissao;

		    Console.WriteLine($"TOTAL = R${salarioTotal.ToString("0.00")}");
		}
	}
}
