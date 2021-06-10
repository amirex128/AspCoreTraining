using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web1.logic
{
    public class PropertyTest
    {
        private string _name;
        public string name
        {
            get => _name;
            set => _name = value;
        }

        
        public string values { get; set; }
    }
}