﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sgEtudiantG25Entities : DbContext
    {
        public sgEtudiantG25Entities()
            : base("name=sgEtudiantG25Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<Cours> Cours { get; set; }
        public virtual DbSet<Etudiants> Etudiants { get; set; }
        public virtual DbSet<Matieres> Matieres { get; set; }
        public virtual DbSet<Notes> Notes { get; set; }
        public virtual DbSet<OTPCodes> OTPCodes { get; set; }
        public virtual DbSet<Professeurs> Professeurs { get; set; }
        public virtual DbSet<Utilisateurs> Utilisateurs { get; set; }
    }
}
