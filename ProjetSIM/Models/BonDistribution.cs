namespace ProjetSIM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BonDistribution")]
    public partial class BonDistribution
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BonDistribution()
        {
            LigneBonDistributions = new HashSet<LigneBonDistribution>();
            NotificationBonDistributions = new HashSet<NotificationBonDistribution>();
        }

        [Key]
        public int numBonDistribution { get; set; }

        public int numFiliale { get; set; }

        public DateTime dateBonDistribution { get; set; }

        [StringLength(50)]
        public string nomUtilisateur { get; set; }

        public virtual Filiale Filiale { get; set; }

        public virtual Utilisateur Utilisateur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LigneBonDistribution> LigneBonDistributions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationBonDistribution> NotificationBonDistributions { get; set; }
    }
}
