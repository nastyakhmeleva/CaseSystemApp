//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CaseSystemApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Column
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Column()
        {
            this.Connection = new HashSet<Connection>();
            this.Connection1 = new HashSet<Connection>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<bool> DefaultValue { get; set; }
        public string NotNull { get; set; }
        public Nullable<bool> Unique { get; set; }
        public bool Increment { get; set; }
        public bool Key { get; set; }
    
        public virtual Table Table { get; set; }
        public virtual Mask Mask { get; set; }
        public virtual Type Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Connection> Connection { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Connection> Connection1 { get; set; }
    }
}
