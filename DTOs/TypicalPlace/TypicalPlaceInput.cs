using System.ComponentModel.DataAnnotations;

namespace FoodShop.DTOs.TypicalPlace;

public record TypicalPlaceInput(
    [Required(AllowEmptyStrings = false, ErrorMessage = "The Food Typical Place must be informed!")]
    [MinLength(2, ErrorMessage = "Food Food Typical Places must be greater than 2 characters!")]
    [MaxLength(100, ErrorMessage = "Food Food Typical Places can not exceed 100 characters!")]
    string Country
);
