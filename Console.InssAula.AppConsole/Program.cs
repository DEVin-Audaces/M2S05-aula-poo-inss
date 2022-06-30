// See https://aka.ms/new-console-template for more information
using Lib.InssAula.Domain.Interfaces;
using Lib.InssAula.Domain.Models;
using Lib.InssAula.Service.Services;

var salario = new Salario();

Console.WriteLine("Salário: ");
salario.Valor = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Data: ");
salario.Data = Convert.ToDateTime(Console.ReadLine());


ISalarioService salarioService = new SalarioService();

ServiceResposta<DescontoSalario> respostaSalario = salarioService.CalcularInss(salario);

if (respostaSalario.Sucesso)
{
    Console.WriteLine($"Salario com desconto é {respostaSalario.Resposta.SalarioComDesconto}");
    Console.WriteLine($"O valor do desconto é {respostaSalario.Resposta.ValorDesconto}");
}
else
    Console.WriteLine($"Erro. Mensagem: {respostaSalario.MensagemErro}");