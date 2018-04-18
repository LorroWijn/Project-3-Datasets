using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public static class Constants
    {
        public const int aantalProvincies = 12;
    }

    public static class DataSource
    {
        public const string dataSource = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Github\Project-3-Datasets\Project 3 - Databases App\WindowsFormsApp3\Database for project 3 - Databases.mdf;Integrated Security=True";
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

    public enum ProvincieLinksEnum
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

    public enum ProvincieRechtsEnum
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
