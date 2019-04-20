using System;
using System.Linq;


namespace PRACTICE_CODING
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string[] dayInAMonth = new string[] {
                "1","2","3","4","5","6","7","8","9","10","11","12","13","14","15","16","17","18",
                "19","20","21","22","23","24","25","26","27","28","29","30","31",
            };

            string[] monthInAYear = new string[] {
                "1","2","3","4","5","6","7","8","9","10","11","12"
            };

            //days
            Console.Write("Day: ");
            string day = Console.ReadLine();

            while (day == "" || !dayInAMonth.Contains(day)) {
                Console.Clear();
                Console.Write("Day: ");
                day = Console.ReadLine();

                if (dayInAMonth.Contains(day))
                {
                    break;
                }
            }



            //month
            Console.Write("Month: ");
            string month = Console.ReadLine();

            while (month == "" || !monthInAYear.Contains(month))
            {
                Console.Clear();
                Console.Write("Month: ");
                month = Console.ReadLine();

                if (dayInAMonth.Contains(month))
                {
                    break;
                }
            }

            //year last 2 digit
            Console.Write("Last 2 digit of the year: ");
            string last2DigitYear = Console.ReadLine();

            while (last2DigitYear.Length > 2 || last2DigitYear == "") {
                Console.Write("Last 2 digit of the year: ");
                last2DigitYear = Console.ReadLine();

                if (last2DigitYear == "0") {
                    break;
                }
            }

            //year first 2 digit
            Console.Write("First 2 digit of the year: ");
            string first2DigitYear = Console.ReadLine();

            while (first2DigitYear.Length > 2 || first2DigitYear == "")
            {
                Console.Write("First 2 digit of the year: ");
                first2DigitYear = Console.ReadLine();
            }


            int dayConverted = Int32.Parse(day);
            int monthConverted = Int32.Parse(month);
            int last2DigitYearConverted = Int32.Parse(last2DigitYear);
            int first2DigitYearConverted = Int32.Parse(first2DigitYear);

            last2DigitYearConverted = Last2DIGIT(last2DigitYearConverted, monthConverted);
            monthConverted = MonthConvertion(monthConverted);

            Console.WriteLine(dayGenerator(dayConverted, monthConverted, first2DigitYearConverted, last2DigitYearConverted));

            Console.ReadKey();
        }

        public static string dayGenerator(int day, int month, int first2digit, int last2digit) {

            double result = 0;
            //k + [(13 * m - 1) / 5] + D + [D / 4] + [C / 4] - 2 * C
            result = day + ((13 * month - 1) / 5) + last2digit + (last2digit / 4) + (first2digit / 4) - 2 * first2digit;
            double dayoftheweek = result % 7;
            string weekday;
            if (dayoftheweek == 0)
            {
                weekday = "sunday";
                return weekday;
            }
            else if (dayoftheweek == 1)
            {
                weekday = "monday";
                return weekday;
            }
            else if (dayoftheweek == 2)
            {
                weekday = "Tuesday";
                return weekday;
            }
            else if (dayoftheweek == 3)
            {
                weekday = "Wednesday";
                return weekday;
            }
            else if (dayoftheweek == 4)
            {
                weekday = "Thursday";
                return weekday;
            }
            else if (dayoftheweek == 5)
            {
                weekday = "Friday";
                return weekday;
            }
            else if (dayoftheweek == 6)
            {
                weekday = "Saturday";
                return weekday;
            }
            else {
                weekday = "Invalid";
                return weekday;
            }
        }
        public static int Last2DIGIT(int last2digits, int monthNum) {

            int year;
            if (monthNum == 1 || monthNum == 2)
            {
                year = last2digits - 1;
                return year;
            }
            else {
                year = last2digits;
                return year;
            }
            
            
            
            
        }
        public static int MonthConvertion(int monthNum){

            int convertedMonth;
            if (monthNum == 1) {
                //january
                monthNum = 11;
                
            }else if (monthNum == 2)
            {
                //february
                monthNum = 12;

            }
            else if (monthNum == 3)
            {
                //march
                monthNum = 1;

            }
            else if (monthNum == 4)
            {
                //april
                monthNum = 2;

            }
            else if (monthNum == 5)
            {
                //may
                monthNum = 3;

            }
            else if (monthNum == 6)
            {
                //june
                monthNum = 4;

            }
            else if (monthNum == 7)
            {
                //july
                monthNum = 5;

            }
            else if (monthNum == 8)
            {
                //august
                monthNum = 6;

            }
            else if (monthNum == 9)
            {
                //september
                monthNum = 7;

            }
            else if (monthNum == 10)
            {
                //october
                monthNum = 8;

            }
            else if (monthNum == 11)
            {
                //november
                monthNum = 9;

            }
            else if (monthNum == 12)
            {
                //december
                monthNum = 10;

            }
            convertedMonth = monthNum;
            return convertedMonth;
        }

        
    }
}
