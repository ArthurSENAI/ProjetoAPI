namespace ProjetoAPITarde.Model
{
    public interface IFuncionarioRepositorio
    {
        void Add(Funcionario funcionario);

        List<Funcionario> Get();
    }
}
