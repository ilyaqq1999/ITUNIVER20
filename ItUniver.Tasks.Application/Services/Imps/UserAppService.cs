using System.Collections.Generic;
using System.Linq;
using AutoMapper;

using ItUniver.Tasks.Application.Services.Dto;
using ItUniver.Tasks.Entities;
using ItUniver.Tasks.Repositories;

namespace ItUniver.Tasks.Application.Services.Imps
{
    /// <summary>
    /// Сервис для работы с пользователями
    /// </summary>
    public class UserAppService : IUserAppService
    {
        private readonly IUserRepository userRepository;

        private readonly IRoleRepository roleRepository;

        private readonly IMapper mapper;

        /// <summary>
        /// Инициализировать экземпляр <see cref="UserAppService"/>
        /// </summary>
        /// <param name="userRepository">Репозиторий пользователей</param>
        /// <param name="roleRepository"></param>
        /// <param name="mapper">Маппер</param>
        public UserAppService(
            IUserRepository userRepository,
            IRoleRepository roleRepository,
            IMapper mapper)
        {
            this.userRepository = userRepository;
            this.roleRepository = roleRepository;
            this.mapper = mapper;
        }

        public UserDto Get(int id)
        {
            var entity = userRepository.Get(id);
            return mapper.Map<UserDto>(entity);
        }

        /// <inheritdoc/>
        public UserDto Create(CreateUserDto dto)
        {
            var entity = mapper.Map<User>(dto);
            userRepository.Save(entity);
            return mapper.Map<UserDto>(entity);
        }

        /// <inheritdoc/>
        public UserDto Update(UpdateUserDto updateDto)
        {
            var user = userRepository.Get(updateDto.Id);
            user.Email = updateDto.Email;
            user.Role = updateDto.RoleId.HasValue ? roleRepository.Get(updateDto.RoleId.Value) : null;

            userRepository.Update(user);

            return mapper.Map<UserDto>(user);
        }

        /// <inheritdoc/>
        public UserDto Get(string login)
        {
            var entity = userRepository.FirstOrDefault(e => e.Login == login);
            return mapper.Map<UserDto>(entity);
        }

        /// <inheritdoc/>
        public UserDto Get(string login, string password)
        {
            var entity = userRepository.FirstOrDefault(e => e.Login == login && e.Password == password && !e.IsBlocked);///
            return mapper.Map<UserDto>(entity);
        }

        /// <inheritdoc/>
        public ICollection<UserDto> GetAll()
        {
            var entities = userRepository.GetAll().Where(e => !e.IsBlocked).ToList();
            return mapper.Map<ICollection<UserDto>>(entities);
        }

        /// <inheritdoc/>
        public bool IsValidPassword(UserDto dto, string password)
        {
            var entity = userRepository.Get(dto.Id);
            return entity.Password == password;
        }

        /// <inheritdoc/>
        public bool Block(int id)
        {
            try
            {
                var entity = userRepository.Get(id);
                entity.IsBlocked = true;
                userRepository.Update(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}