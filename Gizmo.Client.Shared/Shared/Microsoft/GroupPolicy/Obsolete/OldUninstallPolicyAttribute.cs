namespace Microsoft.GroupPolicy
{
    public class OldUninstallPolicyAttribute : PolicyAttribute
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public OldUninstallPolicyAttribute(string description, string valueName = "", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Uninstall", description, valueName)
        {
            Category = GroupPolicyGroup.Uninstall;
            TargetOperatingSystem = targetOperatingSystem;
        }
    }
}
