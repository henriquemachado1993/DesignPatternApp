using BuilderLib.Interfaces;
using BuilderLib.Models;

namespace BuilderLib.ConcreteBuilder
{
    public class AndroidBuilder : ISmartPhone
    {

        readonly SmartPhone _smartPhone;

        public AndroidBuilder()
        {
            _smartPhone = new SmartPhone("Galax S20");
        }

        public void BuildBateria()
        {
            _smartPhone.bateria = "5000_MAH";
        }

        public void BuildCamera()
        {
            _smartPhone.camera = "48MP";
        }

        public void BuildSistema()
        {
            _smartPhone.sistema = "Android 4.0";
        }

        public void BuildTela()
        {
            _smartPhone.tela = "6.0";
        }

        public SmartPhone smartPhone
        {
            get { return _smartPhone; }
        }
    }
}
