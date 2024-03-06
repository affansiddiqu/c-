// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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
//Console.WriteLine("Enter the day of the week (0 for Monday, 1 for Tuesday, 2 for wednesday,3 for thursday , 4 for friday , 5for saturday, 6 for sunday etc.):");
//var day = Convert.ToInt32(Console.ReadLine());

//switch (day)
//{
//    case 0:
//        Console.WriteLine("Monday");
//        break;
//    case 1:
//        Console.WriteLine("Tuesday");
//        break;
//    case 2:
//        Console.WriteLine("wednesday");
//        break;
//    case 3:
//        Console.WriteLine("thursday");
//        break;
//    case 4:
//        Console.WriteLine("friday");
//        break;
//    case 5:
//        Console.WriteLine("saturday");
//        break;
//    case 6:
//        Console.WriteLine("sunday");
//        break;
//    default:
//        Console.WriteLine("Invalid day");
//        break;
////}

//int[] marks = new int[4];
//marks[0] = 23;
//marks[1] = 99;
//marks[2] = 6;
//marks[3] = 69;

////Console.WriteLine(marks);
//string[] names = { "ali", "usama", "salman", "talha" };
//Array.Sort(names);
//Array.Reverse(names);

//for (int i = 0; i < 4; i++)
//{
//    Console.WriteLine(names[i]);
//}

//Console.WriteLine(names.Max());
//Console.WriteLine(names.Min());
//Console.WriteLine(names.Contains("ali"));

//multidimensional 2d array

int[,] arr2d = new int[3, 4]
{
    {23,3,33, 3},
    {2,3,34,4 },
    {3,33,3,3},
};

int row = arr2d.GetLength(0);
int coloumn = arr2d.GetLength(1);
Console.WriteLine(row);
Console.WriteLine(coloumn);
