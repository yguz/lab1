using static System.Console;

WriteLine("Yorfi Guzman");
WriteLine($"Version: {Environment.Version}");

// Cats' names
string[] catNames = new[] { "Blue", "Ricky" };

// Hobbies
string[] hobbies = new[]
{
    "Going on walks",
    "Playing video games",
    "Feeding stray cats",
    "Going to the movies"
};

// Favorite movies
string[] favoriteMovies = new[] { "Age of Adeline", "Emilia Perez", "Barbie", "Wicked" };

// Favorite food
string[] favoriteFood = new[] { "Pizza" };

// Favorite numbers
int[] favoriteNumbers = new[] { 21, 04, 16 };

// Favorite stores
string[] favoriteStores = new[] { "Walmart", "Old Navy", "Nike" };

// Original multi-dimensional array for demonstration
string[,] grid1 = new[,]
{
    { "Arturo", "Steven", "Emma", "Jabob" },
    { "candy", "Pao", "Jade", "Jacobi" },
    { "christina", "lion", "Cat", "Hannah" }
};

// Display arrays
WriteLine("Cats' names:");
foreach (var name in catNames) WriteLine($"- {name}");

WriteLine("\nHobbies:");
foreach (var hobby in hobbies) WriteLine($"- {hobby}");

WriteLine("\nFavorite movies:");
foreach (var movie in favoriteMovies) WriteLine($"- {movie}");

WriteLine("\nFavorite food:");
foreach (var food in favoriteFood) WriteLine($"- {food}");

WriteLine("\nFavorite numbers:");
foreach (var number in favoriteNumbers) WriteLine($"- {number}");

WriteLine("\nFavorite stores:");
foreach (var store in favoriteStores) WriteLine($"- {store}");

// Display Grid 1
WriteLine("\nGrid 1:");
for (int row = 0; row <= grid1.GetUpperBound(0); row++)
{
    for (int col = 0; col <= grid1.GetUpperBound(1); col++)
    {
        WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
    }
}

// Pattern matching with arrays
WriteLine("\nPattern matching with arrays:");
int[] customNumbers = new[] { 1, 2, 10, 16 }; // Example array
WriteLine($"Custom Numbers: {CheckSwitch(customNumbers)}");

static string CheckSwitch(int[] values) => values switch
{
    [] => "Empty array",
    [1, 2, _, 10] => "Contains 1, 2, any single number, 10.",
    [1, 2, .., 10] => "Contains 1, 2, any range including empty, 10.",
    [1, 2, .., 16] => "Contains 1, 2, any range including 16, 10.",
    [1, 2] => "Contains 1 then 2.",
    [int item1, int item2, int item3] =>
        $"Contains {item1} then {item2} then {item3}.",
    [0, _] => "Starts with 0, then one other number.",
    [0, ..] => "Starts with 0, then any range of numbers.",
    [2, .. int[] others] => $"Starts with 2, then {others.Length} more numbers.",
    [..] => "Any items in any order.",
};
