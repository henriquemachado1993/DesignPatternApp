using System;

namespace SingletonLib
{
    // atributo "sealed" impede que a classe seja herdada
    public sealed class Singleton
    {
        private static Singleton instancia = null;
        private static string codigoInstancia = null;
        public static Singleton GetInstancia
        {
            get
            {
                if (instancia == null && codigoInstancia == null)
                {
                    instancia = new Singleton();
                    codigoInstancia = $"INST_{DateTime.Now.ToString("ddMMyyyy")}";
                    Console.WriteLine();
                    Console.WriteLine($"Bola em campo! Instância criada: {codigoInstancia}");
                }
                return instancia;
            }
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine($"{msg} - Instância usada: {codigoInstancia}");
        }
    }
}
