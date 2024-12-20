using System.ComponentModel.DataAnnotations;

namespace Lab_12.Models
{
    public enum OperationType
    {
        [Display(Name = "+")]
        Add,
        [Display(Name = "-")]
        Subtract,
        [Display(Name = "*")]
        Multiply,
        [Display(Name = "/")]
        Divide
    }
}

