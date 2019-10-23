namespace Part3.Models
{
    public class Box
    {
        public string Name { get; set; }

        public bool HasKey { get; set; }

        public Box InnerBox { get; set; }
    }
}
