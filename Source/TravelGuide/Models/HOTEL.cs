namespace TravelGuide
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOTEL")]
    public partial class HOTEL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_HOTEL { get; set; }

        [Required]
        [StringLength(200)]
        public string NAME_HOTEL { get; set; }

        [StringLength(3)]
        public string ID_CITY { get; set; }

        [StringLength(200)]
        public string ADDRESS_HOTEL { get; set; }

        [StringLength(10)]
        public string TEL_HOTEL { get; set; }

        public int? QUALITY_HOTEL { get; set; }

        [StringLength(200)]
        public string INTRODUCE_HOTEL { get; set; }

        [StringLength(1000)]
        public string DES_HOTEL { get; set; }

        [StringLength(200)]
        public string IMAGE_HOTEL { get; set; }

        public bool? AVAILABLE { get; set; }

        public virtual CITY CITY { get; set; }

        public int? PRICE_HOTEL { get; set; }

        public bool? ISDISCOUNT_HOTEL { get; set; }

        public int? DISCOUNT_HOTEL { get; set; }


        [StringLength(200)]
        public string IMAGE_DETAIL_HOTEL { get; set; }

    }
}
