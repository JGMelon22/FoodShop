using System.ComponentModel.DataAnnotations;

namespace FoodShop.DTOs.Category;

public record CategoryInput(
    [Required(AllowEmptyStrings = false, ErrorMessage = "Category Name must be informed!")]
    [MinLength(2, ErrorMessage = "Food Category must be greater than 2 characters!")]
    [MaxLength(100, ErrorMessage = "Food Category can not exceed 100 characters!")]
    string Name,
    [Required(ErrorMessage = "A valid Food Id must be informed!")]
    int FoodId
);