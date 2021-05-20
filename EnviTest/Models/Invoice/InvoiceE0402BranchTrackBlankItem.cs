using System.ComponentModel.DataAnnotations;

namespace EnviTest.Models
{
    public class InvoiceE0402BranchTrackBlankItem
    {
        /// <summary>
        /// 空白發票起號
        /// 8 碼數字
        /// </summary>
        [Required]
        [Display(Name = "空白發票起號")]
        public string InvoiceBeginNo { get; set; }

        /// <summary>
        /// 空白發票迄號
        /// 8 碼數字
        /// </summary>
        [Required]
        [Display(Name = "空白發票迄號")]
        public string InvoiceEndNo { get; set; }
    }
}