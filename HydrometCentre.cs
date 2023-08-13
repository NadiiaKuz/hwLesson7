namespace hwLesson7
{
    class HydrometCentre
    {
        private Temperature[] temperatures;

        public HydrometCentre(params Temperature[] temperatures)
        {
            this.temperatures = temperatures;
        }

        public string GetTemperatureByDate(string date)
        {
            for (int i = 0; i < temperatures.Length; i++)
            {
                if (temperatures[i].Date == date)
                {
                    return temperatures[i].GetInformation();
                }
            }
            return "Date not found";
        }

        public Temperature GetTemperatureByIndex(int index) =>
            temperatures[index];

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
