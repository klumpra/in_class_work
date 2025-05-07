using System.ComponentModel.DataAnnotations;

namespace Geometry.Models {
    public class RectangleModel {
        [Required(ErrorMessage ="The length is required.")]
        [Range(0,float.MaxValue,ErrorMessage ="The length must not be negative.")]
        public float Length { get; set; }
        [Required(ErrorMessage = "The width is required.")]
        [Range(0, float.MaxValue, ErrorMessage = "The width must not be negative.")]
        public float Width { get; set; }
        public string ToCalculate { get; set; } = "area";
        public float Measure { get; set; } = 0f;
        public void CalculateMeasure() {
            if (ToCalculate == "area") {
                Measure = Length * Width;
            } else {
                Measure = 2 * (Length + Width);
            }
        }

    }
}
