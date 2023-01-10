using sKez.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace sKez
{
    class Profile
    {
        private static String firstname;
        private static String lastname;
        private static Image img;

        static Profile()
        {

        }
        public static void setFname(String value)
        {
            firstname = value;
        }

        public static void setLname(String value)
        {
            lastname = value;
        }
        public static Image Img
        {
            get { return img; }
            set { img = value; }
        }
        public static void setProfile()
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "select * from User_info where Id = @id";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.Add("@id", SqlDbType.Int).Value = User.Id;
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            comm.ExecuteNonQuery();
            DataRow row = dt.Rows[0];
            setFname(row["FirstName"].ToString());
            setLname(row["LastName"].ToString());
            cnt.Close();
        }

        public static String getFname()
        {
            return firstname;
        }
        public static String getLname()
        {
            return lastname;
        }
    }
}
