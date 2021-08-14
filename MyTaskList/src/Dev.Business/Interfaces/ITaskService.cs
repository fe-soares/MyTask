using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dev.Business.Interfaces
{
    public interface ITaskService: IDisposable
    {
        Task Adicionar(Models.Task task);

        Task Atualizar(Models.Task task);

        Task Remover(Models.Task task);

        Task AtualizarContexto(IEnumerable<Models.TaskContext> taskContexts);
    }
}
