namespace Microsoft.GroupPolicy
{
    public class WindowsSidebarPolicyAttribute : PolicyAttribute
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsSidebarPolicyAttribute(string description, string valueName = "", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Windows\Sidebar", description, valueName)
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
