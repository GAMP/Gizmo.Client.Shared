namespace Microsoft.GroupPolicy
{
    /// <summary>
    /// Group policy group.
    /// </summary>
    public enum GroupPolicyGroup
    {
        MSN_Messenger = 1,
        InternetExplorerToolbars = 2,
        InternetExplorer = 3,
        Hardware = 4,
        Uninstall = 5,
        Edge = 6,
        OneDrive = 7,
        Explorer = 8,
        System = 9,
        Windows = 10,
        Chrome = 11,
        Miscellaneous = 12,
        WindowsDefender = 13,
        RemovableStorageDevices = 14,
        WindowsUpdate = 15,
        WindowsFirewall = 16,
        WindowsStore = 17,
        ActiveDesktop = 18,
        Attachments = 19,
        Comdlg32 = 20,
        Network = 21,
        NonEnum = 22,
        MMC = 23,
        PowerShell = 24,
        TaskScheduler = 25,
        WindowsErrorReporting = 26,
        WindowsMediaPlayer = 27,
    }

    public enum GroupPolicyTargetOperatingSystem
    {
        /// <summary>
        /// Windows 10.
        /// </summary>
        Windows10 = 1,

        /// <summary>
        /// Windows 2.
        /// </summary>
        Windows11 = 2,

        /// <summary>
        /// Windows 10 and 11.
        /// </summary>
        Windows10and11 = 3,
    }
}
