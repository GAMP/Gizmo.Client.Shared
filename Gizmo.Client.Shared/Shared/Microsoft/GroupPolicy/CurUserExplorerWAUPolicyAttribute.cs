namespace Microsoft.GroupPolicy
{
    public class CurUserExplorerWAUPolicyAttribute : PolicyAttribute
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        public CurUserExplorerWAUPolicyAttribute(string description, string valueName = "", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer\WAU", description, valueName)
        {
            Category = GroupPolicyGroup.Explorer;
            TargetOperatingSystem = targetOperatingSystem;
        }

        public override object GetValueForAttribute(bool enable)
        {
            return enable ? 1 : PolicyValueDeleteResult.Instance;
        }
    }
}
