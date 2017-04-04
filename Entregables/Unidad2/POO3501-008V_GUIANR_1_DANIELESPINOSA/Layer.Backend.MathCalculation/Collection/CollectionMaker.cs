using System.Collections.Generic;
using Layer.Backend.MathCalculation.Entities.Dto;
using Layer.Backend.MathCalculation.Random;

namespace Layer.Backend.MathCalculation.Collection
{
    public class CollectionMaker
    {

        /// <summary>
        /// ATR: Obtiene, una colección de NumbersDto, pasando por parámetro los límites de los números random a generar
        /// y la cantidad de números. 
        /// </summary>
        /// <param name="HowManyRandomNumbers"></param>
        /// <param name="limitByComa"></param>
        /// <returns></returns>
        public List<NumbersDto> GetRandomCollectionByParameter(int HowManyRandomNumbers, string limitByComa)
        {
            var randomCollection = default(List<NumbersDto>);

            if (!string.IsNullOrEmpty(limitByComa) && (!HowManyRandomNumbers.Equals(default(int))))
            {
                var randomHelper = new RandomMaker();
                randomCollection = new List<NumbersDto>();

                for (var iterator = 0; iterator < HowManyRandomNumbers; iterator++)
                {
                    randomCollection.Add(new NumbersDto()
                    {
                        Number = randomHelper.GetRandomValuesByLimits(limitByComa),
                        Index = iterator
                    }); 
                    
                }
            }

            return randomCollection;
        } 
    }
}
