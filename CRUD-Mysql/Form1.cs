using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD_Mysql
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Selectbtn_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user = root;database=taskManager;password=";

            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();

            string sql = "SELECT * FROM users";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString() + "-" + reader[1].ToString() + "-" + reader[2].ToString());
            }
            reader.Close();



            conn.Close();
        }
    }
}
