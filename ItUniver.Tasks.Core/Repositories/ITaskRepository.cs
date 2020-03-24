using ItUniver.Domain.Repositories;
using ItUniver.Tasks.Entities;

namespace ItUniver.Tasks.Repositories
{
    /// <summary>
    /// Репозиторий сущности <see cref="TaskBase"/>
    /// </summary>
    public interface ITaskRepository : IRepository<TaskBase, long>
    {

    }
}