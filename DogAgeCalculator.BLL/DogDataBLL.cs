using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DogAgeCalculator.DAL;
using DogAgeCalculator.Entities;

namespace DogAgeCalculator.BLL
{
    public class DogDataBLL
    {


        /// <summary>
        /// Fetches the complete list of registered dogs from the Data Access Layer.
        /// </summary>
        /// <returns>A list of <see cref="DogData"/> objects.</returns>
        public List<DogData> GetDogs()
        {
            return DogDataDAL.GetRecords();
        }


        /// <summary>
        /// Processes a new dog registration by validating input data and calculating the equivalent human age.
        /// </summary>
        /// <remarks>NOTE: This method uses fictional business rules for demonstration purposes.</remarks>
        /// <param name="ownerName">The name of the dog's owner.</param>
        /// <param name="dogName">The name of the dog.</param>
        /// <param name="dogAge">The dog's age as a numeric string.</param>
        /// <param name="dogWeight">The dog's weight in kilograms as a numeric string.</param>
        /// <param name="dogBreed">The breed of the dog.</param>
        /// <param name="localDate">The registration date.</param>
        /// <returns>The calculated human age equivalent.</returns>
        /// <exception cref="Exception">Thrown when validation fails for any input field or age/weight ranges.</exception>
        public int AddDog(string ownerName, string dogName, string dogAge, string dogWeight, string dogBreed, DateTime localDate)
        {

            // ---------------------------------------------------------
            // 1. INPUT VALIDATION
            // ---------------------------------------------------------
            if (string.IsNullOrWhiteSpace(ownerName))
            {
                throw new Exception("The owner's name field cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(dogName))
            {
                throw new Exception("The dog's name field cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(dogAge) || !dogAge.All(char.IsDigit))
            {
                throw new Exception("Invalid value for dog's age.");
            }

            int dog_Age = int.Parse(dogAge);
            if (dog_Age < 0 || dog_Age > 30)
            {
                throw new Exception("The dog's age is out of range; it must be between 0 and 30 years.");
            }

            if (string.IsNullOrWhiteSpace(dogWeight) || !dogWeight.All(char.IsDigit))
            {
                throw new Exception("Invalid value for dog's weight.");
            }

            int dog_Weight = int.Parse(dogWeight);
            if (dog_Weight < 1 || dog_Weight > 30)
            {
                throw new Exception("The dog's weight is out of range; it must be between 1 and 30 kg.");
            }

            if (string.IsNullOrWhiteSpace(dogBreed))
            {
                throw new Exception("The dog breed field cannot be empty.");
            }

            // ---------------------------------------------------------
            // 2. AGE CONVERSION LOGIC (Human Years) 
            // ---------------------------------------------------------
            int converted_Age = 0;

            if (dog_Age == 0)
            {
                converted_Age = 0;
            }
            else if (dog_Age == 1)
            {
                converted_Age = 15;
            }
            else if (dog_Age == 2)
            {
                converted_Age = 21;
            }
            else
            {
                int additional_Age = dog_Age - 2;
                converted_Age = 21 + (additional_Age * 4);
            }

            // ---------------------------------------------------------
            // 3. BALANCE ADJUSTMENT (Fictional business rules for demo)
            // ---------------------------------------------------------
            if (converted_Age >= 50)
            {
                converted_Age -= 5;
            }
            else if (converted_Age > 0)
            {
                converted_Age -= 2;
            }

            // ---------------------------------------------------------
            // 4. DATA PERSISTENCE
            // ---------------------------------------------------------
            DogData data = new DogData
            {
                OwnerName = ownerName,
                Name = dogName,
                Age = dog_Age,
                ConvertedAge = converted_Age,
                Weight = dog_Weight,
                Breed = dogBreed,
                Date = localDate
            };

            DogDataDAL.SaveRecord(data);
            return converted_Age;
        }
    }
}
