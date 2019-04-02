//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace api_sicge.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonUser()
        {
            this.UserRol = new HashSet<UserRol>();
        }
    
        public string PersonId { get; set; }
        public string Email { get; set; }
        public Nullable<int> EmailValidated { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> LastLoginAt { get; set; }
        public Nullable<int> Enabled { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
    
        public virtual Person Person { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRol> UserRol { get; set; }
    }
}
