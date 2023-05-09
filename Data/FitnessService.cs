using FitnessTracker.Pages;

namespace FitnessTracker.Data
{
    public class FitnessService
    {
        public bool IsDevice { get; set; }
        public bool IsSmallDevice { get; set; }
        public double InnerWidth { get; set; }
        public DateTime? CurrentDate { get; set; } = DateTime.Now;
        public List<Activity> TodayActivities { get; set; }
        public ProfileInfo ProfileStats { get; set; }
        
        public int ExpectedCalories { get; set; } = 3000;
        
        public List<FitnessService> MasterData { get; set; }
        internal ActivitiesData ActivitiesData { get; set; } = new ActivitiesData();
        internal DietData DietData { get; set; } = new DietData();
        internal FastingData FastingData { get; set; } = new FastingData();
        internal ProfileDialog ProfileDialogRef { get; set; }
        internal AddMenuDialog MenuDialogRef { get; set; }


        internal void GetInitialData()
        {
            FitnessService data = new FitnessService();
            if (MasterData?.Count > 0)
            {
                data = MasterData.First();
                ActivitiesData.Steps = data.ActivitiesData.Steps;
                ActivitiesData.HeartRate = data.ActivitiesData.HeartRate;
                ActivitiesData.SleepInMinutes = data.ActivitiesData.SleepInMinutes;
                ActivitiesData.GridData = data.ActivitiesData.GridData;
                ActivitiesData.ChartDietData = data.ActivitiesData.ChartDietData;
                ActivitiesData.ChartData = data.ActivitiesData.ChartData;
                ActivitiesData.ActivityChartMonthData = data.ActivitiesData.ActivityChartMonthData;
                ActivitiesData.ActivityChartWeekData = data.ActivitiesData.ActivityChartWeekData;  
                DietData.ConsumedCalories = data.DietData.ConsumedCalories;
                DietData.BurnedCalories = data.DietData.BurnedCalories;
                DietData.CurrentBreakFastMenu = data.DietData.CurrentBreakFastMenu;
                DietData.CurrentBreakFastCalories = data.DietData.CurrentBreakFastCalories;
                DietData.CurrentBreakFastMenuText = data.DietData.CurrentBreakFastMenuText;
                DietData.IsBreakFastMenuAdded = data.DietData.IsBreakFastMenuAdded;
                DietData.CurrentSnack1Menu = data.DietData.CurrentSnack1Menu;
                DietData.CurrentSnack1Calories = data.DietData.CurrentSnack1Calories;
                DietData.CurrentSnack1MenuText = data.DietData.CurrentSnack1MenuText;
                DietData.IsSnack1MenuAdded = data.DietData.IsSnack1MenuAdded;
                DietData.CurrentLunchMenu = data.DietData.CurrentLunchMenu;
                DietData.CurrentLunchCalories = data.DietData.CurrentLunchCalories;
                DietData.CurrentLunchMenuText = data.DietData.CurrentLunchMenuText;
                DietData.IsLunchMenuAdded = data.DietData.IsLunchMenuAdded;
                DietData.CurrentTotalProteins = data.DietData.CurrentTotalProteins;
                DietData.CurrentTotalFat = data.DietData.CurrentTotalFat;
                DietData.CurrentTotalCarbs = data.DietData.CurrentTotalCarbs;
                DietData.CurrentTotalCalcium = data.DietData.CurrentTotalCalcium;
                DietData.CurrentTotalSodium = data.DietData.CurrentTotalSodium;
                DietData.CurrentTotalIron = data.DietData.CurrentTotalIron;
                FastingData.ConsumedWaterCount = data.FastingData.ConsumedWaterCount;
                FastingData.ConsumedWaterAmount = data.FastingData.ConsumedWaterCount * 150;
                FastingData.WeightChartData = data.FastingData.WeightChartData;
            }
            else
            {
                MasterData = new List<FitnessService>();
                Random random = new Random();
                int morningWalk = (int)Math.Round(random.NextDouble() * (3000 - 1000) + 1000);
                int breakfastWaterTaken = (int)Math.Round(random.NextDouble() * (5 - 2) + 2);
                int lunchWaterTaken = (int)Math.Round(random.NextDouble() * (5 - 2) + 2);
                ActivitiesData.Steps = morningWalk;
                ActivitiesData.HeartRate = (int)Math.Round(random.NextDouble() * (100 - 70) + 70);
                ActivitiesData.SleepInMinutes = (int)Math.Round(random.NextDouble() * (480 - 300) + 300);
                FastingData.ConsumedWaterCount = breakfastWaterTaken + lunchWaterTaken;
                FastingData.ConsumedWaterAmount = FastingData.ConsumedWaterCount * 150;
                data.CurrentDate = CurrentDate;
                data.ActivitiesData.Steps = ActivitiesData.Steps;
                data.ActivitiesData.HeartRate = ActivitiesData.HeartRate;
                data.ActivitiesData.SleepInMinutes = ActivitiesData.SleepInMinutes;
                data.ActivitiesData.ChartDietData = ActivitiesData.ChartDietData;
                data.ActivitiesData.ChartData = ActivitiesData.ChartData;
                data.ActivitiesData.GridData = ActivitiesData.GridData;
                data.ActivitiesData.ActivityChartMonthData = ActivitiesData.ActivityChartMonthData;
                data.ActivitiesData.ActivityChartWeekData = ActivitiesData.ActivityChartWeekData;
                data.ActivitiesData.MorningWalk = morningWalk;
                data.DietData.CurrentBreakFastMenu = DietData.CurrentBreakFastMenu;
                data.DietData.CurrentBreakFastCalories = DietData.CurrentBreakFastCalories;
                data.DietData.CurrentBreakFastMenuText = DietData.CurrentBreakFastMenuText;
                data.DietData.IsBreakFastMenuAdded = DietData.IsBreakFastMenuAdded;
                data.DietData.CurrentSnack1Menu = DietData.CurrentSnack1Menu;
                data.DietData.CurrentSnack1Calories = DietData.CurrentSnack1Calories;
                data.DietData.CurrentSnack1MenuText = DietData.CurrentSnack1MenuText;
                data.DietData.IsSnack1MenuAdded = DietData.IsSnack1MenuAdded;
                data.DietData.CurrentLunchMenu = DietData.CurrentLunchMenu;
                data.DietData.CurrentLunchCalories = DietData.CurrentLunchCalories;
                data.DietData.CurrentLunchMenuText = DietData.CurrentLunchMenuText;
                data.DietData.IsLunchMenuAdded = DietData.IsLunchMenuAdded;
                data.DietData.ConsumedCalories = DietData.ConsumedCalories;
                data.DietData.BurnedCalories = DietData.BurnedCalories;
                data.DietData.BreakfastWaterTaken = breakfastWaterTaken;
                data.DietData.LunchWaterTaken = lunchWaterTaken;
                data.DietData.CurrentTotalProteins = DietData.CurrentTotalProteins;
                data.DietData.CurrentTotalFat = DietData.CurrentTotalFat;
                data.DietData.CurrentTotalCarbs = DietData.CurrentTotalCarbs;
                data.DietData.CurrentTotalCalcium = DietData.CurrentTotalCalcium;
                data.DietData.CurrentTotalSodium = DietData.CurrentTotalSodium;
                data.DietData.CurrentTotalIron = DietData.CurrentTotalIron;
                data.FastingData.WeightChartData = FastingData.WeightChartData;
                data.FastingData.ConsumedWaterCount = FastingData.ConsumedWaterCount;
                MasterData.Add(data);
            }
            TodayActivities = new List<Activity>()
            {
                new Activity { Name = "Morning Walk", ActivityType ="Morning Walk", Duration = "30m", Distance = ((double)data.ActivitiesData.MorningWalk / 1312).ToString("0.00").Replace(".00", string.Empty) + "Km", Percentage = (((double)data.ActivitiesData.MorningWalk / 6000) * 100).ToString("0.00").Replace(".00", string.Empty) + "%", Time = "7:00 AM" },
                new Activity { Name = "Breakfast Water", ActivityType ="Water Taken", Count = data.DietData.BreakfastWaterTaken, Amount = data.DietData.BreakfastWaterTaken + " Glasses", Percentage = ((((double)data.DietData.BreakfastWaterTaken * 150) / data.FastingData.ExpectedWaterAmount) * 100).ToString("0.00").Replace(".00", string.Empty) + "%", Time = "7:40 AM" },
                new Activity { Name = "Breakfast", ActivityType ="Breakfast", Amount = data.DietData.CurrentBreakFastMenuText, Percentage = (((double)data.DietData.CurrentBreakFastCalories / ExpectedCalories) * 100).ToString("0.00").Replace(".00", string.Empty) + "%", Time = "9:00 AM" },
                new Activity { Name = "Snack1", ActivityType ="Snack", Amount = data.DietData.CurrentSnack1MenuText, Percentage = (((double)data.DietData.CurrentSnack1Calories / ExpectedCalories) * 100).ToString("0.00").Replace(".00", string.Empty) + "%", Time = "11:00 AM" },
                new Activity { Name = "Lunch Water", ActivityType ="Water Taken", Count = data.DietData.LunchWaterTaken, Amount = data.DietData.LunchWaterTaken + " Glasses", Percentage = ((((double)data.DietData.LunchWaterTaken * 150) / data.FastingData.ExpectedWaterAmount) * 100).ToString("0.00").Replace(".00", string.Empty) + "%", Time = "12:00 PM" },
                new Activity { Name = "Lunch", ActivityType ="Lunch", Amount = data.DietData.CurrentLunchMenuText, Percentage = (((double)data.DietData.CurrentLunchCalories / ExpectedCalories) * 100).ToString("0.00").Replace(".00", string.Empty) + "%", Time = "1:00 PM" }
            };
        }
        internal void UpdateConsumedCalories()
        {
            DietData.CurrentTotalProteins = 0;
            DietData.CurrentTotalFat = 0;
            DietData.CurrentTotalCarbs = 0;
            DietData.CurrentTotalCalcium = 0;
            DietData.CurrentTotalIron = 0;
            DietData.CurrentTotalSodium = 0;
            DietData.ConsumedCalories = 0;
            Dictionary<string, object> currentMenuData;
            if (DietData.IsBreakFastMenuAdded)
            {
                currentMenuData = GetMenuData(DietData.CurrentBreakFastMenu);
                DietData.CurrentBreakFastMenuText = string.Join(", ", currentMenuData["menuText"] as List<string>);
                DietData.CurrentBreakFastCalories = (int)currentMenuData["calories"];
                DietData.ConsumedCalories += DietData.CurrentBreakFastCalories;
            }
            if (DietData.IsSnack1MenuAdded)
            {
                currentMenuData = GetMenuData(DietData.CurrentSnack1Menu);
                DietData.CurrentSnack1MenuText = string.Join(", ", currentMenuData["menuText"] as List<string>);
                DietData.CurrentSnack1Calories = (int)currentMenuData["calories"];
                DietData.ConsumedCalories += DietData.CurrentSnack1Calories;
            }
            if (DietData.IsLunchMenuAdded)
            {
                currentMenuData = GetMenuData(DietData.CurrentLunchMenu);
                DietData.CurrentLunchMenuText = string.Join(", ", currentMenuData["menuText"] as List<string>);
                DietData.CurrentLunchCalories = (int)currentMenuData["calories"];
                DietData.ConsumedCalories += DietData.CurrentLunchCalories;
            }
            if (DietData.IsSnack2MenuAdded)
            {
                currentMenuData = GetMenuData(DietData.CurrentSnack2Menu);
                DietData.CurrentSnack2MenuText = string.Join(", ", currentMenuData["menuText"] as List<string>);
                DietData.CurrentSnack2Calories = (int)currentMenuData["calories"];
                DietData.ConsumedCalories += DietData.CurrentSnack2Calories;
            }
            if (DietData.IsDinnerMenuAdded)
            {
                currentMenuData = GetMenuData(DietData.CurrentDinnerMenu);
                DietData.CurrentDinnerMenuText = string.Join(", ", currentMenuData["menuText"] as List<string>);
                DietData.CurrentDinnerCalories = (int)currentMenuData["calories"];
                DietData.ConsumedCalories += DietData.CurrentDinnerCalories;
            }
        }
        private Dictionary<string, object> GetMenuData(List<MenuItems> menuItem)
        {
            List<string> menuText = new List<string>();
            double proteins = 0;
            double fat = 0;
            double carbs = 0;
            double calcium = 0;
            double iron = 0;
            double sodium = 0;
            int calories = 0;
            menuItem.ForEach(x =>
            {
                menuText.Add(x.Item);
                proteins += x.Proteins;
                fat += x.Fat;
                carbs += x.Carbs;
                calcium += x.Calcium;
                iron += x.Iron;
                sodium += x.Sodium;
                calories += x.Cal;
            });
            DietData.CurrentTotalProteins = Convert.ToDouble((DietData.CurrentTotalProteins + proteins).ToString("0.00").Replace(".00", string.Empty));
            DietData.CurrentTotalFat = Convert.ToDouble((DietData.CurrentTotalFat + fat).ToString("0.00").Replace(".00", string.Empty));
            DietData.CurrentTotalCarbs = Convert.ToDouble((DietData.CurrentTotalCarbs + carbs).ToString("0.00").Replace(".00", string.Empty));
            DietData.CurrentTotalCalcium = Convert.ToDouble((DietData.CurrentTotalCalcium + calcium).ToString("0.00").Replace(".00", string.Empty));
            DietData.CurrentTotalIron = Convert.ToDouble((DietData.CurrentTotalIron + iron).ToString("0.00").Replace(".00", string.Empty));
            DietData.CurrentTotalSodium = Convert.ToDouble((DietData.CurrentTotalSodium + sodium).ToString("0.00").Replace(".00", string.Empty));
            return new Dictionary<string, object>
            {
                { "menuText", menuText },
                { "calories", calories }
            };
        }
        internal ProfileInfo GetProfileStats()
        {
            return new ProfileInfo
            {
                Name = "John Watson",
                Age = 24,
                Location = "India",
                Weight = 70,
                Height = 165,
                Goal = 65,
                Email = "john.watson@gmail.com",
                WeightMes = "kg",
                GoalMes = "kg",
                HeightMes = "cm"
            };
        }

