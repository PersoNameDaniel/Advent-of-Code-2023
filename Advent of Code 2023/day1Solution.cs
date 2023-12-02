using System.IO;
// declare variables
int lineCounter = -1;
int finalAnswer = 0;

// Read input from a text file
string path = @"day1Input.txt";
string[] inputFile = File.ReadAllLines(path);

//Console.WriteLine("File read");

// declaring array
char[,] allNums = new char[2, inputFile.Length];
string[] numsConcat = new string[inputFile.Length];
int[] numsInt = new int[inputFile.Length];
char lineCharacter;

foreach (string lineForeach in inputFile)
{
    //adding one "l" to the end to avoid out of bounds error
    string line = "l" + lineForeach + "l";
    // var line = lineForeach;

    //Console.WriteLine(line);

    // incrementing line counter
    lineCounter++;
    //Console.WriteLine($"Line Counter: {lineCounter}");

    // check for first number in the line

    // iterating through line forwards
    //foreach (char lineCharacter in line)
    for (int i=1 ; i<=line.Length ; i++)
    {
        lineCharacter = line[i];
    
        //check if character an int
        if (Char.IsDigit(lineCharacter))

        {
            // write int to array
            allNums[0,lineCounter] = lineCharacter;
            //Console.WriteLine($"First Num: {lineCharacter}");
            break;
        }

        if (line[i] == 'z') {
            if (line[i+1] == 'e') {
                if (line[i+2] == 'r') {
                    if (line[i+3] == 'o') {
                        allNums[0, lineCounter] = '0';
                        break;
                    }
                }
            }
        }

        if (line[i] == 'o') {
            if (line[i+1] == 'n') {
                if (line[i+2] == 'e') {
                    allNums[0, lineCounter] = '1';
                    break;
                }
            }
        }

        if (line[i] == 't') {
            if (line[i+1] == 'w') {
                if (line[i+2] == 'o') {
                    allNums[0, lineCounter] = '2';
                    break;
                }
            }
        }

        if (line[i] == 't') {
            if (line[i+1] == 'h') {
                if (line[i+2] == 'r') {
                    if (line[i+3] == 'e') {
                        if (line[i+4] == 'e') {
                            allNums[0, lineCounter] = '3';
                            break;
                        }
                    }
                }
            }
        }

        if (line[i] == 'f') {
            if (line[i+1] == 'o') {
                if (line[i+2] == 'u') {
                    if (line[i+3] == 'r') {
                        allNums[0, lineCounter] = '4';
                        break;
                    }
                }
            }
        }

        if (line[i] == 'f') {
            if (line[i+1] == 'i') {
                if (line[i+2] == 'v') {
                    if (line[i+3] == 'e') {
                        allNums[0, lineCounter] = '5';
                        break;
                    }
                }
            }
        }

        if (line[i] == 's') {
            if (line[i+1] == 'i') {
                if (line[i+2] == 'x') {
                    allNums[0, lineCounter] = '6';
                    break;
                }
            }
        }

        if (line[i] == 's') {
            if (line[i+1] == 'e') {
                if (line[i+2] == 'v') {
                    if (line[i+3] == 'e') {
                        if (line[i+4] == 'n') {
                            allNums[0, lineCounter] = '7';
                            break;
                        }
                    }
                }
            }
        }

        if (line[i] == 'e') {
            if (line[i+1] == 'i') {
                if (line[i+2] == 'g') {
                    if (line[i+3] == 'h') {
                        if (line[i+4] == 't') {
                            allNums[0, lineCounter] = '8';
                            break;
                        }
                    }
                }
            }
        }

        if (line[i] == 'n') {
            if (line[i+1] == 'i') {
                if (line[i+2] == 'n') {
                    if (line[i+3] == 'e') {
                        allNums[0, lineCounter] = '9';
                        break;
                    }
                }
            }
        }

    }
    // check for last number in each line

    // iterate through line backwards
    for (int i = line.Length - 2; i >= 0; i--)
    {
        // check if character is int
        if (Char.IsDigit(line[i]))
        {
            // write int to array
            allNums[1, lineCounter] = line[i];
            //Console.WriteLine($"Last Num: {line[i]}");
            break;
        }

        if (line[i] == 'o') {
            if (line[i-1] == 'r') {
                if (line[i-2] == 'e') {
                    if (line[i-3] == 'z') {
                        allNums[1, lineCounter] = '0';
                        break;
                    }
                }
            }
        }

        if (line[i] == 'e') {
            if (line[i-1] == 'n') {
                if (line[i-2] == 'o') {
                    allNums[1, lineCounter] = '1';
                    break;
                }
            }
        }

        if (line[i] == 'o') {
            if (line[i-1] == 'w') {
                if (line[i-2] == 't') {
                    allNums[1, lineCounter] = '2';
                    break;
                }
            }
        }

        if (line[i] == 'e') {
            if (line[i-1] == 'e') {
                if (line[i-2] == 'r') {
                    if (line[i-3] == 'h') {
                        if (line[i-4] == 't') {
                            allNums[1, lineCounter] = '3';
                            break;
                        }
                    }
                }
            }
        }

        if (line[i] == 'r') {
            if (line[i-1] == 'u') {
                if (line[i-2] == 'o') {
                    if (line[i-3] == 'f') {
                        allNums[1, lineCounter] = '4';
                        break;
                    }
                }
            }
        }

        if (line[i] == 'e') {
            if (line[i-1] == 'v') {
                if (line[i-2] == 'i') {
                    if (line[i-3] == 'f') {
                        allNums[1, lineCounter] = '5';
                        break;
                    }
                }
            }
        }

        if (line[i] == 'x') {
            if (line[i-1] == 'i') {
                if (line[i-2] == 's') {
                    allNums[1, lineCounter] = '6';
                    break;
                }
            }
        }

        if (line[i] == 'n') {
            if (line[i-1] == 'e') {
                if (line[i-2] == 'v') {
                    if (line[i-3] == 'e') {
                        if (line[i-4] == 's') {
                            allNums[1, lineCounter] = '7';
                            break;
                        }
                    }
                }
            }
        }

        if (line[i] == 't') {
            if (line[i-1] == 'h') {
                if (line[i-2] == 'g') {
                    if (line[i-3] == 'i') {
                        if (line[i-4] == 'e') {
                            allNums[1, lineCounter] = '8';
                            break;
                        }
                    }
                }
            }
        }

        if (line[i] == 'e') {
            if (line[i-1] == 'n') {
                if (line[i-2] == 'i') {
                    if (line[i-3] == 'n') {
                        allNums[1, lineCounter] = '9';
                        break;
                    }
                }
            }
        }
    }

    Console.WriteLine($"{lineForeach} : {allNums[0, lineCounter]}{allNums[1, lineCounter]}");
}

// concating chars to strings
for (int i = 0; i <= lineCounter; i++)
{
    // numsConcat[i] = allNums[0, i].ToString() + allNums[1, i].ToString();
    numsConcat[i] = new string(new[] { allNums[0,i], allNums[1,i] });
    //Console.WriteLine($"{numsConcat[i]}");

    numsInt[i] = int.Parse(numsConcat[i]);
    //Console.WriteLine(numsInt[i]);

    finalAnswer += numsInt[i];
    //Console.WriteLine(finalAnswer);
}

Console.WriteLine(finalAnswer);
