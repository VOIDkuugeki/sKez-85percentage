using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sKez
{
    class User
    {
        private static int id;
        private static String username;
        private static String password;
        private static String mail;
        private static List<Board> bLst;

        static User()
        {
            id = 0;
            bLst = new List<Board>();
        }
        //Id
        public static int Id
        {
            get { return id; }
            set { id = value; }
        }
        //Name
        public static String Uname
        {
            get { return username; }
            set { username = value; }
        }
        //Password
        public static String Pwd
        {
            get { return password; }
            set { password = value; }
        }

        //Set mail from DB
        public static void SetMail()
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
            cnt.Close();
        }

        //Get mail
        public static String GetMail()
        {
            return mail;
        }

        //Get board list
        public static List<Board> BLst
        {
            get { return bLst; }
        }

        //Set Boards List
        public static void SetBLst()
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "select * from Board where UID = @id";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            comm.ExecuteNonQuery();

            //Check DT null or not
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    //Clear boards in list
                    bLst.Clear();

                    //Adapt controls
                    foreach (DataRow row in dt.Rows)
                    {
                        int id = Convert.ToInt32(row["BoardId"]);
                        String name = row["BoardName"].ToString();
                        Board tmp = new Board(id, name);
                        bLst.Add(tmp);
                    }
                }
            }
            cnt.Close();
            comm.Dispose();
            sda.Dispose();
            dt.Dispose();
        }
    }
}
