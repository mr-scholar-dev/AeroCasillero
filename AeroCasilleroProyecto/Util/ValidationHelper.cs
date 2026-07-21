namespace AeroCasilleroProyecto.Util;

public static class ValidationHelper
{
    public static void Require(bool condition, string message)
    {
        if (!condition)
        {
            throw new ArgumentException(message);
        }
    }

    public static string TrimOrEmpty(string? value) => string.IsNullOrWhiteSpace(value) ? string.Empty : value.Trim();
}
