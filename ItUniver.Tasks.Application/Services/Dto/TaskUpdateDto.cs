using ItUniver.Tasks.Entities;
using ItUniver.Tasks.Enums;

namespace ItUniver.Tasks.Application.Services.Dto
{
    /// <summary>
    /// ДТО обновления <see cref="TaskBase"/>
    /// </summary>
    public class TaskUpdateDto
    {
        /// <summary>
        /// Индентификатор
        /// </summary>
        public long Id
        {
            get;
            set;
        }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Статус
        /// </summary>
        public TaskStatus Status
        {
            get;
            set;
        }
    }
}