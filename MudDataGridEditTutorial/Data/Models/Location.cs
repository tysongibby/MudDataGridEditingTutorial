using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MudDataGridEditTutorial.Data.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public string Description { get; set; }        

        // One-to-many navigation, Location is parent
        public virtual ICollection<Meeting> Meetings { get; set; }
    }
}
