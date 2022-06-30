using Lib.InssAula.Domain.Models;

namespace Lib.InssAula.Domain.Interfaces
{
    public interface IInss
    {
        DescontoSalario Calcula(decimal salario);
    }

}