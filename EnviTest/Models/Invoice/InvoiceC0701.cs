using System.ComponentModel.DataAnnotations;

namespace EnviTest.Models
{
    /// <summary>
    /// 註銷發票訊息存證規格
    /// </summary>
    public class InvoiceC0701
    {
        /// <summary>
        /// 註銷發票號碼
        /// </summary>
        [Required]
        [Display(Name = "註銷發票號碼")]
        public string VoidInvoiceNumber { get; set; }

        /// <summary>
        /// 發票日期 (YYYYDMMDD)
        /// </summary>
        [Required]
        [Display(Name = "發票日期(YYYYDMMDD)")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 買方統一編號
        /// </summary>
        [Required]
        [Display(Name = "買方統一編號")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 賣方統一編號
        /// </summary>
        [Required]
        [Display(Name = "賣方統一編號")]
        public string SellerId { get; set; }

        /// <summary>
        /// 註銷日期 (YYYYDMMDD)
        /// </summary>
        [Required]
        [Display(Name = "註銷日期(YYYYDMMDD)")]
        public string VoidDate { get; set; }

        /// <summary>
        /// 註銷時間
        /// </summary>
        [Required]
        [Display(Name = "註銷時間(HH:mm:ss)")]
        public string VoidTime { get; set; }

        /// <summary>
        /// 註銷原因
        /// 長度至少為1
        /// </summary>
        [Required]
        [Display(Name = "註銷原因")]
        public string VoidReason { get; set; }
        
        /// <summary>
        /// 備註 (選項)
        /// </summary>
        [Display(Name = "備註")]
        public string Remark { get; set; }
    }
}