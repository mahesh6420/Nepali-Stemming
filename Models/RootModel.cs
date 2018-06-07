using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Stemming.Models
{
    public class RootModel
    {
        [Key]
        public int Id {get; set; }
        public string RootName { get; set; }    
    }
}
