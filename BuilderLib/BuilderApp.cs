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

            smartPhoneBuilder = new IosBuilder();
            fabricante.Construtor(smartPhoneBuilder);          
            Console.WriteLine($"Nome: { smartPhoneBuilder.smartPhone.nome }, " +
                            $"Tela: { smartPhoneBuilder.smartPhone.tela }, " +
                            $"Câmera: { smartPhoneBuilder.smartPhone.camera }");

            smartPhoneBuilder = new AndroidBuilder();
            fabricante.Construtor(smartPhoneBuilder);
            Console.WriteLine();
            Console.WriteLine($"Nome: { smartPhoneBuilder.smartPhone.nome }, " +
                            $"Tela: { smartPhoneBuilder.smartPhone.tela }, " +
                            $"Câmera: { smartPhoneBuilder.smartPhone.camera }");
        }
    }
}
