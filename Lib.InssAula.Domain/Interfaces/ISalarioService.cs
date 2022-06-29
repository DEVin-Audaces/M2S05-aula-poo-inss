using Lib.InssAula.Domain.Models;

namespace Lib.InssAula.Domain.Interfaces
{
    public interface ISalarioService
    {
        DescontoSalario CalcularInss(Salario salario);
    }
}