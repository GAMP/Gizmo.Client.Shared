namespace Microsoft.GroupPolicy
{
    public class EventViewerPolicyAttribute : PolicyAttribute
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public EventViewerPolicyAttribute(string description, string valueName, string enableValue = "", string disabledValue = "PolicyValueDeleteResult", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\policies\microsoft\eventviewer", description, valueName)
        {
            Category = GroupPolicyGroup.Miscellaneous;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledStringValue = enableValue;
            DefaultStringValue = disabledValue;
        }

        public string EnabledStringValue { get; protected set; }
        public string DefaultStringValue { get; protected set; }

        public override object GetValueForAttribute(bool enable)
        {

            if (DefaultStringValue != "PolicyValueDeleteResult")
            {
                return enable ? EnabledStringValue : DefaultStringValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }

        }
    }
}
