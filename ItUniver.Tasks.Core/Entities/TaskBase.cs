﻿using System;
using ItUniver.Domain.Entities;
using ItUniver.Tasks.Enums;

namespace ItUniver.Tasks.Entities
{
    /// <summary>
    /// Базовый класс задач
    /// </summary>
    public class TaskBase : Entity<long>
    {
        public const string TableName = "Tasks";

        /// <summary>
        /// Тема
        /// </summary>
        public virtual string Subject { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public virtual DateTime CreationDate { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public virtual TaskStatus Status { get; set; }
    }
}