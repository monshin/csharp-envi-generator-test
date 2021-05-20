using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EnviTest.Models
{
    /// <summary>
    /// 分支機構配號檔
    /// </summary>
    public class InvoiceE0402
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
        /// 空白字軌
        /// 二碼英文(需為大寫)
        /// </summary>
        [Required]
        [Display(Name = "空白字軌")]
        public string InvoiceTrack { get; set; }

        /*
         * Details
         */

        public List<InvoiceE0402BranchTrackBlankItem> BranchTrackBlankItems { get; set; }

    }
}