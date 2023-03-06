using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03.File_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CollectionPoem col = new CollectionPoem();
            col.Add(new Poem("Name poem", "Name Surname", 1991, "Text", "Theam"));
            col.Add(new Poem("Name poem2", "Name Surname2", 1995, "Text2", "Theam2"));
            col.Add(new Poem("Name poem3", "Name Surname3", 2013, "Text3", "Theam3"));
            col.WriteFile();
            col.LoadFile();
            col.WriteFile();
            Console.WriteLine(col.SearchByNamePoem("Name poem"));
            IReport obj = null;
            obj = new ReportNamePoem();
            Console.WriteLine(obj.Report(col.GetList()));
            WriteFileReport writer = new WriteFileReport();
            writer.Write(obj, "ReportNamePoem");
            obj = new ReportNameSurname();
            Console.WriteLine(obj.Report(col.GetList()));
            writer.Write(obj, "ReportNameSurname");
            obj = new ReportTheame();
            Console.WriteLine(obj.Report(col.GetList()));
            writer.Write(obj, "ReportTheame");
            ReportCountWord obj3 = new ReportCountWord();
            Console.WriteLine(obj3.Report(col.GetList(), "Text"));
            obj = new ReportCountText();
            Console.WriteLine("Count text -> " + obj.Report(col.GetList()));
            writer.Write(obj, "ReportCountText");
        }
    }
}
