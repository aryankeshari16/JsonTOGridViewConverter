namespace JsonTOGridViewConverter
{
    partial class GridView
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
            this.hrsPanelBox1 = new Hrs_Control.HrsPanelBox();
            this.TravelDate_To = new System.Windows.Forms.DateTimePicker();
            this.TravelDate_From = new System.Windows.Forms.DateTimePicker();
            this.travel_date_label = new System.Windows.Forms.Label();
            this.entrydate_to = new System.Windows.Forms.DateTimePicker();
            this.EntryDate_From = new System.Windows.Forms.DateTimePicker();
            this.entrydate_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noneRadioButton1 = new System.Windows.Forms.RadioButton();
            this.falseRadioButton1 = new System.Windows.Forms.RadioButton();
            this.trueRadioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.accIdtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sectorComboBox = new Hrs_Control.HrsComboBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.CountRecordsLbl = new System.Windows.Forms.Label();
            this.pax_label = new System.Windows.Forms.Label();
            this.paxTextBox = new System.Windows.Forms.TextBox();
            this.EventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TraceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApiName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Child = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Infant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponseTimeMs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Success = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.export_to_excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventType,
            this.EntryDateTime,
            this.TraceId,
            this.UserName,
            this.AccountId,
            this.ApiName,
            this.Origin,
            this.Destination,
            this.TravelDate,
            this.Adult,
            this.Child,
            this.Infant,
            this.ResultCount,
            this.ResponseTimeMs,
            this.ClientIP,
            this.Device,
            this.Success,
            this.ErrorMessage});
            this.dataGridView1.Location = new System.Drawing.Point(12, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1679, 588);
            this.dataGridView1.TabIndex = 0;
            // 
            // hrsPanelBox1
            // 
            this.hrsPanelBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hrsPanelBox1.AutoSize = true;
            this.hrsPanelBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hrsPanelBox1.HeaderBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hrsPanelBox1.HeadreText = "Filter Section";
            this.hrsPanelBox1.Location = new System.Drawing.Point(12, 13);
            this.hrsPanelBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hrsPanelBox1.Name = "hrsPanelBox1";
            this.hrsPanelBox1.Size = new System.Drawing.Size(1679, 173);
            this.hrsPanelBox1.TabIndex = 1;
            // 
            // TravelDate_To
            // 
            this.TravelDate_To.Checked = false;
            this.TravelDate_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TravelDate_To.Location = new System.Drawing.Point(710, 63);
            this.TravelDate_To.Margin = new System.Windows.Forms.Padding(4);
            this.TravelDate_To.Name = "TravelDate_To";
            this.TravelDate_To.ShowCheckBox = true;
            this.TravelDate_To.Size = new System.Drawing.Size(195, 22);
            this.TravelDate_To.TabIndex = 636;
            // 
            // TravelDate_From
            // 
            this.TravelDate_From.Checked = false;
            this.TravelDate_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TravelDate_From.Location = new System.Drawing.Point(480, 63);
            this.TravelDate_From.Margin = new System.Windows.Forms.Padding(4);
            this.TravelDate_From.Name = "TravelDate_From";
            this.TravelDate_From.ShowCheckBox = true;
            this.TravelDate_From.Size = new System.Drawing.Size(222, 22);
            this.TravelDate_From.TabIndex = 635;
            // 
            // travel_date_label
            // 
            this.travel_date_label.AutoSize = true;
            this.travel_date_label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.travel_date_label.Location = new System.Drawing.Point(371, 69);
            this.travel_date_label.Name = "travel_date_label";
            this.travel_date_label.Size = new System.Drawing.Size(78, 16);
            this.travel_date_label.TabIndex = 634;
            this.travel_date_label.Text = "Travel Date";
            // 
            // entrydate_to
            // 
            this.entrydate_to.Checked = false;
            this.entrydate_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.entrydate_to.Location = new System.Drawing.Point(710, 92);
            this.entrydate_to.Margin = new System.Windows.Forms.Padding(4);
            this.entrydate_to.Name = "entrydate_to";
            this.entrydate_to.ShowCheckBox = true;
            this.entrydate_to.Size = new System.Drawing.Size(195, 22);
            this.entrydate_to.TabIndex = 633;
            // 
            // EntryDate_From
            // 
            this.EntryDate_From.Checked = false;
            this.EntryDate_From.Location = new System.Drawing.Point(480, 93);
            this.EntryDate_From.Margin = new System.Windows.Forms.Padding(4);
            this.EntryDate_From.Name = "EntryDate_From";
            this.EntryDate_From.ShowCheckBox = true;
            this.EntryDate_From.Size = new System.Drawing.Size(222, 22);
            this.EntryDate_From.TabIndex = 632;
            // 
            // entrydate_label
            // 
            this.entrydate_label.AutoSize = true;
            this.entrydate_label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.entrydate_label.Location = new System.Drawing.Point(371, 98);
            this.entrydate_label.Name = "entrydate_label";
            this.entrydate_label.Size = new System.Drawing.Size(69, 16);
            this.entrydate_label.TabIndex = 631;
            this.entrydate_label.Text = "Entry Date";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.groupBox1.Controls.Add(this.noneRadioButton1);
            this.groupBox1.Controls.Add(this.falseRadioButton1);
            this.groupBox1.Controls.Add(this.trueRadioButton1);
            this.groupBox1.Location = new System.Drawing.Point(374, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 50);
            this.groupBox1.TabIndex = 637;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Success";
            // 
            // noneRadioButton1
            // 
            this.noneRadioButton1.AutoSize = true;
            this.noneRadioButton1.Checked = true;
            this.noneRadioButton1.Location = new System.Drawing.Point(154, 21);
            this.noneRadioButton1.Name = "noneRadioButton1";
            this.noneRadioButton1.Size = new System.Drawing.Size(61, 20);
            this.noneRadioButton1.TabIndex = 0;
            this.noneRadioButton1.TabStop = true;
            this.noneRadioButton1.Text = "None";
            this.noneRadioButton1.UseVisualStyleBackColor = true;
            // 
            // falseRadioButton1
            // 
            this.falseRadioButton1.AutoSize = true;
            this.falseRadioButton1.Location = new System.Drawing.Point(76, 21);
            this.falseRadioButton1.Name = "falseRadioButton1";
            this.falseRadioButton1.Size = new System.Drawing.Size(62, 20);
            this.falseRadioButton1.TabIndex = 0;
            this.falseRadioButton1.Text = "False";
            this.falseRadioButton1.UseVisualStyleBackColor = true;
            // 
            // trueRadioButton1
            // 
            this.trueRadioButton1.AutoSize = true;
            this.trueRadioButton1.Location = new System.Drawing.Point(14, 21);
            this.trueRadioButton1.Name = "trueRadioButton1";
            this.trueRadioButton1.Size = new System.Drawing.Size(56, 20);
            this.trueRadioButton1.TabIndex = 0;
            this.trueRadioButton1.Text = "True";
            this.trueRadioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(49, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 639;
            this.label2.Text = "Account ID";
            // 
            // accIdtextBox
            // 
            this.accIdtextBox.Location = new System.Drawing.Point(142, 61);
            this.accIdtextBox.Name = "accIdtextBox";
            this.accIdtextBox.Size = new System.Drawing.Size(200, 22);
            this.accIdtextBox.TabIndex = 640;
            this.accIdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accIdtextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(49, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 639;
            this.label3.Text = "Sector";
            // 
            // sectorComboBox
            // 
            this.sectorComboBox.FormattingEnabled = true;
            this.sectorComboBox.Location = new System.Drawing.Point(142, 137);
            this.sectorComboBox.Name = "sectorComboBox";
            this.sectorComboBox.Size = new System.Drawing.Size(200, 24);
            this.sectorComboBox.TabIndex = 641;
            // 
            // Searchbtn
            // 
            this.Searchbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Searchbtn.Location = new System.Drawing.Point(639, 128);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(137, 41);
            this.Searchbtn.TabIndex = 642;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = false;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // CountRecordsLbl
            // 
            this.CountRecordsLbl.AutoSize = true;
            this.CountRecordsLbl.BackColor = System.Drawing.SystemColors.Control;
            this.CountRecordsLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountRecordsLbl.Location = new System.Drawing.Point(138, 24);
            this.CountRecordsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CountRecordsLbl.Name = "CountRecordsLbl";
            this.CountRecordsLbl.Size = new System.Drawing.Size(139, 19);
            this.CountRecordsLbl.TabIndex = 644;
            this.CountRecordsLbl.Text = "[ 0 Record(s) Found. ]";
            // 
            // pax_label
            // 
            this.pax_label.AutoSize = true;
            this.pax_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pax_label.Location = new System.Drawing.Point(49, 101);
            this.pax_label.Name = "pax_label";
            this.pax_label.Size = new System.Drawing.Size(33, 16);
            this.pax_label.TabIndex = 645;
            this.pax_label.Text = "PAX";
            // 
            // paxTextBox
            // 
            this.paxTextBox.Location = new System.Drawing.Point(142, 97);
            this.paxTextBox.Name = "paxTextBox";
            this.paxTextBox.Size = new System.Drawing.Size(200, 22);
            this.paxTextBox.TabIndex = 640;
            this.paxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paxTextBox_KeyPress);
            // 
            // EventType
            // 
            this.EventType.DataPropertyName = "EventType";
            this.EventType.HeaderText = "EventType";
            this.EventType.MinimumWidth = 6;
            this.EventType.Name = "EventType";
            this.EventType.ReadOnly = true;
            this.EventType.Visible = false;
            this.EventType.Width = 125;
            // 
            // EntryDateTime
            // 
            this.EntryDateTime.DataPropertyName = "EventTimeUtc";
            this.EntryDateTime.HeaderText = "EntryDateTime";
            this.EntryDateTime.MinimumWidth = 6;
            this.EntryDateTime.Name = "EntryDateTime";
            this.EntryDateTime.ReadOnly = true;
            this.EntryDateTime.Width = 125;
            // 
            // TraceId
            // 
            this.TraceId.DataPropertyName = "TraceId";
            this.TraceId.HeaderText = "TraceId";
            this.TraceId.MinimumWidth = 6;
            this.TraceId.Name = "TraceId";
            this.TraceId.ReadOnly = true;
            this.TraceId.Visible = false;
            this.TraceId.Width = 125;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "UserName";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 125;
            // 
            // AccountId
            // 
            this.AccountId.DataPropertyName = "AccountId";
            this.AccountId.HeaderText = "AccountId";
            this.AccountId.MinimumWidth = 6;
            this.AccountId.Name = "AccountId";
            this.AccountId.ReadOnly = true;
            this.AccountId.Width = 125;
            // 
            // ApiName
            // 
            this.ApiName.DataPropertyName = "ApiName";
            this.ApiName.HeaderText = "ApiName";
            this.ApiName.MinimumWidth = 6;
            this.ApiName.Name = "ApiName";
            this.ApiName.ReadOnly = true;
            this.ApiName.Width = 125;
            // 
            // Origin
            // 
            this.Origin.DataPropertyName = "Origin";
            this.Origin.HeaderText = "Origin";
            this.Origin.MinimumWidth = 6;
            this.Origin.Name = "Origin";
            this.Origin.ReadOnly = true;
            this.Origin.Width = 125;
            // 
            // Destination
            // 
            this.Destination.DataPropertyName = "Destination";
            this.Destination.HeaderText = "Destination";
            this.Destination.MinimumWidth = 6;
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            this.Destination.Width = 125;
            // 
            // TravelDate
            // 
            this.TravelDate.DataPropertyName = "JourneyDate";
            this.TravelDate.HeaderText = "TravelDate";
            this.TravelDate.MinimumWidth = 6;
            this.TravelDate.Name = "TravelDate";
            this.TravelDate.ReadOnly = true;
            this.TravelDate.Width = 125;
            // 
            // Adult
            // 
            this.Adult.DataPropertyName = "Adult";
            this.Adult.HeaderText = "Adult";
            this.Adult.MinimumWidth = 6;
            this.Adult.Name = "Adult";
            this.Adult.ReadOnly = true;
            this.Adult.Width = 125;
            // 
            // Child
            // 
            this.Child.DataPropertyName = "Child";
            this.Child.HeaderText = "Child";
            this.Child.MinimumWidth = 6;
            this.Child.Name = "Child";
            this.Child.ReadOnly = true;
            this.Child.Width = 125;
            // 
            // Infant
            // 
            this.Infant.DataPropertyName = "Infant";
            this.Infant.HeaderText = "Infant";
            this.Infant.MinimumWidth = 6;
            this.Infant.Name = "Infant";
            this.Infant.ReadOnly = true;
            this.Infant.Visible = false;
            this.Infant.Width = 125;
            // 
            // ResultCount
            // 
            this.ResultCount.DataPropertyName = "ResultCount";
            this.ResultCount.HeaderText = "ResultCount";
            this.ResultCount.MinimumWidth = 6;
            this.ResultCount.Name = "ResultCount";
            this.ResultCount.ReadOnly = true;
            this.ResultCount.Width = 125;
            // 
            // ResponseTimeMs
            // 
            this.ResponseTimeMs.DataPropertyName = "ResponseTimeMs";
            this.ResponseTimeMs.HeaderText = "ResponseTimeMs";
            this.ResponseTimeMs.MinimumWidth = 6;
            this.ResponseTimeMs.Name = "ResponseTimeMs";
            this.ResponseTimeMs.ReadOnly = true;
            this.ResponseTimeMs.Visible = false;
            this.ResponseTimeMs.Width = 125;
            // 
            // ClientIP
            // 
            this.ClientIP.DataPropertyName = "ClientIP";
            this.ClientIP.HeaderText = "ClientIP";
            this.ClientIP.MinimumWidth = 6;
            this.ClientIP.Name = "ClientIP";
            this.ClientIP.ReadOnly = true;
            this.ClientIP.Visible = false;
            this.ClientIP.Width = 125;
            // 
            // Device
            // 
            this.Device.DataPropertyName = "Device";
            this.Device.HeaderText = "Device";
            this.Device.MinimumWidth = 6;
            this.Device.Name = "Device";
            this.Device.ReadOnly = true;
            this.Device.Visible = false;
            this.Device.Width = 125;
            // 
            // Success
            // 
            this.Success.DataPropertyName = "Success";
            this.Success.HeaderText = "Success";
            this.Success.MinimumWidth = 6;
            this.Success.Name = "Success";
            this.Success.ReadOnly = true;
            this.Success.Width = 125;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.DataPropertyName = "ErrorMessage";
            this.ErrorMessage.HeaderText = "ErrorMessage";
            this.ErrorMessage.MinimumWidth = 6;
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.ReadOnly = true;
            this.ErrorMessage.Width = 125;
            // 
            // export_to_excel
            // 
            this.export_to_excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.export_to_excel.BackColor = System.Drawing.Color.LightCyan;
            this.export_to_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.export_to_excel.Location = new System.Drawing.Point(12, 791);
            this.export_to_excel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.export_to_excel.Name = "export_to_excel";
            this.export_to_excel.Size = new System.Drawing.Size(167, 43);
            this.export_to_excel.TabIndex = 646;
            this.export_to_excel.Text = "Export To Excel";
            this.export_to_excel.UseVisualStyleBackColor = false;
            this.export_to_excel.Click += new System.EventHandler(this.export_to_excel_Click);
            // 
            // GridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 845);
            this.Controls.Add(this.export_to_excel);
            this.Controls.Add(this.pax_label);
            this.Controls.Add(this.CountRecordsLbl);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.sectorComboBox);
            this.Controls.Add(this.paxTextBox);
            this.Controls.Add(this.accIdtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TravelDate_To);
            this.Controls.Add(this.TravelDate_From);
            this.Controls.Add(this.travel_date_label);
            this.Controls.Add(this.entrydate_to);
            this.Controls.Add(this.EntryDate_From);
            this.Controls.Add(this.entrydate_label);
            this.Controls.Add(this.hrsPanelBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GridView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GridView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Hrs_Control.HrsPanelBox hrsPanelBox1;
        private System.Windows.Forms.DateTimePicker TravelDate_To;
        private System.Windows.Forms.DateTimePicker TravelDate_From;
        private System.Windows.Forms.Label travel_date_label;
        private System.Windows.Forms.DateTimePicker entrydate_to;
        private System.Windows.Forms.DateTimePicker EntryDate_From;
        private System.Windows.Forms.Label entrydate_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton falseRadioButton1;
        private System.Windows.Forms.RadioButton trueRadioButton1;
        private System.Windows.Forms.RadioButton noneRadioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accIdtextBox;
        private System.Windows.Forms.Label label3;
        private Hrs_Control.HrsComboBox sectorComboBox;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Label CountRecordsLbl;
        private System.Windows.Forms.Label pax_label;
        private System.Windows.Forms.TextBox paxTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TraceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApiName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Child;
        private System.Windows.Forms.DataGridViewTextBoxColumn Infant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponseTimeMs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Success;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorMessage;
        private System.Windows.Forms.Button export_to_excel;
    }
}