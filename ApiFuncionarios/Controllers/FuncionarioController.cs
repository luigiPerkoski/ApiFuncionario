using ApiFuncionarios.Service.FuncionarioService;
using GerenciadorDeFuncionários.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiFuncionarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioInterface _funcionarioService;

        public FuncionarioController(IFuncionarioInterface funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }
        
        [HttpGet]

        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> Get()
        {
            return Ok(await _funcionarioService.Get());
        }
        
        [HttpGet("{id}")]

        public async Task<ActionResult<ServiceResponse<FuncionarioModel>>> GetbyId(int id)
        {
            return Ok(await _funcionarioService.GetById(id));
        }
        
        [HttpPost]

        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> Create(FuncionarioModel newFuncionario)
        {
            return Ok(await _funcionarioService.Create(newFuncionario));
        }

        [HttpPut("Disable Funcionario")]

        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> Disable(int id)
        {
                return Ok(await _funcionarioService.Disable(id));
        }

        [HttpPut]

        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> Update(FuncionarioModel funcionarioDisable)
        {
            return Ok(await _funcionarioService.Update(funcionarioDisable));
        }

        [HttpDelete]

        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> Delete(int id)
        {
            return Ok(await _funcionarioService.Delete(id));
        }
    }
}
