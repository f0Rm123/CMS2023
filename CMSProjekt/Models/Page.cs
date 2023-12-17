using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSProjekt.Models
{
    public class Page
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public bool Visible { get; set; }
        public int ParentPageId { get; set; }
        public List<PageElement>? PageElements { get; set; }
    }
}
