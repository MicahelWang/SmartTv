//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;
using System;
using System.Collections.Generic;

namespace YeahTVApi.Entity.CentralMapping
{

    /// <summary>
    /// 酒店排序实体
    /// </summary>
    [Serializable]

    public partial class HotelSortValue 
    {
        
        public int ID { get; set; }
        /// <summary>
        /// 酒店编号
        /// </summary>
        
        public string HotelID { get; set; }
        /// <summary>
        /// 第一天 以下依次第n天
        /// </summary>
        
        public double D0 { get; set; }
        
        public double D1 { get; set; }
        
        public double D2 { get; set; }
        
        public double D3 { get; set; }
        
        public double D4 { get; set; }
        
        public double D5 { get; set; }
        
        public double D6 { get; set; }
        
        public double D7 { get; set; }
        
        public double D8 { get; set; }
        
        public double D9 { get; set; }
        
        public double D10 { get; set; }
        
        public double D11 { get; set; }
        
        public double D12 { get; set; }
        
        public double D13 { get; set; }

        public virtual HotelInfo HotelInfo { get; set; }
    }
}
