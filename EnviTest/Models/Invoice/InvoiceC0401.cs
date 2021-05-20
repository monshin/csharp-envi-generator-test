using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EnviTest.Models
{
    /// <summary>
    /// 平台存證開立發票訊息規格
    /// </summary>
    public class InvoiceC0401
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
        /// 發票日期
        /// </summary>
        [Required]
        [Display(Name = "發票日期(YYYYDMMDD)")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 發票時間
        /// </summary>
        [Required]
        [Display(Name = "發票時間(HH:mm:ss)")]
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
        /// 載具類別號碼
        /// </summary>
        [Display(Name = "載具類別號碼")]
        public string CarrierType { get; set; }

        /// <summary>
        /// 載具顯碼 id
        /// </summary>
        [Display(Name = "載具顯碼 id")]
        public string CarrierId1 { get; set; }

        /// <summary>
        /// 載具隱碼 id
        /// </summary>
        [Display(Name = "載具隱碼 id")]
        public string CarrierId2 { get; set; }

        /// <summary>
        /// 電子發票證明聯已列印註記
        /// </summary>
        [Required]
        [Display(Name = "電子發票證明聯已列印註記(Y/N)")]
        public string PrintMark { get; set; }

        /// <summary>
        /// 發票捐贈對象 (選項)
        /// 捐贈捐贈碼請將捐贈碼資料 3-7 碼「完整」填入
        /// </summary>
        [Display(Name = "發票捐贈對象")]
        public string NPOBAN { get; set; }

        /// <summary>
        /// 發票防偽隨機碼
        /// 交易當下隨機產生，4 位數值，少於 4 位者踢退
        /// </summary>
        [Required]
        [StringLength(4, ErrorMessage = "必須為 4 位數值", MinimumLength = 4)]
        [Display(Name = "發票防偽隨機碼")]
        public string RandomNumber { get; set; }

        /*
         * Details
         */

        public List<InvoiceC0401ProductItem> ProductItems { get; set; }

        /*
         * Amount 
         */

        /// <summary>
        /// 應稅銷售額合計
        /// 一、整數(小數點以下四捨五入)
        /// 二、境外電商營業人如以外 幣列示，小數點後至多 2 位。如以新臺幣列示應為整數(小數點以下四 捨五入)
        /// 三、若無此交易則填 0
        /// </summary>
        [Required]
        [Display(Name = "應稅銷售額合計")]
        public string SalesAmount { get; set; }

        /// <summary>
        /// 免稅銷售額合計
        /// 一、以新臺幣列示應為整數 (小數點以下四捨五入)
        /// 二、若無此交易則填 0
        /// </summary>
        [Required]
        [Display(Name = "免稅銷售額合計")]
        public string FreeTaxSalesAmount { get; set; }

        /// <summary>
        /// 零稅率銷售額合計
        /// 一、以新臺幣列示應為整數 (小數點以下四捨五入)
        /// 二、若無此交易則填 0
        /// </summary>
        [Required]
        [Display(Name = "零稅率銷售額合計")]
        public string ZeroTaxSalesAmount { get; set; }

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
        /// 以新臺幣列示應為整數 (小數點以下四捨五入)
        /// </summary>
        [Required]
        [Display(Name = "營業稅額")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 總計
        /// 一、整數
        /// 二、境外電商營業人如以外幣列示，小數點後至多 2 位
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
        /// 一、供營業人備註使用
        /// 二、境外電商營業人為必填
        /// </summary>
        [Display(Name = "幣別")]
        public string Currency { get; set; }

    }

}