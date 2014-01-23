using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

using HSp.CsEpo;
using HSp.CsNman;

namespace HSp.FotoDB
{
    public partial class FormMaterial : Form
    {
        public FormMaterial()
        {
            InitializeComponent();
        }

        private void FormMaterial_Load(object sender, EventArgs e)
        {
            ArrayList matlist = FormMain.MaterialVerwo.Select();
           
            foreach (Material mat in matlist)
            {
                AddMatToList(materialLV, mat );
            }

            RegisterForDeletes();
            RegisterForFlushes();
        }


        /// <summary>
        /// Das Material auch von der Materialliste löschen
        /// </summary>
        /// <param name="msg"></param>
        void HandleMaterialDeletes(NMessage msg)
        {
            Material flushed = msg.Sender as Material;
            ListViewItem foundLit = null;

            foreach (ListViewItem lit in materialLV.Items)
            {
                if (lit.Tag.Equals(flushed))
                {
                    foundLit = lit;
                    materialLV.Items.Remove(foundLit);
                }

                if (foundLit != null) break;
            }
        }


        /// <summary>
        /// Änderungen in der Hauptfilmliste reflektieren
        /// </summary>
        /// <param name="msg"></param>
        void HandleMaterialFlushes(NMessage msg)
        {
            Material flushed = msg.Sender as Material;
            ListViewItem foundLit = null;

            foreach (ListViewItem lit in materialLV.Items)
            {
                if (lit.Tag.Equals(flushed))
                {
                    foundLit = lit;
                    materialLV.Items.Remove(foundLit);
                    AddMatToList(materialLV, flushed);
                }

                if (foundLit != null) break;
            }
        }


        public void RegisterForDeletes()
        {
            NDelegate HandleDeletesDelegate = new NDelegate(HandleMaterialDeletes);


            HSp.CsNman.Nman.Instance.Register("OBJDELETE" + FormMain.MaterialVerwo.ClassInfo().className, 
                this, 
                HandleDeletesDelegate);
        }

        public void RegisterForFlushes()
        {
            NDelegate HandleFlushesDelegate = new NDelegate(HandleMaterialFlushes);

            HSp.CsNman.Nman.Instance.Register("OBJFLUSH" + FormMain.MaterialVerwo.ClassInfo().className, 
                this, 
                HandleFlushesDelegate);
        }

        private void AddMatToList(ListView materialLV, Material mat)
        {
            ListViewItem liv = new ListViewItem();
            AddMatToLit(liv, mat);
            materialLV.Items.Add(liv);
        }

        private void AddMatToLit(ListViewItem liv, Material mat)
        {
            liv.Text = mat.Name;
            liv.Tag = mat;
            liv.SubItems.Add(mat.Asa.ToString());
            
            FilmArt fat = mat.ResolveOid(mat.ArtOid) as FilmArt;
            if (fat != null)
                liv.SubItems.Add(fat.Bezeichnung);
        }

        private void closeBU_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Material mat = new Material();
            mat.Flush();

            AddMatToList(materialLV, mat);
        }

       
        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selItCol = materialLV.SelectedItems;
            if (selItCol.Count != 1) return;

            ListViewItem lit = selItCol[0];
            if (lit.Tag == null) return;
            Material mat = lit.Tag as Material;
            if (mat == null) return;

            mat.Delete();
        }

        private void materialLV_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selCols = materialLV.SelectedItems;

            if (selCols.Count != 1) return;
            ListViewItem lit = selCols[0];
            if (lit.Tag == null) return;

            Material mat = lit.Tag as Material;
            if (mat == null) return;

            ViewMaterial vmat = new ViewMaterial(mat, this);
            vmat.Show();
        }

        private void materialDuplizierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selItCol = materialLV.SelectedItems;
            if (selItCol.Count != 1) return;

            ListViewItem lit = selItCol[0];
            if (lit.Tag == null) return;
            Material mat = lit.Tag as Material;
            if (mat == null) return;

            Material newMat = mat.Clone() as Material;
            newMat.Name = "*" + mat.Name;
            newMat.Flush();

            AddMatToList(materialLV, newMat);
        }
    }
}
