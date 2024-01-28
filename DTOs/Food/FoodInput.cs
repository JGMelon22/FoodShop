using System.ComponentModel.DataAnnotations;

namespace FoodShop.DTOs.Food;

public record FoodInput(

    [Required(ErrorMessage = "Food Name must be informed!")]
    [MinLength(2, ErrorMessage = "Food Name must be greater than 2 characters!")]
    [MaxLength(100, ErrorMessage = "Food Name can not exceed 100 characters!")]
    string FoodName,

    [Required(ErrorMessage = "Is Healthy status must be informed!")]
    // [AllowedValues(1, 0)]
    bool IsHealthy    
);
