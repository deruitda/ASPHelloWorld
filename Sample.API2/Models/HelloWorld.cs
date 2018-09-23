using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.API2.Models
{
    public class HelloWorld
    {
        private string _str;
        [Key]
        public string Str
        {
            get { return _str; }
            set { _str = value; }
        }
    }
}
