//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestion_Etudiants
{
    using System;
    using System.Collections.Generic;
    
    public partial class OTPCodes
    {
        public int Id { get; set; }
        public Nullable<int> IdUtilisateur { get; set; }
        public string Code { get; set; }
        public System.DateTime DateExpiration { get; set; }
    
        public virtual Utilisateurs Utilisateurs { get; set; }
    }
}
