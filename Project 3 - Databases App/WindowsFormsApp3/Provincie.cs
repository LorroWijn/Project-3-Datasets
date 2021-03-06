﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public static class Constants
    {
        public const int aantalProvincies = 12;
        public const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\loren\OneDrive\Documents\GitHub\Project-3-Datasets\Project 3 - Databases App\WindowsFormsApp3\Database for project 3 - Databases.mdf';Integrated Security=True";
    }

    class Calculator
    {
        public static string Difference(int minimum, int maximum, int current)
        {
            var difference = maximum - minimum;
            var differenceDiv11 = difference / 11;
            var colorAmount = ((current - minimum) / differenceDiv11) + 1;
            var colorAmountString = string.Format("{0:00}", colorAmount);
            return colorAmountString;
        }

        public static int Maximum(int oldValue, int newValue)
        {
            int maximum;
            if (oldValue < newValue)
            {
                maximum = newValue;
            }
            else
            {
                maximum = oldValue;
            }
            return maximum;
        }

        public static int Minimum(int oldValue, int newValue)
        {
            int minimum;
            if (oldValue > newValue)
            {
                minimum = newValue;
            }
            else
            {
                minimum = oldValue;
            }

            return minimum;
        }

    }

    public enum ProvincieEnum
    {
        Drenthe = 0,
        Flevoland,
        Friesland,
        Gelderland,
        Groningen,
        Limburg,
        NoordBrabant,
        NoordHolland,
        Overijssel,
        Utrecht,
        Zeeland,
        ZuidHolland
    }

}
