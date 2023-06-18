using System;

namespace MudDataGridEditTutorial.Data.Models
{
    public class Element
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Sign { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int Position { get; set; }
        public decimal Molar { get; set; }

        public DateTime ModifiedDate { get; set; } = DateTime.UtcNow;
    }
}
