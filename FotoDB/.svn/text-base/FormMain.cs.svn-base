using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using HSp.CsNman;
using HSp.CsEpo;

namespace HSp.FotoDB
{
    public partial class FormMain : Form
    {
        private static Kamera kameraVerwo;
        private static Material materialVerwo;
        private static FilmArt filmArtVerwo;
        private static Film filmVerwo;

        public FormMain()
        {
            InitializeComponent();
        }

        public static Kamera KameraVerwo {
            get { return kameraVerwo; }
        }

        public static Material MaterialVerwo {
            get { return materialVerwo; }
        }

        /// <summary>
        /// Änderungen in der Hauptfilmliste reflektieren
        /// </summary>
        /// <param name="msg"></param>
        void HandleFilmFlushes(NMessage msg)
        {
            Film flushed = msg.Sender as Film;
            ListViewItem foundLit = null;

            foreach (ListViewItem lit in filmeLV.Items)
            {
                if (lit.Tag.Equals(flushed))
                {
                    foundLit = lit;
                    filmeLV.Items.Remove(foundLit);
                    AddFilmToList(filmeLV, flushed);
                }

                if (foundLit!=null) break;
            }
        }

        /// <summary>
        /// Den Film auch von der Hauptfilmliste löschen
        /// </summary>
        /// <param name="msg"></param>
        void HandleFilmDeletes(NMessage msg)
        {
            Film flushed = msg.Sender as Film;
            ListViewItem foundLit = null;

            foreach (ListViewItem lit in filmeLV.Items)
            {
                if (lit.Tag.Equals(flushed))
                {
                    foundLit = lit;
                    filmeLV.Items.Remove(foundLit);
                }

                if (foundLit != null) break;
            }
        }

        public void RegisterForDeletes() {
            NDelegate HandleDeletesDelegate = new NDelegate(HandleFilmDeletes);


            HSp.CsNman.Nman.Instance.Register("OBJDELETE" + filmVerwo.ClassInfo().className, this, HandleDeletesDelegate);
        }

        public void RegisterForFlushes()
        {
             NDelegate HandleFlushesDelegate = new NDelegate(HandleFilmFlushes);

             HSp.CsNman.Nman.Instance.Register("OBJFLUSH" + filmVerwo.ClassInfo().className, this, HandleFlushesDelegate);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            string dbConnStr = Properties.Settings.Default.DBConnString;

            Trace.WriteLine("Initialisiere Datenbankverbindungen...");
            kameraVerwo = new Kamera(dbConnStr);
            filmArtVerwo = new FilmArt(dbConnStr);
            materialVerwo = new Material(dbConnStr);
            filmVerwo = new Film(dbConnStr);
            Trace.WriteLine("...fertig");

            Trace.WriteLine("Fülle Hauptfilmliste...");
            FillMainFilmlist();
            Trace.WriteLine("...fertig");

            RegisterForDeletes();
            RegisterForFlushes();

        }



        private void AddFilmToList(ListViewItem lit, Film fi)
        {
            lit.Text = fi.Id.ToString("0000");
            lit.Tag = fi;
            lit.SubItems.Add(fi.Titel);
            lit.SubItems.Add(fi.Jahr.ToString());

            Material mat = fi.ResolveOid(fi.MaterialOid) as Material;
            if (mat != null)
                lit.SubItems.Add(mat.Name);

            Kamera kam = fi.ResolveOid(fi.KameraOid) as Kamera;
            if (kam != null)
                lit.SubItems.Add(kam.Name);

        }

        private void AddFilmToList(ListView lv, Film fi) {
            
            ListViewItem lit = new ListViewItem();

            AddFilmToList(lit, fi);
            
            lv.Items.Add(lit);
        }


        private void FillMainFilmlist()
        {
            ArrayList erg = filmVerwo.Select();

            foreach (Film f in erg)
            {
                AddFilmToList(filmeLV, f);
            }
        }




        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void neuerFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Film nf = new Film();
           
            nf.Flush();

            AddFilmToList(filmeLV, nf);
        }

