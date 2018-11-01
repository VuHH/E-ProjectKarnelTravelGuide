namespace TravelGuide
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN")]
    public partial class ADMIN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_ADMIN { get; set; }

        [Required]
        [StringLength(200)]
        public string NAME_ADMIN { get; set; }

        [StringLength(200)]
        public string ADDRESS_ADMIN { get; set; }

        [StringLength(10)]
        public string TEL_ADMIN { get; set; }

        [StringLength(50)]
        public string EMAIL_ADMIN { get; set; }

        public bool? DISASBLE { get; set; }

        [StringLength(50)]
        [Required]
        [RegularExpression(@"^\S*$", ErrorMessage = "No white space allowed")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string PASS_ADMIN { get; set; }
    }
}
