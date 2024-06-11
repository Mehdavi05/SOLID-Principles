namespace Solid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;

            while (option != -1)
            {
                Console.WriteLine("Select option to see the required principle in run.\n1. Solid Principle.\n2. Open/Closed Priciple\n" +
                "3. Liskov Substitution Principle.\n4. Interface Segregation Principle (ISP).\n5. Dependency Inversion Principle ");

                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        // Creating a new report
                        Report report = new Report("Monthly Report", "This is the content of the monthly report.");

                        // Printing the report
                        ReportPrinter printer = new ReportPrinter();
                        printer.PrintReport(report);

                        // Saving the report to a file
                        ReportSaver saver = new ReportSaver();
                        saver.SaveReport(report, "report.txt");
                        break;

                    case 2:
                        //Creating Shapes
                        Shape circle = new Circle(5.0);
                        Shape rectangle = new Rectangle(4.0, 6.0);

                        // Adding shapes to the drawer
                        ShapeDrawer shapeDrawer = new ShapeDrawer();
                        shapeDrawer.AddShape(circle);
                        shapeDrawer.AddShape(rectangle);

                        // Drawing all shapes
                        shapeDrawer.DrawAllShapes();

                        break;
                 
                    case 3:
                        
                        List<Bird> birds = new List<Bird>
                        {
                            new Sparrow(),
                            new Penguin()
                        };

                        foreach (var bird in birds)
                        {
                            bird.MakeSound();
                            if (bird is Sparrow sparrow)
                            {
                                sparrow.Fly();
                            }
                            else if (bird is Penguin penguin)
                            {
                                penguin.Swim();
                            }
                        }
                        break;

                    case 4:
                        // Using SimplePrinter
                        IPrinter simplePrinter = new SimplePrinter();
                        simplePrinter.Print("Simple Printer Document");

                        // Using MultifunctionPrinter
                        IPrinter multifunctionPrinter = new MultifunctionPrinter();
                        IScanner multifunctionScanner = new MultifunctionPrinter();

                        multifunctionPrinter.Print("Multifunction Printer Document");
                        multifunctionScanner.Scan("Multifunction Printer Document");

                        // Using SimpleScanner
                        IScanner simpleScanner = new SimpleScanner();
                        simpleScanner.Scan("Simple Scanner Document");

                        break;

                    case 5:
                        // Using the EmailService to send a notification
                        IMessageService emailService = new EmailService();
                        Notification emailNotification = new Notification(emailService);
                        emailNotification.Notify("This is an email notification.");

                        // Using the SmsService to send a notification
                        IMessageService smsService = new SmsService();
                        Notification smsNotification = new Notification(smsService);
                        smsNotification.Notify("This is an SMS notification.");
                        break;

                    default:
                        break;

                }
            }

            Console.ReadKey();
        }
    }
}
