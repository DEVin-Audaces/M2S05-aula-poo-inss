using Lib.InssAula.Domain.Models;

namespace Lib.InssAula.Domain.Interfaces
{
    public interface IInss
    {
        // ctrl K + D
        DescontoSalario Calcula(decimal salario);
    }
}