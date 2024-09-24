using Microsoft.AspNetCore.Mvc;
using ProjetoAPITarde.Model;
using ProjetoAPITarde.ViewModel;

namespace ProjetoAPITarde.Controllers
{
    [ApiController]
    [Route("api/v1/funcionarios")]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioRepositorio _funcionarioRepositorio;

        public FuncionarioController(IFuncionarioRepositorio funcionarioRepositorio)
        {
            _funcionarioRepositorio = funcionarioRepositorio;
        }

        public IActionResult Add(FuncionarioViewModel fun)
        {
            var funcionario = new Funcionario(fun.Nome, fun.Idade, null);
        }
    }
}
