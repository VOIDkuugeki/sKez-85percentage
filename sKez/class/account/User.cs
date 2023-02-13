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
        public static List<Board> BLst
        {
            get { return bLst; }
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
            cnt.Close();
        }
        public static String getMail()
        {
            return mail;
        }

        //Get Boards of User
        public static void setBLst()
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
            if(dt != null)
            {
                if(dt.Rows.Count > 0)
                {
                    List<Control> ctrls = new List<Control>(bLst.Count);
                    bLst.Clear();
                    foreach (Control c in ctrls)
                        c.Dispose();

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
        }
    }
}
