using System.ComponentModel.DataAnnotations;

namespace EnumToSelectList.Enums
{
    public enum Priority : byte
    {
        [Display(Name = "زیاد")]
        High,

        [Display(Name = "متوسط")]
        Medium,

        [Display(Name = "کم")]
        Low
    }
}
