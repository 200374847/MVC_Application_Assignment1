namespace Mvc_Application.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Order_ID { get; set; }

        public int Order_Number { get; set; }

        [StringLength(1)]
        public string Person_Name { get; set; }

        public int? Department_ID { get; set; }

        public virtual Department Department { get; set; }
    }
}
