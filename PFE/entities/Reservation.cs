//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp2.entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        public int id_reservations { get; set; }
        public System.DateTime date_debut { get; set; }
        public System.DateTime date_fin { get; set; }
        public int id_immeubiliers { get; set; }
        public int id_clients { get; set; }
        public int nbr_personne { get; set; }
        public float tarif { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Immeubilier Immeubilier { get; set; }
    }
}
