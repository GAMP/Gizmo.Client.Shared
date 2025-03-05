namespace Microsoft.GroupPolicy
{
    public class WindowsPolicyAttribute : PolicyAttribute
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsPolicyAttribute(string description, string valueName = "", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Windows", description, valueName)
        {
            Category = GroupPolicyGroup.Windows;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
        }

        public override object GetValueForAttribute(bool enable)
        {
            return enable ? 1 : PolicyValueDeleteResult.Instance;
        }
    }
}
