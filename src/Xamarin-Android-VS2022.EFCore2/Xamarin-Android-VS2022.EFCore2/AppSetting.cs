using System.ComponentModel.DataAnnotations.Schema;

namespace Xamarin_Android_VS2022.EFCore2
{
    [Table(nameof(AppSetting))]
    public class AppSetting
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
