using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Client.Repository
{
    public class SampleRepository : ISampleRepository
    {
        public string ConnectionString { get; set; }
        public SampleRepository()
        {
            ConnectionString = "Server=FAROOOK;Database=LMS; Integrated Security=True;";

        }
        public int Sample(int i)
        {
            int y = i + 5;
            return y;
        }
        
        //public async Task<List<Model>> GetCoursePartsAsync(int getCourseID)
        //{
        //    using (var connection = new SqlConnection(ConnectionString))
        //    {
        //        connection.Open();
        //        DynamicParameters parameters = new DynamicParameters();
        //        parameters.Add("@Para", getCourseID);
        //        var getQuestions = await connection.QueryAsync<Model>("MySP", parameters, commandType: CommandType.StoredProcedure);
        //        return getQuestions.ToList();
        //    }
        //}
    }
}
