namespace FastService.prod.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LastWork")]
    public partial class LastWork
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string Img { get; set; }

        public bool IsDeleted { get; set; }
    }
}