        internal List<MenuItems> GetBreakfastMenu()
        {
            return new List<MenuItems>()
            {
                new MenuItems { Item = "Banana", Cal = 105, Fat = 0.4, Carbs = 27, Proteins = 1.3, Sodium = 0.0012, Iron = 0.00031, Calcium = 0.005 },
                new MenuItems { Item = "Bread", Cal = 77, Fat = 1, Carbs = 14, Proteins = 2.6, Sodium = 0.142, Iron = 0.0036, Calcium = 0.260 },
                new MenuItems { Item = "Boiled Egg", Cal = 78, Fat = 5.3, Carbs = 0.6, Proteins = 6.3, Sodium = 0.062, Iron = 0.001, Calcium = 0.05  },
                new MenuItems { Item = "Wheat Chapathi", Cal = 120, Fat = 3.7, Carbs = 18, Proteins = 3.1, Sodium = 0.119, Iron = 0.001, Calcium = 0.01 },
                new MenuItems { Item = "Dosa", Cal = 168, Fat = 3.7, Carbs = 29, Proteins = 3.9, Sodium = 0.094, Iron = 0.0005, Calcium = 0.01 },
                new MenuItems { Item = "Tea", Cal = 5, Fat = 0.1, Carbs = 1.4, Proteins = 0.1, Sodium = 0.0008, Iron = 0, Calcium = 0.02 },
                new MenuItems { Item = "Coffee", Cal = 2, Fat = 0.1, Carbs = 0, Proteins = 0.3, Sodium = 0.047, Iron = 0, Calcium = 0.039 },
                new MenuItems { Item = "Milk", Cal = 122, Fat = 4.8, Carbs = 12, Proteins = 8.1, Sodium = 0.115, Iron = 0, Calcium = 0.125 }
            };
        }

