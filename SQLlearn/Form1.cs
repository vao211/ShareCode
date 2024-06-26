using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQLlearn
{
    public partial class Form1 : Form
    {
        SqlConnection sqlCon = new SqlConnection(Connect.ConnectionString);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                using (sqlCon)
                {
                    sqlCon.Open();
                    if (sqlCon.State == ConnectionState.Open)
                    {
                        MessageBox.Show("Connected Succesfully");
                    }
                    dataGridTest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridTest.DataSource = GetHumanTable().Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void refresh()
        {
            sqlCon = new SqlConnection(Connect.ConnectionString);
            sqlCon.Open();
            dataGridTest.DataSource = GetHumanTable().Tables[0];
            dataGridTest.Refresh();

        }

        DataSet GetHumanTable()
        {
            string query = "select * from human";

            DataSet data = new DataSet();
            if (sqlCon.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

                sqlDataAdapter.Fill(data);
            }
            return data;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            using (sqlCon)
            {
                sqlCon.Close();
                if (sqlCon.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Connection Disconnected");
                    dataGridTest.DataSource = null;
                    sqlCon = new SqlConnection(Connect.ConnectionString);
                }

            }
        }

        private void btnShowNum_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(Connect.ConnectionString);
            sqlCon.Open();
            string qurCount = "select COUNT(*) from human";
            using (SqlCommand cmdCount = new SqlCommand(qurCount, sqlCon))
            {
                int count = (int)cmdCount.ExecuteScalar();
                MessageBox.Show("number of human :" + count);
            };

        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(Connect.ConnectionString);
            sqlCon.Open();
            int humanId = int.Parse(txtID.Text.Trim());

            string query = "DELETE FROM human WHERE Id = @humanId";

            using (SqlCommand command = new SqlCommand(query, sqlCon))
            {
                command.Parameters.AddWithValue("@humanId", humanId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("delete successfully");
                    refresh();
                }
                else
                {
                    MessageBox.Show("unable to delete");
                }


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(Connect.ConnectionString);
            sqlCon.Open();
            string qurAdd = "insert into human values (@name,@age,@race,@Id)";
            int Id = int.Parse(txtID.Text.Trim());
            string name = txtName.Text.Trim();
            string race = txtRace.Text.Trim();
            int age = int.Parse(txtAge.Text.Trim());
            SqlCommand cmdAdd = new SqlCommand(qurAdd, sqlCon);
            cmdAdd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            cmdAdd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = name;
            cmdAdd.Parameters.Add("@age", SqlDbType.Int).Value = age;
            cmdAdd.Parameters.Add("@race", SqlDbType.NVarChar, 50).Value = race;
            cmdAdd.ExecuteNonQuery();
            MessageBox.Show("Add Successfully");
            refresh();
        }

        private void dataGridTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rowData = dataGridTest.Rows[e.RowIndex];

                txtID.Text = rowData.Cells["id"].Value.ToString();
                txtName.Text = rowData.Cells["name"].Value.ToString();
                txtAge.Text = rowData.Cells["age"].Value.ToString();
                txtRace.Text = rowData.Cells["race"].Value.ToString();
                btnEdit.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(Connect.ConnectionString);
            sqlCon.Open();
            string qurEdit = "UPDATE human \n SET name = @name, Id = @Id, age = @age, race = @race \n WHERE Id = @Id";
            int Id = int.Parse(txtID.Text.Trim());
            string name = txtName.Text.Trim();
            string race = txtRace.Text.Trim();
            int age = int.Parse(txtAge.Text.Trim());
            SqlCommand cmdEdit = new SqlCommand(qurEdit, sqlCon);
            cmdEdit.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            cmdEdit.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = name;
            cmdEdit.Parameters.Add("@age", SqlDbType.Int).Value = age;
            cmdEdit.Parameters.Add("@race", SqlDbType.NVarChar, 50).Value = race;
            cmdEdit.ExecuteNonQuery();
            refresh();
        }
    }
}