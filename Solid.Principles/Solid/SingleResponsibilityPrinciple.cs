using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Single Responsibility Principle (SRP)
//Principle: A class should have only one reason to change, meaning it should have only one job or responsibility.

namespace Solid
{
    // Class responsible for storing report data
    public class Report
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Report(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }

    // Class responsible for printing the report
    public class ReportPrinter
    {
        public void PrintReport(Report report)
        {
            Console.WriteLine("Printing Report:");
            Console.WriteLine("Title: " + report.Title);
            Console.WriteLine("Content: " + report.Content);
        }
    }

    // Class responsible for saving the report to a file
    public class ReportSaver
    {
        public void SaveReport(Report report, string filePath)
        {
            File.WriteAllText(filePath, "Title: " + report.Title + "\nContent: " + report.Content);
            Console.WriteLine("Report saved to " + filePath);
        }
    }
}