        internal List<MenuItems> GetSnackMenu()
        {
            return new List<MenuItems>()
            {
                new MenuItems { Item = "Banana", Cal = 105, Fat = 0.4, Carbs = 27, Proteins = 1.3, Sodium = 0.0012, Iron = 0.00031, Calcium = 0.006 },
                new MenuItems { Item = "Apple", Cal = 95, Fat = 0.3, Carbs = 25, Proteins = 0.5, Sodium = 0.018, Iron = 0.0001, Calcium = 0.0085 },
                new MenuItems { Item = "Orange", Cal = 69, Fat = 0.2, Carbs = 18, Proteins = 1.3, Sodium = 0.0014, Iron = 0.0001, Calcium = 0.04 },
                new MenuItems { Item = "Samosa", Cal = 262, Fat = 17, Carbs = 24, Proteins = 3.5, Sodium = 0.423, Iron = 0.0005, Calcium = 0.013 },
                new MenuItems { Item = "Peas", Cal = 134, Fat = 0.3, Carbs = 25, Proteins = 8.6, Sodium = 0.048, Iron = 0.00015, Calcium = 0.036 },
                new MenuItems { Item = "Tea", Cal = 5, Fat = 0.1, Carbs = 1.4, Proteins = 0.1, Sodium = 0.0008, Iron = 0, Calcium = 0.02 },
                new MenuItems { Item = "Coffee", Cal = 2, Fat = 0.1, Carbs = 0, Proteins = 0.3, Sodium = 0.047, Iron = 0, Calcium = 0.039 },
                new MenuItems { Item = "Biscuits", Cal = 37, Fat = 1.2, Carbs = 6.2, Proteins = 0.5, Sodium = 0.002, Iron = 0.00031, Calcium = 0.03 }
            };
        }

