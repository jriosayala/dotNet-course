class DateCalculator
{
    public DateTime GetDateTime(string prompt)
    {
        DateTime date;
        bool validDate = false;
        do
        {
            Console.WriteLine(prompt);
            string? input = Console.ReadLine();
            if (DateTime.TryParseExact(input, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out date))
            {
                validDate = true;
            }
            else
            {
                Console.WriteLine("Invalid date format. Enter proper format to cotinue");
            }
        } while (!validDate);
        return date;
    }
    public int DifferenceInDates(DateTime firstDate, DateTime secondDate) {
        TimeSpan dateDifference = secondDate - firstDate;
        return Math.Abs(dateDifference.Days);
    }
}