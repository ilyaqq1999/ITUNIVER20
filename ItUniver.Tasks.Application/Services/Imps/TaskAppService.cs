using AutoMapper;

using ItUniver.Application.Services;
using ItUniver.Tasks.Application.Services.Dto;
using ItUniver.Tasks.Entities;
using ItUniver.Tasks.Managers;

namespace ItUniver.Tasks.Application.Services.Imps
{
    public class TaskAppService : ApplicationService, ITaskAppService
    {
        private readonly ITaskManager taskManager;
        private readonly IMapper mapper;

        public TaskAppService(ITaskManager taskManager, IMapper mapper)
        {
            this.taskManager = taskManager;
            this.mapper = mapper;
        }

        public TaskDto Get(long id)
        {
            var entity = taskManager.Get(id);
            var dto = mapper.Map<TaskDto>(entity);
            return dto;
        }
        public TaskDto Create(TaskCreateDto task)
        {
            var entity = mapper.Map<TaskBase>(task);
            taskManager.Create(entity);
            var dto = mapper.Map<TaskDto>(entity);
            return dto;
        }
        public TaskDto Update(TaskUpdateDto task)
        {
            var entity = mapper.Map<TaskBase>(task);
            taskManager.Update(entity);
            var dto = mapper.Map<TaskDto>(entity);
            return dto;
        }

        public void Delete(long id)
        {
            taskManager.Delete(id);
        }

    }
}