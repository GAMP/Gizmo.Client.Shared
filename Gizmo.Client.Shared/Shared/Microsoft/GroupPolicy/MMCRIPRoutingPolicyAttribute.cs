namespace Microsoft.GroupPolicy
{
    public class MMCRIPRoutingPolicyAttribute : PolicyAttribute
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCRIPRoutingPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{C2FE4504-D6C2-11D0-A37B-00C04FC9DA04}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
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
