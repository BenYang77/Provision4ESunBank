using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class PersonalInfoModel : WebApplication1.Models.PersonalInfo
    {
        [Required(ErrorMessage = "姓名 is required.")]
        [Display(Name = "姓名")]
        public new string name { get; set; }

        [Required(ErrorMessage = "security number is required.")]
        public new string security_id { get; set; }

        [Required(ErrorMessage = "生日 number is required.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "生日")]
        public new System.DateTime birthdate { get; set; }
    }
}