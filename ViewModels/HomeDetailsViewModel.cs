using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TinyRobotsTools.Models;

namespace TinyRobotsTools.ViewModels
{
    public class HomeDetailsViewModel
    {
        public Order Order { get; set; }
        public int OrderId { get; set; }

        public string PageTitle { get; set; }

    }
}
