namespace TransfareData.Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DraiverNames
    {
        public int id { get; set; }

        public int DraiverNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string DraiverName { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        public int? Cityid { get; set; }

        [StringLength(50)]
        public string Notes { get; set; }
    }
}
