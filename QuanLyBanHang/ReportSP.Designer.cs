namespace QuanLyBanHang
{
	partial class ReportSP
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
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.sanPhamBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.quanLyHangHoaDataSet = new QuanLyBanHang.QuanLyHangHoaDataSet();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.sanPhamTableAdapter = new QuanLyBanHang.QuanLyHangHoaDataSetTableAdapters.SanPhamTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyHangHoaDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// sanPhamBindingSource1
			// 
			this.sanPhamBindingSource1.DataMember = "SanPham";
			this.sanPhamBindingSource1.DataSource = this.quanLyHangHoaDataSet;
			// 
			// quanLyHangHoaDataSet
			// 
			this.quanLyHangHoaDataSet.DataSetName = "QuanLyHangHoaDataSet";
			this.quanLyHangHoaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer1
			// 
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.sanPhamBindingSource1;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanHang.ReportSP.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(15, 19);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(766, 358);
			this.reportViewer1.TabIndex = 0;
			this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
			// 
			// sanPhamTableAdapter
			// 
			this.sanPhamTableAdapter.ClearBeforeFill = true;
			// 
			// ReportSP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.reportViewer1);
			this.Name = "ReportSP";
			this.Text = "ReportSP";
			this.Load += new System.EventHandler(this.ReportSP_Load);
			((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyHangHoaDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private QuanLyHangHoaDataSet quanLyHangHoaDataSet;
	
		private QuanLyHangHoaDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
		private System.Windows.Forms.BindingSource sanPhamBindingSource1;
	}
}