using System.Collections.Generic;

using ItUniver.Tasks.Entities;

namespace ItUniver.Tasks.Stores
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITaskStore
    {
        /// <summary>
        /// Сохранение
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        TaskBase Save(TaskBase task);

        /// <summary>
        /// Обновление
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TaskBase Update(TaskBase entity);

        /// <summary>
        /// Удаление
        /// </summary>
        /// <param name="id"></param>
        void Delete(long id);

        /// <summary>
        ///  Получение
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TaskBase Get(long id);

        /// <summary>
        /// Получить все
        /// </summary>
        ICollection<TaskBase> GetAll();
    }
}
