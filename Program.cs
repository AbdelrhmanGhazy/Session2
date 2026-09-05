using System;

class Program
{
    // Class used for Problem 6 (Reference Type Example)
    class Person
    {
        public string Name;
    }

    static void Main()
    {
        Console.WriteLine("=================== PROBLEM 1 ===================");
        // Write a program that allows the user to enter a number then print it.
        Console.Write("Enter a number: ");
        int inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine($"You entered: {inputNumber}\n");


        Console.WriteLine("=================== PROBLEM 2 ===================");
        // Convert a string to an integer, but the string contains non-numeric characters.
        // WHAT WILL HAPPEN: Throws System.FormatException because 'abc' cannot be converted to a number.
        try
        {
            string invalidString = "123abc";
            int parsedResult = Convert.ToInt32(invalidString);
            Console.WriteLine(parsedResult);
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Exception caught as expected: {ex.Message}\n");
        }


        Console.WriteLine("=================== PROBLEM 3 ===================");
        // Perform a simple arithmetic operation with floating-point numbers.
        // WHAT WILL HAPPEN: Output is 0.30000000000000004 due to binary base-2 representation inaccuracy.
        double doubleNum1 = 0.1;
        double doubleNum2 = 0.2;
        double floatResult = doubleNum1 + doubleNum2;
        Console.WriteLine($"0.1 + 0.2 = {floatResult}");
        Console.WriteLine($"Is 0.1 + 0.2 == 0.3? {floatResult == 0.3}\n");


        Console.WriteLine("=================== PROBLEM 4 ===================");
        // Extract a substring from a given string.
        string fullText = "Hello World";
        string extractedSubstring = fullText.Substring(6, 5); // Starts at index 6, takes 5 characters
        Console.WriteLine($"Extracted Substring: {extractedSubstring}\n");


        Console.WriteLine("=================== PROBLEM 5 ===================");
        // Assigning one value type variable to another and modifying the value of one variable.
        // WHAT WILL HAPPEN: 'valA' stays 10 and 'valB' becomes 20 because value types copy the actual data on the Stack.
        int valA = 10;
        int valB = valA;
        valB = 20;
        Console.WriteLine($"valA: {valA}, valB: {valB}\n");


        Console.WriteLine("=================== PROBLEM 6 ===================");
        // Assigning one reference type variable to another and modifying the object through one variable.
        // WHAT WILL HAPPEN: Both variables show 'Bob' because reference types share the same memory pointer on the Heap.
        Person person1 = new Person { Name = "Alice" };
        Person person2 = person1;
        person2.Name = "Bob";
        Console.WriteLine($"person1.Name: {person1.Name}, person2.Name: {person2.Name}\n");


        Console.WriteLine("=================== PROBLEM 7 ===================");
        // Take two string variables and print them as one variable.
        string str1 = "Hello, ";
        string str2 = "World!";
        string mergedString = str1 + str2;
        Console.WriteLine($"Combined String: {mergedString}\n");


        Console.WriteLine("=================== MCQs ANSWERS ===================");

        // Question 8: d = Convert.ToInt32( !(30 < 20) );
        // Answer: A value 1 will be assigned to d.
        int d = Convert.ToInt32(!(30 < 20));
        Console.WriteLine($"Q8 Result: d = {d}");

        // Question 9: Console.WriteLine(13 / 2 + " " + 13 % 2);
        // Answer: 6 1
        Console.Write("Q9 Result: ");
        Console.WriteLine(13 / 2 + " " + 13 % 2);

        // Question 10: Output of ++num + z++ + " " + ++z
        // Answer: 7 7
        Console.Write("Q10 Result: ");
        int num = 1, z = 5;
        if (!(num <= 0))
            Console.WriteLine(++num + z++ + " " + ++z);
        else
            Console.WriteLine(--num + z-- + " " + --z);
    }
}