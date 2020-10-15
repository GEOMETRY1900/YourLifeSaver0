namespace YourLifeSaver.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shelter")]
    public partial class shelter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(500)]
        public string s_Name { get; set; }

        [StringLength(500)]
        public string Address_2 { get; set; }

        [StringLength(100)]
        public string Suburb { get; set; }

        [StringLength(100)]
        public string Longitude { get; set; }

        [StringLength(100)]
        public string Latitude { get; set; }
    }
}