        internal List<MenuItems> GetLunchMenu()
        {
            return new List<MenuItems>()
            {
                new MenuItems { Item = "Plain Rice", Cal = 205, Fat = 0.4, Carbs = 45, Proteins = 4.3, Sodium = 0.0016, Iron = 0.0002, Calcium = 0.011 },
                new MenuItems { Item = "Roti", Cal = 120, Fat = 3.7, Carbs = 18, Proteins = 3.1, Sodium = 0.119, Iron = 0.003, Calcium = 0.01 },
                new MenuItems { Item = "Moong Dal", Cal = 236, Fat = 2, Carbs = 41, Proteins = 16, Sodium = 0.465, Iron = 0.0032, Calcium = 0.06 },
                new MenuItems { Item = "Mixed Vegetables", Cal = 45, Fat = 0.5, Carbs = 9.7, Proteins = 2.4, Sodium = 0.043, Iron = 0.0021, Calcium = 0.022 },
                new MenuItems { Item = "Curd Rice", Cal = 207, Fat = 3.2, Carbs = 38, Proteins = 6.1, Sodium = 0.167, Iron = 0.0006, Calcium = 0.272 },
                new MenuItems { Item = "Chicken Curry", Cal = 243, Fat = 11, Carbs = 7.5, Proteins = 28, Sodium = 0.073, Iron = 0.0008, Calcium = 0.023 }
            };
        }

