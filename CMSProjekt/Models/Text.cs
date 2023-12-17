namespace CMSProjekt.Models
{
    public class Text
    {
        public int Id { get; set; }
        public PageElement Element { get; set; }
        public int ElementId { get; set; }
        public string TextString { get; set; }
        public string Color { get; set; }
        public bool IsBold { get; set; }
    }
}
