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
    public partial class frmLibraryMovies : Form
    {
        public Int32 totalNumberOfMovies = 0;
        public frmLibraryMovies()
        {
            InitializeComponent();
            //Add new items to comboboxitem to combobox
            frmCBBoxLM.Items.Add(new ComboBoxItem("New", "N"));
            frmCBBoxLM.Items.Add(new ComboBoxItem("Junior", "J"));
            frmCBBoxLM.Items.Add(new ComboBoxItem("Loyal", "L"));
            frmCBBoxLM.SelectedIndex = 0;                                   //Sets new as selected value of combobox  
            currentDateLM.Value = DateTime.Today;                           //Intitalize Current Date to Todays Date
            dueDateLM.MaxDate = DateTime.Today;                             //Set Max Date to Due Date Selector  
        }

        //This mehthod hides the current form and shows the main menu
        private void returnLM_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.DialogResult = DialogResult.OK;                                     //Set the dialog result to OK
        }

        //In this method we calculate the late fee based on the difference between the current date and the due date and multiplying it by LATE_FEE_FINE
        private void calculateLM_Click(object sender, EventArgs e)
        {
            try
            {
                const double LATE_FEE_FINE = 0.57;                                           //Late Fee Fine 
                DateTime dCurrent = DateTime.Now;                                            //Get Current Date
                DateTime dDue = dueDateLM.Value;                                             //Get Due Date Value
                TimeSpan days = (dCurrent.Date - dDue.Date);                                 //Get the difference between current date and due date
                double numberOFDays = days.TotalDays;                                        //Gets the number of days between current and due date
                noOfDaysLateLM.Text = numberOFDays.ToString();                               //Assigns the difference between current date and due date to noOfDaysLate text form on form

                bool showResult = int.TryParse(noOfMovieLM.Text, out totalNumberOfMovies);   //This checks if the value entered in noOfMovies is int or not if int return true and assign value to totalNumberOfMovies
                                                                                             //Check if the value entered by user is an integer 
                if (isValid())                                                               //check if the data entered is valid
                {
                    double lateFee = calculateLateFee(LATE_FEE_FINE, numberOFDays);          //Calculate Late Fee by calling calculate late fee method     
                    this.Tag = lateFee;                                                      //Late Fee value to Tag 
                    lateFeeLM.Text = lateFee.ToString("c");                                  //Assigns calculated late fee to lateFee text box on form 
                }


            }
            catch (Exception ex)                                                             //Catch exception if any
            {
                MessageBox.Show(ex.Message + "\n\n" +                                        //Show stack trace of exception
                    ex.GetType().ToString() + "\n\n" +
                    ex.StackTrace, "Exception");
            }

        }

        private double calculateLateFee(double LATE_FEE_FINE, double numberOFDays)
        {
            double lateFee = LATE_FEE_FINE * numberOFDays * totalNumberOfMovies;          //Calculates the Late Fee and assigns it to late fee variable
            double lateFeeAfterDiscount = lateFee - calculateDiscount(lateFee);           //Calculates Late Fee after discount subtract discounted value from latefee
            return lateFeeAfterDiscount;                                                  //Return the late fee value
        }

        //Check if data entered is valid 
        public bool isValid()
        {
            return isPresent(noOfMovieLM, "No of Movies") && IsInt32(noOfMovieLM, "No of Movies") && IsPositive(noOfMovieLM, "No of Movies");     //Calling all the validation functions
        }

        //Check if the value is entered if its present then return success else entry error
        public bool isPresent(Label textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + "is a required field.", "Entry Error"); //Show entry error if blank
                textBox.Focus();                                              //Change focust to text box 
                return false;
            }
            return true;
        }

        //Check if the value entered is positive or not 
        public bool IsPositive(Label textBox, string name)
        {
            int number = 0;
            Int32.TryParse(textBox.Text, out number);       //saves the value to number 
            if (number >= 0)
            {
                return true;                                                    //returns true if number greater than or equal to zero 
            }
            else
            {
                MessageBox.Show(name + "must be an postive interger.", "Entry Error");      //Show error if entry is not postive 
                textBox.Focus();                                                          //Change focust to text box 
                return false;
            }
        }

        //check if the value entered is integer 
        public bool IsInt32(Label textBox, string name)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;                                            //Retruns true if value entered is integer 
            }
            else
            {
                MessageBox.Show(name + "must be an interger.", "Entry Error"); // Show error if entry is not an integer 
                textBox.Focus();                                                //Change focust to text box 
                return false;
            }
        }


        //This function calculates the discount applicable based on the type of customer
        private double calculateDiscount(double lateFee)
        {

            switch ((frmCBBoxLM.SelectedItem as ComboBoxItem).Value.ToString())                 //Here wwe first cast the object as ComboBoxItem then get the selected Value which works as case
            {
                case "N":
                    return 0;                                                                   //If New customer return no discount;
                case "J":
                    return 0.05 * lateFee;                                                      //If Junior customer return 5% discount value on late fee
                case "L":
                    return 0.10 * lateFee;                                                      //If Loyal Customer return 10% discount value on late fee
                default:
                    return 0;                                                                   //If un recognized option return default no discount ;
            }
        }

        private void noOfMovieLM_KeyUp(object sender, KeyEventArgs e)
        {
            lateFeeLM.Text = "";                                                                //make latefee box blank
        }

        private void addMovie_Click(object sender, EventArgs e)
        {
            Form frmLateFilms = new frmLateFilms();                                 //Create Late Film Form Instance
            DialogResult okButton = frmLateFilms.ShowDialog();                      //Get the dialog result for late films
            if (okButton == DialogResult.OK)                                         //If the dialog result is ok 
            {
                noOfMovieLM.Text = frmLateFilms.Tag.ToString();                    //Change the text of noOfMovies to the value
            }
        }
    
    }
}
