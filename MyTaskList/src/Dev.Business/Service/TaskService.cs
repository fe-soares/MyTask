using Dev.Business.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using Dev.Business.Models.Validations;
using System.Linq;

namespace Dev.Business.Service
{
    public class TaskService : BaseService, ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly ITaskContextRepository _taskContextRepository;
        public TaskService(ITaskRepository taskRepository, ITaskContextRepository taskContextRepository, INotificador notificador): base(notificador)
        {
            _taskRepository = taskRepository;
            _taskContextRepository = taskContextRepository; ;
        }
        public async Task Adicionar(Models.Task task)
        {
            if(!ExecutarValidacao(new TaskValidation(), task) && !ExecutarValidacaoByContext(new TaskContextValidation(), task.TaskContext))
            {
                return;
            }

            await _taskRepository.Add(task);
        }

        public async Task Atualizar(Models.Task task)
        {
            if (!ExecutarValidacao(new TaskValidation(), task))
            {
                return;
            }

            await _taskRepository.Update(task);
        }

        public async Task AtualizarContexto(IEnumerable<Models.TaskContext> taskContexts)
        {
            foreach(Models.TaskContext taskContext in taskContexts)
            {
                _taskContextRepository.Update(taskContext);
            }
        }

        public void Dispose()
        {
            _taskRepository?.Dispose();
            _taskContextRepository?.Dispose();
        }

        public async Task Remover(Models.Task task)
        {
            await _taskRepository.Delete(task);
        }
    }
}
