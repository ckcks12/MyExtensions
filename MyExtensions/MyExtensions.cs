global using System.Runtime.CompilerServices;

namespace MyExtensions;

public static class MyExtensions
{
    public static TimeSpan Hour(this int a) => TimeSpan.FromHours(a);
    public static TimeSpan Min(this int a) => TimeSpan.FromMinutes(a);
    public static TimeSpan Sec(this int a) => TimeSpan.FromSeconds(a);
    public static TaskAwaiter GetAwaiter(this int a) => Task.Delay(a).GetAwaiter();
    public static IEnumerable<int> Range(this int a) => Enumerable.Range(0, a);
    public static IEnumerable<int> Range(this int a, int b) => Enumerable.Range(a, b);
    public static IEnumerable<T> Select<T>(this int a, Func<int, T> b) => a.Range().Select(b);
    public static IEnumerable<T> Select<T>(this int a, Func<int, int, T> b) => a.Range().Select(b);
}