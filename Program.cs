
using System.Collections;
using System.Reflection;

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
    var asciiNum = ascii_code[i];
    var binArr = PaddTo8Bits(asciiNum);
    
    //Add to combined binary array
    for (int j = 0; j < binArr.Length; j++)
    {
        bin_code[(i * 8) + j] = binArr[j];
    };
}

Console.Write(string.Join(" ", bin_code));






static int[] PaddTo8Bits(int asciiNum)
{
    var asciiBinArr = Convert.ToString(asciiNum, 2).ToCharArray();
    var paddingBits = 8 % asciiBinArr.Length;

    if(asciiBinArr.Length > 8) { throw new Exception("Error: The provided ASCII code's binary contains >8 bits. A conversion from the ASCII character to its numerical value has likely failed. Cannot continue."); }

    //Add padding
    var binArr = new int[8];

    //Add remaining bits - or all if no padding was needed
    for (int j = paddingBits; j < binArr.Length; j++)
    {
        //Console.WriteLine(asciiBinArr[j]);
        binArr[j] = Int32.Parse(asciiBinArr[j - paddingBits].ToString());
    }

    return binArr;
}