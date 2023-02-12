namespace InventoryBase
{
    partial class HomePage
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
            this.dataGridViewDeviceLogs = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBoxHardwareNo = new System.Windows.Forms.TextBox();
            this.txtBoxBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.txtFaultStatus = new System.Windows.Forms.TextBox();
            this.lblHardware = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.lblFaultStatus = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeviceLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDeviceLogs
            // 
            this.dataGridViewDeviceLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeviceLogs.Location = new System.Drawing.Point(12, 21);
            this.dataGridViewDeviceLogs.Name = "dataGridViewDeviceLogs";
            this.dataGridViewDeviceLogs.RowTemplate.Height = 25;
            this.dataGridViewDeviceLogs.Size = new System.Drawing.Size(486, 289);
            this.dataGridViewDeviceLogs.TabIndex = 0;
            this.dataGridViewDeviceLogs.SelectionChanged += new System.EventHandler(this.dataGridViewDeviceLogs_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSave.Location = new System.Drawing.Point(681, 357);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBoxHardwareNo
            // 
            this.txtBoxHardwareNo.Location = new System.Drawing.Point(613, 55);
            this.txtBoxHardwareNo.Name = "txtBoxHardwareNo";
            this.txtBoxHardwareNo.Size = new System.Drawing.Size(143, 23);
            this.txtBoxHardwareNo.TabIndex = 2;
            // 
            // txtBoxBrand
            // 
            this.txtBoxBrand.Location = new System.Drawing.Point(613, 111);
            this.txtBoxBrand.Name = "txtBoxBrand";
            this.txtBoxBrand.Size = new System.Drawing.Size(143, 23);
            this.txtBoxBrand.TabIndex = 3;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(613, 164);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(143, 23);
            this.txtModel.TabIndex = 4;
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Location = new System.Drawing.Point(613, 218);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(143, 23);
            this.txtSerialNo.TabIndex = 5;
            // 
            // txtFaultStatus
            // 
            this.txtFaultStatus.Location = new System.Drawing.Point(609, 266);
            this.txtFaultStatus.Name = "txtFaultStatus";
            this.txtFaultStatus.Size = new System.Drawing.Size(143, 23);
            this.txtFaultStatus.TabIndex = 6;
            // 
            // lblHardware
            // 
            this.lblHardware.AutoSize = true;
            this.lblHardware.Location = new System.Drawing.Point(525, 63);
            this.lblHardware.Name = "lblHardware";
            this.lblHardware.Size = new System.Drawing.Size(58, 15);
            this.lblHardware.TabIndex = 8;
            this.lblHardware.Text = "Hardware";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(525, 119);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(38, 15);
            this.lblBrand.TabIndex = 9;
            this.lblBrand.Text = "Brand";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(525, 172);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(41, 15);
            this.lblModel.TabIndex = 10;
            this.lblModel.Text = "Model";
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Location = new System.Drawing.Point(525, 226);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(82, 15);
            this.lblSerialNumber.TabIndex = 11;
            this.lblSerialNumber.Text = "Serial Number";
            // 
            // lblFaultStatus
            // 
            this.lblFaultStatus.AutoSize = true;
            this.lblFaultStatus.Location = new System.Drawing.Point(525, 274);
            this.lblFaultStatus.Name = "lblFaultStatus";
            this.lblFaultStatus.Size = new System.Drawing.Size(68, 15);
            this.lblFaultStatus.TabIndex = 12;
            this.lblFaultStatus.Text = "Fault Status";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(609, 357);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 32);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(525, 322);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 15);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Date";
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Location = new System.Drawing.Point(613, 314);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(143, 23);
            this.txtBoxDate.TabIndex = 17;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.Color.Snow;
            this.btnDelete.Location = new System.Drawing.Point(342, 314);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdate.ForeColor = System.Drawing.Color.Snow;
            this.btnUpdate.Location = new System.Drawing.Point(423, 316);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtBoxDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblFaultStatus);
            this.Controls.Add(this.lblSerialNumber);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblHardware);
            this.Controls.Add(this.txtFaultStatus);
            this.Controls.Add(this.txtSerialNo);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtBoxBrand);
            this.Controls.Add(this.txtBoxHardwareNo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridViewDeviceLogs);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeviceLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewDeviceLogs;
        private Button btnSave;
        private TextBox txtBoxHardwareNo;
        private TextBox txtBoxBrand;
        private TextBox txtModel;
        private TextBox txtSerialNo;
        private TextBox txtFaultStatus;
        private Label lblHardware;
        private Label lblBrand;
        private Label lblModel;
        private Label lblSerialNumber;
        private Label lblFaultStatus;
        private Button btnClear;
        private Label lblDate;
        private TextBox txtBoxDate;
        private Button btnDelete;
        private Button btnUpdate;
    }
}