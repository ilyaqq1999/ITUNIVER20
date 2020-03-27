using System;
using ItUniver.Tasks.Entities;
using ItUniver.Tasks.Enums;

namespace ItUniver.Tasks.Application.Services.Dto
{
    /// <summary>
    /// ДТО обновления <see cref="TaskBase"/>
    /// </summary>
    public class UpdateTaskDto
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// Исполнитель
        /// </summary>
        public int? Executor { get; set; }
    }
}