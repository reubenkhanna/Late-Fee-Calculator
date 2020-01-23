using RentalMaintenance;
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
    public partial class frmRentalMaintenance : Form
    {
        public frmRentalMaintenance()
        {
            InitializeComponent();
        }
        List<RentalItem> rentalItems = null;                                        // A List of rental items instantiated as null
        private void FrmRentalMaintenance_Load(object sender, EventArgs e)          //On Form load event
        {
            rentalItems = RentalItemDB.GetMovies();                                 //Get All the moves from rental item db       
            FillMovieListBox();                                                     //Call fill movie list box method 
        }

        private void FillMovieListBox()
        {
            listMovieBox.Items.Clear();                                             //Clear the list movie box 
            foreach(RentalItem r in rentalItems)                                    //For each in rentalitems
            {   
                listMovieBox.Items.Add(r.GetDisplayText());                         //Add rentalitem to listmoviebox
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)                     //When Add button is clicked
        {
            frmNewMovie newMovie = new frmNewMovie();                               //Create a newMovie form object
            RentalItem rentalItem= newMovie.GetNewRental();                         //Call the GetNewRenatl method 
            if(rentalItem != null)                                                  //If Rental Item is not null
            {   
                rentalItems.Add(rentalItem);                                        //Add the itme to renta item lists
                RentalItemDB.SaveMovies(rentalItems);                               //Send the list to be added to db
                FillMovieListBox();                                                 //update the movie list box 
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)                         //When Delete button is clicked 
        {
            int i = listMovieBox.SelectedIndex;                                         //Get the index of selected item
            if(i != -1)                                                                 //If index is not -1 
            {
                RentalItem rentalItem = (RentalItem)rentalItems[i];                                       //Get the item from rental items list 
                string msg = "Are you sure you want to delete " + rentalItem.Description + "?";            //Message for user 
                DialogResult button = MessageBox.Show(msg,"Confirm Delete", MessageBoxButtons.YesNo);      //Show confirmation dialog to user 
                if(button == DialogResult.Yes)                                                             //If user selected yes
                {
                    rentalItems.Remove(rentalItem);                                                         //Remove item from list
                    RentalItemDB.SaveMovies(rentalItems);                                                   //Save the list to db
                    FillMovieListBox();                                                                     //Update the movie list box
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {   
            this.Close();                                                           //On click close, close the form 
        }
    }
}
