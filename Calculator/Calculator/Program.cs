﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Addition
            double numone, numtwo = 0;
            double int_number = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Welcome to Calculator | type");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" esc");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" and enter to exit the calculator");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You can use operators + , - , / , *  Ex:- 2+5-2*2/5");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter numbers to calculate followed by enter");
            //string number_build = "";
            //double short_sum = 0;
            while (true)
            {
                string typed_string = Console.ReadLine();
                if ("esc" == typed_string.ToLower())
                    Environment.Exit(0);
                var input_array = typed_string.ToList();
                //string[] operators =  {"+","-","/","*"};
                var operators = new List<string>();
                bool strat_is_a_operator = false;
                double number_input = 0;

                string[] typed_numbers = typed_string.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
                int xx = 0;
                for (int i = 0; i < input_array.Count(); i++)
                {
                    string current_text = input_array[i].ToString();
                    if ("+" == current_text)
                    {
                        if (0 == xx)
                        {
                            strat_is_a_operator = true;
                        }
                        operators.Add("+");

                    }
                    else if ("-" == current_text)
                    {
                        if (0 == xx)
                        {
                            strat_is_a_operator = true;
                        }
                        operators.Add("-");

                    }
                    else if ("/" == current_text)
                    {
                        if (0 == xx)
                        {
                            strat_is_a_operator = true;
                        }
                        operators.Add("/");

                    }
                    else if ("*" == current_text)
                    {
                        if (0 == xx)
                        {
                            strat_is_a_operator = true;
                        }
                        operators.Add("*");

                    }
                    xx++;
                }
                int jj = 0;
                double final = 0;
                if (typed_numbers.Length > 1)
                {
                    for (int j = 0; j < operators.Count; j++)
                    {

                        if ("/" == operators[0] && "0" == typed_numbers[0])
                        {
                            //if ("0" == typed_numbers[0])
                            //{
                            Console.WriteLine("Error! Result is undefined");
                            //}
                        }
                        else if ("/" == operators[0] && "0" == typed_numbers[1])
                        {

                            Console.WriteLine("Error! Cannot divide by zero");

                        }

                        else if (operators.Count > 0)
                        {
                            if (0 == j)
                            {
                                if (1 == typed_numbers.Length)
                                {
                                    double t_numbers = 0;
                                    double.TryParse(typed_numbers[j], out t_numbers);
                                    final = calcuations(operators[j], t_numbers, final);
                                    //Console.WriteLine("Sum in " + final.ToString());
                                }
                                else
                                {
                                    double t_numbers1 = 0;
                                    double t_numbers2 = 0;
                                    double.TryParse(typed_numbers[j], out t_numbers1);
                                    double.TryParse(typed_numbers[j + 1], out t_numbers2);
                                    final = calcuations(operators[j], t_numbers1, t_numbers2);
                                    //Console.WriteLine("Sum in " + final.ToString());
                                }

                            }
                            else
                            {
                                double t_numbers = 0;
                                double.TryParse(typed_numbers[j + 1], out t_numbers);
                                final = calcuations(operators[j], t_numbers, final);
                                //Console.WriteLine("Sum in " + final.ToString());
                            }
                        }


                    }
                }
                else
                {
                    double.TryParse(typed_numbers[0], out final);
                }

                double calcuations(string opt, double number, double sum)
                {
                    if ("+" == opt)
                    {
                        sum = addition(number, sum);
                    }
                    else if ("-" == opt)
                    {
                        sum = subtraction(number,sum);
                    }
                    else if ("/" == opt)
                    {
                        sum = divition(number,sum);
                    }
                    else if ("*" == opt)
                    {
                        sum = multiplication(number,sum);
                    }
                    return sum;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Total is :");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(final);
                Console.ForegroundColor = ConsoleColor.White;
            }

            double addition(double the_number, double sumof)
            {
                sumof = sumof + the_number;
                return sumof;
            }

            double subtraction(double the_number, double sumof)
            {
                sumof = sumof - the_number;
                return sumof;
            }

            double multiplication(double the_number, double sumof)
            {
                sumof = sumof * the_number;
                return sumof;
            }

            double divition(double the_number, double sumof)
            {
                sumof = the_number/sumof;
                return sumof;
            }

            double convert_string_numbers(string num_str)
            {

                if (double.TryParse(Console.ReadLine(), out int_number))
                {
                    return int_number;
                }
                else
                {
                    return 0;
                }

            }
        }
    }
}
