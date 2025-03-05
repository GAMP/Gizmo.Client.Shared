namespace Microsoft.GroupPolicy
{
    public class CurUserExplorerPolicyAttribute : PolicyAttribute
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public CurUserExplorerPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer", description, valueName)
        {
            Category = GroupPolicyGroup.Explorer;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledIntValue = enableValue;
            DefaultIntValue = disabledValue;
            ValueIsString = false;
        }
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. Empty or "PolicyValueDeleteResult" if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public CurUserExplorerPolicyAttribute(string description, string valueName, string enableValue, string disabledValue = "PolicyValueDeleteResult", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer", description, valueName)
        {
            Category = GroupPolicyGroup.Explorer;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledStringValue = enableValue;
            DefaultStringValue = disabledValue;
            ValueIsString = true;
        }

        public bool ValueIsString { get; protected set; }
        public string EnabledStringValue { get; protected set; } = string.Empty;
        public string DefaultStringValue { get; protected set; } = string.Empty;
        public int DefaultIntValue { get; protected set; }
        public int EnabledIntValue { get; protected set; }

        public override object GetValueForAttribute(bool enable)
        {
            if (ValueIsString)
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
            else
            {
                if (DefaultIntValue != -1)
                {
                    return enable ? EnabledIntValue : DefaultIntValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
        }
    }
}
