namespace hwLesson7
{
    class HydrometCentre
    {
        private Temperature[] temperatures;

        public HydrometCentre(params Temperature[] temperatures)
        {
            this.temperatures = temperatures;
        }

        public Temperature this[string date]
        {
            get => GetTemperatureByDate(date);
        }

        public Temperature[] this[string start, string end]
        {
            get => GetTemperaturesByPeriod(start, end);
        }

        private int GetIndex(string date)
        {
            for (int i = 0; i < temperatures.Length; i++)
            {
                if (temperatures[i].Date == date.Trim())
                {
                    return i;
                }
            }

            return -1;
        }

        private Temperature GetTemperatureByDate(string date)
        {
            for (int i = 0; i < temperatures.Length; i++)
            {
                if (temperatures[i].Date == date.Trim())
                {
                    return temperatures[i];
                }
            }

            return new Temperature();
        }

        private Temperature[] GetTemperaturesByPeriod(string start, string end)
        {
            int startPos = GetIndex(start);

            if (startPos == -1)
            {
                return Array.Empty<Temperature>();
            }

            int endPos = GetIndex(end);

            if (endPos == -1)
            {
                return Array.Empty<Temperature>();
            }

            Temperature[] temp = new Temperature[endPos-startPos+1]; 
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = temperatures[startPos + i];
            }

            return temp;
        }
    }
}
