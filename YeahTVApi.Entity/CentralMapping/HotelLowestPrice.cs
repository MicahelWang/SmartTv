//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;

namespace YeahTVApi.Entity.CentralMapping
{
    using System;
    using System.Collections.Generic;
    [Serializable]
    public partial class HotelLowestPrice
    {
         
        public int ID { get; set; }
         
        public string HotelID { get; set; }
         
        public System.DateTime BizDate { get; set; }
         
        public decimal LowestPrice { get; set; }

        public virtual HotelInfo HotelInfo { get; set; }
    }
}
