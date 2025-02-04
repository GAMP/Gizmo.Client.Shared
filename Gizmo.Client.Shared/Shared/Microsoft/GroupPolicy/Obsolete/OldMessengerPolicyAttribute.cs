namespace Microsoft.GroupPolicy
{
    public class OldMessengerPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public OldMessengerPolicyAttribute(string description, string valueName = "", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\Messenger\Client", description, valueName)
        {
            Category = GroupPolicyGroup.MSN_Messenger;
            TargetOperatingSystem = targetOperatingSystem;
        }
        #endregion
    }
}
