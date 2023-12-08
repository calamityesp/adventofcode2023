StreamReader reader = File.OpenText("S:\\AdventOfCode\\2023\\Day1\\numbers.txt");
string? list;
List<int> numbers = new List<int>();
int sum = 0;
while ((list = reader.ReadLine()) != null)
{
    var firstSet = false;
    var myNum = '\0';
    var lastNum = '\0';
    string finalNum = string.Empty;
    foreach (var letter in list)
    {
        if (char.IsDigit(letter))
        {
            if (!firstSet)
            {
                myNum = letter;
                firstSet = true;
            }
            else
            {
                lastNum = letter;
            }
        }
    }

    finalNum += myNum == '\0' ? 0.ToString() : myNum;
    finalNum += lastNum == '\0' ? myNum : lastNum;
    Console.WriteLine(finalNum);
    numbers.Add(int.Parse(finalNum));

}
sum = numbers.Sum(x => x);
Console.WriteLine(sum);
