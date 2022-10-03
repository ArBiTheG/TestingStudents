namespace TestingStudentsData.Tables
{
    public class Chapter
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public byte[] picture { get; set; }
        public int parent_id { get; set; }
        public bool active { get; set; }
    }
}
