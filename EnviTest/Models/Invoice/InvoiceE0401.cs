using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EnviTest.Models
{
    /// <summary>
    /// 分支機構配號檔
    /// </summary>
    public class InvoiceE0401
    {
        /*
         * Main 
         */

        /// <summary>
        /// 總公司統一編號
        /// </summary>
        [Required]
        [Display(Name = "總公司統一編號")]
        public string HeadBan { get; set; }

        /// <summary>
        /// 分支機構統一編號
        /// </summary>
        [Required]
        [Display(Name = "分支機構統一編號")]
        public string BranchBan { get; set; }

        /// <summary>
        /// 發票類別
        /// 07:一般稅額計算之電子發票 
        /// 08:特種稅額計算之電子發票
        /// </summary>
        [Required]
        [Display(Name = "發票類別")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 發票期別
        /// 僅填雙月，例:
        /// 10202(表示 10201~10202)
        /// 10204(表示 10203~10204)
        /// </summary>
        [Required]
        [Display(Name = "發票期別")]
        public string YearMonth { get; set; }

        /// <summary>
        /// 發票字軌
        /// 二碼英文(需為大寫)
        /// </summary>
        [Required]
        [Display(Name = "發票字軌")]
        public string InvoiceTrack { get; set; }

        /// <summary>
        /// 發票起號
        /// 8 碼數字
        /// 發票起號需與電子發票整合服務平台配號一致
        /// </summary>
        [Required]
        [Display(Name = "發票起號")]
        public string InvoiceBeginNo { get; set; }

        /// <summary>
        /// 發票迄號
        /// 8 碼數字
        /// 發票迄號需與電子發票整合服務平台配號一致
        /// </summary>
        [Required]
        [Display(Name = "發票迄號")]
        public string InvoiceEndNo { get; set; }

        /*
         * Details
         */

        public List<InvoiceE0401BranchTrackItem> BranchTrackItems { get; set; }

    }
}