        internal List<GridListData> GetData()
        {
            List<GridListData> sampleData = new List<GridListData>();
            string[] workout = new string[] { "Running", "Swimming", "Walking", "Yoga" };
            int[] average = new int[] { 10, 18, 22 };
            int[] hours = new int[] { 8, 7, 6, 6 };
            int[] minutes = new int[] { 0, 0, 30, 0 };
            int[] caloriesBurned = new int[] { 10, 15, 30 };
            int count = 1;
            DietData.BurnedCalories = 0;
            DateTime date = CurrentDate.HasValue ? CurrentDate.Value : DateTime.Now;
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < workout.Length; j++)
                {
                    TimeSpan span = new TimeSpan(hours[j], minutes[j], 0);
                    DateTime time = date.Date.Add(span);
                    double? distance = workout[j] == "Yoga" ? null : workout[j] == "Running" ? random.NextDouble() * (5 - 1) + 1 : random.NextDouble() * (2 - 1) + 1;
                    GridListData data = new GridListData()
                    {
                        Workout = workout[j],
                        Distance = distance,
                        Duration = workout[j] == "Yoga" ? random.NextDouble() * (30 - 10) + 10 : (distance.Value * average[j]),
                        Date = time,
                        Completion = random.NextDouble() * (30 - 10) + 10
                    };
                    sampleData.Add(data);
                    DietData.BurnedCalories += workout[j] == "Yoga" ? 0 : (int)Math.Round((double)(data.Duration / caloriesBurned[j]) * 100);
                }
            }
            return sampleData;
        }

        internal List<ChartData> GetChartData(string chartDropDownValue, string action)
        {
            int count = chartDropDownValue == "Monthly" ? 30 : 7;
            List<ChartData> sampleChartData = new List<ChartData>();
            if (chartDropDownValue == "Monthly")
            {
                if (action == "Diet" && ActivitiesData.ActivityChartMonthData.Diet?.Count > 0)
                {
                    sampleChartData = ActivitiesData.ActivityChartMonthData.Diet;
                }
                else if (action == "Workout" && ActivitiesData.ActivityChartMonthData.Workout?.Count > 0)
                {
                    sampleChartData = ActivitiesData.ActivityChartMonthData.Workout;
                }
            }
            else
            {
                if (action == "Diet" && ActivitiesData.ActivityChartWeekData.Diet?.Count > 0)
                {
                    sampleChartData = ActivitiesData.ActivityChartWeekData.Diet;
                }
                else if (action == "Workout" && ActivitiesData.ActivityChartWeekData.Workout?.Count > 0)
                {
                    sampleChartData = ActivitiesData.ActivityChartWeekData.Workout;
                }
            }
            if (sampleChartData.Any())
            {
                return sampleChartData;
            }
            Random random = new Random();
            DateTime date = CurrentDate.HasValue ? CurrentDate.Value : DateTime.Now;
            for (int i = count - 1; i >= 0; i--)
            {
                ChartData currentData = new ChartData()
                {
                    X = date.Date.AddDays(-i),
                    Y = Convert.ToDouble((random.NextDouble() * (90 - 50) + 50).ToString("0.00").Replace(".00", string.Empty))
                };
                sampleChartData.Add(currentData);
            }
            if (chartDropDownValue == "Monthly")
            {
                if (action == "Diet")
                {
                    ActivitiesData.ActivityChartMonthData.Diet = sampleChartData;
                }
                else
                {
                    ActivitiesData.ActivityChartMonthData.Workout = sampleChartData;
                }
            }
            else
            {
                if (action == "Diet")
                {
                    ActivitiesData.ActivityChartWeekData.Diet = sampleChartData;
                }
                else
                {
                    ActivitiesData.ActivityChartWeekData.Workout = sampleChartData;
                }
            }
            return sampleChartData;
        }

        internal List<ChartData> GetWeightChartData()
        {
            List<ChartData> sampleChartData = new List<ChartData>();
            int count = 12;
            Random random = new Random();
            DateTime date = CurrentDate.HasValue ? CurrentDate.Value : DateTime.Now;
            for (int i = count - 1; i >= 0; i--)
            {
                ChartData data = new ChartData()
                {
                    X = date.AddMonths(-i),
                    Y = Math.Round(70 + (i * (random.NextDouble() * (3.5 - 2) + 2)))
                };
                sampleChartData.Add(data);
            }
            return sampleChartData;
        }
    }
}

