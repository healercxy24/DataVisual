﻿using System.ComponentModel.DataAnnotations;

namespace DataVisual.Data
{
    public class FD1RUL
    {
        [Key]
        public int EngineID { get; set; }
        public int RUL { get; set; }
    }
}
