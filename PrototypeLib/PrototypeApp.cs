using System;

namespace PrototypeLib
{
    public static class PrototypeApp
    {
        public static void Executar()
        {
            Console.WriteLine();
            Console.WriteLine("-------- Pattern Prototype --------");
            Console.WriteLine();
            Console.WriteLine("Exemplo: Clone de objetos Funcionários");
            Console.WriteLine("");

            Funcionario funcionario = new Funcionario() { 
                Nome = "Henrique Machado",
                Tipo = "Permanente",
                Idade = 26
            };
            Console.WriteLine($"Detalhes do funcionário Permanente:");
            Console.WriteLine($"Nome: {funcionario.Nome}, Tipo: {funcionario.Tipo}, Idade: {funcionario.Idade}");
            
            Funcionario cloneFuncionario = (Funcionario)funcionario.Clone();
            cloneFuncionario.Nome = "Jhon Carter";
            cloneFuncionario.Idade = 45;
            Console.WriteLine($"Detalhes do funcionário Permanente clonado:");
            Console.WriteLine($"Nome: {cloneFuncionario.Nome}, Tipo: {cloneFuncionario.Tipo}, Idade: {cloneFuncionario.Idade}");
        }
    }
}
