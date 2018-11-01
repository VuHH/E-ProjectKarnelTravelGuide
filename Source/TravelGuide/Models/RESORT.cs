namespace TravelGuide
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RESORT")]
    public partial class RESORT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_RESORT { get; set; }

        [Required]
        [StringLength(200)]
        public string NAME_RESORT { get; set; }

        [StringLength(3)]
        public string ID_CITY { get; set; }

        [StringLength(200)]
        public string ADDRESS_RESORT { get; set; }

        [StringLength(10)]
        public string TEL_RESORT { get; set; }

        public int? QUALITY_RESORT { get; set; }

        public bool? AVAILABLE { get; set; }

        [StringLength(10)]
        public string INTRODUCE_RESORT { get; set; }

        [StringLength(1000)]
        public string DES_RESORT { get; set; }

        [StringLength(200)]
        public string IMAGE_RESORT { get; set; }

        public bool? ISDISCOUNT_RESORT { get; set; }

        public int? DISCOUNT_RESORT { get; set; }

        public int? PRICE_RESORT { get; set; }

        public virtual CITY CITY { get; set; }


        [StringLength(200)]
        public string IMAGE_DETAIL_RESORT { get; set; }

    }
}
