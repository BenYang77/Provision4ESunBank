using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public List<PersonalInfoModel> getThisList(int id)
        {
            var oPInfo = new PersonalInfoModel();
            return new Repotory<PersonalInfoModel>().getThisList(oPInfo, id);
        }

        public bool updateThisList(PersonalInfoModel personalInfo)
        {
            var oPInfo = personalInfo;
            var parameters = new DynamicParameters();
            parameters.Add("@name", oPInfo.name);
            parameters.Add("@security_id", oPInfo.security_id);
            parameters.Add("@Id", oPInfo.Id);

            var sqlStr = $@"
update [PersonalInfo] 
   set [security_id] = @security_id,
       [name]        = @name,
       [upd_date]    = getdate()
 WHERE [Id]          = @Id
";
            
            return new Repotory<PersonalInfoModel>().updateThisList(sqlStr, parameters);
        }
    }
}