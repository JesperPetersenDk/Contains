using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Contains_Test.Models
{
    public class ContainsViewModel
    {
        [ReadOnly(true)]
        public string Text { get; set; }
    }
}