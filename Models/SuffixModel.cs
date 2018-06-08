using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Stemming.Models
{
    public class SuffixModel
    {
        [Key] 
        public int Id { get; set; }
        public string SuffixName { get; set; }
    }
}