using AutoMapper;

using ItUniver.Tasks.Entities;
using ItUniver.Tasks.Web.Models;

namespace ItUniver.Tasks.Web
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            CreateMap<TaskCreateModel, TaskBase>();
        }
    }
}