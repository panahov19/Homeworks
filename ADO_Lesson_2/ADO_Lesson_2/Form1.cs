using Microsoft.Data.SqlClient;
using System.Data;

namespace ADO_Lesson_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void query_Click(object sender, EventArgs e)
        {
            try

            {

                String str = "server=DESKTOP-CPU5UM7;database=Academy;";

                String query = "select * from data";

                SqlConnection con = new SqlConnection(str);

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                DataSet ds = new DataSet();

                MessageBox.Show("connect with sql server");

                con.Close();

            }

            catch (Exception es)

            {

                MessageBox.Show(es.Message);



            }

        }

    }
}
