using System.IO;
// declare variables
int lineCounter = -1;
int finalAnswer = 0;

// Read input from a text file
string path = @"C:\Users\Daniel\source\repos\Advent of Code 2023\Advent of Code 2023\day1Input.txt";
string[] inputFile = File.ReadAllLines(path);

//Console.WriteLine("File read");

// declaring array
char[,] allNums = new char[2, inputFile.Length];
String[] numsConcat = new String[inputFile.Length];
int[] numsInt = new int[inputFile.Length];

foreach (string line in inputFile)
{
    // Console.WriteLine(line);

    // incrementing line counter
    lineCounter++;
    //Console.WriteLine($"Line Counter: {lineCounter}");

    // check for first number in the line

    // iterating through line forwards
    foreach (char lineCharacter in line)
    {
        //check if character an int
        if (Char.IsDigit(lineCharacter))
        {
            // write int to array
            allNums[0,lineCounter] = lineCharacter;
            //Console.WriteLine($"First Num: {lineCharacter}");
            break;
        }

    }
    // check for last number in each line

    // iterate through line backwards
    for (int i = line.Length - 1; i >= 0; i--)
    {
        // check if character is int
        if (Char.IsDigit(line[i]))
        {
            // write int to array
            allNums[1, lineCounter] = line[i];
            //Console.WriteLine($"Last Num: {line[i]}");
            break;
        }
    }

}

// concating chars to strings
for (int i = 0; i <= lineCounter; i++)
{
    numsConcat[i] = (allNums[0, i].ToString() + allNums[1, i].ToString());
    //Console.WriteLine($"{numsConcat[i]}");

    numsInt[i] = int.Parse(numsConcat[i]);
    //Console.WriteLine(numsInt[i]);

    finalAnswer += numsInt[i];
    //Console.WriteLine(finalAnswer);
}

Console.WriteLine(finalAnswer);