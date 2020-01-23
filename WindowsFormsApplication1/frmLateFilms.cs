using System;
using System.Collections;
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
    public partial class frmLateFilms : Form
    {
        SortedList lateMovies = new SortedList();   //Create a sorted list
        int noOfFims;                               //Variable to store no of films
        int count = 0;                              //Counter to count no of films entered 
        public frmLateFilms()
        {
            InitializeComponent();
            frmFilmNameTB.Select();                  //Focus on text box after initializing the component 
        }


        //Action performed when we click the Ok button
        private void frmOkBtn_Click(object sender, EventArgs e)
        {
            if(noOfFims == 0)                                                   //If the count of film is 0
            {
                MessageBox.Show("You have entered 0 movies", "Info");           //Show message to user he has entered 0 movies 
            }else
            {
                String data = "You have entered the following movies \n";       //Create a data string for showing user movies he has entered 
                ICollection key = lateMovies.Keys;                              //Get the keys and add it to ICollection 
                foreach(int k in key)                                           //For Each key in keys
                {
                    data += k + "\t" + lateMovies[k] +"\n";                     //Append the movies to String data
                }
                MessageBox.Show(data, "Info");                                  //Show movies entered to user
            }
            this.DialogResult = DialogResult.OK;                                //Set the dialog result to OK
            this.Tag = noOfFims;                                                //Set tag to no of films 
                         
        }

        //Action performed when we click the Add button
        private void addMovie_Click(object sender, EventArgs e)
        {
            if (frmFilmNameTB.Text != "")                                   //Check if entered value is not blank
            {   
                lateMovies.Add(++count, frmFilmNameTB.Text);                //Add textbox value to sorted list collection
                noOfFims = lateMovies.Count;                                //get the count of collection
                frmFilmNameTB.Text = "";                                    //Set text box to blank
                frmFilmNameTB.Focus();                                      //Focus on text box
            }
            else
            {
                MessageBox.Show("You have not entered anything", "Entry Error");    //Show error to user text field is blank
            }
        }
    }
}
