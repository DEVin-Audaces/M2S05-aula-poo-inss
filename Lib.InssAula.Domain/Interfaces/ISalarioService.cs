using Lib.InssAula.Domain.Models;

namespace Lib.InssAula.Domain.Interfaces
{
    public interface ISalarioService
    {
        ServiceResposta<DescontoSalario> CalcularInss(Salario salario);
    }
}