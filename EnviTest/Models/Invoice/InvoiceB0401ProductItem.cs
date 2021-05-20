namespace EnviTest.Models
{
    public class InvoiceB0401ProductItem
    {
        /// <summary>
        /// 原發票日期
        /// YYYYDMMDD
        /// </summary>
        public string OriginalInvoiceDate { get; set; }

        /// <summary>
        /// 原發票號碼
        /// </summary>
        public string OriginalInvoiceNumber { get; set; }

        /// <summary>
        /// 原明細排列序號
        /// </summary>
        public string OriginalSequenceNumber { get; set; }

        /// <summary>
        /// 原品名
        /// </summary>
        public string OriginalDescription { get; set; }

        /// <summary>
        /// 數量
        /// </summary>
        public string Quantity { get; set; }

        /// <summary>
        /// 單位
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 單價
        /// </summary>
        public string UnitPrice { get; set; }

        /// <summary>
        /// 小計金額(不含稅之進貨額)
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// 營業稅額
        /// </summary>
        public string Tax { get; set; }

        /// <summary>
        /// 折讓證明單明細排列序號
        /// </summary>
        public string AllowanceSequenceNumber { get; set; }

        /// <summary>
        /// 課稅別
        /// 1：應稅
        /// 2：零稅率
        /// 3：免稅
        /// 4：應稅(特種稅率)
        /// 9：混合應稅與免稅或零稅率(限訊息C0401使用)
        /// </summary>
        public string TaxType { get; set; }
    }
}