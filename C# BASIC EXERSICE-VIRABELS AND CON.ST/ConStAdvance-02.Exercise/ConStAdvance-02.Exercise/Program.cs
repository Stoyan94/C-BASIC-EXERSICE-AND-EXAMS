﻿using System;

namespace NewSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string food = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0.0;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":

                    {

                        switch (food)
                        {
                            case "banana":
                                price = quantity * 2.50;
                                break;
                            case "apple":
                                price = quantity * 1.20;
                                break;
                            case "orange":
                                price = quantity * 0.85;
                                break;
                            case "grapefruit":
                                price = quantity * 1.45;
                                break;
                            case "kiwi":
                                price = quantity * 2.70;
                                break;
                            case "pineapple":
                                price = quantity * 5.50;
                                break;
                            case "grapes":
                                price = quantity * 3.85;
                                break;
                        }
                    }

                    break;

                case "Saturday":
                case "Sunday":
                    switch (food)
                    {
                        case "banana":
                            price = quantity * 2.70;
                            break;
                        case "apple":
                            price = quantity * 1.25;
                            break;
                        case "orange":
                            price = quantity * 0.90;
                            break;
                        case "grapefruit":
                            price = quantity * 1.60;
                            break;
                        case "kiwi":
                            price = quantity * 3.00;
                            break;
                        case "pineapple":
                            price = quantity * 5.60;
                            break;
                        case "grapes":
                            price = quantity * 4.20;
                            break;
                    }

                    break;
            }
            if (price == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{price:F2}");
            }
        }
    }
}

