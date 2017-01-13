namespace ProjetSIM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Filiale")]
    public partial class Filiale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Filiale()
        {
            BonDistributions = new HashSet<BonDistribution>();
            Stocks = new HashSet<Stock>();
            Ventes = new HashSet<Vente>();
        }

        [Key]
        public int numFiliale { get; set; }

        [Required]
        [StringLength(25)]
        public string nom { get; set; }

        [Required]
        [StringLength(50)]
        public string adresse { get; set; }

        [Required]
        [StringLength(15)]
        public string type { get; set; }

        [Required]
        [StringLength(10)]
        public string telephone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BonDistribution> BonDistributions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stock> Stocks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vente> Ventes { get; set; }
    }
}
