namespace DictionaryReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, ConsoleColor> errorsColors = new Dictionary<char, ConsoleColor>()
            {
               {'*', ConsoleColor.Red },
               { '#', ConsoleColor.Green },
               { '%', ConsoleColor.Blue}
            };

            errorsColors['*'] = ConsoleColor.White;
            errorsColors['&'] = ConsoleColor.Yellow;



            Console.ForegroundColor = errorsColors['&'];
            Console.WriteLine("Error");


            var point1 = new Point(1, 2);
            var point2 = new Point(2, 3);
            var point3 = new Point(1, 2);


            Console.WriteLine(point1.GetHashCode());


            var pointsDictionary = new Dictionary<Point, string>()
                {
                    { point1, "First Point" },
                    { point2, "Second Point" },
                    { point3, "Third Point" }
                };

            Console.WriteLine(pointsDictionary[3]);
        }

   var dic2 = divisions
    .Where(d => !d.Disabled)
    .GroupBy(d => new { d.CityID, d.AreaID })
    .Where(g => !string.IsNullOrWhiteSpace(g.Key.CityID))
    .OrderBy(g => g.First().City.SortOrder)
    .ToDictionary(g => g.Key.CityID,
     g =>
           g.Select(groupAreas => new AreaWithDivisions
           {
               AreaID = groupAreas.Key.AreaID ?? string.Empty,
               AreaNameUa = groupAreas.First()?.AreaUA ?? string.Empty,
               AreaNameRu = groupAreas.First()?.AreaRU ?? string.Empty,
               Divisions = groupAreas.ToList()
           })
           .OrderBy(ga => ga.AreaNameUa)
    }
}
