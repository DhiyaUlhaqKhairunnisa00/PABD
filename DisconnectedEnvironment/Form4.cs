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
    public partial class Data_Status_Mahasiswa : Form
    {
        string connectionString = "data source = LAPTOP-CK57KRTO;database=Prodi;MultipleActiveResultSets=True;User ID = sa; Password = Mudah123";
        private SqlConnection koneksi;
        public Data_Status_Mahasiswa()
        {
            InitializeComponent();
            koneksi = new SqlConnection(connectionString);
            refreshform();
        }
        private void Data_Status_Mahasiswa_Load(object sender, EventArgs e)
        {

        }
        private void refreshform()
        {
            nmMhs.Enabled = false;
            statusMhs.Enabled = false;
            ThMasuk.Enabled = false;
            nmMhs.SelectedIndex = -1;
            statusMhs.SelectedIndex = -1;
            ThMasuk.SelectedIndex = -1;
            Nim.Visible = false;
            SaveBtn.Enabled = false;
            ClearBtn.Enabled = false;
            AddBtn.Enabled = true;

        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.status_mahasiswa";
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

        private void txtNama_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string nim = "";
            string strs = "select NIM from dbo.Mahasiswa where nama_mahasiswa = @nm";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@nm", nmMhs.Text));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                nim = dr["NIM"].ToString();
            }
            dr.Close();
            koneksi.Close();

            Nim.Text = nim;
        }

        private void cbNama()
        {
            koneksi.Open();
            string str = "select nama_mahasiswa from dbo.mahasiswa where " +
                "not EXISTS(select id_status from dbo.status_mahasiswa where " +
                "status_mahasiswa.nim = mahasiswa.nim)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();

            nmMhs.DisplayMember = "nama_mahasiswa";
            nmMhs.ValueMember = "Nim";
            nmMhs.DataSource = ds.Tables[0];
        }

        private void cbTahunMasuk()
        {
            int y = DateTime.Now.Year - 2010;
            string[] type = new string[y];
            int i = 0;
            for (i = 0; i < type.Length; i++)
            {
                if (i == 0)
                {
                    ThMasuk.Items.Add("2010");
                }
                else
                {
                    int l = 2010 + i;
                    ThMasuk.Items.Add(l.ToString());
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThMasuk.Enabled = true;
            nmMhs.Enabled = true;
            statusMhs.Enabled = true;
            Nim.Visible = true;
            cbTahunMasuk();
            cbNama();
            ClearBtn.Enabled = true;
            SaveBtn.Enabled = true;
            AddBtn.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nim = Nim.Text;
            string statusmahasiswa = statusMhs.Text;
            string tahunmasuk = ThMasuk.Text;
            int count = 0;
            string tempkodestatus = "";
            string kodestatus = "";
            koneksi.Open();

            string str = "select count (*) from dbo.status_mahasiswa";
            SqlCommand cm = new SqlCommand(str, koneksi);
            count = (int)cm.ExecuteScalar();

            if (count == 0)
            {
                kodestatus = "1";
            }
            else
            {
                string querryString = "select max(id_status) from dbo.status_mahasiswa";
                SqlCommand cmStatusMahasiswaSum = new SqlCommand(str, koneksi);
                int totalStatusMahasiswa = (int)cmStatusMahasiswaSum.ExecuteScalar();
                int finalkodestatusint = totalStatusMahasiswa + 1;
                kodestatus = Convert.ToString(finalkodestatusint);
            }
            string queryString = "insert into dbo.status_mahasiswa (id_status, nim, " +
                "status_mahasiswa, tahun_masuk)" + "values(@ids, @Nim, @sm, @tm)";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("ids", kodestatus));
            cmd.Parameters.Add(new SqlParameter("Nim", nim));
            cmd.Parameters.Add(new SqlParameter("sm", statusmahasiswa));
            cmd.Parameters.Add(new SqlParameter("tm", tahunmasuk));
            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("data berhasil disimpan", "sukses", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            refreshform();
            dataGridView();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }
    }
}
