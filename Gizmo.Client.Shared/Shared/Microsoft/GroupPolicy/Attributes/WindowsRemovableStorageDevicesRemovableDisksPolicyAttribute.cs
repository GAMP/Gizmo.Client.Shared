namespace Microsoft.GroupPolicy
{
    public class WindowsRemovableStorageDevicesRemovableDisksPolicyAttribute : PolicyAttribute
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsRemovableStorageDevicesRemovableDisksPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\RemovableStorageDevices\{53f5630d-b6bf-11d0-94f2-00a0c91efb8b}", description, valueName)
        {
            Category = GroupPolicyGroup.RemovableStorageDevices;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }

        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }

        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
    }
}
