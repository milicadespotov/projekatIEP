namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ErrorLog")]
    public partial class ErrorLog
    {
        public int ErrorLogID { get; set; }

        public DateTime ErrorTime { get; set; }

        [Required]
        [StringLength(128)]
        public string UserName { get; set; }

        public int ErrorNumber { get; set; }

        public int? ErrorSeverity { get; set; }

        public int? ErrorState { get; set; }

        [StringLength(126)]
        public string ErrorProcedure { get; set; }

        public int? ErrorLine { get; set; }

        [Required]
        [StringLength(4000)]
        public string ErrorMessage { get; set; }
    }
}
