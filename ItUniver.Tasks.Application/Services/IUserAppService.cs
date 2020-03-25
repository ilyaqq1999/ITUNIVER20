using System.Collections.Generic;
using ItUniver.Application.Services;
using ItUniver.Tasks.Application.Services.Dto;

namespace ItUniver.Tasks.Application.Services
{
    /// <summary>
    /// Сервис для работы с пользователями
    /// </summary>
    public interface IUserAppService : IApplicationService
    {
        /// <summary>
        /// Создать пользователя
        /// </summary>
        /// <param name="dto"></param>
        UserDto Create(CreateUserDto dto);

        /// <summary>
        /// Получить пользователя
        /// </summary>
        /// <param name="login">Логин</param>
        UserDto Get(string login);

        /// <summary>
        /// Получить пользователя
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        UserDto Get(string login, string password);

        /// <summary>
        /// Получить список пользователей
        /// </summary>
        /// <remarks>
        /// Только не блокированные пользователи
        /// </remarks>
        /// <returns></returns>
        ICollection<UserDto> GetAll();

        /// <summary>
        /// Проверить пароль
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="password">Пароль</param>
        bool IsValidPassword(UserDto dto, string password);

        /// <summary>
        /// Заблокировать пользователя
        /// </summary>
        /// <param name="id">Идентификатор</param>
        bool Block(int id);
    }
}