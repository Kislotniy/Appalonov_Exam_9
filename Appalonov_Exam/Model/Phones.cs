//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Appalonov_Exam.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Phones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phones()
        {
            this.OrdersPhone = new HashSet<OrdersPhone>();
        }
    
        public int id_Phone { get; set; }
        public string Name_Phone { get; set; }
        public int id_Type { get; set; }
        public Nullable<int> Sale { get; set; }
        public Nullable<decimal> Sum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersPhone> OrdersPhone { get; set; }
        public virtual PhonesType PhonesType { get; set; }
    }
}