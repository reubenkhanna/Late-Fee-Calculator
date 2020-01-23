using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMenu : Form
    {
        float totalLateFee=0; //Counter to calculate late fee
        public frmMenu()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void newReleaseBtn_Click(object sender, EventArgs e)
        {
            frmNewReleases NewReleases = new frmNewReleases();                  //Created new instance of form release 
            DialogResult dr = NewReleases.ShowDialog();                         //Get dialog result of new release form
            if(dr == DialogResult.OK && NewReleases.Tag != null)                //If dialog result if ok AND NewRelease Tag is not null
            {
                totalLateFee += float.Parse(NewReleases.Tag.ToString());        //get the tag value and add it to total late fee
                totalLateFeeM.Text = totalLateFee.ToString("c");                //Set the late fee value to late fee 
            }
         
        }


        private void libraryMoviesBtn_Click(object sender, EventArgs e)
        {
            frmLibraryMovies LibraryMovies = new frmLibraryMovies();                //Create new instance of library movies 
            DialogResult dr = LibraryMovies.ShowDialog();                           //Get dialog result of library movie form
            if (dr == DialogResult.OK && LibraryMovies.Tag != null)                 //If the dialog result is ok AND ibrary movie tag is not null
            {   
                totalLateFee += float.Parse(LibraryMovies.Tag.ToString());          //get the tag value and add it to total fee
                totalLateFeeM.Text = totalLateFee.ToString("c");                    //Set the late fee value to late fee
            }
        }


        private void kidsMoviesBtn_Click(object sender, EventArgs e)
        {
            frmKidsMovies KidsMovies = new frmKidsMovies();                         //Create new instance of kids movies 
            DialogResult dr = KidsMovies.ShowDialog();                              //Get dialog result of kids movies form 
            if (dr == DialogResult.OK && KidsMovies.Tag != null)                    //If the dialog result is ok and kid movies tag is not null
            {
                totalLateFee += float.Parse(KidsMovies.Tag.ToString());             //Get the tag value and add it to total fee
                totalLateFeeM.Text = totalLateFee.ToString("c");                    //Set the late fee value to late fee 
            }
        }

        private void MaintainFilm_Click(object sender, EventArgs e)
        {
            frmRentalMaintenance rentalMaintenance = new frmRentalMaintenance();
            rentalMaintenance.ShowDialog();
        }
    }
}
