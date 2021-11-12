using BlazorMUCsrv.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMUCsrv.Pages.modul4
{
    public class Asynctest
    {
        public Asynctest()
        {
            var x = new northwindContext();
            var y = x.Customers.ToListAsync(); //using Microsoft.EntityFrameworkCore;
        }
    }
}
