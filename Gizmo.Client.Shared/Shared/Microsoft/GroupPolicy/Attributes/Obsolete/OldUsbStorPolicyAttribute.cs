namespace Microsoft.GroupPolicy
{
    public class OldUsbStorPolicyAttribute : PolicyAttribute
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public OldUsbStorPolicyAttribute(string description, string valueName = "", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"System\CurrentControlSet\Services\UsbStor", description, valueName)
        {
            Hive = Win32.RegistryHive.LocalMachine;
            Category = GroupPolicyGroup.Hardware;
            TargetOperatingSystem = targetOperatingSystem;
        }
 
        /// <summary>
        /// Gets value for the attribute.
        /// </summary>
        /// <param name="enable">Enable parameter.</param>
        /// <returns>Value.</returns>
        public override object GetValueForAttribute(bool enable)
        {
            return enable ? 4 : 3;
        }
    }
}
