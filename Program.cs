char[,] map = ReadMap("Map1.txt");

static char[,] ReadMap(string mapName)
{
    string[] newFile = File.ReadAllLines($"Maps/{mapName}");
    char[,] map = new char[newFile.Length, newFile[0].Length];

    for (int i = 0; i < map.GetLength(0); i++)
    {
        for (int j = 0; j < map.GetLength(1); j++)
        {
            map[i, j] = newFile[i][j];
        }
    }

    return map;
}

static void DrawMap(char[,] map)
{
    for (int i = 0; i < map.GetLength(0); i++)
    {
        for (int j = 0; j < map.GetLength(1); j++)
        {
            Console.WriteLine(map[i,j]);
        }

        Console.WriteLine();
    }
}