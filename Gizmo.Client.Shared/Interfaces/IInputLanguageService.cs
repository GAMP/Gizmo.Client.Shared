using System.Globalization;

namespace Gizmo.Client
{
    /// <summary>
    /// Input language service.
    /// </summary>
    /// <remarks>
    /// Provides functionality to list and select sytem wide input language.
    /// </remarks>
    public interface IInputLanguageService
    {
        /// <summary>
        /// Gets currently available input languages.
        /// </summary>
        IEnumerable<CultureInfo> AvailableInputLanguages { get; }

        /// <summary>
        /// Gets the current input language.
        /// </summary>
        CultureInfo CurrentInputLanguage { get; }

        Task SetCurrentLanguageAsync(CultureInfo inputLanguage);
    }
}
