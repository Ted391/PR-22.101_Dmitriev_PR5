//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PR_22._101_Dmitriev_PR5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TriggeringAlarm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TriggeringAlarm()
        {
            this.ObjectInspection = new HashSet<ObjectInspection>();
        }
    
        public int TriggeringAlarm_ID { get; set; }
        public int TriggeringAlarmType_ID { get; set; }
        public int Object_ID { get; set; }
        public System.DateTime Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObjectInspection> ObjectInspection { get; set; }
        public virtual TriggeringAlarmType TriggeringAlarmType { get; set; }
    }
}
