using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        public static string Name(string yourName)
        {
            //NAME
            //validate string by pattern and store result in Match variable.
            // Names can only have alphabets, they should start with a capital letter, and they have a maximum length of 30.
            Match temp = Regex.Match(yourName, @"(^[A-Za-z]{1,30}$)");
            //check Match variable to see if validation was successful.
            if (Regex.Match(yourName, @"(^[A-z]{1,30}$)").Success)
            {
                Console.WriteLine("Your entry is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, name is not valid! ");
            }
            return yourName;
        }

        public static string Emails(string email)
        {
            //EMAIL
            Match temp = Regex.Match(email, @"([0-9A-Za-z\\]{5,30}@{1}[0-9A-Za-z\\]{5,10}\.[0-9A-Za-z]{2,3})");
            if (Regex.Match(email, @"([0-9A-Za-z\\]{5,30}@{1}[0-9A-Za-z\\]{5,10}\.[0-9A-Za-z]{2,3})").Success)
            {
                Console.WriteLine("Email is valid! ");
            }
            else
            {
                Console.WriteLine("Email is invalid.");
            }
            return email;
        }

        public static string PhoneNumber(string phone)
        {
            //PHONE NUMBER: ###-###-####
            Match temp = Regex.Match(phone, @"(^[0-9]{3}-[0-9]{3}-[0-9]{4}$)");
            if (Regex.Match(phone, @"(^[0-9]{3}-[0-9]{3}-[0-9]{4}$)").Success)
            {
                Console.WriteLine("Your entry is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, phone is not valid! ");
            }
            return phone;
        }

        public static string DateFormat(string date)
        {
            //DATE: DD/MM/YYYY
            Match temp = Regex.Match(date, @"(^\d\d([/])\d\d([/])\d\d\d\d$)");
            if (Regex.Match(date, @"(^\d\d([/])\d\d([/])\d\d\d\d$)").Success)
            {
                Console.WriteLine("Your entry is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, date is not valid! ");
            }
            return date;
        }

        public static string HtmlParagraph(string html)
        {
            //HTML elements
            Match temp = Regex.Match(html, @"(^<+[a-z]+>+([ ])+<([/])[a-z]>$)");
            if (Regex.Match(html, @"(^<+[a-z]+>+([ ])+<([/])[a-z]>$)").Success)
            {
                Console.WriteLine($"{html} is a valid html element.");
            }
            else if (Regex.Match(html, @"(^<+[a-z]+([ ])+<+[a-z]>$)").Success)
            {
                Console.WriteLine($"{html} is not valid.");
            }
            return html;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid Name: ");
            string yourName = Console.ReadLine();
            Name(yourName); //Calling Name method using yourName parameter

            Console.WriteLine("Please enter a valid email: ");
            string email = Console.ReadLine();
            Emails(email); //Calling Emails method using email parameter

            Console.WriteLine("Please enter a valid phone number: ");
            string phone = Console.ReadLine();
            PhoneNumber(phone); //Calling PhoneNumber method using phone parameter

            Console.WriteLine("Please enter a valid date: ");
            string date = Console.ReadLine();
            DateFormat(date); //Calling DateFormat method using date parameter

            Console.WriteLine("Please enter paragraph HTML element: ");
            string html = Console.ReadLine();
            HtmlParagraph(html); //Calling HtmlParagraph method using html parameter
        }
    }
}
