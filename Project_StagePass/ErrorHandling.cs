using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_StagePass
{
    public class ErrorHandling : Exception
    {
        public ErrorHandling(string message) : base(message) { }
    }
}
