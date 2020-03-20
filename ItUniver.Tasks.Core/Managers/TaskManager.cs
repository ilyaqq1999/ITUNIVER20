﻿using System;
using System.Collections.Generic;

using ItUniver.Tasks.Entities;
using ItUniver.Tasks.Stores;

namespace ItUniver.Tasks.Managers
{
    /// <inheritdoc/>
    public class TaskManager : ITaskManager
    {
        private readonly ITaskStore taskStore;

        public TaskManager(ITaskStore taskStore)
        {
            this.taskStore = taskStore;
        }

        /// <inheritdoc/>
        public TaskBase Create(TaskBase task)
        {
            task.CreationDate = DateTime.Now;///
            task.Status = Enums.TaskStatus.ToDo;
            return taskStore.Save(task);
        }

        /// <inheritdoc/>
        public TaskBase Create(string subject)
        {
            var task = new TaskBase { Subject = subject };
            return taskStore.Save(task);
        }

        /// <inheritdoc/>
        public ICollection<TaskBase> GetAll()
        {
            return taskStore.GetAll();
        }

        public void Delete(long id)
        {
            taskStore.Delete(id);
        }

        public TaskBase Get(long id)
        {
            return taskStore.Get(id);
        }

        public TaskBase Update(TaskBase task)
        {
            return taskStore.Update(task);
        }
    }
}