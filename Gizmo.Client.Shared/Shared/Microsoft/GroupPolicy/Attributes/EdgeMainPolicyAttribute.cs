namespace Microsoft.GroupPolicy
{
    public class EdgeMainPolicyAttribute : PolicyAttribute
    {

        public EdgeMainPolicyAttribute(string description, string valueName = "", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\MicrosoftEdge\Main", description, valueName)
        {
            Category = GroupPolicyGroup.Edge;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
        }
        public override object GetValueForAttribute(bool enable)
        {
            return enable ? "no" : PolicyValueDeleteResult.Instance;
        }
    }   
}
