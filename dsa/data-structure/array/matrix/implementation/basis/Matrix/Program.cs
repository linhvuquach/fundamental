// Matrix declaration
int number_of_rows = 3, number_of_columns = 3;

int[,] arr = new int[number_of_rows, number_of_columns];

// Initializing Matrix
int[,] arrInitialization = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

// Accessing elements of 2-D array
// arr[row, col]

Console.WriteLine($"First element of first row: {arrInitialization[0, 0]}");
Console.WriteLine($"Third element of second row: {arrInitialization[1, 2]}");
Console.WriteLine($"Second element of third row: {arrInitialization[2, 1]}");

// Traversal
for (int i = 0; i < number_of_rows; i++)
{
    for (int j = 0; j < number_of_columns; j++)
    {
        Console.Write(arrInitialization[i, j]);
        Console.Write(" ");
    }
    Console.WriteLine("");
}

// Searching
static bool searchInMatrix(int[,] arr, int x)
{
    int m = arr.GetLength(0), n = arr.GetLength(1);

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (arr[i, j] == x) return true;
        }
    }

    return false;
}

int cr7 = 7;
if (searchInMatrix(arrInitialization, cr7))
{
    Console.WriteLine("Found");
}
else
{
    Console.WriteLine("NotFound");
}
