namespace Microsoft.GroupPolicy
{
    public class OldChromePolicyAttribute : PolicyAttribute
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public OldChromePolicyAttribute(string description, string valueName = "", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\NonEnum", description, valueName)
        {
            Category = GroupPolicyGroup.NonEnum;
            TargetOperatingSystem = targetOperatingSystem;
        }

        public override object GetValueForAttribute(bool enable)
        {
            return enable ? 3 : PolicyValueDeleteResult.Instance;
        }
    }
}
