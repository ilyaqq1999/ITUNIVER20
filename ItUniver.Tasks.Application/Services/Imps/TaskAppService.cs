using System.Collections.Generic;

using AutoMapper;

using ItUniver.Application.Services;
using ItUniver.Runtime.Session;
using ItUniver.Tasks.Application.Services.Dto;
using ItUniver.Tasks.Entities;
using ItUniver.Tasks.Managers;
using ItUniver.Tasks.Repositories;

namespace ItUniver.Tasks.Application.Services.Imps
{
    /// <summary>
    /// Сервис для работы с задачами
    /// </summary>
    public class TaskAppService : ApplicationService, ITaskAppService
    {
        private readonly ITaskManager taskManager;

        private readonly IUserRepository userRepository;

        private readonly IMapper mapper;

        private readonly IAppSession appSession;

        /// <summary>
        /// Инициализировать экземпляр <see cref="TaskAppService"/>
        /// </summary>
        /// <param name="taskManager">Менеджер для работы с задачами</param>
        /// <param name="session"></param>
        /// <param name="userRepository"></param>
        /// <param name="mapper">Маппер</param>
        public TaskAppService(
            ITaskManager taskManager,
            IUserRepository userRepository,
            IMapper mapper,
            IAppSession session,
            IAppSession appSession)
        {
            this.taskManager = taskManager;
            this.userRepository = userRepository;
            this.mapper = mapper;
            this.appSession = appSession;
        }

        /// <inheritdoc/>
        public TaskDto Get(long id)
        {
            var entity = taskManager.Get(id);
            var dto = mapper.Map<TaskDto>(entity);
            return dto;
        }

        /// <inheritdoc/>
        public ICollection<TaskDto> GetAll()
        {
            var entities = taskManager.GetAll();
            var dtos = mapper.Map<ICollection<TaskDto>>(entities);
            return dtos;
        }

        /// <inheritdoc/>
        public ICollection<TaskDto> GetMyIncoming()
        {
            var iam = userRepository.FirstOrDefault(user => user.Login == appSession.UserLogin);
            var entities = taskManager.GetIncoming(iam);
            return mapper.Map<ICollection<TaskDto>>(entities);
        }

        /// <inheritdoc/>
        public ICollection<TaskDto> GetMyOutgoing()
        {
            var iam = userRepository.FirstOrDefault(user => user.Login == appSession.UserLogin);
            var entities = taskManager.GetOutgoing(iam);
            return mapper.Map<ICollection<TaskDto>>(entities);
        }

        /// <inheritdoc/>
        public TaskDto Create(CreateTaskDto createDto)
        {
            var entity = mapper.Map<TaskBase>(createDto);
            entity.Executor = GetUserById(createDto.Executor);
            taskManager.Create(entity);
            var dto = mapper.Map<TaskDto>(entity);
            return dto;
        }

        /// <inheritdoc/>
        public TaskDto Update(UpdateTaskDto updateDto)
        {
            var entity = taskManager.Get(updateDto.Id);
            entity.Description = updateDto.Description;
            entity.Executor = GetUserById(updateDto.Executor);

            taskManager.Update(entity);

            var dto = mapper.Map<TaskDto>(entity);

            return dto;
        }

        /// <inheritdoc/>
        public void Delete(long id)
        {
            taskManager.Delete(id);
        }

        private User GetUserById(int? user)
        {
            return user.HasValue ? userRepository.Get(user.Value) : null;
        }

        public ICollection<TaskDto> GetMyIncomin()
        {
            var iam = userRepository.FirstOrDefault(user => user.Login == appSession.UserLogin);
            var entities = taskManager.GetIncoming(iam);
            return mapper.Map<ICollection<TaskDto>>(entities);
        }
    }
}