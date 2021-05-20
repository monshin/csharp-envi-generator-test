using System.ComponentModel.DataAnnotations;

namespace EnviTest.Models
{
    /// <summary>
    /// 開立折讓證明/通知單接收確認訊息規格
    /// </summary>
    public class InvoiceB0102
    {
        /// <summary>
        /// 作廢折讓證明單號碼
        /// </summary>
        [Required]
        [Display(Name = "折讓證明單號碼")]
        public string AllowanceNumber { get; set; }

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
        /// 折讓證明單接收日 (YYYYDMMDD)
        /// </summary>
        [Required]
        [Display(Name = "折讓證明單接收日")]
        public string ReceiveDate { get; set; }

        /// <summary>
        /// 折讓證明單接收時間 (HH:mm:ss)
        /// </summary>
        [Required]
        [Display(Name = "折讓證明單接收時間")]
        public string ReceiveTime { get; set; }

        /// <summary>
        /// 折讓種類
        /// 1:買方開立折讓證明單
        /// 2:賣方開立折讓證明通知單
        /// </summary>
        [Required]
        [Display(Name = "折讓種類")]
        public string AllowanceType { get; set; }
        
        /// <summary>
        /// 備註 (選項)
        /// </summary>
        [Display(Name = "備註")]
        public string Remark { get; set; }
    }
}