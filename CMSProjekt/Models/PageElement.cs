using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSProjekt.Models
{
    public class PageElement
    {
        public int Id { get; set; }
        public Page Page { get; set; }
        public int OrderNumber { get; set; }
        public File? File { get; set; }
        public Text? Text { get; set; }
        public Image? Image { get; set; }
        public Table? Table { get; set; }
    }
}
