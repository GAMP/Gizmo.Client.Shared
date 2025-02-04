namespace Microsoft.GroupPolicy
{
    public class OldSystemPolicyAttribute : PolicyAttribute
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public OldSystemPolicyAttribute(string description, string valueName = "", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", description, valueName)
        {
            Category = GroupPolicyGroup.System;
            TargetOperatingSystem = targetOperatingSystem;
        }

        public OldSystemPolicyAttribute(string description, Win32.RegistryHive hive, string valueName = "", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", description, valueName)
        {
            Category = GroupPolicyGroup.System;
            Hive = hive;
            TargetOperatingSystem = targetOperatingSystem;
        }
    }
}
