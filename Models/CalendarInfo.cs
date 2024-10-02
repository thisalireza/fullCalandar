using System.ComponentModel.DataAnnotations;

namespace fullCalandar.Models
{
    public class CalendarInfo
    {
        [Key]
        public int CalendarInfoId { get; set; }
        [Display(Name ="کاربر")]
        public int UserId { get; set;}
        [Display(Name = "عنوان")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [MaxLength(50,ErrorMessage = "نمی تواند کم تر از {1} کاراکتر باشد {0}")]
        public string EventTitle { get; set;} = string.Empty;
        [Display(Name = "عنوان")]
        [MaxLength(350, ErrorMessage = "نمی تواند کم تر از {1} کاراکتر باشد {0}")]
        public string? EventDescription { get; set; } = string.Empty;
        [Display(Name = "تاریخ شروع")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(10, ErrorMessage = "نمی تواند کم تر از {1} کاراکتر باشد {0}")]
        public string StartDate { get; set; } = string.Empty;
        [Display(Name = "تاریخ پایان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(10, ErrorMessage = "نمی تواند کم تر از {1} کاراکتر باشد {0}")]
        public string EndDate { get; set; } = string.Empty;
        [Display(Name = "ساعت شروع")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(10, ErrorMessage = "نمی تواند کم تر از {1} کاراکتر باشد {0}")]
        public string StartTime { get; set; } = string.Empty;
        [Display(Name = "ساعت پایان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(10, ErrorMessage = "نمی تواند کم تر از {1} کاراکتر باشد {0}")]
        public string EndTime { get; set; } = string.Empty;


    }
}
