namespace FitnessTracker.Data
{
    public class ProfileInfo
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public int Goal { get; set; }
        public string Email { get; set; }
        public string WeightMes { get; set; }
        public string GoalMes { get; set; }
        public string HeightMes { get; set; }
    }

    public class Activity
    {
        public string Name { get; set; }
        public string ActivityType { get; set; }
        public string Duration { get; set; }
        public int Count { get; set; }
        public string Amount { get; set; }
        public string Distance { get; set; }
        public string Percentage { get; set; }
        public string Time { get; set; }
    }

    public class ChartData
    {
        public DateTime X { get; set; }
        public double Y { get; set; }
    }
    public class GridData
    {
        public string Workout { get; set; }
        public double Distance { get; set; }
        public double Duration { get; set; }
        public DateTime Date { get; set; }
        public double Completion { get; set; }
    }

    public class PieChartData
    {
        public string X { get; set; }
        public double Y { get; set; }
        public string Fill { get; set; }
    }

    public class MenuItems
    {
        public string Item { get; set; }
        public int Cal { get; set; }
        public double Fat { get; set; }
        public double Carbs { get; set; }
        public double Proteins { get; set; }
        public double Sodium { get; set; }
        public double Iron { get; set; }
        public double Calcium { get; set; }
        public bool IsAdded { get; set; }
    }
}