using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recettes.DAL;

namespace Recettes.Forms
{
    public partial class MainForm : Form
    {
        RecetteProvider recetteProvider = new RecetteProvider();

        public MainForm()
        {
            InitializeComponent();

            recetteProvider.CountAll();
        }

        private void OuvrirNouvelleRecette()
        {
            RecetteEditForm recetteEditForm = new RecetteEditForm();
            recetteEditForm.ShowDialog();
        }

        #region Gestion des événements

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnNouvelleRecette_Click(object sender, EventArgs e)
        {
            OuvrirNouvelleRecette();
        }

        #endregion
    }
}
