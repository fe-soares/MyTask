using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMyTask.ViewModels.Task;
using AutoMapper;
using Dev.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMyTask.Controllers
{
    [Route("api/task")]
    [ApiController]
    public class TaskController : MainController
    {
        private readonly ITaskRepository _taskRepository;
        private readonly ITaskService _taskService;
        private readonly IMapper _mapper;

        public TaskController(ITaskRepository taskRepository, ITaskService taskService, IMapper mapper, INotificador notificador) : base(notificador)
        {
            _taskRepository = taskRepository;
            _taskService = taskService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<TaskViewModel>> ObterTodos()
        {
            var tasks = _mapper.Map<IEnumerable<TaskViewModel>>(await _taskRepository.GetAll());

            return tasks;
        }

        [HttpPost]
        public async Task<ActionResult<TaskViewModel>> Adicionar(TaskViewModel taskViewModel)
        {
            if (!ModelState.IsValid) return BadRequest();

            var task = _mapper.Map<Dev.Business.Models.Task>(taskViewModel);
            await _taskService.Adicionar(task);

            return CustomResponse(taskViewModel);
        }
    }
}
