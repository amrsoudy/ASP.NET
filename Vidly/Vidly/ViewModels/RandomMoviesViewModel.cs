using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RandomMoviesViewModel
    {
        public Movie movie { get; set; }
        public List<Customer> Customers { get; set; }
        
    }
}