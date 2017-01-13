namespace ProjetSIM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Paiement")]
    public partial class Paiement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int numPaiement { get; set; }

        public int numVente { get; set; }

        [Required]
        [StringLength(10)]
        public string type { get; set; }

        public double montantPaiement { get; set; }

        public double? montantRecu { get; set; }

        public double? monaie { get; set; }

        [StringLength(25)]
        public string numCarte { get; set; }

        [StringLength(10)]
        public string typeCarte { get; set; }

        public virtual Vente Vente { get; set; }
    }
}
