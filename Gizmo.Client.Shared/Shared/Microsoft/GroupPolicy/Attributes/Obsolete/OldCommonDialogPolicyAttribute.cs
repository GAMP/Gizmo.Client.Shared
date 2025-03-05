namespace Microsoft.GroupPolicy
{
    public class OldCommonDialogPolicyAttribute : PolicyAttribute
    {     
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public OldCommonDialogPolicyAttribute(string description, string valueName = "", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Comdlg32", description, valueName)
        {
            Category = GroupPolicyGroup.Comdlg32;
            TargetOperatingSystem = targetOperatingSystem;
        }
    }
}
