using System.Numerics;

namespace Consolee;

public static class AlgorithmQue4
{
    public static int Calculator(DateTime birthDate)
    {
        DateTime now = DateTime.Now;
        var diffrence = now - birthDate;
        int x =diffrence.Days / 365;
        return x;
    }
}
