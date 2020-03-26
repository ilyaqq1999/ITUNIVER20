using AutoMapper;

using ItUniver.Tasks.Application.Services;
using ItUniver.Tasks.Web.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ItUniver.Tasks.Web.Controllers
{
    /// <summary>
    /// Контроллер для работы с пользователями
    /// </summary>
    [Authorize/*(Roles = "admin")*/]
    public class UserController : Controller
    {
        private readonly IUserAppService userAppService;
        private readonly IMapper mapper;
        /// <summary>
        /// Инициализировать экземпляр <see cref="UserController"/>
        /// </summary>
        /// <param name="userAppService">Сервис для работы с пользователями</param>
        /// <param name="mapper">Маппер</param>
        public UserController(IUserAppService userAppService, IMapper mapper)
        {
            this.userAppService = userAppService;
            this.mapper = mapper;
        }

        /// <summary>
        /// Получить страницу с пользователми
        /// </summary>
        [HttpGet]
        public IActionResult Index()
        {
            var dtos = userAppService.GetAll();
            return View(dtos);
        }

        public IActionResult Edit(int id)
        {
            var userDto = userAppService.Get(id);
            var model = mapper.Map<UserEditModel>(userDto);
            if (userDto.Role != null)
            {
                model.RoleId = userDto.Role.Id;
            }
            return View(model);
        }
    }
}