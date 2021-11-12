using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMUCsrv.Pages.modul5
{
    public class Person
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="da muss was rein")]
        [StringLength(45,ErrorMessage ="max 45 Zeichen")]
        public string Name { get; set; }
        [Required(ErrorMessage = "da muss was rein")]
        public DateTime GebDat { get; set; }
        [Required(ErrorMessage = "da muss was rein")]
        [Range(140,200, ErrorMessage ="keine Achterbahn für dich")]
        public int Gross { get; set; }
    }
}
