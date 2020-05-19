using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Repotory;

namespace WebApplication1.Biz
{
    public class PersonalInfoBiz
    {
        public List<PersonalInfoModel> getList()
        {
            var oPInfo = new PersonalInfoModel();
            return new Repotory<PersonalInfoModel>().getList(oPInfo);
        }
    }
}