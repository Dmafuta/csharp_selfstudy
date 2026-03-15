using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace SelfStudy
{
    public class LearnStrings
    {
        static void Main(string[] args)
        {
            //1. StringConversion();
            //2. StringAsArray();
            //3. EscapeString();
            //4. AppendingStrings();
            //InterpolationAndLiteral();
            //StringBuilderDemo();
            //WorkingWithArrays();
            //PadAndTrim();
            //SearchingStrings();
            //OrderingStrings();
            //TestingEquality();
            //GettingASubstring();
            //ReplacingText();
            //InsertingText();
            RemovingText();


        }

        private static void StringConversion()
        {
            string testString = "tHis iS tHE fBI cALLinG";
            TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;
            TextInfo english = new CultureInfo("fr-FR", false).TextInfo;

            string results;

            results = testString.ToLower();
            Console.WriteLine(results);

            results = testString.ToUpper();
            Console.WriteLine(results);

            results = currentTextInfo.ToTitleCase(testString);
            Console.WriteLine(results);

            results = english.ToTitleCase(testString);
            Console.WriteLine(results);
        }

        private static void StringAsArray()
        {
            string testString = "Dennis";

            for (int i = 0; i < testString.Length; i++)
            {
                Console.WriteLine(testString[i]);
            }
        }

        private static void EscapeString()
        {
            string results;

            results = "This is my \"Test\" solution";
            Console.WriteLine(results);

            results = "C:\\Demo\\Test.txt";
            Console.WriteLine(results);

            results = @"C:\Demo\Test.txt"; // The @ used as a string literal
            Console.WriteLine(results);
        }

        private static void AppendingStrings()
        {
            string firstname = "Dennis";
            string lastname = "Simiyu";
            string results;

            results = "My name is: " + firstname + " " + lastname;
            Console.WriteLine(results);

            results = string.Format("My name is: {0} {1}", firstname, lastname);
            Console.WriteLine(results);

            Console.WriteLine($"My name is: {firstname} {lastname}"); // String interpolation
        }

        private static void InterpolationAndLiteral()
        {
            string testString = "Dennis Simiyu";
            string results = $@"C:\Demo\{testString}\Test.txt";

            Console.WriteLine(results);
        }

        private static void StringBuilderDemo()
        {
            Stopwatch regularStopWatch = new Stopwatch();
            regularStopWatch.Start();

            string test = "";

            for (int i = 0; i < 10000; i++)
            {
                test += i;

            }

            regularStopWatch.Stop();
            Console.WriteLine($"Regular Stopwatch: {regularStopWatch.ElapsedMilliseconds}ms");

            Stopwatch builderStopWatch = new Stopwatch();
            builderStopWatch.Start();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 1000000; i++)
            {
                sb.Append(i);

            }

            builderStopWatch.Stop();
            Console.WriteLine($"Regular Stopwatch: {builderStopWatch.ElapsedMilliseconds}ms");
        }

        private static void WorkingWithArrays()
        {
            int[] ages = new int[] { 25, 33, 18, 28, 55, 70 };
            string results;

            results = String.Concat(ages);
            Console.WriteLine(results);

            results = String.Join(", ",ages);
            Console.WriteLine(results);
            Console.WriteLine();

            string testString = "Dennis, Kevin, Cecilia, kennedy, Ayden, Eziel";
            string[] resultsArray = testString.Split(','); // Notice the single quotes

            Array.ForEach(resultsArray, x => Console.WriteLine(x));

            Console.WriteLine();

            testString = "Dennis, Kevin, Cecilia, kennedy, Ayden, Eziel";
            resultsArray = testString.Split(", "); // Notice the double quotes

            Array.ForEach(resultsArray, x => Console.WriteLine(x));
        }

        private static void PadAndTrim()
        {
            string testString = "     Hello Worlds     ";
            string result;
            result = testString.TrimStart();
            Console.WriteLine($"'{result}'");

            result = testString.TrimEnd();
            Console.WriteLine($"'{result}'");

            result = testString.Trim();
            Console.WriteLine($"'{result}'");

            testString = "1.15";
            result = testString.PadLeft(10, '0');
            Console.WriteLine(result);

            result = testString.PadRight(10, '0');
            Console.WriteLine(result);
        }

        private static void SearchingStrings()
        {
            string testString = "This is a test of the search. Let's see how this test works out.";
            bool resultBoolean;
            int resultsInt;

            resultBoolean = testString.StartsWith("This is");
            Console.WriteLine($"Starts with \"This is\": {resultBoolean}");

            resultBoolean = testString.StartsWith("ThIs is"); // Returns false
            Console.WriteLine($"Starts with \"This is\": {resultBoolean}");

            resultBoolean = testString.EndsWith("works out.");
            Console.WriteLine($"Ends with \"works out\": {resultBoolean}");

            resultBoolean = testString.EndsWith("work out."); // Returns false
            Console.WriteLine($"Ends with \"work out\": {resultBoolean}");

            resultBoolean = testString.Contains("test");
            Console.WriteLine($"Contains \"test\": {resultBoolean}");

            resultBoolean = testString.Contains("tests"); // Returns false
            Console.WriteLine($"Contains \"tests\": {resultBoolean}");

            resultsInt = testString.IndexOf("test");
            Console.WriteLine($"Index of \"test\" is: {resultsInt}");

            resultsInt = testString.IndexOf("test", 11);
            Console.WriteLine($"Index of \"test\" after character 10 is: {resultsInt}");

          
            resultsInt = testString.IndexOf("test", 50);  
            Console.WriteLine($"Index of \"test\" after character 49 is: {resultsInt}");

            resultsInt = testString.LastIndexOf("test");
            Console.WriteLine($"Last Index of \"test\" is: {resultsInt}");

            resultsInt = testString.LastIndexOf("test", 48);
            Console.WriteLine($"Last Index of \"test\" before character 48 is: {resultsInt}");


            resultsInt = testString.LastIndexOf("test", 9);
            Console.WriteLine($"Last Index of \"test\" after character 9 is: {resultsInt}");
        }

        private static void OrderingStrings()
        {
            CompareToHelper("Mary", "Bob");
            CompareToHelper("Mary", null);
            CompareToHelper("Adam", "Bob");
            CompareToHelper("Bob", "Bob");
            CompareToHelper("Bob", "Bobby");

            Console.WriteLine();

            CompareHelper("Mary", "Bob");
            CompareHelper("Mary", null);
            CompareHelper(null, "Bobby");
            CompareHelper("Adam", "Bob");
            CompareHelper("Bob", "Bob");
            CompareHelper("Bob", "Bobby");
            CompareHelper(null, null);

        }

        private static void CompareToHelper(string testA, string? testB)
        {
            int resultsInt = testA.CompareTo(testB);

            switch (resultsInt)
            {
                case > 0:
                    Console.WriteLine($"CompareTo: {testB ?? "null"} comes before { testA }");
                    break;
                case < 0:
                    Console.WriteLine($"CompareTo: { testA } comes before { testB }");
                    break;
                case 0:
                    Console.WriteLine($"CompareTo: { testA } is the same as {testB}");
                    break;
            }

        }

        private static void CompareHelper(string? testA, string? testB)
        {
            int resultsInt = String.Compare(testA, testB);

            switch (resultsInt)
            {
                case > 0:
                    Console.WriteLine($"Compare: {testB ?? "null"} comes before {testA}");
                    break;
                case < 0:
                    Console.WriteLine($"Compare: {testA ?? "null"} comes before {testB}");
                    break;
                case 0:
                    Console.WriteLine($"Compare: {testA ?? "null"} is the same as {testB ?? "null"}");
                    break;
            }
        }

        private static void TestingEquality()
        {
            EqualityHelper("Bob", "Mary");
            EqualityHelper(null, "");
            EqualityHelper("", " ");
            EqualityHelper("Bob", "bob");
        }

        private static void EqualityHelper(string? testA, string? testB)
        {
            bool resultBoolean;

            resultBoolean = String.Equals(testA, testB);
            if(resultBoolean)
            {
                Console.WriteLine($"Equals: '{ testA ?? "null"}' equals '{ testB ?? "null" }'");
            }
            else
            {
                Console.WriteLine($"Equals: '{ testA ?? "null"}' does not equal '{ testB ?? "null"}'");
            }

            resultBoolean = String.Equals(testA, testB, StringComparison.CurrentCultureIgnoreCase);
            if (resultBoolean)
            {
                Console.WriteLine($"Equals(Ignore case): '{testA ?? "null"}' equals '{testB ?? "null"}'");
            }
            else
            {
                Console.WriteLine($"Equals (Ignore case): '{testA ?? "null"}' does not equal '{testB ?? "null"}'");
            }

            resultBoolean = testA == testB;
            if (resultBoolean)
            {
                Console.WriteLine($"==: '{testA ?? "null"}' equals '{testB ?? "null"}'");
            }
            else
            {
                Console.WriteLine($"==: '{testA ?? "null"}' does not equal '{testB ?? "null"}'");
            }
            Console.WriteLine();
        }

        private static void GettingASubstring()
        {
            string testString = "This is a test bustring. Let's see how its testing works out";
            string results;

            results = testString.Substring(5);
            Console.WriteLine(results);

            results = testString.Substring(5, 4);
            Console.WriteLine(results);
        }

        private static void ReplacingText()
        {
            string testString = "This is a test of replace. Let's see how it Works out";
            string results;

            results = testString.Replace("test", "trial");
            Console.WriteLine(results);

            results = testString.Replace("test", " trial ");
            Console.WriteLine(results);

            results = testString.Replace("works", "makes", StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine(results);
        }

        private static void InsertingText()
        {
            string testString = "This is a test of insert. Let's see how it Works out";
            string results;

            results = testString.Insert(5, "(test) ");
            Console.WriteLine(results);
        }

        private static void RemovingText()
        {
            string testString = "This is a test of remove. Let's see how it Works out";
            string results;

            results = testString.Remove(25);
            Console.WriteLine(results);

            results = testString.Remove(10, 14);
            Console.WriteLine(results);
        }
    }
}
