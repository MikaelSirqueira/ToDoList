using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProAtividade.Domain.Entities;

namespace ProAtividade.Domain.Interfaces.Services
{
    public interface IAtividadeService
    {
        Task<Atividade> AdicionarAtividade(Atividade model);
        Task<Atividade> AtualizarAtividade(Atividade model);
        Task<bool> DeletarAtividade(int atividadeID);
        Task<bool> ConcluirAtividade(Atividade model);
        Task<Atividade[]> RetornarAtividades();
        Task<Atividade> RetornarAtividadeID(int atividadeID);
    }
}