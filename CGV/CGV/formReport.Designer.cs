
namespace CGV
{
    partial class formReport
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
            this.reportGenerator1 = new DevExpress.XtraReports.ReportGeneration.ReportGenerator(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLCGVDataSet = new CGV.QLCGVDataSet();
            this.TicketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TicketTableAdapter = new CGV.QLCGVDataSetTableAdapters.TicketTableAdapter();
            this.QLCGVDataSet1 = new CGV.QLCGVDataSet1();
            this.SelectShowTimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SelectShowTimeTableAdapter = new CGV.QLCGVDataSet1TableAdapters.SelectShowTimeTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QLCGVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCGVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectShowTimeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SelectShowTimeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CGV.Report.reportTicket.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 71);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1233, 605);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLCGVDataSet
            // 
            this.QLCGVDataSet.DataSetName = "QLCGVDataSet";
            this.QLCGVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TicketBindingSource
            // 
            this.TicketBindingSource.DataMember = "Ticket";
            this.TicketBindingSource.DataSource = this.QLCGVDataSet;
            // 
            // TicketTableAdapter
            // 
            this.TicketTableAdapter.ClearBeforeFill = true;
            // 
            // QLCGVDataSet1
            // 
            this.QLCGVDataSet1.DataSetName = "QLCGVDataSet1";
            this.QLCGVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SelectShowTimeBindingSource
            // 
            this.SelectShowTimeBindingSource.DataMember = "SelectShowTime";
            this.SelectShowTimeBindingSource.DataSource = this.QLCGVDataSet1;
            // 
            // SelectShowTimeTableAdapter
            // 
            this.SelectShowTimeTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(56, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "( Mã Lịch chiếu)";
            // 
            // formReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 680);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "formReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formReport";
            this.Load += new System.EventHandler(this.formReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLCGVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCGVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectShowTimeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraReports.ReportGeneration.ReportGenerator reportGenerator1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TicketBindingSource;
        private QLCGVDataSet QLCGVDataSet;
        private QLCGVDataSetTableAdapters.TicketTableAdapter TicketTableAdapter;
        private System.Windows.Forms.BindingSource SelectShowTimeBindingSource;
        private QLCGVDataSet1 QLCGVDataSet1;
        private QLCGVDataSet1TableAdapters.SelectShowTimeTableAdapter SelectShowTimeTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}