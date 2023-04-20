// See https://aka.ms/new-console-template for more information


double pi = 3.14159;

double raio = Convert.ToDouble(Console.ReadLine());
double area = pi * (Math.Pow(raio, 2));


Console.WriteLine($"A={area.ToString("0.0000")}");
