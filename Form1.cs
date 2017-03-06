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

namespace Test_Import_Utility
{
    public partial class importForm: Form
    {
        public importForm()
        {
            InitializeComponent();
        }//End of main form

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //This function is only the label for the 
        private void label1_Click(object sender, EventArgs e)
        {
            

        }//End of button object

        private void browseBttn_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a .csv file.  
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = ".csv Files (*.csv)|*.csv";
            openFileDialog1.Title = "Select a .csv File";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            // Show the Dialog.  
            // If the user clicked OK in the dialog and  
            // a .csv file was selected, open it.  
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Assigns the variable with the file name
                fileName = openFileDialog1.FileName;

            }
        }

        private void openBttn_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a .csv file.  
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            //openFileDialog2.OpenFile();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }//End of partial class

}//End of main function
