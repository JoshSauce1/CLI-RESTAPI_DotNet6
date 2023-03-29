namespace CLIAPI
{
    public class Commander
    {
        public int Id { get; set; }
        public string Line { get; set; } = string.Empty; //command line snippet
        public string Des { get; set; } = string.Empty; //command Description
        public string Platform { get; set; } = string.Empty; //application platform
    }
}
