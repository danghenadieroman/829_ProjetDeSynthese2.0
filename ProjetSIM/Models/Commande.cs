namespace ProjetSIM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Commande")]
    public partial class Commande
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Commande()
        {
            LigneCommandes = new HashSet<LigneCommande>();
        }

        [Key]
        public int numCommande { get; set; }

        public int numFournisseur { get; set; }

        public double montant { get; set; }

        public DateTime dateCommande { get; set; }

        [StringLength(50)]
        public string nomUtilisateur { get; set; }

        public virtual Fournisseur Fournisseur { get; set; }

        public virtual Utilisateur Utilisateur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LigneCommande> LigneCommandes { get; set; }
    }
}
