namespace YourLifeSaver.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class quiz
    {
        public int Id { get; set; }

        [Required]
        public string Result { get; set; }

        public int Count { get; set; }
    }
}
