using System.ComponentModel.DataAnnotations;
using System;

namespace DataVisual.Data
{
    public class FD3RUL
    {
        [Key]
        public int EngineID { get; set; }
        public int RUL { get; set; }
    }
}
