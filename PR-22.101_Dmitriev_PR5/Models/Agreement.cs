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
    
    public partial class Agreement
    {
        public int Agreement_ID { get; set; }
        public int Client_ID { get; set; }
        public int Object_ID { get; set; }
        public System.DateTime SigningDate { get; set; }
        public string AdditionalInfo { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Object Object { get; set; }
    }
}
