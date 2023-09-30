using GerenciadorDeFuncionários.Models;

namespace ApiFuncionarios.Service.FuncionarioService
{
    public interface IFuncionarioInterface
    {
        Task<ServiceResponse<FuncionarioModel>> GetById(int id);

        Task<ServiceResponse<List<FuncionarioModel>>> Get();

        Task<ServiceResponse<List<FuncionarioModel>>> Create(FuncionarioModel newFuncionario);

        Task<ServiceResponse<List<FuncionarioModel>>> Update(FuncionarioModel editFuncionario);

        Task<ServiceResponse<List<FuncionarioModel>>> Delete(int id);

        Task<ServiceResponse<List<FuncionarioModel>>> Disable(int id);


    }
}
