namespace hwLesson7
{
    struct Temperature
    {
        public string Date { get; set; }
        public double Celsius { get; set; }
        public double Fahrenheit { get; set; }
        public double Kelvin { get; set; }

        public Temperature(string date, double celsius, double farenheit, double celvin)
        {
            Date = date;
            Celsius = celsius;
            Fahrenheit = farenheit;
            Kelvin = celvin;
        }

        public void GetInformation()
        {
            Console.WriteLine($"{Date} temperature was {Celsius} C, {Fahrenheit} F, {Kelvin} K");
        }
    }
}
