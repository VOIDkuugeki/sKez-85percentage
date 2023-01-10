using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sKez
{
    class User
    {
        private static int id;
        private static String username;
        private static String password;
        private static String mail;
        private static Profile info; //Composition

        static User()
        {
            id = 0;
        }
        public static int Id
        {
            get { return id; }
            set { id = value; }
        }
        public static String Uname
        {
            get { return username; }
            set { username = value; }
        }
        public static String Pwd
        {
            get { return password; }
            set { password = value; }
        }
        public static void setMail()
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "select * from User_info where Id = @id";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            comm.ExecuteNonQuery();
            DataRow row = dt.Rows[0];
            mail = row["Mail"].ToString();
        }
        public static String getMail()
        {
            return mail;
        }
    }
}
