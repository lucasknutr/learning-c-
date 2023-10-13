namespace FirstApp
{
    public class Pessoa
    {
        public static int CurrentId { get; set; }

        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal Saldo { get; set; }

        public Pessoa(string nome, decimal saldo)
        {
            CurrentId++;
            Id = CurrentId;
            Nome = nome;
            Saldo = saldo;
        }
    }
}