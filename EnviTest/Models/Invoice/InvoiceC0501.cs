using System.ComponentModel.DataAnnotations;

namespace EnviTest.Models
{
    /// <summary>
    /// 平台存證作廢發票訊息規格
    /// </summary>
    public class InvoiceC0501
    {
        /// <summary>
        /// 作廢發票號碼
        /// </summary>
        [Required]
        [Display(Name = "作廢發票號碼")]
        public string CancelInvoiceNumber { get; set; }

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
        /// 作廢日期 (YYYYDMMDD)
        /// </summary>
        [Required]
        [Display(Name = "作廢日期(YYYYDMMDD)")]
        public string CancelDate { get; set; }

        /// <summary>
        /// 作廢時間
        /// </summary>
        [Required]
        [Display(Name = "作廢時間(HH:mm:ss)")]
        public string CancelTime { get; set; }

        /// <summary>
        /// 作廢原因
        /// 長度至少為1
        /// </summary>
        [Required]
        [Display(Name = "作廢原因")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 專案作廢核准文號 (選項)
        /// </summary>
        [Display(Name = "專案作廢核准文號")]
        public string ReturnTaxDocumentNumber { get; set; }

        /// <summary>
        /// 備註 (選項)
        /// </summary>
        [Display(Name = "備註")]
        public string Remark { get; set; }
    }
}