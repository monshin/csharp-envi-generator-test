using System.ComponentModel.DataAnnotations;

namespace EnviTest.Models
{
    /// <summary>
    /// 發票接收確認訊息規格
    /// </summary>
    public class InvoiceA0102
    {
        /// <summary>
        /// 發票號碼
        /// </summary>
        [Required]
        [Display(Name = "發票號碼")]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// 發票開立日期
        /// YYYYDMMDD
        /// </summary>
        [Required]
        [Display(Name = "發票開立日期")]
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
        /// 發票接收日期
        /// YYYYDMMDD
        /// </summary>
        [Required]
        [Display(Name = "發票接收日期")]
        public string ReceiveDate { get; set; }

        /// <summary>
        /// 發票接收時間
        /// HH:mm:ss
        /// </summary>
        [Required]
        [Display(Name = "發票接收時間")]
        public string ReceiveTime { get; set; }

        /// <summary>
        /// 買受人註記欄 (選項)
        /// </summary>
        [Display(Name = "買受人註記欄")]
        public string BuyerRemark { get; set; }

        /// <summary>
        /// 備註 (選項)
        /// </summary>
        [Display(Name = "備註")]
        public string Remark { get; set; }

        /// <summary>
        /// 買受人簽署適用零稅率註記 (選項)
        /// 1: 符合加值型及非加值型營業稅法第 7 條第 4 款規定 (買受人為保稅區營業人)
        /// 2: 符合加值型及非加值型營業稅法第 7 條第 7 款規定 (買受人為遠洋漁業營業人)
        /// 3: 符合自由貿易港區設置管理條例第 28 條第 1項第 1 款及第 4 款規定(買受人為自由貿易港區營業人)
        /// </summary>
        [Display(Name = "買受人簽署適用零稅率註記")]
        public string BondedAreaConfirm { get; set; }

    }
}