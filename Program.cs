namespace hwLesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature[] array = new[]
            {
                new Temperature("12.03.2023", 10),
                new Temperature("13.03.2023", 15),
                new Temperature("14.03.2023", 20),
                new Temperature("15.03.2023", 25),
                new Temperature("16.03.2023", 30)
            };

            HydrometCentre hydrometCentre = new HydrometCentre(array);

            string date = "14.03.2023";
            Console.WriteLine(hydrometCentre[date].GetInformation());

            string startDate = "13.03.2023";
            string endDate = "15.03.2023";

            var result = hydrometCentre[startDate, endDate];

            if(result.Length == 0)
            {
                Console.WriteLine("Dates not found");
            }
            else
            {
                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine(result[i].GetInformation());
                }
            }
        }
    }
}