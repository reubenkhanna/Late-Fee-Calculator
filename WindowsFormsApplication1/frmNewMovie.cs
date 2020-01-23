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
    public partial class frmNewMovie : Form
    {
        public frmNewMovie()
        {
            InitializeComponent();
            
            cbNMRating.Items.Add(new ComboBoxItem("G", "G"));                           // Add Combo box item for ratings  
            cbNMRating.Items.Add(new ComboBoxItem("PG", "PG"));                         // Add Combo box item for ratings 
            cbNMRating.Items.Add(new ComboBoxItem("PG-13", "PG-13"));                   // Add Combo box item for ratings 
            cbNMRating.Items.Add(new ComboBoxItem("R", "R"));                           // Add Combo box item for ratings 
            cbNMRating.Items.Add(new ComboBoxItem("X", "X"));                           // Add Combo box item for ratings 
            cbNMRating.SelectedIndex=0;                                                 //Select the first value as default for combobox 
        }

        private RentalItem rentalItem = null;                                           //Instantiate RentalItem Class as null

        //Method to create dialog of current form and return rental item at the end
        public RentalItem GetNewRental()
        {
            this.ShowDialog();                                                          //Creates dialog of current form
            return rentalItem;                                                          //Return rental Item
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();                                                                 //Closes the form when we click btn close
        }

        //Check for validation 
        private bool IsValidData()
        {
            return Validator.IsPresent(lblNMDesc) && Validator.IsPresent(lblNMMno) && Validator.IsInt32(lblNMMno); // Calls Validator function to check validity of data 
        }

        //Function called on add button clicked 
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())                                                      //Check if data is valid 
            {
                //Create a new renatalItem objec with Movie no , Description and Rating 
                rentalItem = new RentalItem(Convert.ToInt32(lblNMMno.Text), 
                    lblNMDesc.Text,
                    cbNMRating.Text);
                this.Close();                                                        //Close the form 
            }
        }
    }
}
