//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class materials
    {
        public materials()
        {
            this.inquriy_ma = new HashSet<inquriy_ma>();
            this.invo_ma = new HashSet<invo_ma>();
            this.orderForm_ma = new HashSet<orderForm_ma>();
            this.out_ma = new HashSet<out_ma>();
            this.quo_ma = new HashSet<quo_ma>();
            this.re_ven_ma = new HashSet<re_ven_ma>();
            this.rfq_ven_ma = new HashSet<rfq_ven_ma>();
            this.sales_ma = new HashSet<sales_ma>();
            this.receipt = new HashSet<receipt>();
        }
    
        public int materialID { get; set; }
        public int vendorCode { get; set; }
        public string name { get; set; }
        public Nullable<int> quantity { get; set; }
        public string placeOfOrigin { get; set; }
        public string describtion { get; set; }
        public Nullable<decimal> unitPrice { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<int> stock { get; set; }
    
        public virtual ICollection<inquriy_ma> inquriy_ma { get; set; }
        public virtual ICollection<invo_ma> invo_ma { get; set; }
        public virtual vendor vendor { get; set; }
        public virtual ICollection<orderForm_ma> orderForm_ma { get; set; }
        public virtual ICollection<out_ma> out_ma { get; set; }
        public virtual ICollection<quo_ma> quo_ma { get; set; }
        public virtual ICollection<re_ven_ma> re_ven_ma { get; set; }
        public virtual ICollection<rfq_ven_ma> rfq_ven_ma { get; set; }
        public virtual ICollection<sales_ma> sales_ma { get; set; }
        public virtual ICollection<receipt> receipt { get; set; }
    }
}
