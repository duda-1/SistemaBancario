using SistemaBancario;
using System.Drawing;

double Saldo = 500;
double LimiteCredito = 200;
double valor;
double TaxaJuros = 0.5;

Console.WriteLine("Valor Que deseja Depositar:");
valor = double.Parse(Console.ReadLine());
Saldo =  valor + (Saldo * TaxaJuros);
Console.WriteLine($"Valor Depositado com sucesso!!\n Saldo Atual: {Saldo}");

Console.WriteLine("Quantos deseja Sacar?");
valor = double.Parse(Console.ReadLine());

if (valor > 0 && valor <= Saldo+LimiteCredito)
{
    Saldo = Saldo - valor;
    Console.WriteLine($"Valor retirado com sucesso!! Saldo Atual {Saldo}");

}
else
{
    Console.WriteLine("Saldo Insuficiente");

}



