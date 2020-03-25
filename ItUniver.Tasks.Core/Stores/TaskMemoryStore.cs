using System;
using System.Collections.Generic;
using System.Linq;

using ItUniver.Tasks.Entities;
using ItUniver.Tasks.Helpers;

namespace ItUniver.Tasks.Stores
{
    public class TaskMemoryStore : ITaskStore
    {
        private List<TaskBase> tasks;

        private long counter;

        public TaskMemoryStore()
        {
            counter = 1;
            tasks = new List<TaskBase>();
        }

        public TaskBase Save(TaskBase task)
        {
            var saved = tasks.FirstOrDefault(item => item.CustomEquals(task));
            if (saved != null)
            {
                task.Id = saved.Id;
                return saved.Copy();
            }
            task.Id = counter++;
            tasks.Add(task.Copy());
            return task;
        }

        /// <inheritdoc/>
        public TaskBase Update(TaskBase task)
        {
            var saved = InternalGet(task.Id);
            if (saved == null)
            {
                throw new Exception("Задача не найдена");
            }
            saved.Subject = task.Subject;
            saved.Description = task.Description;
            //saved.CreationDate = task.CreationDate;
            saved.Status = task.Status;

            return task;
        }

        public void Delete(long id)
        {
            tasks.RemoveAll(task => task.Id == id);
        }

        public TaskBase Get(long id)
        {
            var saved = InternalGet(id);
            return saved?.Copy();
        }
        private TaskBase InternalGet(long id)
        {
            return tasks.FirstOrDefault(task => task.Id == id);
        }
        /// <inheritdoc/>
        public ICollection<TaskBase> GetAll()
        {
            return tasks.Select(task => task.Copy()).ToList();
        }
    }
}