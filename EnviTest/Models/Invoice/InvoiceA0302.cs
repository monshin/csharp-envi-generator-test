using System.ComponentModel.DataAnnotations;

namespace EnviTest.Models
{
    /// <summary>
    /// 退回(拒收)發票接收確認訊息規格
    /// </summary>
    public class InvoiceA0302
    {
        /// <summary>
        /// 退回(拒收)發票號碼
        /// </summary>
        [Required]
        [Display(Name = "退回(拒收)發票號碼")]
        public string RejectInvoiceNumber { get; set; }

        /// <summary>
        /// 發票日期 (YYYYDMMDD)
        /// </summary>
        [Required]
        [Display(Name = "發票日期")]
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
        /// 退回(拒收)日期 (YYYYDMMDD)
        /// </summary>
        [Required]
        [Display(Name = "退回(拒收)日期")]
        public string RejectDate { get; set; }

        /// <summary>
        /// 退回(拒收)時間 (HH:mm:ss)
        /// </summary>
        [Required]
        [Display(Name = "退回(拒收)時間")]
        public string RejectTime { get; set; }
        
        /// <summary>
        /// 備註 (選項)
        /// </summary>
        [Display(Name = "備註")]
        public string Remark { get; set; }
    }
}