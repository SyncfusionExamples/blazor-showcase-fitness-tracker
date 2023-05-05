using FitnessTracker.Pages;
using Syncfusion.Blazor.Kanban.Internal;
using Syncfusion.Blazor.RichTextEditor;

namespace FitnessTracker.Data
{
    public class FitnessService
    {
        public bool IsDevice { get; set; }
        public bool IsSmallDevice { get; set; }
        public double InnerWidth { get; set; } = 900;
        public DateTime? CurrentDate { get; set; } = DateTime.Now;
        public List<Activity> Activities { get; set; }
        public ProfileInfo ProfileStats { get; set; }
        public int ConsumedCalories { get; set; } = 0;
        public int ExpectedCalories { get; set; } = 3000;
        public int BurnedCalories { get; set; }
        public List<MenuItems> CurrentMenu { get; set; }

        internal ProfileDialog ProfileDialogRef { get; set; }

        public ProfileInfo GetProfileStats()
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

        public List<Activity> GetActivities()
        {
            return new List<Activity>()
            {
                new Activity { Name = "Morning Walk", ActivityType ="Morning Walk", Duration = "30m", Time = "7:00 AM" },
                new Activity { Name = "Breakfast Water", ActivityType ="Water Taken", Time = "7:40 AM" },
                new Activity { Name = "Breakfast", ActivityType ="Breakfast", Time = "9:00 AM" },
                new Activity { Name = "Snack", ActivityType ="Snack", Time = "11:00 AM" },
                new Activity { Name = "Lunch Water", ActivityType ="Water Taken", Time = "12:00 PM" },
                new Activity { Name = "Lunch", ActivityType ="Lunch", Time = "1:00 PM" },
            };
        }

        public List<MenuItems> GetBreakfastMenu()
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

        public List<MenuItems> GetSnackMenu()
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

        public List<MenuItems> GetLunchMenu()
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
    }
}

