namespace HakAkses
{
    partial class CleaningRoom
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.dataGridViewCS = new System.Windows.Forms.DataGridView();
            this.dataGridViewCSD = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cleaning Schedules";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(32, 616);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(168, 45);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewCS
            // 
            this.dataGridViewCS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCS.Location = new System.Drawing.Point(32, 62);
            this.dataGridViewCS.Name = "dataGridViewCS";
            this.dataGridViewCS.RowHeadersWidth = 62;
            this.dataGridViewCS.RowTemplate.Height = 28;
            this.dataGridViewCS.Size = new System.Drawing.Size(792, 239);
            this.dataGridViewCS.TabIndex = 2;
            this.dataGridViewCS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewCSD
            // 
            this.dataGridViewCSD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCSD.Location = new System.Drawing.Point(32, 372);
            this.dataGridViewCSD.Name = "dataGridViewCSD";
            this.dataGridViewCSD.RowHeadersWidth = 62;
            this.dataGridViewCSD.RowTemplate.Height = 28;
            this.dataGridViewCSD.Size = new System.Drawing.Size(792, 221);
            this.dataGridViewCSD.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cleaning Schedule Detail";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(227, 616);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(168, 45);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import Excel";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // CleaningRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 694);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.dataGridViewCSD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewCS);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label1);
            this.Name = "CleaningRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CleaningRoom";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dataGridViewCS;
        private System.Windows.Forms.DataGridView dataGridViewCSD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImport;
    }
}