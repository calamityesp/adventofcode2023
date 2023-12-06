// 1) Read in values of an array 

using System.Globalization;

string[] calibrationValues = new string[]
{
    "1abc2",
    "pqr3stu8vwx",
    "a1b2c3d4e5f",
    "treb7uchet"
};

int first = 0;
string number = string.Empty;
bool lastSet = false;
List<int> numList = new List<int>();
int sum;

// testing 
foreach (var value in calibrationValues)
{
    char lastnum = '\0';
    char firstnum = '\0';
    foreach (var letter in value)
    {
        if(char.IsDigit(letter))
        {
            if (first == 0)
            {
                first = letter - '0';
                firstnum = letter;
                number += letter;
            }
            else
            {
                lastnum = letter;
                lastSet = true;
            }
        }
    }

    if(lastSet) 
    {
        number += lastnum.ToString();
    }
    else
    {
        number += firstnum.ToString();
    }

    Console.WriteLine(int.Parse(number));
    numList.Add(int.Parse(number));
    first = 0;
    number = string.Empty;
    lastSet = false;
  }

sum = numList.Sum(x => x);
Console.WriteLine(sum);
