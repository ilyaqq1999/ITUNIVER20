using System.Reflection;

using ItUniver.Application.Services;

using Microsoft.AspNetCore.Mvc.Controllers;

namespace ItUniver.AspNetCore.Mvc.Providers
{
    public class AppServiceControllerFeatureProvider : ControllerFeatureProvider
    {
        protected override bool IsController(TypeInfo typeInfo)
        {
            if (!typeof(IApplicationService).IsAssignableFrom(typeInfo.AsType()) ||
                !typeInfo.IsPublic || typeInfo.IsAbstract || typeInfo.IsGenericType)
            {
                return false;
            }

            return true;
        }
    }
}
