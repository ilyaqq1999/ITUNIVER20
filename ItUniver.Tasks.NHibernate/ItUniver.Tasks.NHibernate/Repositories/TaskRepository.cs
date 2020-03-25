
using ItUniver.Tasks.Entities;
using ItUniver.Tasks.Repositories;

using NHibernate;

namespace ItUniver.Tasks.NHibernate.Repositories
{
    /// <summary>
    /// Репозиторий сущности <see cref="TaskBase"/>
    /// </summary>
    public class TaskRepository : NhRepositoryBase<TaskBase, long>, ITaskRepository
    {
        /// <summary>
        /// Инициализировать экземпляр <see cref="TaskRepository"/>
        /// </summary>
        /// <param name="session">Сессия NHibernate</param>
        public TaskRepository(ISession session)
            : base(session)
        {

        }
    }
}