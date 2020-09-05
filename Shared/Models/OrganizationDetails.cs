using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBlazorApp.Data
{
    public class OrganizationDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public bool? HasTeam { get; set; }
        public bool? IsExpanded { get; set; }
        public string Name { get; set; }
    }
}
