//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EquipmentMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EType
    {
        public EType()
        {
            this.BorrowAndReturn = new HashSet<BorrowAndReturn>();
            this.Equipment = new HashSet<Equipment>();
        }
    
        public int ETypeID { get; set; }
        public string EType1 { get; set; }
    
        public virtual ICollection<BorrowAndReturn> BorrowAndReturn { get; set; }
        public virtual ICollection<Equipment> Equipment { get; set; }
        public virtual EType EType11 { get; set; }
        public virtual EType EType2 { get; set; }
    }
}
