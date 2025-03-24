namespace Saber.Common.Extensions;

public static class GenericExtensions
{
    public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> e)
    {
        return e.OrderBy(x => Helpers.Random.Next());
    }
}