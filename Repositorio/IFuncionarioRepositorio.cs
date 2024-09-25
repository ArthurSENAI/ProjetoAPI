using ProjetoAPIWEB.Model;

namespace ProjetoAPIWEB.Repositorio
{
    public interface IFuncionarioRepositorio
    {
        void Add(Funcionario funcionario);

        List<Funcionario> GetAll();

        void Update(Funcionario funcionario);

        void Delete(Funcionario funcionario);
    }
}
