using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class PersonalInfoModel: WebApplication1.Models.PersonalInfo
    {
        [Display(Name = "姓名")]
        public new string name { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        [Display(Name = "生日")]
        public new System.DateTime birthdate { get; set; }
    }
}