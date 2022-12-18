using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace savingly_crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textbox_spending_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"F:\\Data Qornain\\Materi Matkul\\Materi_Semester\\Sem 3\\PBO\\ProjectAkhir\\savingly_pbo_project\\savingly_crud\\Savingly_DB.mdf\";Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into SPENDING values (@date,@spending,@items)", conn);
            cmd.Parameters.AddWithValue("@date", date_picker.Value);
            cmd.Parameters.AddWithValue("@spending", int.Parse(textbox_spending.Text));
            cmd.Parameters.AddWithValue("@items", textbox_items.Text);
            cmd.ExecuteNonQuery(); 
            conn.Close();
            MessageBox.Show("Spending successfully've been recorded.");
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"F:\\Data Qornain\\Materi Matkul\\Materi_Semester\\Sem 3\\PBO\\ProjectAkhir\\savingly_pbo_project\\savingly_crud\\Savingly_DB.mdf\";Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd_update = new SqlCommand("Update SPENDING set spending=@spending, items=@items where ID=@ID", conn);
            cmd_update.Parameters.AddWithValue("@ID", int.Parse(textbox_ID_updel.Text));
            cmd_update.Parameters.AddWithValue("@spending", int.Parse(textbox_spending_updel.Text));
            cmd_update.Parameters.AddWithValue("@items", textbox_items_updel.Text);
            cmd_update.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Update spending is successfully've been done.");
        }

        private void text_date_Click(object sender, EventArgs e)
        {

        }

        private void date_picker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"F:\\Data Qornain\\Materi Matkul\\Materi_Semester\\Sem 3\\PBO\\ProjectAkhir\\savingly_pbo_project\\savingly_crud\\Savingly_DB.mdf\";Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd_delete = new SqlCommand("Delete SPENDING where ID=@ID", conn);
            cmd_delete.Parameters.AddWithValue("@ID", int.Parse(textbox_ID_updel.Text));
            cmd_delete.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully Deleted!");
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"F:\\Data Qornain\\Materi Matkul\\Materi_Semester\\Sem 3\\PBO\\ProjectAkhir\\savingly_pbo_project\\savingly_crud\\Savingly_DB.mdf\";Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd_refresh = new SqlCommand("Select * from SPENDING", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd_refresh);
            DataTable dt = new DataTable();
            da.Fill(dt);
            table.DataSource = dt;
        }
    }
}
