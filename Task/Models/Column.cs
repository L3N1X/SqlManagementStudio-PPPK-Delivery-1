using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models
{
    public class Column
    {
        public string Name { get; set; }
        public string DataType { get; set; }
        public override string ToString() => $"{this.Name} ({this.DataType})";
    }
}
