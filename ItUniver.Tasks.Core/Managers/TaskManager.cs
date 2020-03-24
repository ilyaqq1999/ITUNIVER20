using System;
using System.Collections.Generic;

using ItUniver.Tasks.Repositories;
using ItUniver.Tasks.Entities;
using ItUniver.Tasks.Stores;

namespace ItUniver.Tasks.Managers
{
    /// <inheritdoc/>
    public class TaskManager : ITaskManager
    {
       ////private readonly ITaskStore taskStore;
        private readonly ITaskRepository taskRepository;

        //public TaskManager(ITaskStore taskStore/*, ITaskRepository taskRepository*/)
        public TaskManager(ITaskRepository taskRepository)
        {
            ////this.taskStore = taskStore;
            this.taskRepository = taskRepository;
        }

        /// <inheritdoc/>
        public TaskBase Create(TaskBase task)
        {
            task.CreationDate = DateTime.Now;
            task.Status = Enums.TaskStatus.ToDo;
            ////var w = taskRepository.Create(task);
            return taskRepository.Save(task);
            //return taskStore.Save(task);
        }

        /// <inheritdoc/>
        public TaskBase Create(string subject)
        {
            var task = new TaskBase { Subject = subject };
            return taskRepository.Save(task);
        }

        /// <inheritdoc/>
        public ICollection<TaskBase> GetAll()
        {
            //var e = taskRepository.GetAll();
            return taskRepository.GetAllList();
        }

        public void Delete(long id)
        {
            taskRepository.Delete(id);
           // taskStore.Delete(id);
        }

        public TaskBase Get(long id)
        {
            //return taskStore.Get(id);
            return taskRepository.Get(id);
        }

        public TaskBase Update(TaskBase task)
        {
            //return taskStore.Update(task);
            return taskRepository.Update(task);
        }
    }
}