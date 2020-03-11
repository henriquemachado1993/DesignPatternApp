using BuilderLib.Interfaces;

namespace BuilderLib
{
    public class Fabricante
    {
        public void Construtor(ISmartPhone smartPhoneBuilder)
        {
            smartPhoneBuilder.BuildBateria();
            smartPhoneBuilder.BuildCamera();
            smartPhoneBuilder.BuildSistema();
            smartPhoneBuilder.BuildTela();
        }
    }
}
