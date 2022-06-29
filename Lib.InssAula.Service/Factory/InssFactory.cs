using Lib.InssAula.Domain.Interfaces;
using Lib.InssAula.Service.Services.InssServices;

namespace Lib.InssAula.Service.Factory
{
    public class InssFatory
    {

        public IInss MakeInss(int ano)
        {
            switch (ano)
            {
                case 2011:
                    return new Inss2011();
                case 2012:
                    return new Inss2012();
                default:
                    return null;
            }
        }

    }
}