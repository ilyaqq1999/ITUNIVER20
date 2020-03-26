using System.Collections.Generic;
using ItUniver.Domain.Entities;

namespace ItUniver.Tasks.Entities
{
    /// <summary>
    /// Роль
    /// </summary>
    public class Role : Entity
    {
        /// <summary>
        /// Имя таблицы
        /// </summary>
        public const string TableName = "Roles";

        /// <summary>
        /// Инициализировать экземпляр <see cref="Role"/>
        /// </summary>
        public Role()
        {
            Users = new List<User>();
        }

        /// <summary>
        /// Имя
        /// </summary>
        public virtual string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Пользователи
        /// </summary>
        public virtual IEnumerable<User> Users
        {
            get;
            set;
        }
    }
}
