using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingStudentsData.Table
{
    public class Testing
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public byte[] picture { get; set; }
        public DateTime date_create { get; set; }
        public int chapter_id { get; set; }
        public bool is_visible { get; set; }
    }
}
