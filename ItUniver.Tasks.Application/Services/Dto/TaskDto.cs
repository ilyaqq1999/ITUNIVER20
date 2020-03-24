using System;

using ItUniver.Tasks.Entities;
using ItUniver.Tasks.Enums;

namespace ItUniver.Tasks.Application.Services.Dto
{
    /// <summary>
    /// ДТО для <see cref="TaskBase"/>
    /// </summary>
    public class TaskDto
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Тема
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public TaskStatus Status { get; set; }
    }
}
