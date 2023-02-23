using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace sKez
{
    class CurrentBoard
    {
        private static int id;
        private static String name;
        private static List<Note> nList = new List<Note>();

        public CurrentBoard()
        {
            id = 0;
        }

        //Id
        public static int Id
        {
            get { return id; }
            set { id = value; }
        }
        //Name
        public static String Bname
        {
            get { return name; }
            set { name = value; }
        }

        //Get notes
        public static List<Note> GetNList()
        {
            return nList;
        }

        //Set notes in board
        public static void SetNList()
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "select * from List where BID = @id";
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
                    //Clear notes in list
                    nList.Clear();

                    //Adapt controls
                    foreach (DataRow row in dt.Rows)
                    {
                        int n_id = Convert.ToInt32(row["ListId"]);
                        String n_name = row["ListName"].ToString();
                        Note tmp = new Note(n_id, n_name);
                        nList.Add(tmp);
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
