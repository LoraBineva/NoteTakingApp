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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bineva_L_Notebook_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection sql;
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                sql = new SqlConnection(@"Data Source=LAB109PC01\SQLEXPRESS; Initial Catalog=Notebook_App; Integrated Security=True;");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void new_note_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sql.State == ConnectionState.Closed)
                    sql.Open();

                DateTime today = DateTime.Now;

                string Query = "Insert into Notes Values(@Title, @Text, @Date) ";
                SqlCommand cmd = new SqlCommand(Query, sql);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Title", Title.Text);
                cmd.Parameters.AddWithValue("@Text", Text.Text);
                cmd.Parameters.AddWithValue("@Date", today);

                cmd.ExecuteNonQuery();

                MessageBox.Show("You have added a new note!", "Good Job", MessageBoxButtons.OK);
                // how to automatically remove the previous title?
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
