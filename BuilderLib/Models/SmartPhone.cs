namespace BuilderLib.Models
{
    public class SmartPhone
    {

        public SmartPhone(string _nome)
        {
            nome = _nome;
        }

        public string nome { get; set; }
        public string tela { get; set; }
        public string bateria { get; set; }
        public string camera { get; set; }
        public string sistema { get; set; }
    }
}
