using SistemaDeAgendamento.Data;
using SistemaDeAgendamento.Models;
using SistemaDeAgendamento.Repositorys.Interfaces;

namespace SistemaDeAgendamento.Repositorys
{
    public class UsuarioRespository : IUsuarioRepository
    {
        private readonly SistemaAgendamentoDBContext _dbContext;

        public UsuarioRespository(SistemaAgendamentoDBContext sistemaAgendamentoDBContext)
        {
            _dbContext = sistemaAgendamentoDBContext;
        }
        public Task<UsuarioModel> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}
