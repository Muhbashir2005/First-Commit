using System;

namespace ChapterTwo
{
    class Program
    {
        static void Main(string[] args)
        {
         /* 1. Declare several variables by selecting for each one of them the most
appropriate of the types sbyte, byte, short, ushort, int, uint, long
and ulong in order to assign them the following values: 52,130; -115;
4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000;
1990; 123456789123456789.*/
             byte var1 = 52;
             sbyte var2 = 130;
             sbyte var3 = -115;
             int var4 = 4825932;
             short var5 = 97;
             short var6 = -10000;
             ushort var7 = 20000;
             short var8 = 228;
             long var9 = 970700000;
             ushort var10 = 112;
             short var11 = -4;
             int var12 = -1000000;
             short var13 = 1990;
             ulong var14 = 123456789123456789;
            /*2. Which of the following values can be assigned to variables of type float,
double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857;
3456.091124875956542151256683467?*/
             double number1 = 34.567839023;
             float number2 = 12.345f;
             double number3 = 8923.1234857;
             decimal number4 = 3456.091124875956542151256683467m; 
          /* 3. Write a program, which compares correctly two real numbers with
accuracy at least 0.000001.*/
            float a = 56.4F;
            float b = 45.78F;
            bool equal = Math.Abs(a - b) < 0.000001;
            /*4. Initialize a variable of type int with a value of 256 in
hexadecimal format (256 is 100 in a numeral system with base 16).*/
           int numberInDec = 100;
           int numberInHex = 0x10;
           /*5. Declare a variable of type char and assign as a value the character, which has Unicode code, 72 (use the Windows calculator in order to find hexadecimal representation of 72).*/
          char number_In_Dec = 72;
          char number_In_Hex = 0x100;
        /*6. Declare a variable isMale of type bool and assign a value to it depending on your gender.*/
        bool male = true;
         /*7. Declare two variables of type string with values "Hello" and "World". Declare a variable of type object. Assign to this variable the value obtained of concatenation of the two string variables (add space if necessary). Print the variable of type object.*/
         string word1 = "Hello";
         string word2 = "World";
         object concat = word1 + " " + word2;
         Console.WriteLine(concat);
         /*8. Declare two variables of type string and assign them values "Hello" and "World". Declare a variable of type object and assign to it the value obtained of concatenation of the two variables of type string (do not miss the space in the middle). Declare a third variable of type string and initialize it with the value of the variable of type object (you should use type casting).*/
         string word_1 = "Hello";
         string word_2 = "World";
         object obj = word_1 + " " + word_2;
         string word_3 = obj.ToString();
         Console.WriteLine(word_3);
        /*9. Declare two variables of type string and assign them a value “The "use" of quotations causes difficulties.” (without the outer quotes). In one of the variables use quoted string and in the other do not use it.*/
        string str1 = "The \"use\" of quotations causes difficulties.";        
        string str2 = "The " + "\u0022" + "use" + "\u0022" + " of quotations causes difficulties";
        Console.WriteLine(str1 + " " + str2);
        /*Write a program to print a figure in the shape of a heart by the sign \"o\".*/
        Console.WriteLine("  0        0 ");
        Console.WriteLine("0   0    0   0");
        Console.WriteLine(" 0   0  0   0");
        Console.WriteLine("  0   00   0");
        Console.WriteLine("   0      0 ");
        Console.WriteLine("    0    0  ");
        Console.WriteLine("     0  0   ");
        Console.WriteLine("      00   ");
        /*11. Write a program that prints on the console isosceles triangle which sides consist of the copyright character \"©\".*/
        Console.WriteLine("    ©");
        Console.WriteLine("   © ©");
        Console.WriteLine("  ©   ©");
        Console.WriteLine(" ©     ©");
        Console.WriteLine("©©©©©©©©");
        /*12. A company dealing with marketing wants to keep a data record of its employees. Each record should have the following characteristic – first name, last name, age, gender (‘m’ or ‘f’) and unique employee number (27560000 to 27569999). Declare appropriate variables needed to maintain the information for an employee by using the appropriate data types and attribute names.*/
        string firstName = "Bola";
        string lastName = "Tinubu";
        byte age = 70;
        char gender = 'm';
        long id = 5467365243563479879;
        /*13. Declare two variables of type int. Assign to them values 5 and 10 respectively. Exchange (swap) their values and print them.*/
        int a = 2;
        int b = 3;
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine($"a:{a} b:{b}");
       }
    }
}

