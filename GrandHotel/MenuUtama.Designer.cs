namespace HakAkses
{
    partial class MenuUtama
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
            this.main = new System.Windows.Forms.Panel();
            this.LRole = new System.Windows.Forms.Label();
            this.navFrontOffice = new System.Windows.Forms.Panel();
            this.btnNavMasterRT = new System.Windows.Forms.Button();
            this.btnNavMasterI = new System.Windows.Forms.Button();
            this.btnNavCI = new System.Windows.Forms.Button();
            this.btnNavRAI = new System.Windows.Forms.Button();
            this.btnNavMasterR = new System.Windows.Forms.Button();
            this.btnNavCO = new System.Windows.Forms.Button();
            this.btnNavR = new System.Windows.Forms.Button();
            this.navSupervisor = new System.Windows.Forms.Panel();
            this.btnNavAHS = new System.Windows.Forms.Button();
            this.navHousekeeper = new System.Windows.Forms.Panel();
            this.btnNavCR = new System.Windows.Forms.Button();
            this.navAdmin = new System.Windows.Forms.Panel();
            this.btnNavE = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.main.SuspendLayout();
            this.navFrontOffice.SuspendLayout();
            this.navSupervisor.SuspendLayout();
            this.navHousekeeper.SuspendLayout();
            this.navAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.SteelBlue;
            this.main.Controls.Add(this.btnLogout);
            this.main.Controls.Add(this.LRole);
            this.main.Controls.Add(this.navFrontOffice);
            this.main.Controls.Add(this.navSupervisor);
            this.main.Controls.Add(this.navHousekeeper);
            this.main.Controls.Add(this.navAdmin);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(0, 0);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(1434, 847);
            this.main.TabIndex = 0;
            // 
            // LRole
            // 
            this.LRole.AutoSize = true;
            this.LRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRole.ForeColor = System.Drawing.Color.White;
            this.LRole.Location = new System.Drawing.Point(27, 85);
            this.LRole.Name = "LRole";
            this.LRole.Size = new System.Drawing.Size(57, 26);
            this.LRole.TabIndex = 4;
            this.LRole.Text = "Role";
            // 
            // navFrontOffice
            // 
            this.navFrontOffice.Controls.Add(this.btnNavMasterRT);
            this.navFrontOffice.Controls.Add(this.btnNavMasterI);
            this.navFrontOffice.Controls.Add(this.btnNavCI);
            this.navFrontOffice.Controls.Add(this.btnNavRAI);
            this.navFrontOffice.Controls.Add(this.btnNavMasterR);
            this.navFrontOffice.Controls.Add(this.btnNavCO);
            this.navFrontOffice.Controls.Add(this.btnNavR);
            this.navFrontOffice.Location = new System.Drawing.Point(31, 140);
            this.navFrontOffice.Name = "navFrontOffice";
            this.navFrontOffice.Size = new System.Drawing.Size(284, 609);
            this.navFrontOffice.TabIndex = 0;
            // 
            // btnNavMasterRT
            // 
            this.btnNavMasterRT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMasterRT.ForeColor = System.Drawing.Color.Black;
            this.btnNavMasterRT.Location = new System.Drawing.Point(0, 355);
            this.btnNavMasterRT.Name = "btnNavMasterRT";
            this.btnNavMasterRT.Size = new System.Drawing.Size(262, 67);
            this.btnNavMasterRT.TabIndex = 6;
            this.btnNavMasterRT.Text = "Master Room Type";
            this.btnNavMasterRT.UseVisualStyleBackColor = true;
            this.btnNavMasterRT.Click += new System.EventHandler(this.btnNavMasterRT_Click);
            // 
            // btnNavMasterI
            // 
            this.btnNavMasterI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMasterI.ForeColor = System.Drawing.Color.Black;
            this.btnNavMasterI.Location = new System.Drawing.Point(0, 522);
            this.btnNavMasterI.Name = "btnNavMasterI";
            this.btnNavMasterI.Size = new System.Drawing.Size(262, 67);
            this.btnNavMasterI.TabIndex = 5;
            this.btnNavMasterI.Text = "Master Item";
            this.btnNavMasterI.UseVisualStyleBackColor = true;
            this.btnNavMasterI.Click += new System.EventHandler(this.btnNavMasterI_Click);
            // 
            // btnNavCI
            // 
            this.btnNavCI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCI.ForeColor = System.Drawing.Color.Black;
            this.btnNavCI.Location = new System.Drawing.Point(0, 90);
            this.btnNavCI.Name = "btnNavCI";
            this.btnNavCI.Size = new System.Drawing.Size(262, 67);
            this.btnNavCI.TabIndex = 4;
            this.btnNavCI.Text = "Check in";
            this.btnNavCI.UseVisualStyleBackColor = true;
            this.btnNavCI.Click += new System.EventHandler(this.btnNavCI_Click);
            // 
            // btnNavRAI
            // 
            this.btnNavRAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavRAI.ForeColor = System.Drawing.Color.Black;
            this.btnNavRAI.Location = new System.Drawing.Point(0, 172);
            this.btnNavRAI.Name = "btnNavRAI";
            this.btnNavRAI.Size = new System.Drawing.Size(262, 67);
            this.btnNavRAI.TabIndex = 3;
            this.btnNavRAI.Text = "Request Additional item (s)";
            this.btnNavRAI.UseVisualStyleBackColor = true;
            this.btnNavRAI.Click += new System.EventHandler(this.btnNavRAI_Click);
            // 
            // btnNavMasterR
            // 
            this.btnNavMasterR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMasterR.ForeColor = System.Drawing.Color.Black;
            this.btnNavMasterR.Location = new System.Drawing.Point(0, 438);
            this.btnNavMasterR.Name = "btnNavMasterR";
            this.btnNavMasterR.Size = new System.Drawing.Size(262, 67);
            this.btnNavMasterR.TabIndex = 2;
            this.btnNavMasterR.Text = "Master Room";
            this.btnNavMasterR.UseVisualStyleBackColor = true;
            this.btnNavMasterR.Click += new System.EventHandler(this.btnNavMasterR_Click);
            // 
            // btnNavCO
            // 
            this.btnNavCO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCO.ForeColor = System.Drawing.Color.Black;
            this.btnNavCO.Location = new System.Drawing.Point(0, 265);
            this.btnNavCO.Name = "btnNavCO";
            this.btnNavCO.Size = new System.Drawing.Size(262, 67);
            this.btnNavCO.TabIndex = 1;
            this.btnNavCO.Text = "Check Out";
            this.btnNavCO.UseVisualStyleBackColor = true;
            this.btnNavCO.Click += new System.EventHandler(this.btnNavCO_Click);
            // 
            // btnNavR
            // 
            this.btnNavR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavR.ForeColor = System.Drawing.Color.Black;
            this.btnNavR.Location = new System.Drawing.Point(0, 3);
            this.btnNavR.Name = "btnNavR";
            this.btnNavR.Size = new System.Drawing.Size(262, 67);
            this.btnNavR.TabIndex = 0;
            this.btnNavR.Text = "Reservation";
            this.btnNavR.UseVisualStyleBackColor = true;
            this.btnNavR.Click += new System.EventHandler(this.btnNavR_Click);
            // 
            // navSupervisor
            // 
            this.navSupervisor.Controls.Add(this.btnNavAHS);
            this.navSupervisor.Location = new System.Drawing.Point(31, 140);
            this.navSupervisor.Name = "navSupervisor";
            this.navSupervisor.Size = new System.Drawing.Size(284, 609);
            this.navSupervisor.TabIndex = 1;
            // 
            // btnNavAHS
            // 
            this.btnNavAHS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAHS.ForeColor = System.Drawing.Color.Black;
            this.btnNavAHS.Location = new System.Drawing.Point(0, 3);
            this.btnNavAHS.Name = "btnNavAHS";
            this.btnNavAHS.Size = new System.Drawing.Size(262, 67);
            this.btnNavAHS.TabIndex = 0;
            this.btnNavAHS.Text = "Add Housekeping Schedule";
            this.btnNavAHS.UseVisualStyleBackColor = true;
            this.btnNavAHS.Click += new System.EventHandler(this.btnNavAHS_Click);
            // 
            // navHousekeeper
            // 
            this.navHousekeeper.Controls.Add(this.btnNavCR);
            this.navHousekeeper.Location = new System.Drawing.Point(30, 140);
            this.navHousekeeper.Name = "navHousekeeper";
            this.navHousekeeper.Size = new System.Drawing.Size(284, 609);
            this.navHousekeeper.TabIndex = 2;
            // 
            // btnNavCR
            // 
            this.btnNavCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCR.ForeColor = System.Drawing.Color.Black;
            this.btnNavCR.Location = new System.Drawing.Point(0, 3);
            this.btnNavCR.Name = "btnNavCR";
            this.btnNavCR.Size = new System.Drawing.Size(262, 67);
            this.btnNavCR.TabIndex = 0;
            this.btnNavCR.Text = "Cleaning Room";
            this.btnNavCR.UseVisualStyleBackColor = true;
            this.btnNavCR.Click += new System.EventHandler(this.btnNavCR_Click);
            // 
            // navAdmin
            // 
            this.navAdmin.Controls.Add(this.btnNavE);
            this.navAdmin.Location = new System.Drawing.Point(29, 140);
            this.navAdmin.Name = "navAdmin";
            this.navAdmin.Size = new System.Drawing.Size(284, 609);
            this.navAdmin.TabIndex = 3;
            // 
            // btnNavE
            // 
            this.btnNavE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavE.ForeColor = System.Drawing.Color.Black;
            this.btnNavE.Location = new System.Drawing.Point(0, 3);
            this.btnNavE.Name = "btnNavE";
            this.btnNavE.Size = new System.Drawing.Size(262, 67);
            this.btnNavE.TabIndex = 0;
            this.btnNavE.Text = "Master Employee";
            this.btnNavE.UseVisualStyleBackColor = true;
            this.btnNavE.Click += new System.EventHandler(this.btnNavE_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(29, 779);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 56);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 847);
            this.Controls.Add(this.main);
            this.Name = "MenuUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuUtama_Load);
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.navFrontOffice.ResumeLayout(false);
            this.navSupervisor.ResumeLayout(false);
            this.navHousekeeper.ResumeLayout(false);
            this.navAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnNavE;
        public System.Windows.Forms.Button btnNavCR;
        public System.Windows.Forms.Button btnNavAHS;
        public System.Windows.Forms.Button btnNavMasterRT;
        private System.Windows.Forms.Button btnNavMasterI;
        private System.Windows.Forms.Button btnNavCI;
        private System.Windows.Forms.Button btnNavRAI;
        private System.Windows.Forms.Button btnNavMasterR;
        private System.Windows.Forms.Button btnNavCO;
        public System.Windows.Forms.Button btnNavR;
        public System.Windows.Forms.Panel navAdmin;
        public System.Windows.Forms.Panel navHousekeeper;
        public System.Windows.Forms.Panel navSupervisor;
        public System.Windows.Forms.Panel navFrontOffice;
        public System.Windows.Forms.Label LRole;
        public System.Windows.Forms.Panel main;
        private System.Windows.Forms.Button btnLogout;
    }
}