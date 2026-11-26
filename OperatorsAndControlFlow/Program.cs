namespace OperatorsAndControlFlow
{
    class Program
    {
        static void Main()
        {
            // Add Task 1 to Task 6 here, in this order.

            //Task 1: College Reward Points 
            int points = 10;
            points +=5;
            points *= 2;

            Console.WriteLine("Final Points: " + points);

            bool comparing = points >= 25;
            Console.WriteLine ($"Comparing final points to 25: {comparing}");

            int afterPost = points++;
            Console.WriteLine ($"Points returned {afterPost}; Points is now  {points}");

            int afterPre = ++points;
            Console.WriteLine ($"Points returned {afterPre}; Points is now  {points}");


            Console.WriteLine("-------Task 1 Completed---------");



            //Task 2: Student Exam Result

            int marks = 72;
            int attendance = 80;

            string grade = "";

            if (marks >= 80)
            {
                grade = "A";
            }

            else if (marks >= 65 && marks <= 79)
            {
                grade = "B";
            }

            else if (marks >= 50 && marks <= 64)
            {
                grade = "C";
            }
            else
            {
                grade = "Fail";
            }


            bool isEligible = false;
            isEligible = marks >= 50 && attendance >= 75;

            Console.WriteLine ($"Marks : {marks}, Attendance: {attendance}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Pass eligible: {isEligible}");


            Console.WriteLine("-------Task 2 Completed---------");


            //Task 3: Library Menu

            int choice = 2;                  
            Console.WriteLine("Library Menu");
            Console.WriteLine("1. Borrow   2. Return   3. Renew");
            Console.WriteLine($"Selected choice: {choice}");

            // TODO 2: switch on choice with cases 1, 2, 3 and a default
            switch(choice){

                case 1:
                    Console.WriteLine ("You have selected Borrow");
                    break;

                case 2:
                    Console.WriteLine ("You have selected Return");
                    break;

                case 3:
                    Console.WriteLine ("You have selected Renew");
                    break;

            default:
                    Console.WriteLine ("Invalid choice");
                    break;



            }

            // TODO 3: ?? displays "Guest"
            string? userName = null;         
            string displayName = userName ?? "Guest";
            Console.WriteLine($"Display name: {displayName}");

            // TODO 4: ??= assigns "Guest" only when userName is null
            userName ??= "Guest";
            Console.WriteLine($"User Name: {userName}");

            Console.WriteLine("-------Task 3 Completed---------");


            //Task 4: Weekly Attendance
            int[] dailyAttendance = { 20, 22, 21, 24, 23 }; // TODO 1: Monday to Friday
            int total = 0;

            Console.WriteLine("Daily Attendance:");

            // TODO 2: foreach — print each value and add it to total

            foreach (int attendanceCount in dailyAttendance)
            {
                Console.WriteLine($"Attendance: {attendanceCount}");
                total += attendanceCount;
            }

            Console.WriteLine($"Total Attendance: {total}");

            // TODO 3: for — print "Day 1: 20" through "Day 5: 23"

            for (int i = 0; i < dailyAttendance.Length; i++)
            {
                Console.WriteLine($"Day {i+1}: {dailyAttendance[i]}");
            }

            // TODO 4: while — count down from 3 to 1
            int countdown = 3;
            while (countdown >= 1)
            {
                Console.WriteLine(countdown);
                countdown--;
            }

            // TODO 5: do-while — print "Attendance recorded" once with runAgain = false
            bool runAgain = false;
            do
            {
                Console.WriteLine("Attendance recorded");
            } 
            while (runAgain);

            Console.WriteLine("-------Task 4 Completed---------");


            //Task 5: Exam Hall Seat Labels

            
            // TODO 1: nested for loops printing "Row 1 - Seat 1" to "Row 3 - Seat 4"
            int seatCount = 0;
            
             
            for (int row = 1; row <=3; row++)
            {
                for (int seat = 1; seat <=4; seat++)
                {
                    Console.WriteLine($"Row {row} - Seat {seat}");
                    seatCount++;
                }
            }
            Console.WriteLine($"Total seats: {seatCount}");

            // TODO 2: for 1 to 10, continue at 5 and break at 8
            Console.Write("Loop values: ");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                if (i == 8)
                {
                    break;
                }
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine("-------Task 5 Completed---------");

            //Task 6: Simple Division Calculator

            // TODO 1: ask for two integers with Console.ReadLine()
            Console.Write("Enter first integer: ");
            string input1 = Console.ReadLine() ?? "";

            Console.Write("Enter second integer: ");
            string input2 = Console.ReadLine() ?? "";

            // TODO 2: inside try, int.Parse both inputs and divide first by second
            try
            {
                int num1 = int.Parse(input1);
                int num2 = int.Parse(input2);
                int result = num1 / num2;
                Console.WriteLine($"Result: {result}");
            }
            // TODO 3: catch FormatException and DivideByZeroException separately
            catch (FormatException)
            {
                Console.WriteLine("Please enter valid integers.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: The second number cannot be zero.");
            }
            // TODO 4: finally prints "Calculation complete"

            finally
            {
                Console.WriteLine("Calculation complete");
            }

            Console.WriteLine("-------Task 6 Completed---------");




        }
    }
}

