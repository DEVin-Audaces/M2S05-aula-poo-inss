using System.Net;

namespace Lib.InssAula.Domain.Models
{
    public class ServiceResposta<TEntity>
    {
        public TEntity? Resposta { get; set; }
        public bool Sucesso { get; set; }
        public string MensagemErro { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
