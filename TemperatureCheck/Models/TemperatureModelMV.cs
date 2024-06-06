using System.ComponentModel.DataAnnotations;

namespace TemperatureCheck.Models
{
    public class TemperatureModelMV
    {
        [Display(Name = "Temperature")]
        public float? Temperature { get; set; }
        public string GetDiagnosis()
        {

            if (Temperature.HasValue)
            {
                float temperature = Temperature.Value;
                if (temperature >= 35 && temperature < 37.5)
                {
                    return "You have a Normal temperature";
                }
                if (temperature >= 37.5 && temperature < 39)
                {
                    return "You have a Fever";
                }
                if (temperature < 35)
                {
                    return "Your temperature is very low";
                }
                return "You have a High fever and need to check with the doctor immediately";
            }
            return null;
        }
    }
}
