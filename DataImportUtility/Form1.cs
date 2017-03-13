using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace SimpleCSV
{
    public partial class Form1 : Form
    {

        //Variables
        //DataGridView my_dataGridView = new DataGridView();  //New DataGridView
        DataTable my_dataTable = new DataTable();           //New DataTable for CSV file
        //string file_path;                                   //String to store the file path


        public Form1()
        {
            InitializeComponent();
        }

        public DataTable ReadCSV(string fileName)
        {
            DataTable dt = new DataTable("Data");
            using (OleDbConnection cn = new OleDbConnection("Provider=MIcrosoft.Jet.OLEDB.4.0;Data Source=\"" + Path.GetDirectoryName(fileName) + "\"; Extended Properties='text;HDR=yes;FMT=Delimeted(,)';"))
            {
                using (OleDbCommand cmd = new OleDbCommand(string.Format("select *from [{0}]", new FileInfo(fileName).Name), cn))
                {
                    cn.Open();
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
                return dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            this.Size = new Size(750, 450);
            my_dataGridView.Size = new Size(600, 400);
            my_dataGridView.Location = new Point(5, 5);

            string[] raw_text = System.IO.File.ReadAllLines("c:\\SalesJan2009REV1.csv");
            string[] data_col = null;
            int x = 0;
            foreach (string text_line in raw_text)
            {
                //MessageBox.Show(text_line);
                data_col = text_line.Split(',');

                if (x==0)
                {
                    for(int i = 0; i <= data_col.Count() - 1; i++)
                    {
                        my_dataTable.Columns.Add(data_col[i]);
                    }
                    //header
                    x++;
                }
                else
                {

                    //data
                    my_dataTable.Rows.Add(data_col);
                }
            }//End of foreach loop

            my_dataGridView.DataSource = my_dataTable;
            this.Controls.Add(my_dataGridView);
            */
        }//End of Form1_Load

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true, Multiselect = false })
                {
                    if(ofd.ShowDialog() == DialogResult.OK)
                    {
                        dataGridView1.DataSource = ReadCSV(ofd.FileName);
                    }
                }
                 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }//End of Partial Class Form1
}//End of namespace
