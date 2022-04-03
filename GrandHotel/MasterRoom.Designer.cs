namespace HakAkses
{
    partial class MasterRoom
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
            this.components = new System.ComponentModel.Container();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridVMRoom = new System.Windows.Forms.DataGridView();
            this.Rnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rfloor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBoxRType = new System.Windows.Forms.ComboBox();
            this.txtRFloor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVMRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(838, 557);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 38);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(677, 557);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 38);
            this.btnUpdate.TabIndex = 59;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(523, 557);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(98, 38);
            this.btnInsert.TabIndex = 58;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(838, 485);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 38);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Room Type";
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Location = new System.Drawing.Point(656, 339);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(280, 116);
            this.txtDesc.TabIndex = 55;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtRoomP_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Room Floor";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(677, 485);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 38);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRNumber
            // 
            this.txtRNumber.Enabled = false;
            this.txtRNumber.Location = new System.Drawing.Point(159, 339);
            this.txtRNumber.Name = "txtRNumber";
            this.txtRNumber.Size = new System.Drawing.Size(259, 26);
            this.txtRNumber.TabIndex = 52;
            this.txtRNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Room Number";
            // 
            // dataGridVMRoom
            // 
            this.dataGridVMRoom.AllowUserToAddRows = false;
            this.dataGridVMRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVMRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rnumber,
            this.Rtype,
            this.Rfloor,
            this.desc});
            this.dataGridVMRoom.Location = new System.Drawing.Point(35, 26);
            this.dataGridVMRoom.Name = "dataGridVMRoom";
            this.dataGridVMRoom.RowHeadersWidth = 62;
            this.dataGridVMRoom.RowTemplate.Height = 28;
            this.dataGridVMRoom.Size = new System.Drawing.Size(917, 282);
            this.dataGridVMRoom.TabIndex = 50;
            this.dataGridVMRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVMRoom_CellClick);
            this.dataGridVMRoom.Click += new System.EventHandler(this.dataGridVMRoom_Click);
            // 
            // Rnumber
            // 
            this.Rnumber.HeaderText = "Room Number";
            this.Rnumber.MinimumWidth = 8;
            this.Rnumber.Name = "Rnumber";
            this.Rnumber.Width = 150;
            // 
            // Rtype
            // 
            this.Rtype.HeaderText = "Room Type";
            this.Rtype.MinimumWidth = 8;
            this.Rtype.Name = "Rtype";
            this.Rtype.Width = 150;
            // 
            // Rfloor
            // 
            this.Rfloor.HeaderText = "Room Floor";
            this.Rfloor.MinimumWidth = 8;
            this.Rfloor.Name = "Rfloor";
            this.Rfloor.Width = 150;
            // 
            // desc
            // 
            this.desc.HeaderText = "Description";
            this.desc.MinimumWidth = 8;
            this.desc.Name = "desc";
            this.desc.Width = 150;
            // 
            // CBoxRType
            // 
            this.CBoxRType.Enabled = false;
            this.CBoxRType.FormattingEnabled = true;
            this.CBoxRType.Location = new System.Drawing.Point(159, 391);
            this.CBoxRType.Name = "CBoxRType";
            this.CBoxRType.Size = new System.Drawing.Size(259, 28);
            this.CBoxRType.TabIndex = 61;
            // 
            // txtRFloor
            // 
            this.txtRFloor.Enabled = false;
            this.txtRFloor.Location = new System.Drawing.Point(159, 445);
            this.txtRFloor.Name = "txtRFloor";
            this.txtRFloor.Size = new System.Drawing.Size(259, 26);
            this.txtRFloor.TabIndex = 62;
            this.txtRFloor.TextChanged += new System.EventHandler(this.txtRFloor_TextChanged);
            this.txtRFloor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRFloor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Description";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MasterRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 650);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRFloor);
            this.Controls.Add(this.CBoxRType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridVMRoom);
            this.Name = "MasterRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterRoom";
            this.Load += new System.EventHandler(this.MasterRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVMRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridVMRoom;
        private System.Windows.Forms.ComboBox CBoxRType;
        private System.Windows.Forms.TextBox txtRFloor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rfloor;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}