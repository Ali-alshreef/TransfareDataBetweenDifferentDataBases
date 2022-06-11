namespace TransfareData.Data2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Merchants
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(10)]
        public string Phone1 { get; set; }

        [StringLength(10)]
        public string Phone2 { get; set; }

        public int? Cityid { get; set; }

        public decimal Balance { get; set; }

        public bool IsCustomer { get; set; }

        public bool IsSupplier { get; set; }

        public bool IsDraiver { get; set; }

        public bool IsClient { get; set; }

        [StringLength(50)]
        public string Notes { get; set; }

        public int? UserId { get; set; }

        public string MachineName { get; set; }

        public string CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public bool IsOwnerGoods { get; set; }
    }
}
