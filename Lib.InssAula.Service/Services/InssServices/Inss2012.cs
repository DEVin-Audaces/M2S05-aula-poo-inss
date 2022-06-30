using Lib.InssAula.Domain.Interfaces;
using Lib.InssAula.Domain.Models;

namespace Lib.InssAula.Service.Services.InssServices
{
    public class Inss2012 : IInss
    {
        public DescontoSalario Calcula(decimal salario)
        {
            var descontoSalario = new DescontoSalario();

            if (salario <= 1000m)
            {
                descontoSalario.ValorDesconto = salario * 0.07m;
                descontoSalario.SalarioComDesconto = salario - descontoSalario.ValorDesconto;
            }
            else if (salario <= 1500m)
            {
                descontoSalario.ValorDesconto = salario * 0.08m;
                descontoSalario.SalarioComDesconto = salario - descontoSalario.ValorDesconto;
            }
            else
            {
                descontoSalario.ValorDesconto = 500;
                descontoSalario.SalarioComDesconto = salario - descontoSalario.ValorDesconto;
            }

            return descontoSalario;
        }
    }
}