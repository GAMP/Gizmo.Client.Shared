using System.Globalization;

namespace Gizmo.Client
{
    /// <summary>
    /// Input culture service.
    /// </summary>
    /// <remarks>
    /// Provides functionality to list and select sytem wide input culture.
    /// </remarks>
    public interface ICultureInputService
    {
        /// <summary>
        /// Gets currently available input cultures.
        /// </summary>
        IEnumerable<CultureInfo> AvailableInputCultures { get; }

        Task SetCurrentInputCultureAsync(CultureInfo culture);
        CultureInfo GetCurrentInputCulture(IEnumerable<CultureInfo> cultures, string? twoLetterISOLanguageName);
    }
}
