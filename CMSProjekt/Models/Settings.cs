using System.ComponentModel.DataAnnotations;

namespace CMSProjekt.Models
{
    public class Settings
    {
        [Key]
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
