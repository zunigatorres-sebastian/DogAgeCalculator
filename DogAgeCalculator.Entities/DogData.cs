using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogAgeCalculator.Entities
{
    public class DogData
    {
        public string OwnerName { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Breed { get; set; } = string.Empty;
        public int Age { get; set; }
        public int ConvertedAge { get; set; }
        public float Weight { get; set; }
        public DateTime Date { get; set; }
    }
}
