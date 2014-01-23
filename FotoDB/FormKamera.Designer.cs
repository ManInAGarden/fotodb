namespace HSp.FotoDB
{
    partial class FormKamera
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.closeBU = new System.Windows.Forms.Button();
            this.kamerasLV = new System.Windows.Forms.ListView();
            this.NameColumn = new System.Windows.Forms.ColumnHeader();
            this.kameraCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplizierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kameraCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBU
            // 
            this.closeBU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.closeBU.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBU.Location = new System.Drawing.Point(13, 231);
            this.closeBU.Name = "closeBU";
            this.closeBU.Size = new System.Drawing.Size(75, 23);
            this.closeBU.TabIndex = 1;
            this.closeBU.Text = "Schließen";
            this.closeBU.UseVisualStyleBackColor = true;
            this.closeBU.Click += new System.EventHandler(this.closeBU_Click);
            // 
            // kamerasLV
            // 
            this.kamerasLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.kamerasLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn});
            this.kamerasLV.ContextMenuStrip = this.kameraCMS;
            this.kamerasLV.Location = new System.Drawing.Point(12, 12);
            this.kamerasLV.Name = "kamerasLV";
            this.kamerasLV.Size = new System.Drawing.Size(268, 213);
            this.kamerasLV.TabIndex = 2;
            this.kamerasLV.UseCompatibleStateImageBehavior = false;
            this.kamerasLV.View = System.Windows.Forms.View.Details;
            this.kamerasLV.DoubleClick += new System.EventHandler(this.kamerasLV_DoubleClick);
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Bezeichnung";
            this.NameColumn.Width = 200;
            // 
            // kameraCMS
            // 
            this.kameraCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.duplizierenToolStripMenuItem,
            this.löschenToolStripMenuItem});
            this.kameraCMS.Name = "kameraCMS";
            this.kameraCMS.Size = new System.Drawing.Size(127, 70);
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            this.neuToolStripMenuItem.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // duplizierenToolStripMenuItem
            // 
            this.duplizierenToolStripMenuItem.Name = "duplizierenToolStripMenuItem";
            this.duplizierenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.duplizierenToolStripMenuItem.Text = "Duplizieren";
            this.duplizierenToolStripMenuItem.Click += new System.EventHandler(this.duplizierenToolStripMenuItem_Click);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // FormKamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeBU;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.kamerasLV);
            this.Controls.Add(this.closeBU);
            this.Name = "FormKamera";
            this.Text = "Kameras";
            this.Load += new System.EventHandler(this.FormKamera_Load);
            this.kameraCMS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeBU;
        private System.Windows.Forms.ListView kamerasLV;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ContextMenuStrip kameraCMS;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplizierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
    }
}