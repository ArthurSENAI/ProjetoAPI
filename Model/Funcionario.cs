namespace ProjetoAPITarde.Model
{
    public class Funcionario
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public string? Foto { get; set; }

        public Funcionario( string nome, int idade, string? foto)
        {
            Nome = nome;
            Idade = idade;
            Foto = foto;
        }
    }
}
