using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace GrantTest.Models;

public class Product
{
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Product Name is required")]
    [DisplayName("Product Name")]
    public required string ProductName { get; set; }

    [Required(ErrorMessage = "Price is required")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
    [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = true, ConvertEmptyStringToNull = true)]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Creation Date is required")]
    [DisplayName("Creation Date")]
    [DataType(DataType.Date)]
    public DateTime CreationDate { get; set; }
}
