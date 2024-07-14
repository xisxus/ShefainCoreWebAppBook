using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShefainCoreWebApp.Core.Entities
{
    public enum LookUpType
    {
        State = 0,
        Country = 1
    }
    public class LookUp
    {
        [Key]
        public string Code { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public LookUpType LookUpType { get; set; }
    }
}
