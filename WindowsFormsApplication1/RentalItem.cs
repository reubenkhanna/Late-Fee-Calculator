using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class RentalItem
    {
        //Variables to store Movie No, Description, Ratings 
        private int  movieNo;          
        private string description;
        private string rating;

        //All Argument constructor for rental item
        public RentalItem(int movieNo, string description, string rating)
        {
            this.MovieNo = movieNo;
            this.Description = description;
            this.Rating = rating;
        }

        //Default Constructor of Rental Item
        public RentalItem()
        {
            
        }

        //Getter setter for MovieNo
        public int MovieNo
        {
            get
            {
                return movieNo;
            }

            set
            {
                movieNo = value;
            }
        }

        //Getter Setter for Description 
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        //Getter Setter for Rating 
        public string Rating
        {
            get
            {
                return rating;
            }

            set
            {
                rating = value;
            }
        }

        //Use to display text using movie no, description rating
        public string GetDisplayText()
        {
            return MovieNo + "\t" + Description + " " + rating;     //returns movie no, description and rating with proper space
        }
    }
}
