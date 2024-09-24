using ProjetoAPITarde.Model;

namespace ProjetoAPITarde.ORM
{
    public class FuncionarioRepositorio : IFuncionarioRepositorio
    {
        private readonly BdempresaTardeContext _context = new BdempresaTardeContext();

        public void Add(Funcionario funcionario)
        {
            _context.Add(funcionario);
            _context.SaveChanges();
        }


        public List<Funcionario> Get()
        {
            return _context.Funcionario.ToList();
        }

        
    }
}
