using System.ComponentModel.DataAnnotations;

namespace AreaCalculator.Models {
    public class AreaCalculatorModel {
        [Range(0,float.MaxValue,ErrorMessage ="You cannot enter a negative length.")]
        public float Length { get; set; }
        [Range(0, float.MaxValue, ErrorMessage = "You cannot enter a negative width.")]
        public float Width { get; set; }
        public float CalculatorArea() {
            return Length * Width;
        }
    }
}
