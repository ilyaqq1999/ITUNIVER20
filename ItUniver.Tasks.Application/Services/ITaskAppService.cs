using ItUniver.Application.Services;
using ItUniver.Tasks.Application.Services.Dto;

namespace ItUniver.Tasks.Application.Services
{
    public interface ITaskAppService : IApplicationService
    {

        TaskDto Create(TaskCreateDto task);

        TaskDto Update(TaskUpdateDto task);

        void Delete(long id);

        TaskDto Get(long id);
    }
}