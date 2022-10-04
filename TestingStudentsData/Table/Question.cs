using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingStudentsData.Table
{
    public class Question
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public byte[] picture { get; set; }
        public string tooltip { get; set; }
        public int testing_id { get; set; }
        public QuestionType type { get; set; }
        public byte factor { get; set; }
        public bool is_visible { get; set; }
    }
}
