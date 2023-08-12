using System.Diagnostics;


namespace hwLesson7
{
    class HydrometCentre
    {
        private Temperature[] temperatures;

        public HydrometCentre(Temperature temperature1, Temperature temperature2, Temperature temperature3, Temperature temperature4, Temperature temperature5)
        {
            temperatures = new Temperature[] {temperature1, temperature2, temperature3, temperature4, temperature5};
        }

        public void GetTemperatureByDate(string date)
        {
            for (int i = 0; i < temperatures.Length; i++)
            {
                if (temperatures[i].Date == date)
                {
                    temperatures[i].GetInformation();
                    return;
                }
            }
            Console.WriteLine("Date not found");
        }

        public Temperature GetTemperatureByIndex(int index)
        {
            return temperatures[index];
        }

        public int this[string index]
        {
            get
            {
                for (int i = 0; i < temperatures.Length; i++)
                {
                    if (temperatures[i].Date == index)
                    {
                        return i;
                    }
                }
                return -1;
            }
        }
    }
}
