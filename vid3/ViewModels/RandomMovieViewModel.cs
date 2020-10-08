using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vid3.Models;

namespace vid3.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}