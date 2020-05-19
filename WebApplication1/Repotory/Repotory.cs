using Dapper;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Repotory
{
    public class Repotory<T> where T : class
    {
        string SqlConnStr { get; }
        public Repotory() { SqlConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\TestingProject\Provision\AspNetWebApp\WebApplication1\App_Data\DB4ESunBank.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"; }

        public List<T> getList(T oT)
        {
            using (var connection = new SqlConnection(SqlConnStr))
            {
                var oTResult = connection.Query<T>($@"Select * FROM {oT.GetType().Name.Replace("Model", "")}").ToList();

                return oTResult;
            }
        }
    }
}