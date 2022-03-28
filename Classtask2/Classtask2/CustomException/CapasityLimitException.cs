using System;
using System.Collections.Generic;
using System.Text;

namespace Classtask2.CustomException
{
   public class CapasityLimitException:Exception
    {
        public CapasityLimitException (string message) : base(message) { }
    }
}
