//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvcmysql.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class product
    {
        public int ProductID { get; set; }
        [DisplayName("產品名稱")]
        [Required(ErrorMessage = "不能為空白")]
        public string ProductName { get; set; }
        [DisplayName("價格")]
        public Nullable<decimal> Price { get; set; }
        [DisplayName("數量")]
        public Nullable<int> Count { get; set; }
    }
}
