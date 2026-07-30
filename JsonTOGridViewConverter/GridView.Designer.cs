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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.PAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponseTimeMs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Success = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.PAX,
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
            this.dataGridView1.Size = new System.Drawing.Size(1679, 640);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1679, 150);
            this.panel1.TabIndex = 1;
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
            // PAX
            // 
            this.PAX.HeaderText = "PAX";
            this.PAX.MinimumWidth = 6;
            this.PAX.Name = "PAX";
            this.PAX.ReadOnly = true;
            this.PAX.Width = 125;
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
            // GridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 845);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GridView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GridView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn PAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponseTimeMs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Success;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorMessage;
    }
}