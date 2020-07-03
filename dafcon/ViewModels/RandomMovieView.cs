using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dafcon.Models;
//Model for the list of customers in the random scenario 

namespace dafcon.ViewModels
{
    public class RandomMovieView
    {
        public Movie Movie { get; set; }
        public List <Customer> Customer { get; set; }  
    }
}