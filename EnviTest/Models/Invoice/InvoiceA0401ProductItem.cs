namespace EnviTest.Models
{
    public class InvoiceA0401ProductItem
    {
        /// <summary>
        /// 產品名稱
        /// </summary>
        public string Description { get; set; }

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
        /// 小計金額
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// 明細排列序號
        /// </summary>
        public string SequenceNumber { get; set; }

        /// <summary>
        /// 單一欄位備註 (選項)
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 相關號碼 (選項)
        /// 一、商品條碼填列方式:{編碼類別代號及商品編碼}，編碼類別代號如下:
        ///     (一) A:國際商品編碼
        ///     (二) Z:其他商品編碼(包含店內碼) 
        /// 二、範例:
        ///     (一) 商品編碼為「國際商品編碼」 4710110228954，則上傳資訊為 { A4710110228954 }
        ///     (二) 商品編碼為「其他商品編碼(包含店內碼)」 2602970677234，則上傳資訊為 { Z2602970677234 }
        /// </summary>
        public string RelateNumber { get; set; }
    }
}