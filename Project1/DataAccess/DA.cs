using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using StudentEntity1;
namespace DataAccess
{
    public class DA
    {
        public void AddDetails(Student2 s)
        {
            string con = "Data Source=G1C2ML15529;Initial Catalog=db;Integrated Security=True";
            SqlConnection cc = new SqlConnection(con);
            cc.Open();
            string s1 = "insert into tblStudent values(@Id,@Student,@Age,@ClassTeacherId)";
            SqlCommand sq = new SqlCommand(s1, cc);
            sq.Parameters.AddWithValue("@Id", s.Id);
            sq.Parameters.AddWithValue("@Student", s.Student);
            sq.Parameters.AddWithValue("@Age", s.Age);
            sq.Parameters.AddWithValue("@ClassTeacherId", s.ClassTeacherId);
            sq.ExecuteNonQuery();
            Console.WriteLine("Data added successfully");
            s1 = "select*from tblStudent";
            sq = new SqlCommand(s1, cc);
            SqlDataReader sr = sq.ExecuteReader();
            while (sr.Read())
            {
                //(sr.Read();
                Console.WriteLine(sr[0].ToString() + " " + sr[1].ToString() + " " + sr[2].ToString() + " " + sr[3].ToString());
            }
            Console.ReadKey();



        }
    }
}
