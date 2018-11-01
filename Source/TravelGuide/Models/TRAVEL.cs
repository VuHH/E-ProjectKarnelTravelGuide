namespace TravelGuide
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRAVEL")]
    public partial class TRAVEL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_TRAVEL { get; set; }

        [Required]
        [StringLength(200)]
        public string NAME_TRAVEL { get; set; }

        [StringLength(3)]
        public string ID_CITY { get; set; }

        [StringLength(200)]
        public string ADDRESS_TRAVEL { get; set; }

        [StringLength(10)]
        public string TEL_TRAVEL { get; set; }

        public int? QUALITY_TRAVEL { get; set; }

        public bool? AVAILABLE { get; set; }

        [StringLength(1000)]
        public string DES_TRAVEL { get; set; }

        [StringLength(200)]
        public string INTRODUCE_TRAVEL { get; set; }

        [StringLength(200)]
        public string IMAGE_TRAVEL { get; set; }

        public bool? ISDISCOUNT_TRAVEL { get; set; }

        public int? DISCOUNT_TRAVEL { get; set; }

        public virtual CITY CITY { get; set; }


        [StringLength(200)]
        public string IMAGE_DETAIL_TRAVEL { get; set; }
    }
}
