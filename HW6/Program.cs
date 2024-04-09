using System.Diagnostics;
using HW6;

class Program
{
    private static void Main(string[] args)
    {
        var sw = new Stopwatch();
        sw.Start(); 
        double lat = 0;
        double lonh = 0;
        double radius = 0;
        
        for (int i = 0; i < args.Length; i++)
        {
            var temp = args[i].Split("=");
            
            if (temp[0] == "--lat")
            {
                double.TryParse(temp[1], out lat);
            }
            else if (temp[0] == "--long")
            {
                double.TryParse(temp[1], out lonh);
            }
            else if (temp[0] == "--size")
            {
                double.TryParse(temp[1], out radius);
            }
        }
        
        foreach (var row in File.ReadAllLines(@"C:\\Users\\iskos\\RiderProjects\\HW6\\HW6\\ukraine_poi.csv"))
        {
            var splited = row.Split(";");
            var distance = HaversineFormula.CalculateDistance(Convert.ToDouble(splited[0]),
                Convert.ToDouble(splited[1]), lat, lonh);
                                       ;
            if ( distance <= radius)
            {
                Console.WriteLine(row);
            }
        }
        
        sw.Stop();
        Console.WriteLine($"Elapsed time: {sw.Elapsed}");
    }
    
}