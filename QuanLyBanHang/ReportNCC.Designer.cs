namespace QuanLyBanHang
{
	partial class ReportNCC
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
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.quanLyHangHoaDataSet = new QuanLyBanHang.QuanLyHangHoaDataSet();
			this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nhaCungCapTableAdapter = new QuanLyBanHang.QuanLyHangHoaDataSetTableAdapters.NhaCungCapTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.quanLyHangHoaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.nhaCungCapBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanHang.ReportNCC.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(37, 22);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(487, 295);
			this.reportViewer1.TabIndex = 0;
			// 
			// quanLyHangHoaDataSet
			// 
			this.quanLyHangHoaDataSet.DataSetName = "QuanLyHangHoaDataSet";
			this.quanLyHangHoaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// nhaCungCapBindingSource
			// 
			this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
			this.nhaCungCapBindingSource.DataSource = this.quanLyHangHoaDataSet;
			// 
			// nhaCungCapTableAdapter
			// 
			this.nhaCungCapTableAdapter.ClearBeforeFill = true;
			// 
			// ReportNCC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.reportViewer1);
			this.Name = "ReportNCC";
			this.Text = "ReportNCC";
			this.Load += new System.EventHandler(this.ReportNCC_Load);
			((System.ComponentModel.ISupportInitialize)(this.quanLyHangHoaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private QuanLyHangHoaDataSet quanLyHangHoaDataSet;
		private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
		private QuanLyHangHoaDataSetTableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
	}
}