using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EnviTest.Models
{
    /// <summary>
    /// 平台存證開立折讓證明單/傳送折讓證明單通知
    /// </summary>
    public class InvoiceD0401
    {
        /*
         * Main 
         */
        
        /// <summary>
        /// 折讓證明單號碼
        /// </summary>
        [Required]
        [Display(Name = "折讓證明單號碼")]
        public string AllowanceNumber { get; set; }

        /// <summary>
        /// 折讓證明單日期
        /// YYYYDMMDD
        /// </summary>
        [Required]
        [Display(Name = "折讓證明單日期")]
        public string AllowanceDate { get; set; }

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
        /// 折讓種類
        /// 1:買方開立折讓證明單
        /// 2:賣方開立折讓證明通知單
        /// </summary>
        [Required]
        [Display(Name = "折讓種類")]
        public string AllowanceType { get; set; }

        /// <summary>
        /// 證明附件 (選項)
        /// </summary>
        [Required]
        [Display(Name = "證明附件")]
        public string Attachment { get; set; }

        /*
         * Details
         */

        public List<InvoiceD0401ProductItem> ProductItems { get; set; }

        /*
         * Amount 
         */

        /// <summary>
        /// 營業稅額合計
        /// 一、整數
        /// 二、境外電商營業人請填 0
        /// </summary>
        [Required]
        [Display(Name = "營業稅額合計")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 金額合計(不含稅之進貨額合 計)
        /// 一、國內營業人為不含稅之進貨額合計，應為整數
        /// 二、境外電商營業人請填入含稅金額合計。如以外幣列示，小數點後至多 2 位;如以新臺幣列示應為整數
        /// </summary>
        [Required]
        [Display(Name = "金額合計")]
        public string TotalAmount { get; set; }

    }
}