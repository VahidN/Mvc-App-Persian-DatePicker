using System;
using System.ComponentModel.DataAnnotations;

namespace MvcAppPersianDatePicker.Models
{
    public class Post
    {
        public string Title { set; get; }

        [Required(ErrorMessage = "(*)")]
        // Location: Views\Shared\EditorTemplates\PersianDatePicker.cshtml
        [UIHint("PersianDatePicker")]
        public DateTime AddDate { set; get; }

        public OtherInfo NestedProperty { set; get; }

        [UIHint("PersianDatePicker")]
        public DateTime? AddDateNullable { set; get; }
    }

    public class OtherInfo
    {
        [UIHint("PersianDatePicker")]
        public DateTime SaveDate { set; get; }
    }
}