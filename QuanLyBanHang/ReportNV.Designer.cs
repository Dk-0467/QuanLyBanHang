namespace QuanLyBanHang
{
	partial class ReportNV
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
			this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.quanLyHangHoaDataSet = new QuanLyBanHang.QuanLyHangHoaDataSet();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.nhanVienTableAdapter = new QuanLyBanHang.QuanLyHangHoaDataSetTableAdapters.NhanVienTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyHangHoaDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// nhanVienBindingSource
			// 
			this.nhanVienBindingSource.DataMember = "NhanVien";
			this.nhanVienBindingSource.DataSource = this.quanLyHangHoaDataSet;
			// 
			// quanLyThueHangHoaDataSet
			// 
			this.quanLyHangHoaDataSet.DataSetName = "QuanLyHangHoaDataSet";
			this.quanLyHangHoaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer1
			// 
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.nhanVienBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanHang.ReportNV.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(22, 14);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(741, 343);
			this.reportViewer1.TabIndex = 0;
			this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
			// 
			// nhanVienTableAdapter
			// 
			this.nhanVienTableAdapter.ClearBeforeFill = true;
			// 
			// ReportNV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.reportViewer1);
			this.Name = "ReportNV";
			this.Text = "ReportNV";
			this.Load += new System.EventHandler(this.ReportNV_Load);
			((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyHangHoaDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private QuanLyHangHoaDataSet quanLyHangHoaDataSet;
		private System.Windows.Forms.BindingSource nhanVienBindingSource;
		private QuanLyHangHoaDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
	}
}