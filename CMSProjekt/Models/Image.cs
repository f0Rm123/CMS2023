namespace CMSProjekt.Models
{
    public class Image
    {
        public int Id { get; set; }
        public PageElement Element { get; set; }
        public int ElementId { get; set; }
        public string Caption { get; set; }
        public byte[] Data { get; set; }
    }
}
