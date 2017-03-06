namespace Test_Import_Utility
{
    partial class importForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.browseBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pcSynergyLogo = new System.Windows.Forms.PictureBox();
            this.openBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSynergyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 463);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(537, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // browseBttn
            // 
            this.browseBttn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.browseBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBttn.Location = new System.Drawing.Point(660, 201);
            this.browseBttn.Name = "browseBttn";
            this.browseBttn.Size = new System.Drawing.Size(100, 22);
            this.browseBttn.TabIndex = 2;
            this.browseBttn.Text = "Browse";
            this.browseBttn.UseVisualStyleBackColor = false;
            this.browseBttn.Click += new System.EventHandler(this.browseBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pcSynergyLogo
            // 
            this.pcSynergyLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcSynergyLogo.BackColor = System.Drawing.SystemColors.Control;
            this.pcSynergyLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcSynergyLogo.Image = global::Test_Import_Utility.Properties.Resources.pm_by_pcs;
            this.pcSynergyLogo.Location = new System.Drawing.Point(25, 12);
            this.pcSynergyLogo.Name = "pcSynergyLogo";
            this.pcSynergyLogo.Size = new System.Drawing.Size(735, 182);
            this.pcSynergyLogo.TabIndex = 4;
            this.pcSynergyLogo.TabStop = false;
            // 
            // openBttn
            // 
            this.openBttn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.openBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBttn.Location = new System.Drawing.Point(660, 229);
            this.openBttn.Name = "openBttn";
            this.openBttn.Size = new System.Drawing.Size(100, 22);
            this.openBttn.TabIndex = 5;
            this.openBttn.Text = "Open File";
            this.openBttn.UseVisualStyleBackColor = false;
            this.openBttn.Click += new System.EventHandler(this.openBttn_Click);
            // 
            // importForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 747);
            this.Controls.Add(this.openBttn);
            this.Controls.Add(this.pcSynergyLogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseBttn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "importForm";
            this.Text = ".csv Import Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSynergyLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button browseBttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcSynergyLogo;
        private System.Windows.Forms.Button openBttn;
    }
}

