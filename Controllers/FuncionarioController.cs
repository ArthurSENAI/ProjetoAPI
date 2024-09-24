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


        [HttpPost]
        public IActionResult Add(FuncionarioViewModel fun)
        {
            var funcionario = new Funcionario(fun.Nome, fun.Idade, null);

            _funcionarioRepositorio.Add(funcionario);

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var funcionarios = _funcionarioRepositorio.Get();

            return Ok(funcionarios);

        }
    }
}
