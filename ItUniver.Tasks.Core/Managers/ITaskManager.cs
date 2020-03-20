using System.Collections.Generic;

using ItUniver.Tasks.Entities;

namespace ItUniver.Tasks.Managers
{
    /// <summary>
    /// Менеджер сущности <see cref="TaskBase"/>
    /// </summary>
    public interface ITaskManager
    {
        /// <summary>
        /// Создание задачи
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        TaskBase Create(TaskBase task);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="subject"></param>
        /// <returns></returns>
        TaskBase Create(string subject);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TaskBase Get(long id);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        ICollection<TaskBase> GetAll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        void Delete(long id);

        /// <summary>
        /// Обновление
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TaskBase Update(TaskBase task);
    }
}