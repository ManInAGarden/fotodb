using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HSp.CsEpo;
using HSp.CsNman;

namespace HSp.FotoDB
{
    public partial class FormKamera : Form
    {
        public FormKamera()
        {
            InitializeComponent();
        }

        private void FormKamera_Load(object sender, EventArgs e)
        {
            ArrayList kamlist = FormMain.KameraVerwo.Select();

            foreach (Kamera kam in kamlist)
            {
                AddKamToList(kamerasLV, kam);
            }

            RegisterForDeletes();
            RegisterForFlushes();
        }

        /// <summary>
        /// Das Material auch von der Materialliste löschen
        /// </summary>
        /// <param name="msg"></param>
        void HandleKameraDeletes(NMessage msg)
        {
            Kamera deleted = msg.Sender as Kamera;
            ListViewItem foundLit = null;

            foreach (ListViewItem lit in kamerasLV.Items)
            {
                if (lit.Tag.Equals(deleted))
                {
                    foundLit = lit;
                    kamerasLV.Items.Remove(foundLit);
                }

                if (foundLit != null) break;
            }
        }


        /// <summary>
        /// Änderungen in der Hauptfilmliste reflektieren
        /// </summary>
        /// <param name="msg"></param>
        void HandleKameraFlushes(NMessage msg)
        {
            Kamera flushed = msg.Sender as Kamera;
            ListViewItem foundLit = null;

            foreach (ListViewItem lit in kamerasLV.Items)
            {
                if (lit.Tag.Equals(flushed))
                {
                    foundLit = lit;
                    kamerasLV.Items.Remove(foundLit);
                    AddKamToList(kamerasLV, flushed);
                }

                if (foundLit != null) break;
            }
        }


        public void RegisterForDeletes()
        {
            NDelegate HandleDeletesDelegate = new NDelegate(HandleKameraDeletes);


            HSp.CsNman.Nman.Instance.Register("OBJDELETE" + FormMain.KameraVerwo.ClassInfo().className,
                this,
                HandleDeletesDelegate);
        }

        public void RegisterForFlushes()
        {
            NDelegate HandleFlushesDelegate = new NDelegate(HandleKameraFlushes);

            HSp.CsNman.Nman.Instance.Register("OBJFLUSH" + FormMain.KameraVerwo.ClassInfo().className,
                this,
                HandleFlushesDelegate);
        }

        private void AddKamToList(ListView kamerasLV, Kamera kam)
        {
            ListViewItem liv = new ListViewItem();
            AddKamToLit(liv, kam);
            kamerasLV.Items.Add(liv);
        }

        private void AddKamToLit(ListViewItem liv, Kamera kam)
        {
            liv.Text = kam.Name;
            liv.Tag = kam;
            
            //liv.SubItems.Add(mat.Asa.ToString());

            //FilmArt fat = mat.ResolveOid(mat.ArtOid) as FilmArt;
            //if (fat != null)
            //    liv.SubItems.Add(fat.Bezeichnung);
        }

        private void closeBU_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kamera kam = new Kamera();
            kam.Flush();

            AddKamToList(kamerasLV, kam);
        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selItCol = kamerasLV.SelectedItems;
            if (selItCol.Count != 1) return;

            ListViewItem lit = selItCol[0];
            if (lit.Tag == null) return;
            Kamera kam = lit.Tag as Kamera;
            if (kam == null) return;

            kam.Delete();
        }

        private void duplizierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selItCol = kamerasLV.SelectedItems;
            if (selItCol.Count != 1) return;

            ListViewItem lit = selItCol[0];
            if (lit.Tag == null) return;
            Kamera kam = lit.Tag as Kamera;
            if (kam == null) return;

            Kamera newKam = kam.Clone() as Kamera;
            newKam.Name = "*" + kam.Name;
            newKam.Flush();

            AddKamToList(kamerasLV, newKam);
        }

        private void kamerasLV_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selCols = kamerasLV.SelectedItems;

            if (selCols.Count != 1) return;
            ListViewItem lit = selCols[0];
            if (lit.Tag == null) return;

            Kamera kam = lit.Tag as Kamera;
            if (kam == null) return;

            ViewKamera vkam = new ViewKamera(kam, this);
            vkam.Show();
        }
    }
}
