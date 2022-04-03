namespace HakAkses
{
    partial class Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.CBRoomType = new System.Windows.Forms.ComboBox();
            this.dataGridAvaibleR = new System.Windows.Forms.DataGridView();
            this.roomnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomfloor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.RBSearch = new System.Windows.Forms.RadioButton();
            this.RBAddNew = new System.Windows.Forms.RadioButton();
            this.dataGridCustomer = new System.Windows.Forms.DataGridView();
            this.choose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panelAddCustomerData = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numericQty = new System.Windows.Forms.NumericUpDown();
            this.CBItem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridRequestAI = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LTotal = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.dataGridVSRoom = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAvaibleR)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).BeginInit();
            this.panelAddCustomerData.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRequestAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVSRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date";
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(184, 26);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(266, 26);
            this.dateTimeStart.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(663, 28);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(117, 26);
            this.txtNumber.TabIndex = 2;
            this.txtNumber.Text = "0";
            this.txtNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // CBRoomType
            // 
            this.CBRoomType.FormattingEnabled = true;
            this.CBRoomType.Location = new System.Drawing.Point(184, 81);
            this.CBRoomType.Name = "CBRoomType";
            this.CBRoomType.Size = new System.Drawing.Size(266, 28);
            this.CBRoomType.TabIndex = 3;
            this.CBRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.CBRoomType.SelectedValueChanged += new System.EventHandler(this.CBRoomType_SelectedValueChanged);
            this.CBRoomType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CBRoomType_KeyPress);
            this.CBRoomType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CBRoomType_MouseClick);
            // 
            // dataGridAvaibleR
            // 
            this.dataGridAvaibleR.AllowUserToAddRows = false;
            this.dataGridAvaibleR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAvaibleR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomnumber,
            this.roomfloor,
            this.description});
            this.dataGridAvaibleR.Location = new System.Drawing.Point(18, 195);
            this.dataGridAvaibleR.Name = "dataGridAvaibleR";
            this.dataGridAvaibleR.RowHeadersWidth = 62;
            this.dataGridAvaibleR.RowTemplate.Height = 28;
            this.dataGridAvaibleR.Size = new System.Drawing.Size(579, 185);
            this.dataGridAvaibleR.TabIndex = 4;
            this.dataGridAvaibleR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // roomnumber
            // 
            this.roomnumber.HeaderText = "Room Number";
            this.roomnumber.MinimumWidth = 8;
            this.roomnumber.Name = "roomnumber";
            this.roomnumber.Width = 150;
            // 
            // roomfloor
            // 
            this.roomfloor.HeaderText = "Room Floor";
            this.roomfloor.MinimumWidth = 8;
            this.roomfloor.Name = "roomfloor";
            this.roomfloor.Width = 150;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 8;
            this.description.Name = "description";
            this.description.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.RBSearch);
            this.groupBox1.Controls.Add(this.RBAddNew);
            this.groupBox1.Controls.Add(this.dataGridCustomer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panelAddCustomerData);
            this.groupBox1.Location = new System.Drawing.Point(12, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 301);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Data";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(364, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(185, 26);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // RBSearch
            // 
            this.RBSearch.AutoSize = true;
            this.RBSearch.Checked = true;
            this.RBSearch.Location = new System.Drawing.Point(126, 37);
            this.RBSearch.Name = "RBSearch";
            this.RBSearch.Size = new System.Drawing.Size(85, 24);
            this.RBSearch.TabIndex = 14;
            this.RBSearch.TabStop = true;
            this.RBSearch.Text = "Search";
            this.RBSearch.UseVisualStyleBackColor = true;
            this.RBSearch.CheckedChanged += new System.EventHandler(this.RBSearch_CheckedChanged);
            // 
            // RBAddNew
            // 
            this.RBAddNew.AutoSize = true;
            this.RBAddNew.Location = new System.Drawing.Point(6, 37);
            this.RBAddNew.Name = "RBAddNew";
            this.RBAddNew.Size = new System.Drawing.Size(98, 24);
            this.RBAddNew.TabIndex = 13;
            this.RBAddNew.Text = "Add New";
            this.RBAddNew.UseVisualStyleBackColor = true;
            this.RBAddNew.CheckedChanged += new System.EventHandler(this.RBAddNew_CheckedChanged);
            // 
            // dataGridCustomer
            // 
            this.dataGridCustomer.AllowUserToAddRows = false;
            this.dataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.choose,
            this.name,
            this.email,
            this.gender,
            this.Column1,
            this.Column2});
            this.dataGridCustomer.Location = new System.Drawing.Point(6, 112);
            this.dataGridCustomer.Name = "dataGridCustomer";
            this.dataGridCustomer.RowHeadersWidth = 62;
            this.dataGridCustomer.RowTemplate.Height = 28;
            this.dataGridCustomer.Size = new System.Drawing.Size(543, 183);
            this.dataGridCustomer.TabIndex = 12;
            this.dataGridCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomer_CellClick);
            this.dataGridCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomer_CellContentClick);
            // 
            // choose
            // 
            this.choose.HeaderText = "Choose";
            this.choose.MinimumWidth = 8;
            this.choose.Name = "choose";
            this.choose.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 150;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            this.email.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.email.Width = 150;
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 8;
            this.gender.Name = "gender";
            this.gender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gender.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Phone";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Age";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "search";
            // 
            // panelAddCustomerData
            // 
            this.panelAddCustomerData.Controls.Add(this.txtName);
            this.panelAddCustomerData.Controls.Add(this.label12);
            this.panelAddCustomerData.Controls.Add(this.txtPhone);
            this.panelAddCustomerData.Controls.Add(this.label11);
            this.panelAddCustomerData.Location = new System.Drawing.Point(6, 112);
            this.panelAddCustomerData.Name = "panelAddCustomerData";
            this.panelAddCustomerData.Size = new System.Drawing.Size(543, 183);
            this.panelAddCustomerData.TabIndex = 18;
            this.panelAddCustomerData.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(154, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 26);
            this.txtName.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Name";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(154, 37);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(248, 26);
            this.txtPhone.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of nights";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Room Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(491, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 33);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(704, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "List Selected Room";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.numericQty);
            this.groupBox3.Controls.Add(this.CBItem);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dataGridRequestAI);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(708, 401);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(595, 301);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Request Additional Items";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(419, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 33);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numericQty
            // 
            this.numericQty.Location = new System.Drawing.Point(114, 72);
            this.numericQty.Name = "numericQty";
            this.numericQty.Size = new System.Drawing.Size(243, 26);
            this.numericQty.TabIndex = 15;
            // 
            // CBItem
            // 
            this.CBItem.FormattingEnabled = true;
            this.CBItem.Location = new System.Drawing.Point(114, 33);
            this.CBItem.Name = "CBItem";
            this.CBItem.Size = new System.Drawing.Size(243, 28);
            this.CBItem.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Qty";
            // 
            // dataGridRequestAI
            // 
            this.dataGridRequestAI.AllowUserToAddRows = false;
            this.dataGridRequestAI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRequestAI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridRequestAI.Location = new System.Drawing.Point(6, 112);
            this.dataGridRequestAI.Name = "dataGridRequestAI";
            this.dataGridRequestAI.RowHeadersWidth = 62;
            this.dataGridRequestAI.RowTemplate.Height = 28;
            this.dataGridRequestAI.Size = new System.Drawing.Size(555, 183);
            this.dataGridRequestAI.TabIndex = 12;
            this.dataGridRequestAI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRequestAI_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Item";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Qty";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Remove";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Text = "Remove";
            this.Column6.UseColumnTextForButtonValue = true;
            this.Column6.Width = 150;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Item";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "List Available Rooms :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1014, 705);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Total Price";
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Location = new System.Drawing.Point(1140, 705);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(110, 20);
            this.LTotal.TabIndex = 18;
            this.LTotal.Text = "Rp. 12000000";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1144, 746);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 33);
            this.button5.TabIndex = 18;
            this.button5.Text = "Submit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Image = global::HakAkses.Properties.Resources.Kiri;
            this.btnLeft.Location = new System.Drawing.Point(619, 293);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(61, 49);
            this.btnLeft.TabIndex = 13;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Image = global::HakAkses.Properties.Resources.Kanan;
            this.btnRight.Location = new System.Drawing.Point(619, 238);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(61, 49);
            this.btnRight.TabIndex = 12;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridVSRoom
            // 
            this.dataGridVSRoom.AllowUserToAddRows = false;
            this.dataGridVSRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVSRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridVSRoom.Location = new System.Drawing.Point(708, 195);
            this.dataGridVSRoom.Name = "dataGridVSRoom";
            this.dataGridVSRoom.RowHeadersWidth = 62;
            this.dataGridVSRoom.RowTemplate.Height = 28;
            this.dataGridVSRoom.Size = new System.Drawing.Size(561, 185);
            this.dataGridVSRoom.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Room Number";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Room Floor";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(659, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 20;
            // 
            // Reservation
            // 
            this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 791);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridVSRoom);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.LTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridAvaibleR);
            this.Controls.Add(this.CBRoomType);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.label1);
            this.Name = "Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAvaibleR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).EndInit();
            this.panelAddCustomerData.ResumeLayout(false);
            this.panelAddCustomerData.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRequestAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVSRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.ComboBox CBRoomType;
        private System.Windows.Forms.DataGridView dataGridAvaibleR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelAddCustomerData;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton RBSearch;
        private System.Windows.Forms.RadioButton RBAddNew;
        private System.Windows.Forms.DataGridView dataGridCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numericQty;
        private System.Windows.Forms.ComboBox CBItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridRequestAI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridVSRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomfloor;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn choose;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label10;
    }
}