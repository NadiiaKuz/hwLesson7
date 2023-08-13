namespace hwLesson7
{
    struct Temperature
    {
        public string Date { get; }
        public double Celsius { get; }
        public double Fahrenheit { get; }
        public double Kelvin { get; }

        public Temperature(string date, double celsius, double farenheit, double celvin)
        {
            Date = date;
            Celsius = celsius;
            Fahrenheit = farenheit;
            Kelvin = celvin;
        }

        public string GetInformation() =>
            $"{Date} temperature was {Celsius} C, {Fahrenheit} F, {Kelvin} K";
    }
}