        private void filmeLV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filmeLV_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lit = filmeLV.SelectedItems[0];
            if (lit == null) return;
            ViewFilm vf = new ViewFilm(lit.Tag as Film, this);
            vf.Show();
        }

        private void filmLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lit = filmeLV.SelectedItems[0];

            if (lit == null) return;
            (lit.Tag as FotoDbBase).Delete();
        }

        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMaterial fmat = new FormMaterial();

            fmat.Show();

        }

        private void kameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKamera fcam = new FormKamera();

            fcam.Show();
        }

        private void bINEBoxEinlageDruckenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lit = filmeLV.SelectedItems[0];

            if (lit == null) return;

            Film f = lit.Tag as Film;

            if (f == null) return;

            BINEprintDoc.DocumentName = f.Titel;
            BINEPrintDialog.ShowDialog();
        }

        private void BINEprintDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ListViewItem lit = filmeLV.SelectedItems[0];

            if (lit == null) return;

            Film f = lit.Tag as Film;

            if (f == null) return;

            Graphics g = e.Graphics;
            Pen p = new Pen(Brushes.Black, 0.5F);
            Font titF = new Font("Arial", 15);
            Font normF = new Font("Arial", 10);
            string idstr = f.Id.ToString("d6");

            g.PageUnit = GraphicsUnit.Millimeter;
            
            //umgebender Kasten - Angaben in mm
            Point olp = new Point(0, 0);
            Point orp = new Point(152, 0);
            Point urp = new Point(152, 128);
            Point ulp = new Point(0, 128);

            //Klappenrücken in mm
            Point backol = new Point(0, 102);
            Point backor = new Point(152, 102);
            Point backur = new Point(152, 114);
            Point backul = new Point(0, 114);

            //Rand der Außenhülle zeichen
            g.DrawLine(p, olp, orp);
            g.DrawLine(p, orp, urp);
            g.DrawLine(p, urp, ulp);
            g.DrawLine(p, ulp, olp);

            g.DrawLine(p, backol, backor);
            g.DrawLine(p, backul, backur);

            //Texte auf dem Rücken der Außenhülle
            g.DrawString(f.Titel, titF, Brushes.Black, backol.X + 3, backol.Y + 1);
            g.DrawString(idstr + " : " + f.Jahr,
                titF,
                Brushes.Black,
                backol.X + 3,
                backol.Y + 6);

            if (f.KameraOid != null)
            {
                Kamera kam = f.ResolveOid(f.KameraOid) as Kamera;

                if(kam!=null)
                    g.DrawString("Kamera: " + kam.Name,
                        normF,
                        Brushes.Black,
                        backul.X + 3,
                        backul.Y + 3);
            }

            if (f.MaterialOid != null)
            {
                Material mat = f.ResolveOid(f.MaterialOid) as Material;

                if (mat != null)
                    g.DrawString("Material: " + mat.Name,
                        normF,
                        Brushes.Black,
                        backul.X + 3,
                        backul.Y + 7);
            }


            //Rand des Negativumschlags zeichen
            int negbr = 45;
            Point negolp = new Point(ulp.X, ulp.Y + 10);
            Point negorp = new Point(ulp.X + 174, negolp.Y);
            Point negurp = new Point(negorp.X, negolp.Y + 3*negbr - 2); //2mm kürzer damit die innere Lasche in die anderen hineinpasst
            Point negulp = new Point(ulp.X, negurp.Y);

            g.DrawLine(p, negolp, negorp);
            g.DrawLine(p, negorp, negurp);
            g.DrawLine(p, negurp, negulp);
            g.DrawLine(p, negulp, negolp);

            Point neg1l = new Point(negolp.X, negolp.Y + negbr);
            Point neg1r = new Point(negorp.X, neg1l.Y);
            Point neg2l = new Point(negolp.X, negolp.Y + 2* negbr);
            Point neg2r = new Point(negorp.X, neg2l.Y);

            g.DrawLine(p, neg1l, neg1r);
            g.DrawLine(p, neg2l, neg2r);

            //Text auf dem Negativumschlag
            Point textpos = new Point(negorp.X - 30, negorp.Y + negbr/2);
            
            g.DrawString(idstr,
                       normF,
                       Brushes.Black,
                       textpos.X,
                       textpos.Y);

        }

        private void filmDuplizierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lit = filmeLV.SelectedItems[0];

            if (lit == null) return;
            Film nf = (lit.Tag as Film).Clone() as Film;

            nf.Titel = "*" + nf.Titel;
            nf.Flush();

            AddFilmToList(filmeLV, nf);
        }
    }
}
