using Lib.InssAula.Domain.Interfaces;
using Lib.InssAula.Domain.Models;

namespace Lib.InssAula.Service.Services.InssServices
{
    public class Inss2011 : IInss
    {
        public DescontoSalario Calcula(decimal salario)
        {
            var descontoSalario = new DescontoSalario();
            if (salario <= 1106.9m)
            {
                descontoSalario.ValorDesconto = salario * (8 / 100);
                descontoSalario.SalarioComDesconto = salario - descontoSalario.ValorDesconto;
            }
            else if (salario <= 1844.83m)
            {
                descontoSalario.ValorDesconto = salario * (9 / 100);
                descontoSalario.SalarioComDesconto = salario - descontoSalario.ValorDesconto;
            }
            else
            {
                descontoSalario.ValorDesconto = 405;
                descontoSalario.SalarioComDesconto = salario - descontoSalario.ValorDesconto;
            }

            return descontoSalario;
        }
    }
}
