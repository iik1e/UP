// Task 1
using System;

namespace ConsoleApplication1
{
    public class Student
    {
        class Students
        {
            public string LastName { get; set; }
            public string DateBirthday { get; set; }
            public int Group { get; set; }
            public double Performance { get; set; }


            public void information(string LastName, string DateBirthday, int Group, int Performance)
            {
                Console.WriteLine("Last Name: {0}\n Date Birthday: {1}\n Group: {2}\n Performance: {3}\n", LastName, DateBirthday, Group, Performance);
            }
        }

        public static void Main()
        {
            Students Alexey = new Students();

            Alexey.LastName = "Fadeev";
            Alexey.DateBirthday = "02.02.2004";
            Alexey.Group = 621;
            const int size = 5;
            Alexey.Performance = 0;
            int[] MyArray = { 2, 4, 5, 5, 4 };
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += MyArray[i];
                Alexey.Performance = sum / size;
            }
            
            Console.WriteLine("1 - to display information, 2 - to change data");
            int choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"{Alexey.LastName}, {Alexey.DateBirthday}, {Alexey.Group}, {Alexey.Performance}");
                    break;
                case 2:
                    Console.WriteLine("name change");
                    string rename = Console.ReadLine();
                    Console.WriteLine("date of birth change");
                    string BirthChange = Console.ReadLine();
                    Console.WriteLine("group change");
                    int GroupChange = int.Parse(Console.ReadLine());

                    Alexey.LastName = rename;
                    Alexey.DateBirthday = BirthChange;
                    Alexey.Group = GroupChange;
                    
                    Console.WriteLine($"{Alexey.LastName}, {Alexey.DateBirthday}, {Alexey.Group}, {Alexey.Performance}");
                    break;
            }
        }

    }
}

// Task 2:

using System;

namespace ConsoleApp1
{
    public class Program
    {
        class Train
        {
            public string destination { get; set; }
            public int train_number { get; set; }
            public string departure_time { get; set; }
        }
        static void Main(string[] args)
        {
            Train Siberia = new Train();
            Siberia.destination = "mountain Altai";
            Siberia.departure_time = "16.45";
            Siberia.train_number = 621;
            Train Altai = new Train();
            Altai.destination = "Tomsk";
            Altai.departure_time = "15.30";
            Altai.train_number = 532;
            
            Console.WriteLine("Enter train number");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 621:
                    Console.WriteLine($"{Siberia.destination}, {Siberia.train_number}, {Siberia.departure_time}");
                    break;
                case 532:
                    Console.WriteLine($"{Altai.destination}, {Altai.train_number}, {Altai.departure_time}");
                    break; 
                default:
                    Console.WriteLine("There is no such train number.");
                    break;
            }
        }
    }
}

// Task 3:

using System;

namespace ConsoleApp1
{
    public class Program
    {
        class MATH
        {
            public int NUMBER1;
            public int NUMBER2;
        }

        static void Main(string[] args)
        {
            MATH FIRST_NUMBER = new MATH();
            MATH SECOND_NUMBER = new MATH();
            FIRST_NUMBER.NUMBER1 = 10;
            SECOND_NUMBER.NUMBER2 = 25;

            Console.WriteLine("1 - DISPLAY OUTPUT, 2 - CHANGE NUMBER, 3 - FINDING THE HIGHEST NUMBER, 4 - SUM NUMBERS");
            int CHOICE = int.Parse(Console.ReadLine());
            switch (CHOICE)
            {
                case 1:
                    Console.WriteLine($"{FIRST_NUMBER.NUMBER1}, {SECOND_NUMBER.NUMBER2}");
                    break;
                case 2:
                    Console.WriteLine("CHANGE FIRST NUMBER");
                    int NUMBER_CHANGE1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("CHANGE SECOND NUMBER");
                    int NUMBER_CHANGE2 = int.Parse(Console.ReadLine());

                    FIRST_NUMBER.NUMBER1 = NUMBER_CHANGE1;
                    SECOND_NUMBER.NUMBER2 = NUMBER_CHANGE2;
                    Console.WriteLine($"{FIRST_NUMBER.NUMBER1}, {SECOND_NUMBER.NUMBER2}");
                    
                    Console.WriteLine("YOU WANT TO USE THE OPERATION FOR NEW NUMBERS? IF YOU WANT, CLICK 1, ELSE CLICK 2");
                    int CHOISE2 = int.Parse(Console.ReadLine());

                    if (CHOISE2 == 1)
                    {
                        Console.WriteLine("1 - FINDING THE HIGHEST NUMBER, 2 - SUM NUMBERS");
                        int CHOICE_IN_CHOISE = int.Parse(Console.ReadLine());
                        switch (CHOICE_IN_CHOISE)
                        {
                            case 1:
                                if (FIRST_NUMBER.NUMBER1 < SECOND_NUMBER.NUMBER2)
                                {
                                    Console.WriteLine($"HIGHEST VALUE = {SECOND_NUMBER.NUMBER2}");
                                }
                                else
                                {
                                    Console.WriteLine($"HIGHEST VALUE = {FIRST_NUMBER.NUMBER1}");
                                }
                                break;
                            case 2:
                                int SUM_IN_CHOICE = 0;
                                SUM_IN_CHOICE = FIRST_NUMBER.NUMBER1 + SECOND_NUMBER.NUMBER2;
                                Console.WriteLine($"SUM ALL ELEMENTS = {SUM_IN_CHOICE}");
                                break;
                        }
                    }

                    else if (CHOISE2 == 2)
                    {
                        Console.WriteLine(";( WHY DID I DO THIS THEN? ;(");
                    }
                    
                    break;
                case 3:
                    if (FIRST_NUMBER.NUMBER1 < SECOND_NUMBER.NUMBER2)
                    {
                        Console.WriteLine($"HIGHEST VALUE = {SECOND_NUMBER.NUMBER2}");
                    }
                    else
                    {
                        Console.WriteLine($"HIGHEST VALUE = {FIRST_NUMBER.NUMBER1}");
                    }
                    break;
                case 4:
                    int SUM = 0;
                    SUM = FIRST_NUMBER.NUMBER1 + SECOND_NUMBER.NUMBER2;
                    Console.WriteLine($"SUM ALL ELEMENTS = {SUM}");
                    break;
            }
        }
    }
}

