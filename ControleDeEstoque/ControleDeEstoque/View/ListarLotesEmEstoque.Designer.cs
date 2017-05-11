namespace ControleDeEstoque.View
{
    partial class ListarLotesEmEstoque
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
            this.listarLotesEmEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controleDeEstoqueDataSet = new ControleDeEstoque.ControleDeEstoqueDataSet();
            this.listarLotesEmEstoqueTableAdapter = new ControleDeEstoque.ControleDeEstoqueDataSetTableAdapters.ListarLotesEmEstoqueTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.listarLotesEmEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDeEstoqueDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.listarLotesEmEstoqueBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControleDeEstoque.View.ReportListaLotesEmEstoque.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(634, 261);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.ListarLotesEmEstoque_Load);
            // 
            // listarLotesEmEstoqueBindingSource
            // 
            this.listarLotesEmEstoqueBindingSource.DataMember = "ListarLotesEmEstoque";
            this.listarLotesEmEstoqueBindingSource.DataSource = this.controleDeEstoqueDataSet;
            // 
            // controleDeEstoqueDataSet
            // 
            this.controleDeEstoqueDataSet.DataSetName = "ControleDeEstoqueDataSet";
            this.controleDeEstoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listarLotesEmEstoqueTableAdapter
            // 
            this.listarLotesEmEstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // ListarLotesEmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ListarLotesEmEstoque";
            this.Text = "ListarLotesEmEstoque";
            this.Load += new System.EventHandler(this.ListarLotesEmEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listarLotesEmEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDeEstoqueDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ControleDeEstoqueDataSet controleDeEstoqueDataSet;
        private System.Windows.Forms.BindingSource listarLotesEmEstoqueBindingSource;
        private ControleDeEstoqueDataSetTableAdapters.ListarLotesEmEstoqueTableAdapter listarLotesEmEstoqueTableAdapter;
    }
}