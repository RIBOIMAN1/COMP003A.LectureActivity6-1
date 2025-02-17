namespace COMP003A.LectureActivity6_1
{
    internal class Program
    {
		/// <summary>
		/// Represents a general vehicle.
		/// </summary>
		class Vehicle
		{
			// Fields
			private string _brand;

			// Properties
			public string Brand
			{
				get { return _brand; }
				set { _brand = value; }
			}

			public int Year { get; set; }

			/// <summary>
			/// Displays vehicle details.
			/// </summary>
			public virtual void DisplayInfo()
			{
				Console.WriteLine($"Brand: {Brand}, Year: {Year}");
			}
		}
		/// <summary>
		/// Represents a car, which is a type of vehicle.
		/// </summary>
		class Car : Vehicle
		{
			// Auto-implemented properties
			public int Doors { get; set; }

			/// <summary>
			/// Constructs a car with the specified brand, year, and number of doors.
			/// </summary>
			/// <param name="brand"></param>
			/// <param name="year"></param>
			/// <param name="doors"></param>
			public Car(string brand, int year, int doors)
			{
				Brand = brand;
				Year = year;
				Doors = doors;
			}

			/// <summary>
			/// Displays car details including inherited properties.
			/// </summary>
			public override void DisplayInfo()
			{
				base.DisplayInfo();
				Console.WriteLine($"Doors: {Doors}");
			}
		}
		static void Main(string[] args)
        {
			// Create a Vehicle object with brand and year
			Vehicle myVehicle = new Vehicle { Brand = "Toyota", Year = 2020 };
			// Create a Car object with brand, year, and number of doors
			Car myCar = new Car("Honda", 2022, 4);

			// Display vehicle details
			myVehicle.DisplayInfo();
			// Display car details
			myCar.DisplayInfo();
		}
    }
}