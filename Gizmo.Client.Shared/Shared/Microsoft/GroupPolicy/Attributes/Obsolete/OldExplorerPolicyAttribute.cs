namespace Microsoft.GroupPolicy
{
    public class OldExplorerPolicyAttribute : PolicyAttribute
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public OldExplorerPolicyAttribute(string description, string valueName = "", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer", description, valueName)
        {
            Category = GroupPolicyGroup.Explorer;
            TargetOperatingSystem = targetOperatingSystem;
        }

        public override object GetValueForAttribute(bool enable)
        {
            var returnValue = base.GetValueForAttribute(enable);
            if (!string.IsNullOrWhiteSpace(ValueName))
            {
                switch (ValueName)
                {
                    case "NoDriveAutoRun":
                        returnValue = (int)returnValue * (int)Math.Pow(2, 26);
                        break;
                    case "Btn_Folders":
                        returnValue = (int)returnValue * 2;
                        break;
                    default:
                        break;
                }
            }
            return returnValue;
        }
    }
}
