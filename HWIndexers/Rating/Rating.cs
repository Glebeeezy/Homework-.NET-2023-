using HWIndexers.Rating.Enums;
using HWIndexers.Tempreture.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWIndexers.Rating
{
    public class Rating
    {
        private int[,]? _rating;




        public int this[char group, string lastName]
        {
            get
            {

            }
            set
            {

                _rating[group, lastName] = value;
            }
        }
        private void CreateRating(uint numberOfClasses, uint numberOfStudentsPerClass)
        {
            _rating = new int[numberOfClasses, numberOfStudentsPerClass];
        }
        
        private int CheckNumber(string lastName)
        {
            
        }
        public Rating(uint numberOfClasses, uint numberOfStudentsPerClass)
        {
            CreateRating(numberOfClasses, numberOfStudentsPerClass);
        }
    }
}
