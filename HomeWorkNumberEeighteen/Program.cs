using System;
using System.Linq;
using ClassLibrary1;

namespace HomeWorkNumberEeighteen
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = '*';
            string text = "Если слова нет, то долно вернуться null. " +
                "Если больше одного исключение*. " +
                "Не спешите писать свое исключение";

            string[] words = text.Split(' ', ',', '.');
            var wordWithSymbol = words.SingleOrDefault(word => word.EndsWith(symbol));

            Console.WriteLine(wordWithSymbol);

            int[] numbers = { 5, 8, 0, -1, 6, 4, -1, -3 };

            var positiveNumbers = numbers.Where(number => number > 0).ToList();

            Console.WriteLine(positiveNumbers.Count());
            Console.WriteLine(positiveNumbers.Average());

            string sentence = "Женя скоро будет свободен, а у вас все только начинается";

            var sentenceWithoutO = new string(sentence.Where(character => character != 'о').ToArray());
            
            Console.WriteLine(sentenceWithoutO);

            CarDto[] carsDto =
            {
                new CarDto(1, "F10"),
                new CarDto(1, "F01"),
                new CarDto(1, "M5"),
                new CarDto(2, "W140"),
                new CarDto(2, "W201"),
                new CarDto(2, "W210"),
                new CarDto(3, "6"),
                new CarDto(3, "3"),
                new CarDto(3, "CX-5"),
            };

            BrandDto[] brandsDto =
            {
                new BrandDto(1, "BMW"),
                new BrandDto(2, "Mercedes-Benz"),
                new BrandDto(3, "Mazda"),
            };

            Brand[] brands = brandsDto.GroupJoin(
                carsDto, 
                brand => brand.Id, 
                car => car.BrandId, 
                (brand, cars) => new Brand(
                    brand.Name, 
                    cars.Select(car => new Car(car.Model))
                        .ToArray()))
                .ToArray();

            foreach (var brand in brands)
            {
                Console.Write(brand.Name + " ");

                foreach (var car in brand.Cars)
                {
                    Console.Write(car.Model + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
