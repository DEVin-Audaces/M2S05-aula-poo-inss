using Lib.InssAula.Domain.Interfaces;
using Lib.InssAula.Domain.Models;
using Lib.InssAula.Service.Factory;

namespace Lib.InssAula.Service.Services
{
    public class SalarioService : ISalarioService
    {
        public ServiceResposta<DescontoSalario> CalcularInss(Salario salario)
        {
            var serviceRespostaDescontoSalario = new ServiceResposta<DescontoSalario>();

            var inssFactory = new InssFatory();
            int ano = salario.Data.Year;
            ServiceResposta<IInss> respostaFactory = inssFactory.MakeInss(ano);

            if (respostaFactory.Sucesso)
            {
                IInss inss = respostaFactory.Resposta;
                serviceRespostaDescontoSalario.Sucesso = true;
                serviceRespostaDescontoSalario.Resposta = inss.Calcula(salario.Valor);
            }
            else
            {
                serviceRespostaDescontoSalario.Sucesso = respostaFactory.Sucesso;
                serviceRespostaDescontoSalario.MensagemErro = respostaFactory.MensagemErro;
            }

            return serviceRespostaDescontoSalario;
        }

    }
}
