namespace HW6;

public class HaversineFormula
{
    private const double EarthRadiusKm = 6371;

    private static double DegreesToRadians(double degrees)
    {
        return degrees * Math.PI / 180.0;
    }

    public static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
    {
        lat1 = DegreesToRadians(lat1);
        lon1 = DegreesToRadians(lon1);
        lat2 = DegreesToRadians(lat2);
        lon2 = DegreesToRadians(lon2);

        var dLat = lat2 - lat1;
        var dLon = lon2 - lon1;

        var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                Math.Cos(lat1) * Math.Cos(lat2) *
                Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
        var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        var distance = EarthRadiusKm * c;

        return distance;
    }
}