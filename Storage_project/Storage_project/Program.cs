using Storage_;
using Storage_dll;
using Logs;

namespace Storage_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PriceList priceList = new PriceList();
            int menu = 0, count = 0, capacity = 0;
            string manufacturer = string.Empty, model = string.Empty, name = string.Empty, modelfind = string.Empty;
            double speed = 0;
            ILog console_log = new ConsoleLog();
            ILog file_log = new FileLog();

            while (true) // меню
            {
                Console.WriteLine("1. Add\n2. Remove\n3. Find\n4. Edit\n5. Save\n6. Load\n7. Print\n8. Exit");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("1. HDD\n2. Flash\n3. DVD");
                        menu = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Enter manufacturer -> ");
                        manufacturer = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Enter name -> ");
                        model = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Enter model -> ");
                        name = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Enter capacity -> ");
                        capacity = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Enter count -> ");
                        count = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (menu)
                        {
                            case 1:
                                Console.Write("Enter Speendle speed -> ");
                                speed = double.Parse(Console.ReadLine());
                                Console.Clear();
                                priceList.Add(new HDD(manufacturer, name, model, capacity, count, speed));
                                break;
                            case 2:
                                Console.Write("Enter USB speed -> ");
                                speed = double.Parse(Console.ReadLine());
                                Console.Clear();
                                priceList.Add(new Flash(manufacturer, name, model, capacity, count, speed));
                                break;
                            case 3:
                                Console.Write("Enter Write speed -> ");
                                speed = double.Parse(Console.ReadLine());
                                Console.Clear();
                                priceList.Add(new DVD(manufacturer, name, model, capacity, count, speed));
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Error...");
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        console_log.Print("added a new device.");
                        file_log.Print("added a new device.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        continue;
                    case 2:
                        Console.Clear();
                        Console.Write("Enter model to remove -> ");
                        model = Console.ReadLine();
                        Console.Clear();
                        priceList.Remove(model);
                        Thread.Sleep(1000);
                        Console.Clear();
                        console_log.Print("removed the device.");
                        file_log.Print("removed the device.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        continue;
                    case 3:
                        Console.Clear();
                        Console.Write("Enter model to find -> ");
                        model = Console.ReadLine();
                        Console.Clear();
                        priceList.Find(model);
                        Thread.Sleep(1000);
                        Console.Clear();
                        console_log.Print("found the device.");
                        file_log.Print("found the device.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        continue;
                    case 4:
                        Console.Clear();
                        Console.Write("Enter manufacturer -> ");
                        manufacturer = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Enter name -> ");
                        model = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Enter model -> ");
                        name = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Enter capacity -> ");
                        capacity = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Enter count -> ");
                        count = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Enter some (USB\\Spindle\\Write) speed -> ");
                        speed = double.Parse(Console.ReadLine());
                        Console.Clear();
                        priceList.Edit(manufacturer, name, model, capacity, count, speed);
                        Thread.Sleep(1000);
                        Console.Clear();
                        console_log.Print("edited the device.");
                        file_log.Print("edited the device.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        continue;
                    case 5:
                        Console.Clear();
                        priceList.Save();
                        Thread.Sleep(1000);
                        Console.Clear();
                        console_log.Print("saved devices.");
                        file_log.Print("saved devices.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        continue;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Load...");
                        priceList.Load();
                        Thread.Sleep(1000);
                        Console.Clear();
                        console_log.Print("loaded devices.");
                        file_log.Print("loaded devices.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        continue;
                    case 7:
                        Console.Clear();
                        priceList.Print();
                        Thread.Sleep(1000);
                        Console.Clear();
                        console_log.Print("printed devices.");
                        file_log.Print("printed device.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        continue;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Exit...");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Error...");
                        Thread.Sleep(1000);
                        Console.Clear();
                        continue;
                }
                break;
            }
        }

        private static void BaseWindow()
        {
            Console.WriteLine("Doing something here");
            //need one of these for each additional console window
            System.Diagnostics.Process.Start("Proof of Concept 2.exe", "1");
            Console.ReadLine();

        }
        private static void LogsWindow()
        {
            Console.WriteLine("Write something different on other Console");
            Console.ReadLine();
        }
    }
}