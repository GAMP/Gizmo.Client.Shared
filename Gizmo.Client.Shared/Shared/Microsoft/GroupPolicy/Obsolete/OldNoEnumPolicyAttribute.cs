namespace Microsoft.GroupPolicy
{
    public class OldNoEnumPolicyAttribute : PolicyAttribute
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public OldNoEnumPolicyAttribute(string description, string valueName = "", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\NonEnum", description, valueName)
        {
            Category = GroupPolicyGroup.NonEnum;
            TargetOperatingSystem = targetOperatingSystem;
        }
    }
}
