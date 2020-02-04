using System;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime Due { get; set; }
        [Range(1, 5)]
        public int Priority { get; set; }
        
    }
}