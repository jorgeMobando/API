using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api
{
    public class Root
    {
        public Info info { get; set; }
        public List<Result> results { get; set; }
    }
}
