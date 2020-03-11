using BuilderLib.Interfaces;
using BuilderLib.Models;

namespace BuilderLib.ConcreteBuilder
{
    public class IosBuilder : ISmartPhone
    {

        readonly SmartPhone _smartPhone;

        public IosBuilder()
        {
            _smartPhone = new SmartPhone("Iphone 6s");
        }

        public void BuildBateria()
        {
            _smartPhone.bateria = "1715_MAH";
        }

        public void BuildCamera()
        {
            _smartPhone.camera = "12MP";
        }

        public void BuildSistema()
        {
            _smartPhone.sistema = "iOS 13";
        }

        public void BuildTela()
        {
            _smartPhone.tela = "4.7";
        }

        public SmartPhone smartPhone
        {
            get { return _smartPhone; }
        }
    }
}
