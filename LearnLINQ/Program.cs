// Join query syntax

using LearnLINQ;

var innerJoin = from person in Data.People
                join reservation in Data.Reservations
                on person.Id equals reservation.PersonId
                select $"{person.Name} has a reservation on " +
                        $"{reservation.Date}";

Console.WriteLine("innerJoin \n" + string.Join("\n", innerJoin));

var innerJoinThreeTables = from person in Data.People
                           join reservation in Data.Reservations
                           on person.Id equals reservation.PersonId
                           join restaurant in Data.Restaurants
                           on reservation.RestaurantId equals restaurant.Id
                           select $"{person.Name} has a reservation on " +
                                   $"{reservation.Date} " +
                                   $"at the {restaurant.Name}";

Console.WriteLine("innerJoinThreeTables \n" + string.Join("\n", innerJoinThreeTables));

var leftJoin = from person in Data.People
               join reservation in Data.Reservations
               on person.Id equals reservation.PersonId
               into personReservations
               from singleReservation
               in personReservations.DefaultIfEmpty()
               select $"{person.Name} has a reservation on " +
                       $"{singleReservation?.Date}";

Console.WriteLine("leftJoin \n" + string.Join("\n", leftJoin));


Console.ReadLine();