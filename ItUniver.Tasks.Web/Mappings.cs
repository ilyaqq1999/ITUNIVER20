using AutoMapper;

using ItUniver.Tasks.Application.Services.Dto;
using ItUniver.Tasks.Entities;
using ItUniver.Tasks.Web.Models;
using ItUniver.Tasks.Web.Models.Account;

namespace ItUniver.Tasks.Web
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            CreateMap<TaskCreateModel, TaskBase>();
            CreateMap<TaskBase, TaskEditModel>();
            CreateMap<TaskEditModel, TaskBase>();
            CreateMap<RegisterModel, CreateUserDto>();
            CreateMap<TaskDto,TaskEditModel>();
            CreateMap<UserDto, UserEditModel>();
            CreateMap<TaskEditModel, UpdateTaskDto>();
        }
    }
}