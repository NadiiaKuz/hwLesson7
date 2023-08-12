namespace hwLesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature temperature1 = new Temperature("12.03.2023", 10, 50, 283.15);
            Temperature temperature2 = new Temperature("13.03.2023", 15, 59, 288.15);
            Temperature temperature3 = new Temperature("14.03.2023", 20, 68, 293.15);
            Temperature temperature4 = new Temperature("15.03.2023", 25, 77, 298.15);
            Temperature temperature5 = new Temperature("16.03.2023", 30, 86, 303.15);

            HydrometCentre hydrometCentre = new HydrometCentre(temperature1, temperature2, temperature3, temperature4, temperature5);

            //string date = "14.03.2023";
            //hydrometCentre.GetTemperatureByDate(date);

            string startDate = "13.03.2023";
            string endDate = "15.03.2023";

            GetTemperatureByPeriod(hydrometCentre, startDate, endDate);
        }

        public static void GetTemperatureByPeriod(HydrometCentre hydrometCentre, string start, string end)
        {
            int startPos = hydrometCentre[start];

            if (startPos == -1)
            {
                Console.WriteLine($"Start {start} not found");
                return;
            }

            int endPos = hydrometCentre[end];

            if (endPos == -1)
            {
                Console.WriteLine($"End {end} not found");
                return;
            }

            for (int i = startPos; i <= endPos; i++)
            {
                hydrometCentre.GetTemperatureByIndex(i).GetInformation();
            }
        }
    }
}