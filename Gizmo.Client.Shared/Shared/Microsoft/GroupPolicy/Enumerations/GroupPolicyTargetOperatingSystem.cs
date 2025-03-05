using System.ComponentModel.DataAnnotations;

namespace Microsoft.GroupPolicy
{
    /// <summary>
    /// Identifies group policy target operating system.
    /// </summary>
    public enum GroupPolicyTargetOperatingSystem
    {
        /// <summary>
        /// Windows 10.
        /// </summary>
        [Name("Windows 10")]
        [ExtendedDescription("Windows 10")]
        Windows10 = 1,

        /// <summary>
        /// Windows 2.
        /// </summary>
        [Name("Windows 11")]
        [ExtendedDescription("Windows 11")]
        Windows11 = 2,

        /// <summary>
        /// Windows 10 and 11.
        /// </summary>
        [Name("Windows 10 & Windows 11")]
        [ExtendedDescription("Windows 10 & Windows 11")]
        Windows10and11 = 3,
    }
}
