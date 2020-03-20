using System.Linq;

namespace ItUniver.Extensions
{
    public static class ObjectExtensions
    {
        public static bool IsIn<T>(this T item, params T[] list)
        {
            return list.Contains(item);
        }
    }
}