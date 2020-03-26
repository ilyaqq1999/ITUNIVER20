﻿using System.ComponentModel;

namespace ItUniver.Tasks.Web.Models
{
    public class UserEditModel
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Логин
        /// </summary>
        public string Login
        {
            get;
            set;
        }

        /// <summary>
        /// Почта
        /// </summary>
        [DisplayName("Электронная почта")]
        public string Email
        {
            get;
            set;
        }

        /// <summary>
        /// Роль
        /// </summary>
        [DisplayName("Роль")]
        public int? RoleId
        {
            get;
            set;
        }
    }
}
