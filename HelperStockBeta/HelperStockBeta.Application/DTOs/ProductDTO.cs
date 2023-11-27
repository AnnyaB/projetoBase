using HelperStockBeta.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelperStockBeta.Application.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        #region Name
        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName ("Name")]
        public string Name { get; set; }
        #endregion

        #region Description
        [Required(ErrorMessage = "The Description is Required")]
        [MinLength(5)]
        [MaxLength(100)]
        [DisplayName("Description")]
        public string Description { get; set; }
        #endregion

        #region Price
        [Required(ErrorMessage = "The Price is Required")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DataType(DataType.Currency)]
        [DisplayName("Price")]
        public decimal Price { get; set; }
        #endregion 

        #region Stock
        [Required(ErrorMessage = "The Stock is Required")]
        [Range(1, 9999, ErrorMessage = "Stock is positive values")]
        [DisplayName("Stock")]
        public int Stock { get; set; }
        #endregion

        #region Image
        [MaxLength(250)]
        [DisplayName("Product Image")]
        public string Image { get; set; }
        #endregion 

        public Category Category { get; set; }

        #region CategoryId
        [DisplayName("Categories")]
        public int CategoryId { get; set; }
        #endregion
    }
}
