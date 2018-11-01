namespace TravelGuide
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RESTAURANT")]
    public partial class RESTAURANT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_RESTAURANT { get; set; }

        [Required]
        [StringLength(200)]
        public string NAME_RESTAURANT { get; set; }

        [StringLength(3)]
        public string ID_CITY { get; set; }

        [StringLength(200)]
        public string ADDRESS_RESTAURANT { get; set; }

        [StringLength(10)]
        public string TEL_RESTAURANT { get; set; }

        public int? QUALITY_RESTAURANT { get; set; }

        public bool? AVAILABLE { get; set; }

        [StringLength(1000)]
        public string DES_RESTAURANT { get; set; }

        [StringLength(200)]
        public string INTRODUCE_RESTAURANT { get; set; }

        [StringLength(200)]
        public string IMAGE_RESTAURANT { get; set; }

        public bool? ISDISCOUNT_RES { get; set; }

        public int? DISCOUNT_RES { get; set; }

        public int? PRICE_RESTAURANT { get; set; }

        public virtual CITY CITY { get; set; }


        [StringLength(200)]
        public string IMAGE_DETAIL_RESTAURANT { get; set; }
    }
}
