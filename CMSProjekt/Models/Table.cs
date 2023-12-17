namespace CMSProjekt.Models
{
    public class Table
    {
        public int Id { get; set; }
        public PageElement Element { get; set; }
        public int ElementId { get; set; }
        public string Caption { get; set; }
        public string ContentJSON { get; set; }
    }
}
