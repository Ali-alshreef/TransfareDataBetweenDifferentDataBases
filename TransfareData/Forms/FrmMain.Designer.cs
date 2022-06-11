
namespace TransfareData.Forms
{
    partial class FrmMain
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
            this.draiverNamesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.draiverNamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoadDataFromDB1 = new System.Windows.Forms.Button();
            this.btnTrnsfarDataToDB2 = new System.Windows.Forms.Button();
            this.merchantsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.merchantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblD1Count = new System.Windows.Forms.Label();
            this.lblD2Count = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.draiverNamesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.draiverNamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchantsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchantsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // draiverNamesDataGridView
            // 
            this.draiverNamesDataGridView.AllowUserToAddRows = false;
            this.draiverNamesDataGridView.AllowUserToDeleteRows = false;
            this.draiverNamesDataGridView.AutoGenerateColumns = false;
            this.draiverNamesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.draiverNamesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.draiverNamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.draiverNamesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.draiverNamesDataGridView.DataSource = this.draiverNamesBindingSource;
            this.draiverNamesDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.draiverNamesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.draiverNamesDataGridView.Name = "draiverNamesDataGridView";
            this.draiverNamesDataGridView.Size = new System.Drawing.Size(1224, 192);
            this.draiverNamesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DraiverNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "DraiverNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DraiverName";
            this.dataGridViewTextBoxColumn3.HeaderText = "DraiverName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cityid";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cityid";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn6.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // draiverNamesBindingSource
            // 
            this.draiverNamesBindingSource.DataSource = typeof(TransfareData.Data1.DraiverNames);
            // 
            // btnLoadDataFromDB1
            // 
            this.btnLoadDataFromDB1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadDataFromDB1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDataFromDB1.Location = new System.Drawing.Point(26, 228);
            this.btnLoadDataFromDB1.Name = "btnLoadDataFromDB1";
            this.btnLoadDataFromDB1.Size = new System.Drawing.Size(349, 47);
            this.btnLoadDataFromDB1.TabIndex = 2;
            this.btnLoadDataFromDB1.Text = "Load Data From DB1";
            this.btnLoadDataFromDB1.UseVisualStyleBackColor = true;
            this.btnLoadDataFromDB1.Click += new System.EventHandler(this.btnLoadDataFromDB1_Click);
            // 
            // btnTrnsfarDataToDB2
            // 
            this.btnTrnsfarDataToDB2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrnsfarDataToDB2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrnsfarDataToDB2.Location = new System.Drawing.Point(481, 228);
            this.btnTrnsfarDataToDB2.Name = "btnTrnsfarDataToDB2";
            this.btnTrnsfarDataToDB2.Size = new System.Drawing.Size(349, 47);
            this.btnTrnsfarDataToDB2.TabIndex = 3;
            this.btnTrnsfarDataToDB2.Text = "Transfer Data To DB2";
            this.btnTrnsfarDataToDB2.UseVisualStyleBackColor = true;
            this.btnTrnsfarDataToDB2.Click += new System.EventHandler(this.btnTrnsfarDataToDB2_Click);
            // 
            // merchantsDataGridView
            // 
            this.merchantsDataGridView.AllowUserToAddRows = false;
            this.merchantsDataGridView.AllowUserToDeleteRows = false;
            this.merchantsDataGridView.AutoGenerateColumns = false;
            this.merchantsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.merchantsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.merchantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.merchantsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewCheckBoxColumn5});
            this.merchantsDataGridView.DataSource = this.merchantsBindingSource;
            this.merchantsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.merchantsDataGridView.Location = new System.Drawing.Point(0, 281);
            this.merchantsDataGridView.Name = "merchantsDataGridView";
            this.merchantsDataGridView.Size = new System.Drawing.Size(1224, 335);
            this.merchantsDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn8.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Phone1";
            this.dataGridViewTextBoxColumn9.HeaderText = "Phone1";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Phone2";
            this.dataGridViewTextBoxColumn10.HeaderText = "Phone2";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Cityid";
            this.dataGridViewTextBoxColumn11.HeaderText = "Cityid";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Balance";
            this.dataGridViewTextBoxColumn12.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsCustomer";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsCustomer";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "IsSupplier";
            this.dataGridViewCheckBoxColumn2.HeaderText = "IsSupplier";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "IsDraiver";
            this.dataGridViewCheckBoxColumn3.HeaderText = "IsDraiver";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "IsClient";
            this.dataGridViewCheckBoxColumn4.HeaderText = "IsClient";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn13.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "UserId";
            this.dataGridViewTextBoxColumn14.HeaderText = "UserId";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "MachineName";
            this.dataGridViewTextBoxColumn15.HeaderText = "MachineName";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "CreateBy";
            this.dataGridViewTextBoxColumn16.HeaderText = "CreateBy";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "CreateOn";
            this.dataGridViewTextBoxColumn17.HeaderText = "CreateOn";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "IsOwnerGoods";
            this.dataGridViewCheckBoxColumn5.HeaderText = "IsOwnerGoods";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            // 
            // merchantsBindingSource
            // 
            this.merchantsBindingSource.DataSource = typeof(TransfareData.Data2.Merchants);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanges.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(880, 228);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(293, 47);
            this.btnSaveChanges.TabIndex = 4;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "DB1 Draivers Count";
            // 
            // lblD1Count
            // 
            this.lblD1Count.AutoSize = true;
            this.lblD1Count.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD1Count.Location = new System.Drawing.Point(167, 203);
            this.lblD1Count.Name = "lblD1Count";
            this.lblD1Count.Size = new System.Drawing.Size(16, 16);
            this.lblD1Count.TabIndex = 6;
            this.lblD1Count.Text = "0";
            // 
            // lblD2Count
            // 
            this.lblD2Count.AutoSize = true;
            this.lblD2Count.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD2Count.Location = new System.Drawing.Point(700, 203);
            this.lblD2Count.Name = "lblD2Count";
            this.lblD2Count.Size = new System.Drawing.Size(16, 16);
            this.lblD2Count.TabIndex = 8;
            this.lblD2Count.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(556, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "DB2 Draivers Count";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 616);
            this.Controls.Add(this.lblD2Count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblD1Count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.merchantsDataGridView);
            this.Controls.Add(this.btnTrnsfarDataToDB2);
            this.Controls.Add(this.btnLoadDataFromDB1);
            this.Controls.Add(this.draiverNamesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Data";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.draiverNamesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.draiverNamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchantsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchantsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource draiverNamesBindingSource;
        private System.Windows.Forms.DataGridView draiverNamesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnLoadDataFromDB1;
        private System.Windows.Forms.Button btnTrnsfarDataToDB2;
        private System.Windows.Forms.BindingSource merchantsBindingSource;
        private System.Windows.Forms.DataGridView merchantsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblD1Count;
        private System.Windows.Forms.Label lblD2Count;
        private System.Windows.Forms.Label label3;
    }
}