using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace EnumToSelectList.Helpers
{
    public static class CommonHelpers
    {
        public static string ToDisplayName(this Enum value) => value.GetType()
            .GetMember(value.ToString())
            .First()
            .GetCustomAttribute<DisplayAttribute>()
            ?.GetName() ?? string.Empty;

        public static List<SelectListItem> ToSelectList(this Enum enumValue)
            => (from Enum e in Enum.GetValues(enumValue.GetType())
                select new SelectListItem
                {
                    Text = e.ToDisplayName(),
                    Value = Convert.ToInt16(e).ToString()
                }).ToList();

    }
}
