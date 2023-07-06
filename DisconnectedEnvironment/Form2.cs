using DisconnectedEnvironment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected_Environment
{
    public partial class Data_Prodi : Form
    {
        string connectionString = "data source = DESKTOP-S15VN55\\DHIYA_ULHAQ;database=FakultasTeknik;MultipleActiveResultSets=True;User ID = sa; Password = 123";
        private SqlConnection koneksi;
        public Data_Prodi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(connectionString);
            refreshform();
        }

        private void refreshform()
        {
            nmprodi.Text = "";
            nmprodi.Enabled = false;
            SaveBtn.Enabled = false;
            ClearBtn.Enabled = false;
            nmprodi.Enabled = false;
            nmprodi.Text = "";
        }

        private void Data_PordiClosed(object sender, EventArgs e)
        {
            Form1 hu = new Form1();
            hu.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Data_Prodi_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nmProdi = nmprodi.Text;
            string IdProdi = nmprodi.Text;

            if (nmProdi == "")
            {
                MessageBox.Show("masukan nama prodi", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Prodi (nama_prodi, Id_Prodi)" + "values(@nm, @id)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("nm", nmProdi));
                cmd.Parameters.Add(new SqlParameter("id", IdProdi));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil disimpan", "sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select nama_prodi, id_prodi from dbo.prodi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            OpenBtn.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            nmprodi.Enabled = true;
            SaveBtn.Enabled = true;
            ClearBtn.Enabled = true;
            AddBtn.Enabled = true;
        }
    }
}
