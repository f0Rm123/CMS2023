namespace CMSProjekt.Models
{
    public class File
    {
        public int Id { get; set; }
        public PageElement Element { get; set; }
        public int ElementId { get; set; }
        public string Name { get; set; }
        public string Caption { get; set; }
        public byte[] Data { get; set; }
    }
}
