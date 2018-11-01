namespace TravelGuide
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOURIST_SPOTS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_TOURISTSPOT { get; set; }

        [Required]
        [StringLength(200)]
        public string NAME_TOURISTSPOT { get; set; }

        [StringLength(3)]
        public string ID_CITY { get; set; }

        [StringLength(200)]
        public string ADDRESS_TOURISTSPOT { get; set; }

        [StringLength(10)]
        public string TEL_TOURISTSPOT { get; set; }

        public int? QUALITY_TOURISTSPOT { get; set; }

        [StringLength(1000)]
        public string DES_TOURIST_SPOTS { get; set; }

        [StringLength(200)]
        public string INTRODUCE_TOURIST_SPOTS { get; set; }

        [StringLength(200)]
        public string IMAGE_TOURIST_SPOTS { get; set; }

        public virtual CITY CITY { get; set; }


        [StringLength(200)]
        public string IMAGE_DETAIL_TOURIST_SPOTS { get; set; }
    }
}
