namespace ProjetSIM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vente")]
    public partial class Vente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vente()
        {
            Paiements = new HashSet<Paiement>();
            LigneVentes = new HashSet<LigneVente>();
        }

        [Key]
        public int numVente { get; set; }

        public double montant { get; set; }

        public DateTime dateVente { get; set; }

        public int numFiliale { get; set; }

        [StringLength(50)]
        public string nomUtilisateur { get; set; }

        public virtual Filiale Filiale { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paiement> Paiements { get; set; }

        public virtual Utilisateur Utilisateur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LigneVente> LigneVentes { get; set; }
    }
}
