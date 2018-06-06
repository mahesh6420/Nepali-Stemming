using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Stemming.Models
{
    public class InputModel
    {
    
        [Key]
        public int Id {get; set; }
        public string InputName { get; set; }
    }
}
