using BuilderLib.Models;

namespace BuilderLib.Interfaces
{
    public interface ISmartPhone
    {
        void BuildTela();
        void BuildBateria();
        void BuildSistema();
        void BuildCamera();

        SmartPhone smartPhone { get; }
    }
}
