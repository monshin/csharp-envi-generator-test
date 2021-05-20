using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EnviTest.Models
{
    /// <summary>
    /// 平台存證開立發票訊息規格
    /// </summary>
    public class InvoiceA0101
    {
        /*
         * Main 
         */

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
        /// 發票開立時間
        /// HH:mm:ss
        /// </summary>
        [Required]
        [Display(Name = "發票開立時間")]
        public string InvoiceTime { get; set; }

        /// <summary>
        /// 賣方-營業人統一編號
        /// </summary>
        [Required]
        [Display(Name = "賣方-營業人統一編號")]
        public string SellerIdentifier { get; set; }


        /// <summary>
        /// 賣方-營業人名稱
        /// </summary>
        [Required]
        [Display(Name = "賣方-營業人名稱")]
        public string SellerName { get; set; }


        /// <summary>
        /// 買方-營業人統一編號
        /// </summary>
        [Required]
        [Display(Name = "買方-營業人統一編號")]
        public string BuyerIdentifier { get; set; }

        /// <summary>
        /// 買方-營業人名稱
        /// </summary>
        [Required]
        [Display(Name = "買方-營業人名稱")]
        public string BuyerName { get; set; }

        /// <summary>
        /// 發票檢查碼 (選項)
        /// </summary>
        [Display(Name = "發票檢查碼")]
        public string CheckNumber { get; set; }

        /// <summary>
        /// 買受人註記欄 (選項)
        /// </summary>
        [Display(Name = "買受人註記欄")]
        public string BuyerRemark { get; set; }

        /// <summary>
        /// 總備註 (選項)
        /// </summary>
        [Display(Name = "總備註")]
        public string MainRemark { get; set; }

        /// <summary>
        /// 通關方式註記 (選項)
        /// </summary>
        [Display(Name = "通關方式註記")]
        public string CustomsClearanceMark { get; set; }

        /// <summary>
        /// 沖帳別 (選項)
        /// </summary>
        [Display(Name = "沖帳別")]
        public string Category { get; set; }

        /// <summary>
        /// 相關號碼 (選項)
        /// </summary>
        [Display(Name = "相關號碼")]
        public string RelateNumber { get; set; }

        /// <summary>
        /// 發票類別
        /// 07:一般稅額計算之電子發票 
        /// 08:特種稅額計算之電子發票
        /// </summary>
        [Required]
        [Display(Name = "發票類別")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 彙開註記 (選項)
        /// 以 * 表示彙開
        /// </summary>
        [Display(Name = "彙開註記")]
        public string GroupMark { get; set; }

        /// <summary>
        /// 捐贈註記
        /// 0：非捐贈發票
        /// 1：捐贈發票
        /// </summary>
        [Required]
        [Display(Name = "捐贈註記")]
        public string DonateMark { get; set; }
        
        /// <summary>
        /// 證明附件 (選項)
        /// </summary>
        [Display(Name = "證明附件")]
        public string Attachment { get; set; }

        /*
         * Details
         */

        public List<InvoiceA0101ProductItem> ProductItems { get; set; }

        /*
         * Amount 
         */

        /// <summary>
        /// 銷售額合計
        /// 整數(小數點以下四捨五入)
        /// *請注意銷售額合計不應為負數且買受人為營業人時不含稅
        /// </summary>
        [Required]
        [Display(Name = "銷售額合計")]
        public string SalesAmount { get; set; }

        /// <summary>
        /// 課稅別
        /// 1：應稅
        /// 2：零稅率
        /// 3：免稅
        /// 4：應稅(特種稅率)
        /// 9：混合應稅與免稅或零稅率(限訊息C0401使用)
        /// </summary>
        [Required]
        [Display(Name = "課稅別")]
        public string TaxType { get; set; }

        /// <summary>
        /// 稅率
        /// 範例:稅率為 5% 時本欄位值為 0.05
        /// </summary>
        [Required]
        [Display(Name = "稅率")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 營業稅額
        /// 整數 (小數點以下四捨五入)
        /// </summary>
        [Required]
        [Display(Name = "營業稅額")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 總計
        /// 整數
        /// *請注意總計不應為負數
        /// </summary>
        [Required]
        [Display(Name = "總計")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 折扣金額 (選項)
        /// 整數
        /// 供營業人備註以便內部查看交易折扣註記使用
        /// </summary>
        [Display(Name = "折扣金額")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 原幣金額 (選項)
        /// 供營業人備註使用
        /// </summary>
        [Display(Name = "原幣金額")]
        public string OriginalCurrencyAmount { get; set; }

        /// <summary>
        /// 匯率 (選項)
        /// 供營業人備註使用
        /// </summary>
        [Display(Name = "匯率")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// 幣別 (選項)
        /// 供營業人備註使用
        /// </summary>
        [Display(Name = "幣別")]
        public string Currency { get; set; }

    }
}