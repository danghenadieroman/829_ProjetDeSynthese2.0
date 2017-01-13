namespace ProjetSIM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotificationBonDistribution")]
    public partial class NotificationBonDistribution
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int numBonDistribution { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string message { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime dateNotification { get; set; }

        [StringLength(5)]
        public string etat { get; set; }

        public virtual BonDistribution BonDistribution { get; set; }
    }
}
