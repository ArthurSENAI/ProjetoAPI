using ProjetoAPIWEB.Model;

namespace ProjetoAPIWEB.Repositorio
{
    public interface IFuncionarioRepositorio
    {
        void Add(Funcionario funcionario, IFormFile foto);

        List<Funcionario> GetAll();

        void Update(Funcionario funcionario, IFormFile foto);

        void Delete(int id);
    }
}
