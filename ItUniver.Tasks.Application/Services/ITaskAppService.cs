﻿using System.Collections.Generic;

using ItUniver.Application.Services;
using ItUniver.Tasks.Application.Services.Dto;

namespace ItUniver.Tasks.Application.Services
{
    /// <summary>
    /// Сервис для работы с задачами
    /// </summary>
    public interface ITaskAppService : IApplicationService
    {
        /// <summary>
        /// Создать задачу
        /// </summary>
        /// <param name="dto"></param>
        TaskDto Create(CreateTaskDto dto);

        /// <summary>
        /// Обновить задачу
        /// </summary>
        /// <param name="dto"></param>
        TaskDto Update(UpdateTaskDto dto);

        /// <summary>
        /// Удалить задачу
        /// </summary>
        /// <param name="id">Идентификатор задачи</param>
        void Delete(long id);

        /// <summary>
        /// Получить задачу
        /// </summary>
        /// <param name="id">Идентификатор задачи</param>
        TaskDto Get(long id);

        /// <summary>
        /// Получить все задачи
        /// </summary>
        ICollection<TaskDto> GetAll();

        /// <summary>
        /// Получить мои входящие задачи
        /// </summary>
        ICollection<TaskDto> GetMyIncoming();

        /// <summary>
        /// Получить мои исходящие задачи
        /// </summary>
        ICollection<TaskDto> GetMyOutgoing();
    }
}