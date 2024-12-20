using System.ComponentModel.DataAnnotations;

namespace Lab_12.Models
{
    public class CalcModel
    {
        [Required(ErrorMessage = "error")]
        public double Num1 { get; set; }

        [Required(ErrorMessage = "error")]
        public double Num2 { get; set; }

        [Required(ErrorMessage = "error")]
        public OperationType Operation { get; set; }
    }
}
