namespace Microsoft.GroupPolicy
{
    public class OldInternetExplorerPolicyAttribute : PolicyAttribute
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public OldInternetExplorerPolicyAttribute(string description, string valueName = "", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\Internet Explorer\Restrictions", description, valueName)
        {
            Category = GroupPolicyGroup.MSN_Messenger;
            TargetOperatingSystem = targetOperatingSystem;
        }
    }
}
