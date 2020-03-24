using ItUniver.Tasks.Entities;


namespace ItUniver.Tasks.Application.Services.Dto
{
    /// <summary>
    /// ДТО создания <see cref="TaskBase"/>
    /// </summary>
    public class TaskCreateDto
    {
        /// <summary>
        /// Тема
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
    }
}
