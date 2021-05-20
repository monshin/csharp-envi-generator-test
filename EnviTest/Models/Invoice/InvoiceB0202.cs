using System.ComponentModel.DataAnnotations;

namespace EnviTest.Models
{
    /// <summary>
    /// 作廢折讓證明單接收確認訊息規格
    /// </summary>
    public class InvoiceB0202
    {
        /// <summary>
        /// 作廢折讓證明單號碼
        /// </summary>
        [Required]
        [Display(Name = "作廢折讓證明單號碼")]
        public string CancelAllowanceNumber { get; set; }

        /// <summary>
        /// 折讓證明單日期 (YYYYDMMDD)
        /// </summary>
        [Required]
        [Display(Name = "折讓證明單日期")]
        public string AllowanceDate { get; set; }

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
        /// 折讓證明單作廢日期 (YYYYDMMDD)
        /// </summary>
        [Required]
        [Display(Name = "折讓證明單作廢日期")]
        public string CancelDate { get; set; }

        /// <summary>
        /// 折讓證明單作廢時間 (HH:mm:ss)
        /// </summary>
        [Required]
        [Display(Name = "折讓證明單作廢時間")]
        public string CancelTime { get; set; }
        
        /// <summary>
        /// 備註 (選項)
        /// </summary>
        [Display(Name = "備註")]
        public string Remark { get; set; }
    }
}