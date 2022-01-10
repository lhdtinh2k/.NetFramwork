
namespace EFTurtorial
{
    partial class frmLopHoc
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
            this.dtgvLopHoc = new System.Windows.Forms.DataGridView();
            this.lopHocDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopHocDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lopHocDataTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qLSinhVienDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopHocBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.updateOrderOptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopHocTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopHocRowChangeEventHandlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopHocBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLSinhVienModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopHocVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopHocDLLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopHocDLLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocDataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocDataTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateOrderOptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocTableAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocRowChangeEventHandlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocDLLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocDLLBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvLopHoc
            // 
            this.dtgvLopHoc.AutoGenerateColumns = false;
            this.dtgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.totalStudentDataGridViewTextBoxColumn});
            this.dtgvLopHoc.DataSource = this.lopHocVMBindingSource;
            this.dtgvLopHoc.Location = new System.Drawing.Point(12, 50);
            this.dtgvLopHoc.Name = "dtgvLopHoc";
            this.dtgvLopHoc.RowHeadersWidth = 51;
            this.dtgvLopHoc.RowTemplate.Height = 24;
            this.dtgvLopHoc.Size = new System.Drawing.Size(463, 421);
            this.dtgvLopHoc.TabIndex = 0;
            this.dtgvLopHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lopHocDataTableBindingSource
            // 
            this.lopHocDataTableBindingSource.DataSource = typeof(EFTurtorial.QLSinhVienDataSet1.LopHocDataTable);
            // 
            // lopHocDataTableBindingSource1
            // 
            this.lopHocDataTableBindingSource1.DataSource = typeof(EFTurtorial.QLSinhVienDataSet1.LopHocDataTable);
            // 
            // lopHocDataTableBindingSource2
            // 
            this.lopHocDataTableBindingSource2.DataSource = typeof(EFTurtorial.QLSinhVienDataSet1.LopHocDataTable);
            // 
            // qLSinhVienDataSetBindingSource
            // 
            this.qLSinhVienDataSetBindingSource.DataSource = typeof(EFTurtorial.QLSinhVienDataSet);
            this.qLSinhVienDataSetBindingSource.Position = 0;
            // 
            // lopHocBindingSource2
            // 
            this.lopHocBindingSource2.DataMember = "LopHoc";
            this.lopHocBindingSource2.DataSource = typeof(EFTurtorial.QLSinhVienDataSet1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnXoa,
            this.btnThem,
            this.btnSua});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(487, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnXoa
            // 
            this.btnXoa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoa.Image = global::EFTurtorial.Properties.Resources.delete;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(59, 24);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThem.Image = global::EFTurtorial.Properties.Resources.add;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 24);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSua.Image = global::EFTurtorial.Properties.Resources.edit;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(58, 24);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // updateOrderOptionBindingSource
            // 
            this.updateOrderOptionBindingSource.DataSource = typeof(EFTurtorial.QLSinhVienDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption);
            // 
            // lopHocTableAdapterBindingSource
            // 
            this.lopHocTableAdapterBindingSource.DataSource = typeof(EFTurtorial.QLSinhVienDataSet1TableAdapters.LopHocTableAdapter);
            // 
            // lopHocRowChangeEventHandlerBindingSource
            // 
            this.lopHocRowChangeEventHandlerBindingSource.DataSource = typeof(EFTurtorial.QLSinhVienDataSet1.LopHocRowChangeEventHandler);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalStudentDataGridViewTextBoxColumn
            // 
            this.totalStudentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalStudentDataGridViewTextBoxColumn.DataPropertyName = "TotalStudent";
            this.totalStudentDataGridViewTextBoxColumn.HeaderText = "TotalStudent";
            this.totalStudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalStudentDataGridViewTextBoxColumn.Name = "totalStudentDataGridViewTextBoxColumn";
            // 
            // lopHocVMBindingSource
            // 
            this.lopHocVMBindingSource.DataSource = typeof(EFTurtorial.ViewModal.LopHocVM);
            // 
            // lopHocDLLBindingSource
            // 
            this.lopHocDLLBindingSource.DataSource = typeof(EFTurtorial.BLL.LopHocDLL);
            // 
            // lopHocDLLBindingSource1
            // 
            this.lopHocDLLBindingSource1.DataSource = typeof(EFTurtorial.BLL.LopHocDLL);
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataSource = typeof(EFTurtorial.DAL.SinhVien);
            // 
            // frmLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 514);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtgvLopHoc);
            this.Name = "frmLopHoc";
            this.Text = "QUAN LY LOP HOC";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocDataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocDataTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateOrderOptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocTableAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocRowChangeEventHandlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocDLLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocDLLBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource updateOrderOptionBindingSource;
        private System.Windows.Forms.DataGridView dtgvLopHoc;
        private System.Windows.Forms.BindingSource lopHocDataTableBindingSource;
        private System.Windows.Forms.BindingSource lopHocDataTableBindingSource1;
        private System.Windows.Forms.BindingSource lopHocTableAdapterBindingSource;
        private System.Windows.Forms.BindingSource lopHocRowChangeEventHandlerBindingSource;
        private System.Windows.Forms.BindingSource lopHocBindingSource;
        private System.Windows.Forms.BindingSource lopHocDLLBindingSource;
        private System.Windows.Forms.BindingSource lopHocDLLBindingSource1;
        private System.Windows.Forms.BindingSource lopHocBindingSource1;
        private System.Windows.Forms.BindingSource lopHocDataTableBindingSource2;
        private System.Windows.Forms.BindingSource qLSinhVienDataSetBindingSource;
        private System.Windows.Forms.BindingSource lopHocBindingSource2;
        private System.Windows.Forms.BindingSource qLSinhVienModelBindingSource;
   //     private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource lopHocVMBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalStudentDataGridViewTextBoxColumn;
    }
}