// Zip

using LearnLINQ;

var numbersZippedWithWords = Data.Numbers
                    .Zip(Data.Words,
                        (number, word) => $"{number}, {word}"
                     );

Console.WriteLine("numbersZippedWithWords \n" + string.Join("\n", numbersZippedWithWords));

var countries = new[] { "USA", "Japan" };
var currencies = new[] { "USD", "Yen" };

var countryCurrencyDictionary = countries
                                    .Zip(currencies)
                                    .ToDictionary(
                                        tuple => tuple.First,
                                        tuple => tuple.Second
                                    );
Console.WriteLine("countryCurrencyDictionary \n" + string.Join("\n", countryCurrencyDictionary));

Console.ReadLine();