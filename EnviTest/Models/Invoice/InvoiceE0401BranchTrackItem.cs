using System.ComponentModel.DataAnnotations;

namespace EnviTest.Models
{
    public class InvoiceE0401BranchTrackItem
    {
        /// <summary>
        /// 發票起號
        /// 8 碼數字
        /// </summary>
        [Required]
        [Display(Name = "發票起號")]
        public string InvoiceBeginNo { get; set; }

        /// <summary>
        /// 發票迄號
        /// 8 碼數字
        /// </summary>
        [Required]
        [Display(Name = "發票迄號")]
        public string InvoiceEndNo { get; set; }

        /// <summary>
        /// 本組數
        /// </summary>
        [Required]
        [Display(Name = "本組數")]
        public string InvoiceBooklet { get; set; }

    }
}