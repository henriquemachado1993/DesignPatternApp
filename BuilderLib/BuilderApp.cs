using BuilderLib.ConcreteBuilder;
using BuilderLib.Interfaces;
using System;

namespace BuilderLib
{
    public class BuilderApp
    {
        public static void Executar()
        {
            Console.WriteLine();
            Console.WriteLine("-------- Pattern Builder --------");
            Console.WriteLine();

            Fabricante fabricante = new Fabricante();

            ISmartPhone smartPhoneBuilder = null;            
            Console.WriteLine($"Novos smartPhone construídos");
            Console.WriteLine();

            // Caso queira ver um ou o outro basta descomentar
            smartPhoneBuilder = new IosBuilder();
            //smartPhoneBuilder = new AndroidBuilder();
            fabricante.Construtor(smartPhoneBuilder);          
            Console.WriteLine($"Nome: { smartPhoneBuilder.smartPhone.nome }, " +
                            $"Tela: { smartPhoneBuilder.smartPhone.tela }, " +
                            $"Câmera: { smartPhoneBuilder.smartPhone.camera }");
        }
    }
}