// Task 4:

using System;

namespace ConsoleApp1
{
    public class Program
    {
        class counter
        {
            public int CountNumber;
        }

        static void Main(string[] args)
        {
            counter UserNumber = new counter();
            int count = 100;
            Console.WriteLine("1 - use ur value, 2 - use default value(100)");
            int InitialChoise = int.Parse(Console.ReadLine());
            
            if (InitialChoise == 1)
            {
                Console.WriteLine("Enter ur number");
                UserNumber.CountNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter 1 - if you want to increase the number, 2 - decrease the number");

                int Choice = int.Parse(Console.ReadLine());

                if (Choice == 1)
                {
                    bool Increase = true;
                    while (Increase == true)
                    {
                        UserNumber.CountNumber++;
                        Console.WriteLine(
                            "1 - if u want to continue, 2 - If you want to see the result and continue, 3 - finish and get results");
                        int IncreaseChoise = int.Parse(Console.ReadLine());

                        switch (IncreaseChoise)
                        {
                            case 1:
                                Increase = true;
                                break;
                            case 2:
                                Console.WriteLine($"Result = {UserNumber.CountNumber}");
                                Increase = true;
                                break;
                            case 3:
                                Console.WriteLine($"Result = {UserNumber.CountNumber - 1}");
                                Increase = false;
                                break;
                        }
                    }
                }
                else if (Choice == 2)
                {
                    bool Decrease = true;
                    while (Decrease == true)
                    {
                        UserNumber.CountNumber--;
                        Console.WriteLine(
                            "1 - if u want to continue, 2 - If you want to see the result and continue, 3 - finish and get results");
                        int DecreaseChoise = int.Parse(Console.ReadLine());

                        switch (DecreaseChoise)
                        {
                            case 1:
                                Decrease = true;
                                break;
                            case 2:
                                Console.WriteLine($"Result = {UserNumber.CountNumber}");
                                Decrease = true;
                                break;
                            case 3:
                                Console.WriteLine($"Result = {UserNumber.CountNumber + 1}");
                                Decrease = false;
                                break;
                        }
                    }
                }
            }
            else if (InitialChoise == 2)
            {
                Console.WriteLine("Enter 1 - if you want to increase the number, 2 - decrease the number");

                int Choice = int.Parse(Console.ReadLine());

                if (Choice == 1)
                {
                    bool Increase = true;
                    while (Increase == true)
                    {
                        count++;
                        Console.WriteLine(
                            "1 - if u want to continue, 2 - If you want to see the result and continue, 3 - finish and get results");
                        int IncreaseChoise = int.Parse(Console.ReadLine());

                        switch (IncreaseChoise)
                        {
                            case 1:
                                Increase = true;
                                break;
                            case 2:
                                Console.WriteLine($"Result = {count}");
                                Increase = true;
                                break;
                            case 3:
                                Console.WriteLine($"Result = {count - 1}");
                                Increase = false;
                                break;
                        }
                    }
                }
                else if (Choice == 2)
                {
                    bool Decrease = true;
                    while (Decrease == true)
                    {
                        count--;
                        Console.WriteLine(
                            "1 - if u want to continue, 2 - If you want to see the result and continue, 3 - finish and get results");
                        int DecreaseChoise = int.Parse(Console.ReadLine());

                        switch (DecreaseChoise)
                        {
                            case 1:
                                Decrease = true;
                                break;
                            case 2:
                                Console.WriteLine($"Result = {count}");
                                Decrease = true;
                                break;
                            case 3:
                                Console.WriteLine($"Result = {count + 1}");
                                Decrease = false;
                                break;
                        }
                    }
                }
            }
        }
    }
}

// Task 5:

using System;

namespace ConsoleApp1
{
    public class Program
    {
        public class Default
        {
            public string Name;
            public int Age;

            public Default()
            {
                Name = "Egor";
                Age = 18;
            }

            public Default(string Name, int Age)
            {
                if (Name == "Egor" && Age == 18)
                {
                    Console.WriteLine("Conditions met");
                }
                else
                {
                    Console.WriteLine("Conditions not met");
                }
            }

             ~Default()
            {
                Console.Write("objects removed");
            }
            
        }

        static void Main(string[] args)
        {
            Default temp = new Default();
            Default User = new Default("Egor", 18);
        }
        
        
    }
}