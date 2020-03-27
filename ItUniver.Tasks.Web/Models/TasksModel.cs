using System.Collections.Generic;

using ItUniver.Tasks.Application.Services.Dto;

namespace ItUniver.Tasks.Web.Models
{
    public class TasksModel
    {
        public ICollection<TaskDto> Incoming
        {
            get;
            set;
        }

        public ICollection<TaskDto> Outgoing
        {
            get;
            set;
        }
    }
}
