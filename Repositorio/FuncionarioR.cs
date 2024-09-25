using ProjetoAPIWEB.Model;
using ProjetoAPIWEB.ORM;

namespace ProjetoAPIWEB.Repositorio
{
    public class FuncionarioR : IFuncionarioRepositorio
    {
        private BdempresaTardeContext _context;

        public FuncionarioR(BdempresaTardeContext context)
        {
            _context = context;
        }

        public void Add(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public void Delete(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> GetAll()
        {
            List<Funcionario> listFun = new List<Funcionario>();

            var listTb = _context.TbFuncionarios.ToList();

            foreach (var item in listTb)
            {
                var funcionario = new Funcionario
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    // Adicione aqui outras propriedades que precisar mapear
                };

                listFun.Add(funcionario);
            }

            return listFun;
        }

        public void Update(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }
    }
}
