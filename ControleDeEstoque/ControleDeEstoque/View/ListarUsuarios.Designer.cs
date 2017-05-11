namespace ControleDeEstoque.View
{
    partial class ListarUsuarios
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
            this.controleDeEstoqueDataSet = new ControleDeEstoque.ControleDeEstoqueDataSet();
            this.listUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listUsuarioTableAdapter = new ControleDeEstoque.ControleDeEstoqueDataSetTableAdapters.ListUsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.controleDeEstoqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportListaUsuarios";
            reportDataSource1.Value = this.listUsuarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControleDeEstoque.View.ReportListaUsuarios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(636, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // controleDeEstoqueDataSet
            // 
            this.controleDeEstoqueDataSet.DataSetName = "ControleDeEstoqueDataSet";
            this.controleDeEstoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listUsuarioBindingSource
            // 
            this.listUsuarioBindingSource.DataMember = "ListUsuario";
            this.listUsuarioBindingSource.DataSource = this.controleDeEstoqueDataSet;
            // 
            // listUsuarioTableAdapter
            // 
            this.listUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // ListarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ListarUsuarios";
            this.Text = "ListarUsuarios";
            this.Load += new System.EventHandler(this.ListarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controleDeEstoqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ControleDeEstoqueDataSet controleDeEstoqueDataSet;
        private System.Windows.Forms.BindingSource listUsuarioBindingSource;
        private ControleDeEstoqueDataSetTableAdapters.ListUsuarioTableAdapter listUsuarioTableAdapter;
    }
}