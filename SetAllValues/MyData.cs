using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetAllValues
{
    public class MyData
    {
        public int Value { get; set; }
        //Helps to track if the key's value is updated to the latest SetAll value
        public int Counter { get; set; }
    }
}
