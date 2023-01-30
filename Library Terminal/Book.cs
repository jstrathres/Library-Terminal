using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Terminal
{
    public class Book
    {
        //properties
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Status { get; set; }
        public DateTime DueDate { get; set; }   //maybe remove int


        public Book(string _title, string _author, bool _status, DateTime _dueDate)
        {
            Title = _title;
            Author = _author;
            Status = _status;
            DueDate = _dueDate;
        }


        public string GetDetails()
        {
            if (Status == true)
            {
                return $"{Title} by {Author} ";
            }
            else
            {
                return $"{Title} by {Author} ";
            }
        }

        public string statusCheck()
        {
            if (Status == true)
            {
                return "Is Available";
            }
            else
            {
                return "Not available";
            }
        }








    }

        

}







