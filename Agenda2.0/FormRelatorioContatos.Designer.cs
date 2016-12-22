namespace Agenda2._0
{
    partial class FormRelatorioContatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioContatos));
            this.crvRelatorioContatos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrvContatos1 = new Agenda2._0.CrvContatos();
            this.SuspendLayout();
            // 
            // crvRelatorioContatos
            // 
            this.crvRelatorioContatos.ActiveViewIndex = 0;
            this.crvRelatorioContatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRelatorioContatos.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRelatorioContatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRelatorioContatos.Location = new System.Drawing.Point(0, 0);
            this.crvRelatorioContatos.Name = "crvRelatorioContatos";
            this.crvRelatorioContatos.ReportSource = this.CrvContatos1;
            this.crvRelatorioContatos.Size = new System.Drawing.Size(875, 511);
            this.crvRelatorioContatos.TabIndex = 0;
            this.crvRelatorioContatos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FormRelatorioContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 511);
            this.Controls.Add(this.crvRelatorioContatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRelatorioContatos";
            this.Text = "FormRelatorio";
            this.Load += new System.EventHandler(this.FormRelatorioContatos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRelatorioContatos;
        private CrvContatos CrvContatos1;
    }
}