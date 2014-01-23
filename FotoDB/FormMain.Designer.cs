namespace HSp.FotoDB
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.kameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inhaltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überFotoDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.filmeLV = new System.Windows.Forms.ListView();
            this.idColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.titleColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.jahrColumn = new System.Windows.Forms.ColumnHeader();
            this.materialColumn = new System.Windows.Forms.ColumnHeader();
            this.kameraColumn = new System.Windows.Forms.ColumnHeader();
            this.mainListCM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.neuerFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmDuplizierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bINEBoxEinlageDruckenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BINEPrintDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.BINEprintDoc = new System.Drawing.Printing.PrintDocument();
            this.mainMenuStrip.SuspendLayout();
            this.mainListCM.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.hilfeToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(523, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kameraToolStripMenuItem,
            this.materialToolStripMenuItem,
            this.toolStripMenuItem2,
            this.beendenToolStripMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(44, 20);
            this.fileMenu.Text = "Datei";
            // 
            // kameraToolStripMenuItem
            // 
            this.kameraToolStripMenuItem.Name = "kameraToolStripMenuItem";
            this.kameraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kameraToolStripMenuItem.Text = "Kamera";
            this.kameraToolStripMenuItem.Click += new System.EventHandler(this.kameraToolStripMenuItem_Click);
            // 
            // materialToolStripMenuItem
            // 
            this.materialToolStripMenuItem.Name = "materialToolStripMenuItem";
            this.materialToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.materialToolStripMenuItem.Text = "Material";
            this.materialToolStripMenuItem.Click += new System.EventHandler(this.materialToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inhaltToolStripMenuItem,
            this.überFotoDBToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // inhaltToolStripMenuItem
            // 
            this.inhaltToolStripMenuItem.Name = "inhaltToolStripMenuItem";
            this.inhaltToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inhaltToolStripMenuItem.Text = "Inhalt";
            // 
            // überFotoDBToolStripMenuItem
            // 
            this.überFotoDBToolStripMenuItem.Name = "überFotoDBToolStripMenuItem";
            this.überFotoDBToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.überFotoDBToolStripMenuItem.Text = "Über FotoDB";
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 465);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(523, 22);
            this.mainStatusStrip.TabIndex = 1;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // filmeLV
            // 
            this.filmeLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumnHeader,
            this.titleColumnHeader,
            this.jahrColumn,
            this.materialColumn,
            this.kameraColumn});
            this.filmeLV.ContextMenuStrip = this.mainListCM;
            this.filmeLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filmeLV.FullRowSelect = true;
            this.filmeLV.Location = new System.Drawing.Point(0, 24);
            this.filmeLV.MultiSelect = false;
            this.filmeLV.Name = "filmeLV";
            this.filmeLV.ShowItemToolTips = true;
            this.filmeLV.Size = new System.Drawing.Size(523, 441);
            this.filmeLV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.filmeLV.TabIndex = 2;
            this.filmeLV.UseCompatibleStateImageBehavior = false;
            this.filmeLV.View = System.Windows.Forms.View.Details;
            this.filmeLV.SelectedIndexChanged += new System.EventHandler(this.filmeLV_SelectedIndexChanged);
            this.filmeLV.DoubleClick += new System.EventHandler(this.filmeLV_DoubleClick);
            // 
            // idColumnHeader
            // 
            this.idColumnHeader.Tag = "Id";
            this.idColumnHeader.Text = "ID";
            this.idColumnHeader.Width = 40;
            // 
            // titleColumnHeader
            // 
            this.titleColumnHeader.Tag = "Title";
            this.titleColumnHeader.Text = "Titel";
            this.titleColumnHeader.Width = 250;
            // 
            // jahrColumn
            // 
            this.jahrColumn.DisplayIndex = 4;
            this.jahrColumn.Text = "Jahr";
            this.jahrColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // materialColumn
            // 
            this.materialColumn.DisplayIndex = 2;
            this.materialColumn.Text = "Material";
            this.materialColumn.Width = 80;
            // 
            // kameraColumn
            // 
            this.kameraColumn.DisplayIndex = 3;
            this.kameraColumn.Text = "Kamera";
            // 
            // mainListCM
            // 
            this.mainListCM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuerFilmToolStripMenuItem,
            this.filmLöschenToolStripMenuItem,
            this.filmDuplizierenToolStripMenuItem,
            this.bINEBoxEinlageDruckenToolStripMenuItem});
            this.mainListCM.Name = "mainListCM";
            this.mainListCM.Size = new System.Drawing.Size(198, 92);
            // 
            // neuerFilmToolStripMenuItem
            // 
            this.neuerFilmToolStripMenuItem.Name = "neuerFilmToolStripMenuItem";
            this.neuerFilmToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.neuerFilmToolStripMenuItem.Text = "Neuer Film";
            this.neuerFilmToolStripMenuItem.Click += new System.EventHandler(this.neuerFilmToolStripMenuItem_Click);
            // 
            // filmLöschenToolStripMenuItem
            // 
            this.filmLöschenToolStripMenuItem.Name = "filmLöschenToolStripMenuItem";
            this.filmLöschenToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.filmLöschenToolStripMenuItem.Text = "Film löschen";
            this.filmLöschenToolStripMenuItem.Click += new System.EventHandler(this.filmLöschenToolStripMenuItem_Click);
            // 
            // filmDuplizierenToolStripMenuItem
            // 
            this.filmDuplizierenToolStripMenuItem.Name = "filmDuplizierenToolStripMenuItem";
            this.filmDuplizierenToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.filmDuplizierenToolStripMenuItem.Text = "Film duplizieren";
            this.filmDuplizierenToolStripMenuItem.Click += new System.EventHandler(this.filmDuplizierenToolStripMenuItem_Click);
            // 
            // bINEBoxEinlageDruckenToolStripMenuItem
            // 
            this.bINEBoxEinlageDruckenToolStripMenuItem.Name = "bINEBoxEinlageDruckenToolStripMenuItem";
            this.bINEBoxEinlageDruckenToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.bINEBoxEinlageDruckenToolStripMenuItem.Text = "BINE Box Einlage Drucken";
            this.bINEBoxEinlageDruckenToolStripMenuItem.Click += new System.EventHandler(this.bINEBoxEinlageDruckenToolStripMenuItem_Click);
            // 
            // BINEPrintDialog
            // 
            this.BINEPrintDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.BINEPrintDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.BINEPrintDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.BINEPrintDialog.Document = this.BINEprintDoc;
            this.BINEPrintDialog.Enabled = true;
            this.BINEPrintDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("BINEPrintDialog.Icon")));
            this.BINEPrintDialog.Name = "BINEPrintDialog";
            this.BINEPrintDialog.UseAntiAlias = true;
            this.BINEPrintDialog.Visible = false;
            // 
            // BINEprintDoc
            // 
            this.BINEprintDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.BINEprintDoc_PrintPage);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 487);
            this.Controls.Add(this.filmeLV);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "FormMain";
            this.Text = "Foto DB";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainListCM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem kameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inhaltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überFotoDBToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ListView filmeLV;
        private System.Windows.Forms.ContextMenuStrip mainListCM;
        private System.Windows.Forms.ToolStripMenuItem neuerFilmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmLöschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmDuplizierenToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader idColumnHeader;
        private System.Windows.Forms.ColumnHeader titleColumnHeader;
        private System.Windows.Forms.ColumnHeader materialColumn;
        private System.Windows.Forms.ColumnHeader kameraColumn;
        private System.Windows.Forms.ColumnHeader jahrColumn;
        private System.Windows.Forms.ToolStripMenuItem bINEBoxEinlageDruckenToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog BINEPrintDialog;
        private System.Drawing.Printing.PrintDocument BINEprintDoc;
    }
}

