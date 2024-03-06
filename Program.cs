// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//sbyte signvalue = 127;
//Console.WriteLine($"the min value of sbyte is {sbyte.MinValue}");
//Console.WriteLine($"the max value of sbyte is {sbyte.MaxValue}\n");

//byte unsignbyte = 255;
//Console.WriteLine($"the min value of byte is {byte.MinValue}");
//Console.WriteLine($"the max value of byte is {byte.MaxValue}\n");

//short shortvale = 3020;
//Console.WriteLine($"the min value of sbyte is {short.MinValue}");
//Console.WriteLine($"the max value of sbyte is {short.MaxValue}");
//Console.WriteLine($"the max value of sbyte is {shortvale.GetType()}\n");

//ushort ushortvalue = 222;
//Console.WriteLine($"the min value of sbyte is {ushort.MinValue}");
//Console.WriteLine($"the max value of sbyte is {ushort.MaxValue}\n");

//char character = 's';
//Console.WriteLine(character);
//Console.WriteLine($"the max value of sbyte is {char.MaxValue}\n");

//string uni = "karachi uni";
//Console.WriteLine(uni[1]);
//Console.WriteLine(uni.IndexOf("r").GetType());

//int number = 23930;
//Console.WriteLine(number);
//Console.WriteLine($"the number {number}");
//Console.WriteLine($"the data type of this number {number.GetType()}");


//Console.WriteLine("Enter dollar:");
//string amount = Console.ReadLine();
//double num = 278.59;
//int pkr = Convert.ToInt32(amount);
//Console.WriteLine("dollar to pkr is: " + num * pkr);




//int a = 9;
//a += 8;

//int b = 19;
//b -= 2;

//if (a == b & a == b)
//{
//    Console.WriteLine("both condition are true");
//}
//else
//{
//    Console.WriteLine("both condition are false");
//}

//var json = """{"name":"affan","age":"12"}""";
//Console.WriteLine(json);

//var xml = @"<books> <name> affan </name> </books>";
//Console.WriteLine(xml);

//Console.WriteLine(Convert.ToInt32(3));

//Console.WriteLine("enter your age");
//int age = Convert.ToInt16(Console.ReadLine());
//if (age >= 18)
//{
//    Console.WriteLine("enter your cnic");
//    bool cnic = Convert.ToBoolean(Console.ReadLine());
//    if (cnic == true)
//    {
//        Console.WriteLine("you are ready to vote");
//    }
//    else
//    {
//        Console.WriteLine("sorry");
//    }
//}
//else
//{
//    Console.WriteLine("bary hokeee ajjajaaja");
//}

Console.WriteLine("enter your age");
var day = Convert.ToString(Console.ReadLine());

switch (day)
{
    case 0:
        Console.WriteLine("monday");
        break;
    case 1:
        Console.WriteLine("tuesday");
        break;
    default:
        Console.WriteLine("Saturday");
        break;
}


