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

namespace Bineva_L_Notebook_Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection sql;
        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                sql = new SqlConnection(@"Data Source=LAB109PC01\SQLEXPRESS; Initial Catalog=Notebook_App; Integrated Security=True;");
                sql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string fetchTitle = "SELECT Title From Notes WHERE 1=1";
            SqlCommand cmd = new SqlCommand(fetchTitle, sql);
            cmd.CommandType = CommandType.Text;

            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                Title_box.DataSource = ds.Tables[0];
                Title_box.DisplayMember = "Title";
            }
        }

        private void Title_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fetchNote = "SELECT Text From Notes WHERE Title=@Title";
            string fetchTime = "SELECT Date From Notes WHERE Title=@Title";
            SqlCommand cmd2 = new SqlCommand(fetchNote, sql);
            SqlCommand cmd3 = new SqlCommand(fetchTime, sql);
            cmd2.CommandType = CommandType.Text;
            cmd3.CommandType = CommandType.Text;
            cmd2.Parameters.AddWithValue("@Title", Title_box.Text);
            cmd3.Parameters.AddWithValue("@Title", Title_box.Text);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                if (reader.Read())
                {
                    Note.Text = reader["Text"].ToString();
                }
            }
            using (SqlDataReader reader2 = cmd3.ExecuteReader())
            {
                if (reader2.Read())
                {
                    timestamp.Text = "This note was done on " + reader2["Date"].ToString();
                }
            }
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            string deleteNote = "Delete From Notes WHERE Title=@Title";
            SqlCommand cmd = new SqlCommand(deleteNote, sql);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Title", Title_box.Text);
            cmd.ExecuteNonQuery();

            DialogResult result = MessageBox.Show("Are you sure you want to delete this note?", "Sure?", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your note was succesfully deleted!", "Deleted", MessageBoxButtons.OK);
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Your note was not deleted!", "Not Deleted", MessageBoxButtons.OK);
            }

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
