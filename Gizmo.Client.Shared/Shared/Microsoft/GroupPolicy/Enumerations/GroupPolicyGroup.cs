using System.ComponentModel.DataAnnotations;

namespace Microsoft.GroupPolicy
{
    /// <summary>
    /// Group policy group.
    /// </summary>
    public enum GroupPolicyGroup
    {
        [Name("Msn Messenger", "Group_Policy_Group_Msn_Messenger")]
        MSN_Messenger = 1,
        [Name("Internet explorer toolbars", "Group_Policy_Group_Internet_Explorer_Toolbars")]
        InternetExplorerToolbars = 2,
        [Name("Internet explorer", "Group_Policy_Group_Internet_Explorer")]
        InternetExplorer = 3,
        [Name("Hardware", "Group_Policy_Group_Hardware")]
        Hardware = 4,
        [Name("Uninstall", "Group_Policy_Group_Uninstall")]
        Uninstall = 5,
        [Name("Edge", "Group_Policy_Group_Edge")]
        Edge = 6,
        [Name("One Drive", "Group_Policy_Group_One_Drive")]
        OneDrive = 7,
        [Name("Windows Explorer", "Group_Policy_Group_Windows_Explorer")]
        Explorer = 8,
        [Name("System", "Group_Policy_Group_System")]
        System = 9,
        [Name("Windows", "Group_Policy_Group_Windows")]
        Windows = 10,
        [Name("Chrome", "Group_Policy_Group_Chrome")]
        Chrome = 11,
        [Name("Miscellaneous", "Group_Policy_Group_Miscellaneous")]
        Miscellaneous = 12,
        [Name("Windows defender", "Group_Policy_Group_Windows_Defender")]
        WindowsDefender = 13,
        [Name("Removable storage", "Group_Policy_Group_Removable_Storage")]
        RemovableStorageDevices = 14,
        [Name("Windows update", "Group_Policy_Group_Windows_Update")]
        WindowsUpdate = 15,
        [Name("Windows firewall", "Group_Policy_Group_Windows_Firewall")]
        WindowsFirewall = 16,
        [Name("Windows store", "Group_Policy_Group_Windows_Store")]
        WindowsStore = 17,
        [Name("Active desktop", "Group_Policy_Group_Active_Desktop")]
        ActiveDesktop = 18,
        [Name("Attachments", "Group_Policy_Group_Attachments")]
        Attachments = 19,
        [Name("Common dialog", "Group_Policy_Group_Common_Dialog")]
        Comdlg32 = 20,
        [Name("Network", "Group_Policy_Group_Network")]
        Network = 21,
        [Name("No enum", "Group_Policy_Group_No_Enum")]
        NonEnum = 22,
        [Name("MMC", "Group_Policy_Group_MMC")]
        MMC = 23,
        [Name("Power shell", "Group_Policy_Group_Power_Shell")]
        PowerShell = 24,
        [Name("Task scheduler", "Group_Policy_Group_Task_Scheduler")]
        TaskScheduler = 25,
        [Name("Windows error reporting", "Group_Policy_Group_Windows_Error_Reporting")]
        WindowsErrorReporting = 26,
        [Name("Windows media player", "Group_Policy_Group_Windows_Media_Player")]
        WindowsMediaPlayer = 27,
    }
}
