namespace Mvc_Application.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Department()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Department_ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Grocery_dept { get; set; }

        [StringLength(255)]
        public string Bakery_dept { get; set; }

        public int? Total_No_Of_Products { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price_of_Product { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
