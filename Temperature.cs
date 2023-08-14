namespace hwLesson7
{
    struct Temperature
    {
        public string Date { get; }
        public double Celsius { get; }
        public double Fahrenheit { get; }
        public double Kelvin { get; }

        public Temperature(string date, double celsius)
        {
            Date = date;
            Celsius = celsius;
            Fahrenheit = (celsius * 1.8) + 32;
            Kelvin = celsius + 273.15;
        }

        public string GetInformation() =>
            $"{Date} temperature was {Celsius} C, {Fahrenheit} F, {Kelvin} K";
    }
}
