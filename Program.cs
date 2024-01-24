
var str = "hi";

//Convert to ASCII Codes
var ascii_code = new Int32[str.Length];
Console.WriteLine("Convert to ASCII code");
for (int i = 0; i < ascii_code.Length; i++)
{
    ascii_code[i] = str[i];
    Console.Write(ascii_code[i] + ",");
}

Console.WriteLine();
Console.WriteLine();

//Convert to binary
var bin_code = new Int32[str.Length * 8];
Console.WriteLine("Convert to binary");
for (int i = 0; i < ascii_code.Length; i++)
{
    var asciiChar = ascii_code[i];
    var binStr = Convert.ToString(asciiChar, 2);
    for (int j = i + 1; j % 8 != 0; j++)
    {
        bin_code[j] = ;
    };
    bin_code[i] = str[i];

    //Console.Write(ascii_code[i]);
    Console.Write(binStr + ",");
}