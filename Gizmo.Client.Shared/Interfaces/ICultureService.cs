#nullable enable

using System.Globalization;

namespace Gizmo.Client.Interfaces
{
    /// <summary>
    /// Culture service.
    /// </summary>
    /// <remarks>
    /// Responsible of setting culture based on platform.
    /// </remarks>
    public interface ICultureService
    {
        /// <summary>
        /// Sets current UI culture.
        /// </summary>
        /// <param name="culture">Culture.</param>
        Task SetCurrentUICultureAsync(CultureInfo culture);
    }
}
