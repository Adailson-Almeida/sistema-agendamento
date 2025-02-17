using SistemaDeAgendamento.Models;

namespace SistemaDeAgendamento.Repositorys.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios();

        Task<UsuarioModel> BuscarPorId(int id);

        Task<UsuarioModel> Adicionar(UsuarioModel usuario);

        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);

        Task<bool> Remover(int id);
    }
}
