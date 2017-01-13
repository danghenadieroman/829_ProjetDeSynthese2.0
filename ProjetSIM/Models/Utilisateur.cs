namespace ProjetSIM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Utilisateur")]
    public partial class Utilisateur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Utilisateur()
        {
            BonDistributions = new HashSet<BonDistribution>();
            Commandes = new HashSet<Commande>();
            Ventes = new HashSet<Vente>();
        }

        [Key]
        [StringLength(50)]
        public string nomUtilisateur { get; set; }

        [Required]
        [StringLength(50)]
        public string motDePasse { get; set; }

        [Required]
        [StringLength(10)]
        public string type { get; set; }

        public int numFiliale { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BonDistribution> BonDistributions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commande> Commandes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vente> Ventes { get; set; }
    }
}
