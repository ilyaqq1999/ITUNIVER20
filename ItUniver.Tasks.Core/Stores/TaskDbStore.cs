using System.Collections.Generic;

using ItUniver.Tasks.Entities;
using ItUniver.Tasks.Repositories;

namespace ItUniver.Tasks.Stores
{
    public class TaskDbStore : ITaskStore
    {
        private readonly ITaskRepository taskRepository;

        public TaskDbStore(ITaskRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        public void Delete(long id)
        {
            taskRepository.Delete(id);
        }

        public TaskBase Get(long id)
        {
            return taskRepository.Get(id);
        }

        public ICollection<TaskBase> GetAll()
        {
            return taskRepository.GetAllList();
        }

        public TaskBase Save(TaskBase task)
        {
            return taskRepository.Save(task);
        }

        public TaskBase Update(TaskBase task)
        {
            return taskRepository.Update(task);
        }
    }
}