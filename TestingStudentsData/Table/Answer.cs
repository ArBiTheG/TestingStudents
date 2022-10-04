using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingStudentsData.Table
{
    public class Answer
    {
        public int id { get; set; }
        public string primary_text { get; set; }
        public string secondary_text { get; set; }
        public string tooltip { get; set; }
        public byte serial_number { get; set; }
        public bool is_correct { get; set; }
        public int question_id { get; set; }
        public bool is_visible { get; set; }

    }
}
