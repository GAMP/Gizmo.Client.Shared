namespace Microsoft.GroupPolicy
{
    public class OldWindowsSystemPolicyAttribute : PolicyAttribute
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public OldWindowsSystemPolicyAttribute(string description, string valueName = "", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\System", description, valueName)
        {
            Category = GroupPolicyGroup.System;
            TargetOperatingSystem = targetOperatingSystem;
        }

        public override object GetValueForAttribute(bool enable)
        {
            var returnValue = base.GetValueForAttribute(enable);
            if (!string.IsNullOrWhiteSpace(ValueName))
            {
                switch (ValueName)
                {
                    case "DisableCMD":
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
