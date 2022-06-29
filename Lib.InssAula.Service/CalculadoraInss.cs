
using Lib.InssAula.Domain.Interfaces;
using Lib.InssAula.Domain.Models;
using Lib.InssAula.Service.Factory;

namespace Lib.InssAula.Service
{
    public class CalculadoraInss : ISalarioService
    {
        public DescontoSalario Calcular(Salario salario)
        {
            var factoryInss = new InssFatory();
            IInss inss = factoryInss.MakeInss(salario.Data.Year);
            DescontoSalario desconto =  inss.Calcula(salario.Valor);
        }
    }
}