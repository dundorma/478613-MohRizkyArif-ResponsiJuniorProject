using Npgsql;
using System.Data;
namespace responsi2;

public partial class Form1 : Form
{
    private NpgsqlConnection conn;
    string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsi2";
    public static NpgsqlCommand cmd;
    private string sql = null;
    public DataTable dt;
    private DataGridViewRow r;

    private string id_karyawan = null;
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        conn = new NpgsqlConnection(connectionString);
        load();
        List<string> x = new List<string> { "1", "2", "3", "4", "5" };
        txtDep.Items.Add("1");
        txtDep.Items.Add("2");
        txtDep.Items.Add("3");
        txtDep.Items.Add("4");
        txtDep.Items.Add("5");
        txtDep.Text = "1";
    }

    private void btnInsert_Click(object sender, EventArgs e)
    {
        try
        {
            conn.Open();
            sql = @"select * from k_insert(:_nama,:_id_dep)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_nama", txtNama.Text);
            cmd.Parameters.AddWithValue("_id_dep", Int32.Parse(txtDep.Text));

            if ((int)cmd.ExecuteScalar() == 1)
            {
                MessageBox.Show("Data karyawan berhasil ditambah.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                load();
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void load()
    {
        try
        {
            conn.Open();
            sql = @"select * from k_select()";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            NpgsqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            dgKaryawan.DataSource = dt;

            conn.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (id_karyawan.Length <= 0)
        {
            MessageBox.Show("tolong pilih yang mau didelete dengan klik cel yang ingin didelete");
            return;
        }
        try
        {
            conn.Open();
            sql = @"select * from k_delete(:_id_karyawan)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_id_karyawan", id_karyawan);

            if ((int)cmd.ExecuteScalar() == 1)
            {
                MessageBox.Show("Data karyawan berhasil dihapus.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                load();
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dgKaryawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            r = dgKaryawan.Rows[e.RowIndex];
            id_karyawan = r.Cells["_id_karyawan"].Value.ToString();
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (id_karyawan.Length <= 0)
        {
            MessageBox.Show("tolong pilih yang mau diedit dengan klik cel yang ingin diedit");
            return;
        }
        try
        {
            conn.Open();
            sql = @"select * from k_update(:_id_karyawan,:_nama,:_id_dep)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_id_karyawan", id_karyawan);
            cmd.Parameters.AddWithValue("_nama", txtNama.Text);
            cmd.Parameters.AddWithValue("_id_dep", Int32.Parse(txtDep.Text));

            if ((int)cmd.ExecuteScalar() == 1)
            {
                MessageBox.Show("Data karyawan berhasil diedit.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                load();
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
