using Lib.InssAula.Domain.Interfaces;
using Lib.InssAula.Domain.Models;
using Lib.InssAula.Service.Services.InssServices;
using System.Net;

namespace Lib.InssAula.Service.Factory
{
    public class InssFatory
    {
        public ServiceResposta<IInss> MakeInss(int ano)
        {
            var serviceResposta = new ServiceResposta<IInss>();
            switch (ano)
            {
                case 2011:
                    serviceResposta.Sucesso = true;
                    serviceResposta.Resposta = new Inss2011();
                    serviceResposta.StatusCode = HttpStatusCode.OK;
                    break;
                case 2012:
                    serviceResposta.Sucesso = true;
                    serviceResposta.Resposta = new Inss2012();
                    serviceResposta.StatusCode = HttpStatusCode.OK;
                    break;
                default:
                    serviceResposta.Sucesso = false;
                    serviceResposta.MensagemErro = "Ano inválido";
                    serviceResposta.StatusCode = HttpStatusCode.BadRequest;
                    break;
            }

            return serviceResposta;
        }

    }
}