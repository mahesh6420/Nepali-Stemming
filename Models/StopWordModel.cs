using System.ComponentModel.DataAnnotations;

namespace Stemming.Models
{
    public class StopWordModel
    {
        [Key]
        public int Id { get; set; }
        public string StopWord { get; set; }
    }
}