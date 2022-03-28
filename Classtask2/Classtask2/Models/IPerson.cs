using System;
using System.Collections.Generic;
using System.Text;

namespace Classtask2.Models
{
    interface IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string ShowInfo();

    }
}
