using System.ComponentModel.DataAnnotations;

namespace Microsoft.GroupPolicy
{
    /// <summary>
    /// Group policy types.
    /// </summary>
    public enum SecurityPolicyType
    {
        #region Old_policy

        #region MESSENGER

        /// <summary>
        /// Disable Collaboration Applications.
        /// </summary>
        [Obsolete()]
        [Name("Disable Collaboration Applications", "")]
        [OldMessengerPolicy("Disable Collaboration Applications")]
        DisableCollaborationApps = 1,

        /// <summary>
        /// Disable File Transfer.
        /// </summary>
        [Obsolete()]
        [Name("Disable File Transfer", "")]
        [OldMessengerPolicy("Disable File Transfer")]
        DisableFileTransfer = 2,

        /// <summary>
        /// Disable PC2PCAudio.
        /// </summary>
        [Obsolete()]
        [Name("Disable PC2PCAudio", "")]
        [OldMessengerPolicy("Disable PC2PCAudio")]
        DisablePC2PCAudio = 3,

        /// <summary>
        /// Disable PC2Phone.
        /// </summary>
        [Obsolete()]
        [Name("Disable PC2Phone", "")]
        [OldMessengerPolicy("Disable PC2Phone")]
        DisablePC2Phone = 4,

        /// <summary>
        /// Disable Video.
        /// </summary>
        [Obsolete()]
        [Name("Disable Video", "")]
        [OldMessengerPolicy("Disable Video")]
        DisableVideo = 5,

        /// <summary>
        /// Prevent Auto Update.
        /// </summary>
        [Obsolete()]
        [Name("Prevent Auto Update", "")]
        [OldMessengerPolicy("Prevent Auto Update")]
        PreventAutoUpdate = 6,

        /// <summary>
        /// Prevent Background Download.
        /// </summary>
        [Obsolete()]
        [Name("Prevent Background Download", "")]
        [OldMessengerPolicy("Prevent Background Download")]
        PreventBackgroundDownload = 7,

        /// <summary>
        /// Prevent Consumer Version.
        /// </summary>
        [Obsolete()]
        [Name("Prevent Consumer Version", "")]
        [OldMessengerPolicy("Prevent Consumer Version")]
        PreventConsumerVersion = 8,

        #endregion

        #region INTERNET EXPLORER TOOLBARS

        /// <summary>
        /// Disable the ability to change toolbar selection.
        /// </summary>
        [Obsolete()]
        [Name("Disable the ability to change toolbar selection", "")]
        [OldInternetExplorerToolbarsPolicy("Disable the ability to change toolbar selection")]
        NoToolbarOptions = 9,

        /// <summary>
        /// Disable the address bar.
        /// </summary>
        [Obsolete()]
        [Name("Disable the address bar", "")]
        [OldInternetExplorerToolbarsPolicy("Disable the address bar")]
        NoAddressBar = 10,

        /// <summary>
        /// Disable the tool bar.
        /// </summary>
        [Obsolete()]
        [Name("Disable the tool bar", "")]
        [OldInternetExplorerToolbarsPolicy("Disable the tool bar")]
        NoToolBar = 11,

        /// <summary>
        /// Disable the links bar.
        /// </summary>
        [Obsolete()]
        [Name("Disable the links bar", "")]
        [OldInternetExplorerToolbarsPolicy("Disable the links bar")]
        NoLinksBar = 12,

        #endregion

        #region INTERNET EXPLORER SECURITY

        /// <summary>
        /// Always prompt user when downloading files.
        /// </summary>
        [Obsolete()]
        [Name("Always prompt user when downloading files", "")]
        [OldInternetExplorerPolicy("Always prompt user when downloading files")]
        AlwaysPromptWhenDownload = 13,

        /// <summary>
        /// Disable changes to browsers bars.
        /// </summary>
        [Obsolete()]
        [Name("Disable changes to browsers bars", "")]
        [OldInternetExplorerPolicy("Disable changes to browsers bars")]
        NoBrowserBars = 14,

        /// <summary>
        /// Disable the option of closing Internet Explorer.
        /// </summary>
        [Obsolete()]
        [Name("Disable the option of closing Internet Explorer", "")]
        [OldInternetExplorerPolicy("Disable the option of closing Internet Explorer")]
        NoBrowserClose = 15,

        /// <summary>
        /// Disable right-click context menu.
        /// </summary>
        [Obsolete()]
        [Name("Disable right-click context menu", "")]
        [OldInternetExplorerPolicy("Disable right-click context menu")]
        NoBrowserContextMenu = 16,

        /// <summary>
        /// Disable the Tools > Internet Options menu.
        /// </summary>
        [Obsolete()]
        [Name("Disable the Tools > Internet Options menu", "")]
        [OldInternetExplorerPolicy("Disable the Tools > Internet Options menu")]
        NoBrowserOptions = 17,

        /// <summary>
        /// Disable the ability to Save As.
        /// </summary>
        [Obsolete()]
        [Name("Disable the ability to Save As", "")]
        [OldInternetExplorerPolicy("Disable the ability to Save As")]
        NoBrowserSaveAs = 18,

        /// <summary>
        /// Disable the Favorites.
        /// </summary>
        [Obsolete()]
        [Name("Disable the Favorites", "")]
        [OldInternetExplorerPolicy("Disable the Favorites")]
        NoFavorites = 19,

        /// <summary>
        /// Disable the File > New command.
        /// </summary>
        [Obsolete()]
        [Name("Disable the File > New command", "")]
        [OldInternetExplorerPolicy("Disable the File > New command")]
        NoFileNew = 20,

        /// <summary>
        /// Disable the File > Open command.
        /// </summary>
        [Obsolete()]
        [Name("Disable the File > Open command", "")]
        [OldInternetExplorerPolicy("Disable the File > Open command")]
        NoFileOpen = 21,

        /// <summary>
        /// Disable the Find Files command.
        /// </summary>
        [Obsolete()]
        [Name("Disable the Find Files command", "")]
        [OldInternetExplorerPolicy("Disable the Find Files command")]
        NoFindFiles = 22,

        /// <summary>
        /// Disables the Forward and Back navigation buttons.
        /// </summary>
        [Obsolete()]
        [Name("Disables the Forward and Back navigation buttons", "")]
        [OldInternetExplorerPolicy("Disables the Forward and Back navigation buttons")]
        NoNavButtons = 23,

        /// <summary>
        /// Disable Open in New Window option.
        /// </summary>
        [Obsolete()]
        [Name("Disable Open in New Window option", "")]
        [OldInternetExplorerPolicy("Disable Open in New Window option")]
        NoOpeninNewWnd = 24,

        /// <summary>
        /// Remove Print and Print Preview from the File menu.
        /// </summary>
        [Obsolete()]
        [Name("Remove Print and Print Preview from the File menu", "")]
        [OldInternetExplorerPolicy("Remove Print and Print Preview from the File menu")]
        NoPrinting = 25,

        /// <summary>
        /// Disable the option of selecting a download directory.
        /// </summary>
        [Obsolete()]
        [Name("Disable the option of selecting a download directory", "")]
        [OldInternetExplorerPolicy("Disable the option of selecting a download directory")]
        NoSelectDownloadDir = 26,

        /// <summary>
        /// Disable the Full Screen view option.
        /// </summary>
        [Obsolete()]
        [Name("Disable the Full Screen view option", "")]
        [OldInternetExplorerPolicy("Disable the Full Screen view option")]
        NoTheaterMode = 27,

        /// <summary>
        /// Disable the ability to view the page source HTML.
        /// </summary>
        [Obsolete()]
        [Name("Disable the ability to view the page source HTML", "")]
        [OldInternetExplorerPolicy("Disable the ability to view the page source HTML")]
        NoViewSource = 28,

        /// <summary>
        /// Remove Mail and News menu item.
        /// </summary>
        [Obsolete()]
        [Name("Remove Mail and News menu item", "")]
        [OldInternetExplorerPolicy("Remove Mail and News menu item")]
        RestGoMenu = 29,

        #endregion

        #region EXPLORER

        /// <summary>
        /// Remove folders button.
        /// </summary>
        [Obsolete()]
        [Name("Remove folders button", "")]
        [OldExplorerPolicy("Remove folders button", "Btn_Folders")]
        Btn_Folders = 30,

        /// <summary>
        /// Remove the Option to Change or Hide Toolbars
        /// </summary>
        [Name("Remove the Option to Change or Hide Toolbars", " InternetExplorer_NoBandCustomize")]
        [OldExplorerPolicy("Remove the Option to Change or Hide Toolbars")]
        NoBandCustomize = 31,

        /// <summary>
        /// Disable Shut Down.
        /// </summary>
        [Name("Remove and prevent access to the Shut Down, Restart, Sleep, and Hibernate commands", "StartMenu_NoShutdown_Restart_or_Sleep")]
        [OldExplorerPolicy("Disable Shut Down , Restart or Sleep")]
        NoClose = 32,

        /// <summary>
        /// Disable Desktop.
        /// </summary>
        [Name("Hide and disable all items on the desktop", "Explorer_NoDesktop")]
        [OldExplorerPolicy("Disable Desktop")]
        NoDesktop = 33,

        /// <summary>
        /// Disable Removable Media autorun.
        /// </summary>
        [Name("Disable Removable Media autorun", "Explorer_DriveAutorun")]
        [OldExplorerPolicy("Disable Removable Media autorun", "NoDriveAutoRun")]
        NoDriveAutoRun = 34,

        /// <summary>
        /// Hide Drives in My Computer.
        /// </summary>
        [Name("Hide Drives in My Computer", "Explorer_HideDrivesInMyComputer")]
        [OldExplorerPolicy("Hide Drives in My Computer")]
        NoDrives = 35,

        /// <summary>
        /// Disable File Menu.
        /// </summary>
        [Name("Remove File menu from File Explorer", "Explorer_RemoveFileMenu")]
        [OldExplorerPolicy("Disable File Menu")]
        NoFileMenu = 36,

        /// <summary>
        /// Disable File to Url.
        /// </summary>
        [Obsolete()]
        [Name("Disable File to Url", "InternetExplorer_NoFileUrl")]
        [OldExplorerPolicy("Disable File to Url")]
        NoFileUrl = 37,

        /// <summary>
        /// Disable search features.
        /// </summary>
        [Obsolete()]
        [Name("Remove Search link from Start Menu", "StartMenu_NoFind")]
        [OldExplorerPolicy("Disable search features")]
        NoFind = 38,

        /// <summary>
        /// Disable Folder Options Menu.
        /// </summary>
        [Name("Disable Folder Options Menu", "Explorer_DisableFolderOptionsMenu")]
        [OldExplorerPolicy("Disable Folder Options Menu")]
        NoFolderOptions = 39,

        /// <summary>
        /// Remove the Map and Disconnect Network Drive Options.
        /// </summary>
        [Name("Remove the Map and Disconnect Network Drive Options", "Exolorer_RemovetheMapandDisconnectNetworkDriveOptions")]
        [OldExplorerPolicy("Remove the Map and Disconnect Network Drive Options")]
        NoNetConnectDisconnect = 40,

        /// <summary>
        /// Disable Network Neighborhood.
        /// </summary>
        [Name("Disable Network Neighborhood", "Explorer_DisableNetworkNeighborhood")]
        [OldExplorerPolicy("Disable Network Neighborhood")]
        NoNetHood = 41,

        /// <summary>
        /// Disable Run.
        /// </summary>
        [Name("Remove Run menu from Start Menu", "StartMenu_DisableRun")]
        [OldExplorerPolicy("Disable Run")]
        NoRun = 42,

        /// <summary>
        /// Disable saving settings on exit.
        /// </summary>
        [Name("Disable saving settings on exit", "Explorer_DisableSavingSettingsOnExit")]
        [OldExplorerPolicy("Disable saving settings on exit")]
        NoSaveSettings = 43,

        /// <summary>
        /// Disable the Ability to Customize Toolbars.
        /// </summary>
        [Obsolete()]
        [Name("Internet Explorer", "InternetExplorer_NoToolbarCustomize")]
        [OldExplorerPolicy("Disable the Ability to Customize Toolbars")]
        NoToolbarCustomize = 44,

        /// <summary>
        /// Remove shortcut menus from the desktop and from Windows Explorer.
        /// </summary>
        [Name("Remove shortcut menus from the desktop and from Windows Explorer", "Exolorer_RemoveShortcutMenusFromTheDesktopAndFromWindowsExplorer")]
        [OldExplorerPolicy("Remove shortcut menus from the desktop and from Windows Explorer")]
        NoViewContextMenu = 45,

        /// <summary>
        /// Disable Log Off.
        /// </summary>
        [Name("Disables or removes all menu items and buttons that log the user off the system.", "StartMenu_RemoveLogoff")]
        [OldExplorerPolicy("Disable Log Off", "NoLogOff")]
        DisableLogOff = 60,

        /// <summary>
        /// Disable tray contextual menu.
        /// </summary>
        [Name("Disable tray contextual menu", "Explorer_DisableTrayContextualMenu")]
        [OldExplorerPolicy("Disable tray contextual menu", "NoTrayContextMenu")]
        NoTrayContextMenu = 62,

        /// <summary>
        /// Disable control panel (disables both old and new control panels).
        /// </summary>
        [Name("Prohibit access to Control Panel and PC settings", "Explorer_DisableControlPanel")]
        [OldExplorerPolicy("Disable control panel (disables both old and new control panels)", "NoControlPanel")]
        NoExplorerControlPanel = 63,

        /// <summary>
        /// Remove logoff/sign out option from start menu.
        /// </summary>
        [Name("Remove Logoff on the Start Menu", "Explorer_RemoveLogoffOnTheStartMenu")]
        [OldExplorerPolicy("Remove logoff/sign out option from start menu")]
        StartMenuLogOff = 64,

        #endregion

        #region SYSTEM

        /// <summary>
        /// Disable the Change Password Button.
        /// </summary>
        [Name("Remove Change Password", "System_RemoveChangePassword")]
        [OldSystemPolicy("Disable the Change Password Button")]
        DisableChangePassword = 47,

        /// <summary>
        /// Disable the Command Prompt.
        /// </summary>
        [Name("Disable the Command Prompt", "System_DisableCMD")]
        [OldWindowsSystemPolicy("Disable the Command Prompt", "DisableCMD")]
        DisableCMD = 48,

        /// <summary>
        /// Disable Workstation Lock.
        /// </summary>
        [Name("Disable Workstation Lock", "System_DisableWorkstationLock")]
        [OldSystemPolicy("Disable Workstation Lock")]
        DisableLockWorkstation = 49,

        /// <summary>
        /// Disable Registry Tools.
        /// </summary>
        [Name("DisableRegistryTools", "System_DisableRegistryTools")]
        [OldSystemPolicy("Disable Registry Tools")]
        DisableRegistryTools = 50,

        /// <summary>
        /// Disable Task Manager.
        /// </summary>
        [Name("Disable Task Manager", "System_DisableTaskManager")]
        [OldSystemPolicy("Disable Task Manager")]
        DisableTaskMgr = 59,

        /// <summary>
        /// Hide Fast User Switching.
        /// </summary>
        [Name("HideFastUserSwitching", "System_HideFastUserSwitching")]
        [OldSystemPolicy("Hide Fast User Switching", Win32.RegistryHive.LocalMachine)]
        HideFastUserSwitching = 61,

        #endregion

        #region NETWORK

        /// <summary>
        /// Hide Entire Network in Network Neighborhood.
        /// </summary>
        [Obsolete()]
        [Name("Hide Entire Network in Network Neighborhood", "Network_HideEntireNetworkInNetworkNeighborhood")]
        [OldNetworkPolicy("Hide Entire Network in Network Neighborhood")]
        NoEntireNetwork = 51,

        #endregion

        #region COMMON DIALOG

        /// <summary>
        /// Remove back button.
        /// </summary>
        [Name("Hide the common dialog back button", "CommonDialog_HideTheCommonDialogBackButton")]
        [OldCommonDialogPolicy("Remove back button")]
        NoBackButton = 52,

        /// <summary>
        /// Hide most recently used files.
        /// </summary>
        [Name("Hide the dropdown list of recent files", "CommonDialog_HideTheDropdownListOfRecentFiles")]
        [OldCommonDialogPolicy("Hide most recently used files")]
        NoFileMRU = 53,

        /// <summary>
        /// Hide places bar.
        /// </summary>
        [Name("Hide the common dialog places bar", "CommonDialog_HideTheCommonDialogPlacesBar")]
        [OldCommonDialogPolicy("Hide places bar")]
        NoPlacesBar = 54,

        #endregion

        #region NOENUM

        /// <summary>
        /// Hide My Computer.
        /// </summary>
        [Name("Remove Computer icon on the desktop", "NOENUM_RemoveComputerIconOnTheDesktop")]
        [NonEnumPolicyAttribute("Hide My Computer", "{20D04FE0-3AEA-1069-A2D8-08002B30309D}")]
        NoMyComputer = 55,

        /// <summary>
        /// Hide Network Places. Hide by GUI?
        /// </summary>
        [Name("Hide Network Places", "NOENUM_HideNetworkPlaces")]
        [NonEnumPolicyAttribute("Hide Network Places", "{20D04FE0-3AEA-1069-A2D7-08002B30309D}")]
        NoNetworkPlaces = 56,

        /// <summary>
        /// Hide Control Panel. Hide by GUI?
        /// </summary>
        [Name("Hide Control Panel", "NOENUM_HideControlPanel")]
        [NonEnumPolicyAttribute("Hide Control Panel", "{21EC2020-3AEA-1069-A2DD-08002B30309D}")]
        NoControlPanel = 57,

        #endregion

        #region USBSTOR

        /// <summary>
        /// Disable USB Mass Storage.
        /// </summary>
        [Name("Disable USB Mass Storage", "Explorer_DisableUSBMassStorage")]
        [OldUsbStorPolicy("Disable USB Mass Storage", "Start")]
        UsbStorage = 58,

        #endregion

        #region UNINSTALL

        /// <summary>
        /// Disable Add/Remove Programs (Windows XP Only).
        /// </summary>
        [Obsolete()]
        [Name("Disable Add/Remove Programs (Windows XP Only)", "DisableAdd/RemovePrograms")]
        [OldUninstallPolicy("Disable Add/Remove Programs (Windows XP Only)")]
        NoAddRemovePrograms = 46,

        #endregion

        #region CHROME

        /// <summary>
        /// Disable Chrome downloads.
        /// </summary>
        [Name("Disable Chrome downloads", "Chrome_DisableDownloads")]
        [OldChromePolicy("Disable Chrome downloads", "DownloadRestrictions")]
        ChromeNoDownload = 65,

        #endregion

        #endregion

        #region LocalMachine

        #region Edge

        [Name("Edge Allow File Selection Dialogs", "Edge_AllowFileSelectionDialogs")]
        [EdgePolicy("Allow File Selection Dialogs", "AllowFileSelectionDialogs")]
        Edge_AllowFileSelectionDialogs = 66,

        [Name("Edge Allow Games Menu", "Edge_AllowGamesMenu")]
        [EdgePolicy("Allow Games Menu", "AllowGamesMenu")]
        Edge_AllowGamesMenu = 67,

        [Name("Edge Allow Surf Game", "Edge_AllowSurfGame")]
        [EdgePolicy("Allow Surf Game", "AllowSurfGame")]
        Edge_AllowSurfGame = 68,

        [Name("Edge Always Open Pdf Externally", "Edge_AlwaysOpenPdfExternally")]
        [EdgePolicy("Always Open Pdf Externally", "AlwaysOpenPdfExternally", 1)]
        Edge_AlwaysOpenPdfExternally = 69,

        [Name("Edge Application Guard Upload Blocking Enabled", "Edge_ApplicationGuardUploadBlockingEnabled")]
        [EdgePolicy("Application Guard Upload Blocking Enabled", "ApplicationGuardUploadBlockingEnabled", 1)]
        Edge_ApplicationGuardUploadBlockingEnabled = 70,

        [Name("Edge Autofill Credit Card Enabled", "Edge_AutofillCreditCardEnabled")]
        [EdgePolicy("Autofill Credit Card Enabled", "AutofillCreditCardEnabled")]
        Edge_AutofillCreditCardEnabled = 71,

        [Name("Edge Autofill Memberships Enabled", "Edge_AutofillMembershipsEnabled")]
        [EdgePolicy("Autofill Memberships Enabled", "AutofillMembershipsEnabled")]
        Edge_AutofillMembershipsEnabled = 72,

        [Name("Edge Block External Extensions", "Edge_BlockExternalExtensions")]
        [EdgePolicy("Block External Extensions", "BlockExternalExtensions", 1)]
        Edge_BlockExternalExtensions = 73,

        [Name("Edge Browser Add Profile Enabled", "Edge_BrowserAddProfileEnabled")]
        [EdgePolicy("Browser Add Profile Enabled", "BrowserAddProfileEnabled")]
        Edge_BrowserAddProfileEnabled = 74,

        [Name("Edge Browser Guest Mode Enabled", "Edge_BrowserGuestModeEnabled")]
        [EdgePolicy("Browser Guest Mode Enabled", "BrowserGuestModeEnabled", 1)]
        Edge_BrowserGuestModeEnabled = 75,

        [Name("Edge Clear Browsing Data On Exit", "Edge_ClearBrowsingDataOnExit")]
        [EdgePolicy("Clear Browsing Data On Exit", "ClearBrowsingDataOnExit", 1)]
        Edge_ClearBrowsingDataOnExit=76,

        [Name("Edge Clear Cached Images And Files On Exit", "Edge_ClearCachedImagesAndFilesOnExit")]
        [EdgePolicy("Clear Cached Images And Files On Exit", "ClearCachedImagesAndFilesOnExit", 1)]
        Edge_ClearCachedImagesAndFilesOnExit=77,

        [Name("Edge Click Once Enabled", "Edge_ClickOnceEnabled")]
        [EdgePolicy("Click Once Enabled", "ClickOnceEnabled")]
        Edge_ClickOnceEnabled=78,

        [Name("Edge Configure Share", "Edge_ConfigureShare")]
        [EdgePolicy("Configure Share", "ConfigureShare", 1)]
        Edge_ConfigureShare=79,

        [Name("EdgeCrypto Wallet Enabled", "Edge_CryptoWalletEnabled")]
        [EdgePolicy("Crypto Wallet Enabled", "CryptoWalletEnabled")]
        Edge_CryptoWalletEnabled = 80,

        [Name("Edge Default Automatic Downloads Setting", "Edge_DefaultAutomaticDownloadsSetting")]
        [EdgePolicy("Default Automatic Downloads Setting", "DefaultAutomaticDownloadsSetting")]
        Edge_DefaultAutomaticDownloadsSetting = 81,

        [Name("Edge Default Browser Setting Enabled", "Edge_DefaultBrowserSettingEnabled")]
        [EdgePolicy("Default Browser Setting Enabled", "DefaultBrowserSettingEnabled")]
        Edge_DefaultBrowserSettingEnabled = 82,

        [Name("Edge Default File System Read Guard Setting", "Edge_DefaultFileSystemReadGuardSetting")]
        [EdgePolicy("Default File System Read Guard Setting", "DefaultFileSystemReadGuardSetting")]
        Edge_DefaultFileSystemReadGuardSetting = 83,

        [Name("Edge Default File System Write Guard Setting", "Edge_DefaultFileSystemWriteGuardSetting")]
        [EdgePolicy("Default File System Write Guard Setting", "DefaultFileSystemWriteGuardSetting", 2)]
        Edge_DefaultFileSystemWriteGuardSetting = 84,

        [Name("Edge Default Search Provider Context Menu Access Allowed", "Edge_DefaultSearchProviderContextMenuAccessAllowed")]
        [EdgePolicy("Default Search Provider Context Menu Access Allowed", "DefaultSearchProviderContextMenuAccessAllowed")]
        Edge_DefaultSearchProviderContextMenuAccessAllowed = 85,

        [Name("Edge Default Search Provider Enabled", "Edge_DefaultSearchProviderEnabled")]
        [EdgePolicy("Default Search Provider Enabled", "DefaultSearchProviderEnabled", 1)]
        Edge_DefaultSearchProviderEnabled = 86,

        [Name("Edge Default Web Usb Guard Setting", "Edge_DefaultWebUsbGuardSetting")]
        [EdgePolicy("Default Web Usb Guard Setting", "DefaultWebUsbGuardSetting", 2)]
        Edge_DefaultWebUsbGuardSetting = 87,

        [Name("Edge Developer Tools Availability", "Edge_DeveloperToolsAvailability")]
        [EdgePolicy("Developer Tools Availability", "DeveloperToolsAvailability", 2)]
        Edge_DeveloperToolsAvailability = 88,

        [Name("Edge Direct Invoke Enabled", "Edge_DirectInvokeEnabled")]
        [EdgePolicy("Direct Invoke Enabled", "DirectInvokeEnabled")]
        Edge_DirectInvokeEnabled = 89,

        [Name("Edge Disable Screenshots", "Edge_DisableScreenshots")]
        [EdgePolicy("Disable Screenshots", "DisableScreenshots")]
        Edge_DisableScreenshots = 90,

        [Name("Edge Download Restrictions", "Edge_DownloadRestrictions")]
        [EdgePolicy("Download Restrictions", "DownloadRestrictions", 3)]
        Edge_DownloadRestrictions = 91,

        [Name("Edge Collections Enabled", "Edge_EdgeCollectionsEnabled")]
        [EdgePolicy("Edge Collections Enabled", "EdgeCollectionsEnabled")]
        Edge_EdgeCollectionsEnabled = 92,

        [Name("Edge EDrop Enabled", "Edge_EdgeEDropEnabled")]
        [EdgePolicy("Edge EDrop Enabled", "EdgeEDropEnabled")]
        Edge_EdgeEDropEnabled = 93,

        [Name("Edge Follow Enabled", "Edge_EdgeFollowEnabled")]
        [EdgePolicy("Edge Follow Enabled", "EdgeFollowEnabled")]
        Edge_EdgeFollowEnabled = 94,

        [Name("Edge Wallet CheckoutEnabled", "Edge_EdgeWalletCheckoutEnabled")]
        [EdgePolicy("Edge Wallet CheckoutEnabled", "EdgeWalletCheckoutEnabled")]
        Edge_EdgeWalletCheckoutEnabled = 95,

        [Name("Edge Wallet Etree Enabled", "Edge_EdgeWalletEtreeEnabled")]
        [EdgePolicy("Edge Wallet Etree Enabled", "EdgeWalletEtreeEnabled")]
        Edge_EdgeWalletEtreeEnabled = 96,

        [Name("Edit Favorites Enabled", "Edge_EditFavoritesEnabled")]
        [EdgePolicy("Edit Favorites Enabled", "EditFavoritesEnabled")]
        Edge_EditFavoritesEnabled = 97,

        [Name("Edge Enable Media Router", "Edge_EnableMediaRouter")]
        [EdgePolicy("Enable Media Router", "EnableMediaRouter")]
        Edge_EnableMediaRouter = 98,

        [Name("Edge Favorites Bar Enabled", "Edge_FavoritesBarEnabled")]
        [EdgePolicy("Favorites Bar Enabled", "FavoritesBarEnabled")]
        Edge_FavoritesBarEnabled =99,

        [Name("Edge Feature Flag Overrides Control", "Edge_FeatureFlagOverridesControl")]
        [EdgePolicy("Feature Flag Overrides Control", "FeatureFlagOverridesControl\"")]
        Edge_FeatureFlagOverridesControl=100,

        [Name("Edge Gamer Mode Enabled", "Edge_GamerModeEnabled")]
        [EdgePolicy("Gamer Mode Enabled", "GamerModeEnabled")]
        Edge_GamerModeEnabled =101,

        [Name("Edge Hide First Run Experience", "Edge_HideFirstRunExperience")]
        [EdgePolicy("Hide First Run Experience", "HideFirstRunExperience", 1)]
        Edge_HideFirstRunExperience = 102,

        [Name("Edge Hide Internet Explorer Redirect UXF or Incompatible Sites Enabled", "Edge_HideInternetExplorerRedirectUXForIncompatibleSitesEnabled")]
        [EdgePolicy("Hide Internet Explorer Redirect UXF or Incompatible Sites Enabled", "HideInternetExplorerRedirectUXForIncompatibleSitesEnabled", 1)]
        Edge_HideInternetExplorerRedirectUXForIncompatibleSitesEnabled = 103,

        [Name("Edge Hide Restore Dialog Enabled", "Edge_HideRestoreDialogEnabled")]
        [EdgePolicy("Hide Restore Dialog Enabled", "HideRestoreDialogEnabled", 1)]
        Edge_HideRestoreDialogEnabled = 104,

        [Name("Edge Homepage Is New Tab Page", "Edge_HomepageIsNewTabPage")]
        [EdgePolicy("Homepage Is New Tab Page", "HomepageIsNewTabPage", 1)]
        Edge_HomepageIsNewTabPage = 105,

        [Name("Hubs Sidebar Enabled", "Edge_HubsSidebarEnabled")]
        [EdgePolicy("Hubs Sidebar Enabled", "HubsSidebarEnabled")]
        Edge_HubsSidebarEnabled = 106,

        [Name("Edge In Private Mode Availability", "Edge_InPrivateModeAvailability")]
        [EdgePolicy("In Private Mode Availability", "InPrivateModeAvailability", 2)]
        Edge_InPrivateModeAvailability = 107,

        [Name("Edge Internet Explorer Integration Level", "Edge_InternetExplorerIntegrationLevel")]
        [EdgePolicy("Internet Explorer Integration Level", "InternetExplorerIntegrationLevel")]
        Edge_InternetExplorerIntegrationLevel = 108,

        [Name("Edge Internet Explorer Integration Local File Allowed", "Edge_InternetExplorerIntegrationLocalFileAllowed")]
        [EdgePolicy("Internet Explorer Integration Local File Allowed", "InternetExplorerIntegrationLocalFileAllowed")]
        Edge_InternetExplorerIntegrationLocalFileAllowed = 109,

        [Name("Edge Internet Explorer Integration Local File Show Context Menu", "Edge_InternetExplorerIntegrationLocalFileShowContextMenu")]
        [EdgePolicy("Internet Explorer Integration Local File Show Context Menu", "InternetExplorerIntegrationLocalFileShowContextMenu")]
        Edge_InternetExplorerIntegrationLocalFileShowContextMenu = 110,

        [Name("Edge Internet Explorer Integration Reload In IEMode Allowed", "Edge_InternetExplorerIntegrationReloadInIEModeAllowed")]
        [EdgePolicy("Internet Explorer Integration Reload In IEMode Allowed", "InternetExplorerIntegrationReloadInIEModeAllowed")]
        Edge_InternetExplorerIntegrationReloadInIEModeAllowed = 111,

        [Name("Edge Internet Explorer Integration Zone Identifier Mht File Allowed", "Edge_InternetExplorerIntegrationZoneIdentifierMhtFileAllowed")]
        [EdgePolicy("Internet Explorer Integration Zone Identifier Mht File Allowed", "InternetExplorerIntegrationZoneIdentifierMhtFileAllowed")]
        Edge_InternetExplorerIntegrationZoneIdentifierMhtFileAllowed = 112,

        [Name("Edge Internet Explorer Mode Enable Save PageAs", "Edge_InternetExplorerModeEnableSavePageAs")]
        [EdgePolicy("Internet Explorer Mode Enable Save PageAs", "InternetExplorerModeEnableSavePageAs")]
        Edge_InternetExplorerModeEnableSavePageAs = 113,

        [Name("Edge Internet Explorer Mode Toolbar Button Enabled", "Edge_InternetExplorerModeToolbarButtonEnabled")]
        [EdgePolicy("Internet Explorer Mode Toolbar Button Enabled", "InternetExplorerModeToolbarButtonEnabled")]
        Edge_InternetExplorerModeToolbarButtonEnabled = 114,

        [Name("Edge Intranet File Links Enabled", "Edge_IntranetFileLinksEnabled")]
        [EdgePolicy("Intranet File Links Enabled", "IntranetFileLinksEnabled")]
        Edge_IntranetFileLinksEnabled = 115,

        [Name("Edge Local Browser Data Share Enabled", "Edge_LocalBrowserDataShareEnabled")]
        [EdgePolicy("Local Browser Data Share Enabled", "LocalBrowserDataShareEnabled")]
        Edge_LocalBrowserDataShareEnabled = 116,

        [Name("Edge Microsoft Edge Insider Promotion Enabled", "Edge_MicrosoftEdgeInsiderPromotionEnabled")]
        [EdgePolicy("Microsoft Edge Insider Promotion Enabled", "MicrosoftEdgeInsiderPromotionEnabled")]
        Edge_MicrosoftEdgeInsiderPromotionEnabled = 117,

        [Name("Edge Mouse Gesture Enabled", "Edge_MouseGestureEnabled")]
        [EdgePolicy("Mouse Gesture Enabled", "MouseGestureEnabled")]
        Edge_MouseGestureEnabled = 118,

        [Name("Edge New Tab Page Allowed Background Types", "Edge_NewTabPageAllowedBackgroundTypes")]
        [EdgePolicy("New Tab Page Allowed Background Types", "NewTabPageAllowedBackgroundTypes", 3)]
        Edge_NewTabPageAllowedBackgroundTypes = 119,

        [Name("Edge New Tab Page App Launcher Enabled", "Edge_NewTabPageAppLauncherEnabled")]
        [EdgePolicy("New Tab Page App Launcher Enabled", "NewTabPageAppLauncherEnabled")]
        Edge_NewTabPageAppLauncherEnabled = 120,

        [Name("Edge New Tab Page Bing Chat Enabled", "Edge_NewTabPageBingChatEnabled")]
        [EdgePolicy("New Tab Page Bing Chat Enabled", "NewTabPageBingChatEnabled")]
        Edge_NewTabPageBingChatEnabled = 121,

        [Name("Edge New Tab Page Content Enabled", "Edge_NewTabPageContentEnabled")]
        [EdgePolicy("New Tab Page Content Enabled", "NewTabPageContentEnabled")]
        Edge_NewTabPageContentEnabled = 122,

        [Name("Edge New Tab Page Hide Default Top Sites", "Edge_NewTabPageHideDefaultTopSites")]
        [EdgePolicy("New Tab Page Hide Default Top Sites", "NewTabPageHideDefaultTopSites", 1)]
        Edge_NewTabPageHideDefaultTopSites = 123,

        [Name("Edge New Tab Page Quick Links Enabled", "Edge_NewTabPageQuickLinksEnabled")]
        [EdgePolicy("New Tab Page Quick Links Enabled", "NewTabPageQuickLinksEnabled")]
        Edge_NewTabPageQuickLinksEnabled = 124,

        [Name("Edge Password Generator Enabled", "Edge_PasswordGeneratorEnabled")]
        [EdgePolicy("Password Generator Enabled", "PasswordGeneratorEnabled")]
        Edge_PasswordGeneratorEnabled = 125,

        [Name("Edge Password Manager Enabled", "Edge_PasswordManagerEnabled")]
        [EdgePolicy("Password Manager Enabled", "PasswordManagerEnabled")]
        Edge_PasswordManagerEnabled = 126,

        [Name("Edge Pin Browser Essentials Toolbar Button", "Edge_PinBrowserEssentialsToolbarButton")]
        [EdgePolicy("Pin Browser Essentials Toolbar Button", "PinBrowserEssentialsToolbarButton")]
        Edge_PinBrowserEssentialsToolbarButton = 127,

        [Name("Edge Pinning Wizard Allowed", "Edge_PinningWizardAllowed")]
        [EdgePolicy("Pinning Wizard Allowed", "PinningWizardAllowed")]
        Edge_PinningWizardAllowed = 128,

        [Name("Edge Printing Enabled", "Edge_PrintingEnabled")]
        [EdgePolicy("Printing Enabled", "PrintingEnabled")]
        Edge_PrintingEnabled = 129,

        [Name("Edge Quick Search Show Mini Menu", "Edge_QuickSearchShowMiniMenu")]
        [EdgePolicy("Quick Search Show Mini Menu", "QuickSearchShowMiniMenu")]
        Edge_QuickSearchShowMiniMenu = 130,

        [Name("Edge Read Aloud Enabled", "Edge_ReadAloudEnabled")]
        [EdgePolicy("Read Aloud Enabled", "ReadAloudEnabled")]
        Edge_ReadAloudEnabled = 131,

        [Name("Edge Redirect Sites From Internet Explorer Prevent BHO Install", "Edge_RedirectSitesFromInternetExplorerPreventBHOInstall")]
        [EdgePolicy("Redirect Sites From Internet Explorer Prevent BHO Install", "RedirectSitesFromInternetExplorerPreventBHOInstall", 1)]
        Edge_RedirectSitesFromInternetExplorerPreventBHOInstall = 132,

        [Name("Edge Remote Debugging Allowed", "Edge_RemoteDebuggingAllowed")]
        [EdgePolicy("Remote Debugging Allowed", "RemoteDebuggingAllowed")]
        Edge_RemoteDebuggingAllowed = 133,

        [Name("Edge Restore On Startup", "Edge_RestoreOnStartup")]
        [EdgePolicy("Restore On Startup", "RestoreOnStartup", 5)]
        Edge_RestoreOnStartup = 134,

        [Name("Edge Show Acrobat Subscription Button", "Edge_ShowAcrobatSubscriptionButton")]
        [EdgePolicy("Show Acrobat Subscription Button", "ShowAcrobatSubscriptionButton")]
        Edge_ShowAcrobatSubscriptionButton = 135,

        [Name("Edge Show Downloads Toolbar Button", "Edge_ShowDownloadsToolbarButton")]
        [EdgePolicy("Show Downloads Toolbar Button", "ShowDownloadsToolbarButton")]
        Edge_ShowDownloadsToolbarButton = 136,

        [Name("Edge Show Home Button", "Edge_ShowHomeButton")]
        [EdgePolicy("Show Home Button", "ShowHomeButton")]
        Edge_ShowHomeButton = 137,

        [Name("Edge SmartScreen Pua Enabled", "Edge_SmartScreenPuaEnabled")]
        [EdgePolicy("SmartScreen Pua Enabled", "SmartScreenPuaEnabled", 1)]
        Edge_SmartScreenPuaEnabled = 138,

        [Name("Edge Speech Recognition Enabled", "Edge_SpeechRecognitionEnabled")]
        [EdgePolicy("Speech Recognition Enabled", "SpeechRecognitionEnabled")]
        Edge_SpeechRecognitionEnabled = 139,

        [Name("Edge Split Screen Enabled", "Edge_SplitScreenEnabled")]
        [EdgePolicy("Split Screen Enabled", "SplitScreenEnabled")]
        Edge_SplitScreenEnabled = 140,

        [Name("Edge Standalone Hubs Sidebar Enabled", "Edge_StandaloneHubsSidebarEnabled")]
        [EdgePolicy("Standalone Hubs Sidebar Enabled", "StandaloneHubsSidebarEnabled")]
        Edge_StandaloneHubsSidebarEnabled = 141,

        [Name("Edge Sync Disabled", "Edge_SyncDisabled")]
        [EdgePolicy("Sync Disabled", "SyncDisabled")]
        Edge_SyncDisabled = 142,

        [Name("Edge Task Manager End Process Enabled", "Edge_TaskManagerEndProcessEnabled")]
        [EdgePolicy("Task Manager End Process Enabled", "TaskManagerEndProcessEnabled")]
        Edge_TaskManagerEndProcessEnabled = 143,

        [Name("Edge Upload From Phone Enabled", "Edge_UploadFromPhoneEnabled")]
        [EdgePolicy("Upload From Phone Enabled", "UploadFromPhoneEnabled")]
        Edge_UploadFromPhoneEnabled = 144,

        [Name("Edge User Feedback Allowed", "Edge_UserFeedbackAllowed")]
        [EdgePolicy("User Feedback Allowed", "UserFeedbackAllowed")]
        Edge_UserFeedbackAllowed = 145,

        [Name("Edge Video Capture Allowed", "Edge_VideoCaptureAllowed")]
        [EdgePolicy("Video Capture Allowed", "VideoCaptureAllowed")]
        Edge_VideoCaptureAllowed = 146,

        [Name("Edge Wallet Donation Enabled", "Edge_WalletDonationEnabled")]
        [EdgePolicy("Wallet Donation Enabled", "WalletDonationEnabled")]
        Edge_WalletDonationEnabled = 147,

        [Name("Edge Web Capture Enabled", "Edge_WebCaptureEnabled")]
        [EdgePolicy("Web Capture Enabled", "WebCaptureEnabled")]
        Edge_WebCaptureEnabled = 148,

        [Name("Edge Form Suggest Passwords", "Edge_FormSuggestPasswords")]
        [EdgeMainPolicy("Form Suggest Passwords", "FormSuggestPasswords")]
        Edge_FormSuggest_Password = 149,

        [Name("Edge Use FormSuggest", "Edge_UseFormSuggest")]
        [EdgeMainPolicy("Use FormSuggest", "UseFormSuggest")]
        Edge_Use_FormSuggest = 150,
        #endregion

        #region OneDrive

        [Name("OneDrive Prevent Network Traffic Pre User Sign In", "OneDrive_PreventNetworkTrafficPreUserSignIn")]
        [OneDrivePolicy("Prevent Network Traffic Pre User Sign In", "PreventNetworkTrafficPreUserSignIn")]
        OneDrive_PreventNetworkTrafficPreUserSignIn = 151,

        #endregion

        #region Explorer

        [Name("Explorer Allow Online Tips", "Explorer_AllowOnlineTips")]
        [ExplorerPolicy("Allow Online Tips", "AllowOnlineTips")]
        Explorer_AllowOnlineTips = 152,

        [Name("Explorer Disable Local Machine Run", "Explorer_DisableLocalMachineRun")]
        [ExplorerPolicy("Disable Local Machine Run", "DisableLocalMachineRun", 1)]
        Explorer_DisableLocalMachineRun = 153,

        [Name("Explorer Disable Local Machine Run Once", "Explorer_DisableLocalMachineRunOnce")]
        [ExplorerPolicy("Disable Local Machine Run Once", "DisableLocalMachineRunOnce", 1)]
        Explorer_DisableLocalMachineRunOnce = 154,

        [Name("Explorer Dont Set Autoplay Checkbox", "Explorer_DontSetAutoplayCheckbox")]
        [ExplorerPolicy("Dont Set Autoplay Checkbox", "DontSetAutoplayCheckbox", 1)]
        Explorer_DontSetAutoplayCheckbox = 155,

        [Name("Exolorer Hide Power Options", "Explorer_HidePowerOptions")]
        [ExplorerPolicy("Hide Power Options", "HidePowerOptions", 1)]
        Explorer_HidePowerOptions = 156,

        [Name("Explorer Allow No Autorun", "Explorer_NoAutorun")]
        [ExplorerPolicy("Allow No Autorun", "AllowNoAutorun", 1)]
        Explorer_NoAutorun = 157,

        [Name("Explorer No Change Start Menu", "Explorer_NoChangeStartMenu")]
        [ExplorerPolicy("No Change Start Menu", "NoChangeStartMenu", 1)]
        Explorer_NoChangeStartMenu = 158,

        [Name("Explorer No Drive Type AutoRun", "Explorer_NoDriveTypeAutoRun")]
        [ExplorerPolicy("No Drive Type AutoRun", "NoDriveTypeAutoRun", 255)]
        Explorer_NoDriveTypeAutoRun = 159,

        [Name("Explorer No Recent Docs History", "Explorer_NoRecentDocsHistory")]
        [ExplorerPolicy("No Recent Docs History", "NoRecentDocsHistory", 1)]
        Explorer_NoRecentDocsHistory = 160,

        [Name("Explorer No Run", "Explorer_NoRun")]
        [ExplorerPolicy("No Run", "NoRun", 1)]
        Explorer_NoRun = 161,

        [Name("Explorer No Set Taskbar", "Explorer_NoSetTaskbar")]
        [ExplorerPolicy("No Set Taskbar", "NoSetTaskbar", 1)]
        Explorer_NoSetTaskbar = 162,

        [Name("Explorer No Start Menu MFU programs List", "Explorer_NoStartMenuMFUprogramsList")]
        [ExplorerPolicy("No Start Menu MFU programs List", "NoStartMenuMFUprogramsList", 1)]
        Explorer_NoStartMenuMFUprogramsList = 163,

        [Name("Explorer No Start Menu More Programs", "Explorer_NoStartMenuMorePrograms")]
        [ExplorerPolicy("No Start Menu More Programs", "StartMenuMorePrograms", 1)]
        Explorer_NoStartMenuMorePrograms = 164,

        [Name("Explorer No Tray Context Menu", "Explorer_NoTrayContextMenu")]
        [ExplorerPolicy("No Tray Context Menu", "NoTrayContextMenu", 1)]
        Explorer_NoTrayContextMenu = 165,

        [Name("Explorer disable WAU", "Explorer_WAU_Disabled")]
        [ExplorerWAUPolicy("WAU", "Disabled")]
        ExplorerWAU_Disabled = 166,

        [Name("Explorer Disable Context Menus In Start", "WindowsExplorer_DisableContextMenusInStart")]
        [WindowsExplorerPolicy("Disable Context Menus In Start", "DisableContextMenusInStart", 1)]
        WindowsExplorer_DisableContextMenusInStart = 167,

        [Name("Explorer Explorer Ribbon Starts Minimized", "WindowsExplorer_ExplorerRibbonStartsMinimized")]
        [WindowsExplorerPolicy("Explorer Ribbon Starts Minimized", "ExplorerRibbonStartsMinimized", 1)]
        WindowsExplorer_ExplorerRibbonStartsMinimized = 168,

        [Name("Explorer Hide Recently Added Apps", "WindowsExplorer_HideRecentlyAddedApps")]
        [WindowsExplorerPolicy("Hide Recently Added Apps", "HideRecentlyAddedApps", 1)]
        WindowsExplorer_HideRecentlyAddedApps = 169,

        [Name("Explorer No New App Alert", "WindowsExplorer_NoNewAppAlert")]
        [WindowsExplorerPolicy("No New App Alert", "NoNewAppAlert", 1)]
        WindowsExplorer_NoNewAppAlert = 170,
        #endregion

        #region System

        [Name("System Disable Startup Sound", "System_DisableStartupSound")]
        [SystemPolicy("Disable Startup Sound", "DisableStartupSound", 1)]
        System_DisableStartupSound = 171,

        [Name("System Disable Status Messages", "System_DisableStatusMessages")]
        [SystemPolicy("Disable Status Messages", "DisableStatusMessages", 1)]
        System_DisableStatusMessages = 172,

        [Name("System Allow Domain Delay Lock", "System_AllowDomainDelayLock")]
        [WindowsSystemPolicy("Allow Domain Delay Lock", "AllowDomainDelayLock")]
        WindowsSystem_AllowDomainDelayLock = 173,

        [Name("System Disable Lock Screen App Notifications", "System_DisableLockScreenAppNotifications")]
        [WindowsSystemPolicy("Disable Lock Screen App Notifications", "DisableLockScreenAppNotifications", 1)]
        WindowsSystem_DisableLockScreenAppNotifications = 174,

        #endregion

        #region Windows

        [Name("Windows Turn Off Win Cal", "Windows_TurnOffWinCal")]
        [WindowsPolicy("Turn Off Win Cal", "TurnOffWinCal")]
        Windows_TurnOffWinCal = 175,

        [Name("Windows Turn Off Sidebar", "Windows_TurnOffSidebar")]
        [WindowsSidebarPolicy("Turn Off Sidebar", "TurnOffSidebar")]
        Windows_TurnOffSidebar = 176,

        [Name("Windows File History", "Windows_FileHistory")]
        [WindowsFileHistoryPolicy("File History", "Disabled", 1)]
        WindowsFileHistory = 177,

        [Name("Windows Allow Game DVR", "Windows_AllowGameDVR")]
        [WindowsGameDVRPolicy("Allow Game DVR", "AllowGameDVR")]
        WindowsGameDVR_AllowGameDVR = 178,

        [Name("Windows Disable Home Group", "Windows_DisableHomeGroup")]
        [WindowsHomeGroupPolicy("Disable Home Group", "DisableHomeGroup", 1)]
        WindowsHomeGroup_DisableHomeGroup = 179,

        [Name("Windows Maps Auto Download And Update Map Data", "WindowsMaps_AutoDownloadAndUpdateMapData")]
        [WindowsMapsPolicy("Auto Download And Update Map Data", "AutoDownloadAndUpdateMapData")]
        WindowsMaps_AutoDownloadAndUpdateMapData = 180,

        [Name("Windows No Lock Screen Camera", "Windows_NoLockScreenCamera")]
        [WindowsPersonalizationPolicy("No Lock Screen Camera", "NoLockScreenCamera", 1)]
        WindowsPersonalization_NoLockScreenCamera = 181,

        [Name("Windows No Lock Screen Slideshow", "Windows_NoLockScreenSlideshow")]
        [WindowsPersonalizationPolicy("No Lock Screen Slideshow", "NoLockScreenSlideshow", 1)]
        WindowsPersonalization_NoLockScreenSlideshow = 182,

        [Name("Windows Powershell Execution Policy", "WindowsPowershell_ExecutionPolicy")]
        [WindowsPowerShellPolicy("Execution Policy", "executionpolicy", "")]
        WindowsPowershell_ExecutionPolicy = 183,

        [Name("Windows Powershell Enable Scripts", "WindowsPowershell_EnableScripts")]
        [WindowsPowerShellPolicy("Enable Scripts", "EnableScripts")]
        WindowsPowershell_EnableScripts = 184,

        [Name("WindowsSearch Allow Cortana In Aad", "WindowsSearch_allowcortanainaad")]
        [WindowsSearchPolicy("Allow Cortana In Aad", "allowcortanainaad", "")]
        WindowsSearch_allowcortanainaad = 185,

        [Name("WindowsSearch Allow Cortana In Aad Path Oobe", "WindowsSearch_allowcortanainaadpathoobe")]
        [WindowsSearchPolicy("Allow Cortana In Aad Path Oobe", "allowcortanainaadpathoobe", "")]
        WindowsSearch_allowcortanainaadpathoobe = 186,

        [Name("WindowsSearch Allow Cloud Search", "WindowsSearch_AllowCloudSearch")]
        [WindowsSearchPolicy("Allow Cloud Search", "AllowCloudSearch")]
        WindowsSearch_AllowCloudSearch = 187,

        [Name("WindowsSearch Allow Cortana", "WindowsSearch_AllowCortana")]
        [WindowsSearchPolicy("Allow Cortana", "AllowCortana")]
        WindowsSearch_AllowCortana = 188,

        [Name("WindowsSearch Allow Cortana Above Lock", "WindowsSearch_AllowCortanaAboveLock")]
        [WindowsSearchPolicy("Allow Cortana Above Lock", "AllowCortanaAboveLock")]
        WindowsSearch_AllowCortanaAboveLock = 189,

        #endregion

        #region Chrome

        [Name("Chrome Ads Setting For Intrusive Ads Sites", "Chrome_AdsSettingForIntrusiveAdsSites")]
        [ChromePolicy("Ads Setting For Intrusive Ads Sites", "AdsSettingForIntrusiveAdsSites", 2)]
        Chrome_TurnOffWinCal = 190,

        [Name("Chrome Allow Deleting Browser History", "Chrome_AllowDeletingBrowserHistory")]
        [ChromePolicy("Allow Deleting Browser History", "AllowDeletingBrowserHistory", 1)]
        Chrome_AllowDeletingBrowserHistory = 191,

        [Name("Chrome Allow Dinosaur Easter Egg", "Chrome_AllowDinosaurEasterEgg")]
        [ChromePolicy("Allow Dinosaur Easter Egg", "AllowDinosaurEasterEgg")]
        Chrome_AllowDinosaurEasterEgg = 192,

        [Name("Chrome Allow File Selection Dialogs", "Chrome_AllowFileSelectionDialogs")]
        [ChromePolicy("Allow File Selection Dialogs", "AllowFileSelectionDialogs")]
        Chrome_AllowFileSelectionDialogs = 193,

        [Name("Chrome Allow Outdated Plugins", "Chrome_AllowOutdatedPlugins")]
        [ChromePolicy("Allow Outdated Plugins", "AllowOutdatedPlugins")]
        Chrome_AllowOutdatedPlugins = 194,

        [Name("Chrome Autofill Credit Card Enabled", "Chrome_AutofillCreditCardEnabled")]
        [ChromePolicy("Autofill Credit Card Enabled", "AutofillCreditCardEnabled")]
        Chrome_AutofillCreditCardEnabled = 195,

        [Name("Chrome Background Mode Enabled", "Chrome_BackgroundModeEnabled")]
        [ChromePolicy("Background Mode Enabled", "BackgroundModeEnabled")]
        Chrome_BackgroundModeEnabled = 196,

        [Name("Chrome Block External Extensions", "Chrome_BlockExternalExtensions")]
        [ChromePolicy("Block External Extensions", "BlockExternalExtensions", 1)]
        Chrome_BlockExternalExtensions = 197,

        [Name("Chrome Bookmark Bar Enabled", "Chrome_BookmarkBarEnabled")]
        [ChromePolicy("Bookmark Bar Enabled", "BookmarkBarEnabled")]
        Chrome_BookmarkBarEnabled = 198,

        [Name("Chrome Browser Add Person Enabled", "Chrome_BrowserAddPersonEnabled")]
        [ChromePolicy("Browser Add Person Enabled", "BrowserAddPersonEnabled")]
        Chrome_BrowserAddPersonEnabled = 199,

        [Name("Chrome Browser Guest Mode Enabled", "Chrome_BrowserGuestModeEnabled")]
        [ChromePolicy("Browser Guest Mode Enabled", "BrowserGuestModeEnabled", 1)]
        Chrome_BrowserGuestModeEnabled = 200,

        [Name("Chrome Browser Signin", "Chrome_BrowserSignin")]
        [ChromePolicy("Browser Signin", "BrowserSignin")]
        Chrome_BrowserSignin = 201,

        [Name("Chrome Built In Dns Client Enabled", "Chrome_BuiltInDnsClientEnabled")]
        [ChromePolicy("Built In Dns Client Enabled", "BuiltInDnsClientEnabled", 1)]
        Chrome_BuiltInDnsClientEnabled = 202,

        [Name("Chrome Default Browser Setting Enabled", "Chrome_DefaultBrowserSettingEnabled")]
        [ChromePolicy("Default Browser Setting Enabled", "DefaultBrowserSettingEnabled", 1)]
        Chrome_DefaultBrowserSettingEnabled = 203,

        [Name("Chrome Developer Tools Availability", "Chrome_DeveloperToolsAvailability")]
        [ChromePolicy("Developer Tools Availability", "DeveloperToolsAvailability", 2)]
        Chrome_DeveloperToolsAvailability = 204,

        [Name("Chrome Disable Screenshots", "Chrome_DisableScreenshots")]
        [ChromePolicy("Disable Screenshots", "DisableScreenshots", 1)]
        Chrome_DisableScreenshots = 205,

        [Name("Chrome Dns Over Https Mode", "Chrome_DnsOverHttpsMode")]
        [ChromePolicy("Dns Over Https Mode", "DnsOverHttpsMode", "off")]
        Chrome_DnsOverHttpsMode = 206,

        [Name("Chrome Download Restrictions", "Chrome_DownloadRestrictions")]
        [ChromePolicy("Download Restrictions", "DownloadRestrictions", 3)]
        Chrome_DownloadRestrictions = 207,

        [Name("Chrome Edit Bookmarks Enabled", "Chrome_EditBookmarksEnabled")]
        [ChromePolicy("Edit Bookmarks Enabled", "EditBookmarksEnabled")]
        Chrome_EditBookmarksEnabled = 208,

        [Name("Chrome Force Ephemeral Profiles", "Chrome_ForceEphemeralProfiles")]
        [ChromePolicy("Force Ephemeral Profiles", "ForceEphemeralProfiles", 1)]
        Chrome_ForceEphemeralProfiles = 209,

        [Name("Chrome Hide Web Store Icon", "Chrome_HideWebStoreIcon")]
        [ChromePolicy("Hide Web Store Icon", "HideWebStoreIcon", 1)]
        Chrome_HideWebStoreIcon = 210,

        [Name("Chrome Incognito Mode Availability", "Chrome_IncognitoModeAvailability")]
        [ChromePolicy("Incognito Mode Availability", "IncognitoModeAvailability", 2)]
        Chrome_IncognitoModeAvailability = 211,

        [Name("Chrome NTP Custom Background Enabled", "Chrome_NTPCustomBackgroundEnabled")]
        [ChromePolicy("NTP Custom Background Enabled", "NTPCustomBackgroundEnabled")]
        Chrome_NTPCustomBackgroundEnabled = 212,

        [Name("Chrome Password Manager Enabled", "Chrome_PasswordManagerEnabled")]
        [ChromePolicy("Password Manager Enabled", "PasswordManagerEnabled")]
        Chrome_PasswordManagerEnabled = 213,

        [Name("Chrome Printing Enabled", "Chrome_PrintingEnabled")]
        [ChromePolicy("Printing Enabled", "PrintingEnabled")]
        Chrome_PrintingEnabled = 214,

        [Name("Chrome Site Per Process", "Chrome_SitePerProcess")]
        [ChromePolicy("Site Per Process", "SitePerProcess", 1)]
        Chrome_SitePerProcess = 215,

        [Name("Chrome Spellcheck Enabled", "Chrome_SpellcheckEnabled")]
        [ChromePolicy("Spellcheck Enabled", "SpellcheckEnabled", 1)]
        Chrome_SpellcheckEnabled = 216,

        [Name("Chrome SpellCheck Service Enabled", "Chrome_SpellCheckServiceEnabled")]
        [ChromePolicy("SpellCheck Service Enabled", "SpellCheckServiceEnabled", 1)]
        Chrome_SpellCheckServiceEnabled = 217,

        [Name("Chrome Sync Disabled", "Chrome_SyncDisabled")]
        [ChromePolicy("Sync Disabled", "SyncDisabled", 1)]
        Chrome_SyncDisabled = 218,

        [Name("Chrome Translate Enabled", "Chrome_TranslateEnabled")]
        [ChromePolicy("Translate Enabled", "TranslateEnabled", 1)]
        Chrome_TranslateEnabled = 219,

        #endregion

        #region Miscellaneous

        [Name("Windows Assistance No Active Help", "WindowsAssistance_NoActiveHelp")]
        [WindowsAssistancePolicy("No Active Help", "NoActiveHelp", 1)]
        WindowsAssistance_NoActiveHelp = 220,

        [Name("Windows Camera Allow Camera", "Camera_AllowCamera")]
        [CameraPolicy("Allow Camera", "AllowCamera")]
        WindowsCamera_AllowCamera = 221,

        [Name("Windows Event Viewer MicrosoftRedirectionProgram", "EventViewer_MicrosoftRedirectionProgram")]
        [EventViewerPolicy("microsoftredirectionprogram", "microsoftredirectionprogram", "")]
        WindowsEventViewer_MicrosoftRedirectionProgram = 222,

        [Name("Windows Messenger Client Prevent Run", "MessengerClient_PreventRun")]
        [MessengerClientPolicy("Prevent Run", "PreventRun", 1)]
        WindowsMessengerClient_PreventRun = 223,

        [Name("Windows Sound Recorder Soundrec", "SoundRecorder_Soundrec")]
        [SoundRecorderPolicy("Soundrec", "Soundrec", 1)]
        WindowsSoundRecorder_Soundrec = 224,

        [Name("Windows Speech AllowSpeechModelUpdate", "Speech_AllowSpeechModelUpdate")]
        [SpeechPolicy("AllowSpeechModelUpdate", "AllowSpeechModelUpdate")]
        WindowsSpeech_AllowSpeechModelUpdate = 225,

        [Name("WindowsNT MYS DisableShowAtLogon", "WindowsNT_MYS_DisableShowAtLogon")]
        [WindowsNTMYSPolicy("DisableShowAtLogon", "DisableShowAtLogon", 1)]
        WindowsNTMYS_DisableShowAtLogon = 226,

        [Name("WindowsNT IIS PreventIISInstall", "WindowsNT_IIS_PreventIISInstall")]
        [WindowsNTIISPolicy("PreventIISInstall", "PreventIISInstall", 1)]
        WindowsNTIIS_PreventIISInstall = 227,

        [Name("Push Notifications NoCloudApplicationNotification", "PushNotifications_NoCloudApplicationNotification")]
        [PushNotificationsPolicy("NoCloudApplicationNotification", "NoCloudApplicationNotification", 1)]
        PushNotifications_NoCloudApplicationNotification = 228,

        [Name("Protected Event Logging Encryption Certificate", "ProtectedEventLogging_encryptioncertificate")]
        [ProtectedEventLoggingPolicy("Encryption Certificate", "encryptioncertificate", "")]
        ProtectedEventLogging_encryptioncertificate =229,

        [Name("Protected Event Logging Enable Protected Event Logging", "ProtectedEventLogging_EnableProtectedEventLogging")]
        [ProtectedEventLoggingPolicy("Enable Protected Event Logging", "EnableProtectedEventLogging")]
        ProtectedEventLogging_EnableProtectedEventLogging = 230,

        [Name("Windows Inc Workspace Allow Windows Ink Workspace", "WindowsInkWorkspace_AllowWindowsInkWorkspace")]
        [WindowsInkWorkspacePolicy("Allow Windows Ink Workspace", "AllowWindowsInkWorkspace")]
        WindowsIncWorkspace_AllowWindowsInkWorkspace = 231,
        #endregion

        #region Windows Defender

        [Name("Windows Defender pua protection", "WindowsDefender_puaprotection")]
        [WindowsDefenderPolicy("pua protection", "puaprotection", "")]
        WindowsDefender_puaprotection = 232,

        [Name("Windows Defender Allow Fast Service Startup", "WindowsDefender_AllowFastServiceStartup")]
        [WindowsDefenderPolicy("Allow Fast Service Startup", "AllowFastServiceStartup")]
        WindowsDefender_AllowFastServiceStartup = 233,

        [Name("Windows Defender Service Keep Alive", "WindowsDefender_ServiceKeepAlive")]
        [WindowsDefenderPolicy("Service Keep Alive", "ServiceKeepAlive")]
        WindowsDefender_ServiceKeepAlive = 234,

        [Name("Windows Defender Realtime Protection Disable Behavior Monitoring", " WindowsDefenderRealTimeProtection_DisableBehaviorMonitoring")]
        [WindowsDefenderRealTimeProtectionPolicy("Disable Behavior Monitoring", "DisableBehaviorMonitoring", 1)]
        WindowsDefenderRealTimeProtection_DisableBehaviorMonitoring = 235,

        [Name("Windows Defender Realtime Protection Disable IOAV Protection", " WindowsDefenderRealTimeProtection_DisableIOAVProtection")]
        [WindowsDefenderRealTimeProtectionPolicy("Disable IOAV Protection", "DisableIOAVProtection", 1)]
        WindowsDefenderRealTimeProtection_DisableIOAVProtection = 236,

        [Name("Windows Defender Realtime Protection Disable On Access Protection", " WindowsDefenderRealTimeProtection_DisableOnAccessProtection")]
        [WindowsDefenderRealTimeProtectionPolicy("Disable On Access Protection", "DisableOnAccessProtection", 1)]
        WindowsDefenderRealTimeProtection_DisableOnAccessProtection = 237,

        [Name("Windows Defender Realtime Protection Disable Realtime Monitoring", " WindowsDefenderRealTimeProtection_DisableRealtimeMonitoring")]
        [WindowsDefenderRealTimeProtectionPolicy("Disable Realtime Monitoring", "DisableRealtimeMonitoring", 1)]
        WindowsDefenderRealTimeProtection_DisableRealtimeMonitoring = 238,

        [Name("Windows Defender Realtime Protection Disable Scan On Realtime Enable", " WindowsDefenderRealTimeProtection_DisableScanOnRealtimeEnable")]
        [WindowsDefenderRealTimeProtectionPolicy("Disable Scan On Realtime Enable", "DisableScanOnRealtimeEnable", 1)]
        WindowsDefenderRealTimeProtection_DisableScanOnRealtimeEnable = 239,

        [Name("Windows DefenderScan Disable Scanning Network Files", " WindowsDefenderScan_DisableScanningNetworkFiles")]
        [WindowsDefenderScanPolicy("Disable Scanning Network Files", "DisableScanningNetworkFiles", 1)]
        WindowsDefenderScan_DisableScanningNetworkFiles = 240,
        #endregion

        #region RemovableStorageDevices

        [Name("Removable Storage Devices Deny All Removable Storage Devices ", "Windows_RemovableStorageDevices_Deny_All")]
        [WindowsRemovableStorageDevicesPolicy("Removable Storage Devices", "Deny_All", 1)]
        Windows_RemovableStorageDevices_Deny_All = 241,

        [Name("Removable Storage Devices CD and DVD Deny Execute", "Windows_RemovableStorageDevicesCDandDVD_Deny_Execute")]
        [WindowsRemovableStorageDevicesCDDVDPolicy("Deny Execute", "Deny_Execute", 1)]
        Windows_RemovableStorageDevicesCDandDVD_Deny_Execute = 242,

        [Name("Removable Storage Devices CD and DVD Deny Read", "Windows_RemovableStorageDevicesCDandDVD_Deny_Read")]
        [WindowsRemovableStorageDevicesCDDVDPolicy("Deny Read", "Deny_Read", 1)]
        Windows_RemovableStorageDevicesCDandDVD_Deny_Read = 243,

        [Name("Removable Storage Devices Tape Drives Deny Write", "Windows_RemovableStorageDevicesTapeDrives_Deny_Write")]
        [WindowsRemovableStorageDevicesCDDVDPolicy("Deny Write", "Deny_Write", 1)]
        Windows_RemovableStorageDevicesTapeDrives_Deny_Write = 244,

        [Name("Removable Storage Devices Tape Drives Deny Execute", "Windows_RemovableStorageDevicesTapeDrives_Deny_Execute")]
        [WindowsRemovableStorageDevicesTapeDrivesPolicy("Deny Execute", "Deny_Execute", 1)]
        Windows_RemovableStorageDevicesTapeDrives_Deny_Execute = 245,

        [Name("Removable Storage Devices Tape Drives Deny Read", "Windows_RemovableStorageDevicesTapeDrives_Deny_Read")]
        [WindowsRemovableStorageDevicesTapeDrivesPolicy("Deny Read", "Deny_Read", 1)]
        Windows_RemovableStorageDevicesTapeDrives_Deny_Read = 246,

        [Name("Removable Storage Devices CD and DVD Deny Write", "Windows_RemovableStorageDevicesCDandDVD_Deny_Write")]
        [WindowsRemovableStorageDevicesTapeDrivesPolicy("Deny Write", "Deny_Write", 1)]
        Windows_RemovableStorageDevicesCDandDVD_Deny_Write = 247,

        [Name("Removable Storage Devices Removable Disks Deny Execute", "Windows_RemovableStorageDevicesRemovableDisks_Deny_Execute")]
        [WindowsRemovableStorageDevicesRemovableDisksPolicy("Deny Execute", "Deny_Execute", 1)]
        Windows_RemovableStorageDevicesRemovableDisks_Deny_Execute = 248,

        [Name("Removable Storage Devices Removable Disks Deny Read", "Windows_RemovableStorageDevicesRemovableDisks_Deny_Read")]
        [WindowsRemovableStorageDevicesRemovableDisksPolicy("Deny Read", "Deny_Read", 1)]
        Windows_RemovableStorageDevicesRemovableDisks_Deny_Read = 249,

        [Name("Removable Storage Devices Removable Disks Deny Write", "Windows_RemovableStorageDevicesRemovableDisks_Deny_Write")]
        [WindowsRemovableStorageDevicesRemovableDisksPolicy("Deny Write", "Deny_Write", 1)]
        Windows_RemovableStorageDevicesRemovableDisks_Deny_Write = 250,

        [Name("Removable Storage Devices Floppy Drives Deny Execute", "Windows_RemovableStorageDevicesFloppyDrives_Deny_Execute")]
        [WindowsRemovableStorageDevicesFloppyDrivesPolicy("Deny Execute", "Deny_Execute", 1)]
        Windows_RemovableStorageDevicesFloppyDrives_Deny_Execute = 251,

        [Name("Removable Storage Devices Floppy Drives Deny Read", "Windows_RemovableStorageDevicesFloppyDrives_Deny_Read")]
        [WindowsRemovableStorageDevicesFloppyDrivesPolicy("Deny Read", "Deny_Read", 1)]
        Windows_RemovableStorageDevicesFloppyDrives_Deny_Read = 252,

        [Name("Removable Storage Devices Floppy Drives Deny Write", "Windows_RemovableStorageDevicesFloppyDrives_Deny_Write")]
        [WindowsRemovableStorageDevicesFloppyDrivesPolicy("Deny Write", "Deny_Write", 1)]
        Windows_RemovableStorageDevicesFloppyDrives_Deny_Write = 253,

        #endregion

        #region WindowsUpdate

        [Name("Windows Update Manage Preview Builds Policy Value", "WindowsUpdate_managepreviewbuildspolicyvalue")]
        [WindowsUpdatePolicy("Manage Preview Builds Policy Value", "managepreviewbuildspolicyvalue", "")]
        WindowsUpdate_managepreviewbuildspolicyvalue = 254,

        [Name("WindowsUpdate Do Not Connect To Windows Update Internet Locations", "WindowsUpdate_DoNotConnectToWindowsUpdateInternetLocations")]
        [WindowsUpdatePolicy("Do Not Connect To Windows Update Internet Locations", "DoNotConnectToWindowsUpdateInternetLocations", 1)]
        WindowsUpdate_DoNotConnectToWindowsUpdateInternetLocations = 255,

        [Name("WindowsUpdate Manage Preview Builds", "WindowsUpdate_ManagePreviewBuilds")]
        [WindowsUpdatePolicy("Manage Preview Builds", "ManagePreviewBuilds")]
        WindowsUpdate_ManagePreviewBuilds = 256,

        [Name("Windows Update Set Disable UXWU Access", "WindowsUpdate_SetDisableUXWUAccess")]
        [WindowsUpdatePolicy("Set Disable UXWU Access", "SetDisableUXWUAccess", 1)]
        WindowsUpdate_SetDisableUXWUAccess = 257,

        [Name("Windows UpdateAu Allow MU Update Service", "WindowsUpdateAu_allowmuupdateservice")]
        [WindowsUpdateAuPolicy("Allow MU Update Service", "allowmuupdateservice", "")]
        WindowsUpdateAu_allowmuupdateservice = 258,

        [Name("Windows UpdateAu Au Options", "WindowsUpdateAu_auoptions")]
        [WindowsUpdateAuPolicy("Au Options", "auoptions", "")]
        WindowsUpdateAu_auoptions = 259,

        [Name("Windows UpdateAu Automatic Maintenance Enabled", "WindowsUpdateAu_automaticmaintenanceenabled")]
        [WindowsUpdateAuPolicy("Automatic Maintenance Enabled", "automaticmaintenanceenabled", "")]
        WindowsUpdateAu_automaticmaintenanceenabled = 260,

        [Name("Windows UpdateAu Scheduled Install Day", "WindowsUpdateAu_scheduledinstallday")]
        [WindowsUpdateAuPolicy("Scheduled Install Day", "scheduledinstallday", "")]
        WindowsUpdateAu_scheduledinstallday = 261,

        [Name("Windows UpdateAu scheduledinstalleveryweek", "WindowsUpdateAu_scheduledinstalleveryweek")]
        [WindowsUpdateAuPolicy("scheduledinstalleveryweek", "scheduledinstalleveryweek", "")]
        WindowsUpdateAu_scheduledinstalleveryweek = 262,

        [Name("Windows UpdateAu Scheduled Install First Week", "WindowsUpdateAu_scheduledinstallfirstweek")]
        [WindowsUpdateAuPolicy("Scheduled Install First Week", "scheduledinstallfirstweek", "")]
        WindowsUpdateAu_scheduledinstallfirstweek = 263,

        [Name("Windows UpdateAu Scheduled Install Fourth Week", "WindowsUpdateAu_scheduledinstallfourthweek")]
        [WindowsUpdateAuPolicy("Scheduled Install Fourth Week", "scheduledinstallfourthweek", "")]
        WindowsUpdateAu_scheduledinstallfourthweek = 264,

        [Name("Windows UpdateAu Scheduled Install Second Week", "WindowsUpdateAu_scheduledinstallsecondweek")]
        [WindowsUpdateAuPolicy("Scheduled Install Second Week", "scheduledinstallsecondweek", "")]
        WindowsUpdateAu_scheduledinstallsecondweek = 265,

        [Name("Windows UpdateAu Scheduled install Third Week", "WindowsUpdateAu_scheduledinstallthirdweek")]
        [WindowsUpdateAuPolicy("Scheduled Install Third Week", "scheduledinstallthirdweek", "")]
        WindowsUpdateAu_scheduledinstallthirdweek = 266,

        [Name("Windows UpdateAu Scheduled Install Time", "WindowsUpdateAu_scheduledinstalltime")]
        [WindowsUpdateAuPolicy("Scheduled Install Time", "scheduledinstalltime", "")]
        WindowsUpdateAu_scheduledinstalltime = 267,

        [Name("Windows UpdateAu No Auto Update", "WindowsUpdateAu_NoAutoUpdate")]
        [WindowsUpdateAuPolicy("No Auto Update", "NoAutoUpdate", 1)]
        WindowsUpdateAu_NoAutoUpdate = 268,

        #endregion

        #region WindowsFirewall

        [Name("Windows Firewall Domain Disable Notifications", "WindowsFirewallDomain_DisableNotifications")]
        [WindowsFirewallDomainPolicy("Disable Notifications", "DisableNotifications", 1)]
        WindowsFirewallDomain_DisableNotifications = 270,

        [Name("Windows Firewall Domain Enable Firewall", "WindowsFirewallDomain_EnableFirewall")]
        [WindowsFirewallDomainPolicy("Enable Firewall", "EnableFirewall")]
        WindowsFirewallDomain_EnableFirewall = 271,

        [Name("Windows Firewall Standard Disable Notifications", "WindowsFirewallStandard_DisableNotifications")]
        [WindowsFirewallStandardPolicy("Disable Notifications", "DisableNotifications", 1)]
        WindowsFirewallStandard_DisableNotifications = 272,

        [Name("Windows Firewall Standard Enable Firewall", "WindowsFirewallStandard_EnableFirewall")]
        [WindowsFirewallStandardPolicy("Enable Firewall", "EnableFirewall")]
        WindowsFirewallStandard_EnableFirewall = 273,

        #endregion

        #region WindowsStore

        [Name("Windows Store Auto Download", "WindowsStore_AutoDownload")]
        [WindowsStorePolicy("Auto Download", "AutoDownload", 2)]
        WindowsStore_AutoDownload = 274,

        [Name("Windows Store Disable OS Upgrade", "WindowsStore_DisableOSUpgrade")]
        [WindowsStorePolicy("Disable OS Upgrade", "DisableOSUpgrade", 1)]
        WindowsStore_DisableOSUpgrade = 275,

        [Name("Windows Store Disable Store Apps", "WindowsStore_DisableStoreApps")]
        [WindowsStorePolicy("Disable Store Apps", "DisableStoreApps")]
        WindowsStore_DisableStoreApps = 276,

        [Name("Windows Store Remove Windows Store", "WindowsStore_RemoveWindowsStore")]
        [WindowsStorePolicy("Remove Windows Store", "RemoveWindowsStore", 1)]
        WindowsStore_RemoveWindowsStore = 277,

        [Name("Windows Store Require Private Store Only", "WindowsStore_RequirePrivateStoreOnly")]
        [WindowsStorePolicy("Require Private Store Only", "RequirePrivateStoreOnly", 1)]
        WindowsStore_RequirePrivateStoreOnly = 278,

        #endregion

        #endregion

        #region CurrentUser

        #region ActiveDesktop

        [Name("Active Desktop NoAdding Components", "ActiveDesktop_NoAddingComponents")]
        [ActiveDesktopPolicy("NoAdding Components", "NoAddingComponents", 1)]
        ActiveDesktop_NoAddingComponents = 279,

        [Name("Active Desktop No Components", "ActiveDesktop_NoComponents")]
        [ActiveDesktopPolicy("No Components", "NoComponents", 1)]
        ActiveDesktop_NoComponents = 280,

        [Name("Active Desktop No Deleting Components", "ActiveDesktop_NoDeletingComponents")]
        [ActiveDesktopPolicy("No Deleting Components", "NoDeletingComponents", 1)]
        ActiveDesktop_NoDeletingComponents = 281,

        [Name("Active Desktop No Editing Components", "ActiveDesktop_NoEditingComponents")]
        [ActiveDesktopPolicy("No Editing Components", "NoEditingComponents", 1)]
        ActiveDesktop_NoEditingComponents = 282,

        #endregion

        #region Attachments

        [Name("Attachments Scan With AntiVirus", "Attachments_ScanWithAntiVirus")]
        [AttachmentsPolicy("Scan With AntiVirus", "ScanWithAntiVirus", 1)]
        Attachments_ScanWithAntiVirus = 283,

        #endregion

        #region Comdlg32

        [Name("Comdlg32 No Back Button", "Comdlg32_NoBackButton")]
        [Comdlg32Policy("No Back Button", "NoBackButton", 1)]
        Comdlg32_NoBackButton = 284,

        [Name("Comdlg32 No File Mru", "Comdlg32_NoFileMru")]
        [Comdlg32Policy("No File Mru", "NoFileMru", 1)]
        Comdlg32_NoFileMru = 285,

        [Name("Comdlg32 No Places Bar", "Comdlg32_NoPlacesBar")]
        [Comdlg32Policy("No Places Bar", "NoPlacesBar", 1)]
        Comdlg32_NoPlacesBar = 286,

        #endregion

        #region Explorer

        [Name("Explorer Always Show Classic Menu", "Explorer_AlwaysShowClassicMenu")]
        [CurUserExplorerPolicy("Always Show Classic Menu", "AlwaysShowClassicMenu", 1)]
        CurUserExplorer_AlwaysShowClassicMenu = 287,

        [Name("Explorer Clear Recent Docs On Exit", "Explorer_ClearRecentDocsOnExit")]
        [CurUserExplorerPolicy("Clear Recent Docs On Exit", "ClearRecentDocsOnExit", 1)]
        CurUserExplorer_ClearRecentDocsOnExit = 288,

        [Name("Explorer Clear Recent Prog For New User In Start Menu", "Explorer_ClearRecentProgForNewUserInStartMenu")]
        [CurUserExplorerPolicy("Clear Recent Prog For New User In Start Menu", "ClearRecentProgForNewUserInStartMenu", 1)]
        CurUserExplorer_ClearRecentProgForNewUserInStartMenu = 289,

        [Name("Explorer Disable Current User Run", "Explorer_DisableCurrentUserRun")]
        [CurUserExplorerPolicy("Disable Current User Run", "DisableCurrentUserRun", 1)]
        CurUserExplorer_DisableCurrentUserRun = 290,

        [Name("Explorer Disable Current User Run Once", "Explorer_DisableCurrentUserRunOnce")]
        [CurUserExplorerPolicy("DisableCurrentUserRunOnce", "DisableCurrentUserRunOnce", 1)]
        CurUserExplorer_DisableCurrentUserRunOnce = 291,

        [Name("Explorer Disable Thumbnails", "Explorer_DisableThumbnails")]
        [CurUserExplorerPolicy("Disable Thumbnails", "DisableThumbnails", 1)]
        CurUserExplorer_DisableThumbnails = 292,

        [Name("Explorer Disable Thumbnails On Network Folders", "Explorer_DisableThumbnailsOnNetworkFolders")]
        [CurUserExplorerPolicy("Disable Thumbnails On Network Folders", "DisableThumbnailsOnNetworkFolders", 1)]
        CurUserExplorer_DisableThumbnailsOnNetworkFolders = 293,

        [Name("Explorer Disallow Run", "Explorer_DisallowRun")]
        [CurUserExplorerPolicy("Disallow Run", "DisallowRun", 1)]
        CurUserExplorer_DisallowRun = 294,

        [Name("Explorer Dont Set Autoplay Checkbox", "Explorer_DontSetAutoplayCheckbox")]
        [CurUserExplorerPolicy("Dont Set Autoplay Checkbox", "DontSetAutoplayCheckbox", 1)]
        CurUserExplorer_DontSetAutoplayCheckbox = 295,

        [Name("Explorer Hide SCA Health", "Explorer_HideSCAHealth")]
        [CurUserExplorerPolicy("Hide SCA Health", "HideSCAHealth", 1)]
        CurUserExplorer_HideSCAHealth = 296,

        [Name("Explorer Hide SCA Network", "Explorer_HideSCANetwork")]
        [CurUserExplorerPolicy("Hide SCA Network", "HideSCANetwork", 1)]
        CurUserExplorer_HideSCANetwork = 297,

        [Name("Explorer Hide SCA Power", "Explorer_HideSCAPower")]
        [CurUserExplorerPolicy("Hide SCA Power", "HideSCAPower", 1)]
        CurUserExplorer_HideSCAPower = 298,

        [Name("Explorer Intellimenus", "Explorer_Intellimenus")]
        [CurUserExplorerPolicy("Intellimenus", "Intellimenus", 1)]
        CurUserExplorer_Intellimenus = 299,

        [Name("Explorer Lock Taskbar", "Explorer_LockTaskbar")]
        [CurUserExplorerPolicy("Lock Taskbar", "LockTaskbar", 1)]
        CurUserExplorer_LockTaskbar = 300,

        [Name("Explorer Max Recent Docs", "Explorer_MaxRecentDocs")]
        [CurUserExplorerPolicy("Max Recent Docs", "MaxRecentDocs")]
        CurUserExplorer_MaxRecentDocs = 301,

        [Name("Explorer No Active Desktop Changes", "Explorer_NoActiveDesktopChanges")]
        [CurUserExplorerPolicy("No Active Desktop Changes", "NoActiveDesktopChanges", 1)]
        CurUserExplorer_NoActiveDesktopChanges = 302,

        [Name("Explorer No Autorun", "Explorer_NoAutorun")]
        [CurUserExplorerPolicy("No Autorun", "NoAutorun", 1)]
        CurUserExplorer_NoAutorun = 303,

        [Name("Explorer No Auto Update", "Explorer_NoAutoUpdate")]
        [CurUserExplorerPolicy("No Auto Update", "NoAutoUpdate")]
        CurUserExplorer_NoAutoUpdate = 304,

        [Name("Explorer No CD Burning", "Explorer_NoCDBurning")]
        [CurUserExplorerPolicy("No CD Burning", "NoCDBurning", 1)]
        CurUserExplorer_NoCDBurning = 305,

        [Name("Explorer No Change Start Menu", "Explorer_NoChangeStartMenu")]
        [CurUserExplorerPolicy("No Change Start Menu", "NoChangeStartMenu", 1)]
        CurUserExplorer_NoChangeStartMenu = 306,

        [Name("Explorer No Close", "Explorer_NoClose")]
        [CurUserExplorerPolicy("No Close", "NoClose", 1)]
        CurUserExplorer_NoClose = 307,

        [Name("Explorer No Close Drag Drop Bands", "Explorer_NoCloseDragDropBands")]
        [CurUserExplorerPolicy("No Close Drag Drop Bands", "NoCloseDragDropBands", 1)]
        CurUserExplorer_NoCloseDragDropBands = 308,

        [Name("Explorer No Common Groups", "Explorer_NoCommonGroups")]
        [CurUserExplorerPolicy("No Common Groups", "NoCommonGroups", 1)]
        CurUserExplorer_NoCommonGroups = 309,

        [Name("Explorer No Computers Near Me", "Explorer_NoComputersNearMe")]
        [CurUserExplorerPolicy("No Computers Near Me", "NoComputersNearMe", 1)]
        CurUserExplorer_NoComputersNearMe = 310,

        [Name("Explorer No Desktop", "Explorer_NoDesktop")]
        [CurUserExplorerPolicy("No Desktop", "NoDesktop", 1)]
        CurUserExplorer_NoDesktop = 311,

        [Name("Explorer No DFS Tab", "Explorer_NoDFSTab")]
        [CurUserExplorerPolicy("No DFS Tab", "NoDFSTab", 1)]
        CurUserExplorer_NoDFSTab = 312,

        [Name("Explorer No Drives", "Explorer_NoDrives")]
        [CurUserExplorerPolicy("No Drives", "NoDrives", 15)]
        CurUserExplorer_NoDrives = 313,

        [Name("Explorer No Favorites Menu", "Explorer_NoFavoritesMenu")]
        [CurUserExplorerPolicy("No Favorites Menu", "NoFavoritesMenu", 1)]
        CurUserExplorer_NoFavoritesMenu = 314,

        [Name("Explorer No File Menu", "Explorer_NoFileMenu")]
        [CurUserExplorerPolicy("No File Menu", "NoFileMenu", 1)]
        CurUserExplorer_NoFileMenu = 315,

        [Name("Explorer No Find", "Explorer_NoFind")]
        [CurUserExplorerPolicy("No Find", "NoFind", 1)]
        CurUserExplorer_NoFind = 316,

        [Name("Explorer No Folder Options", "Explorer_NoFolderOptions")]
        [CurUserExplorerPolicy("No Folder Options", "NoFolderOptions", 1)]
        CurUserExplorer_NoFolderOptions = 317,

        [Name("Explorer No Hardware Tab", "Explorer_NoHardwareTab")]
        [CurUserExplorerPolicy("No Hardware Tab", "NoHardwareTab", 1)]
        CurUserExplorer_NoHardwareTab = 318,

        [Name("Explorer No Instrumentation", "Explorer_NoInstrumentation")]
        [CurUserExplorerPolicy("No Instrumentation", "NoInstrumentation", 1)]
        CurUserExplorer_NoInstrumentation = 319,

        [Name("Explorer No Internet Icon", "Explorer_NoInternetIcon")]
        [CurUserExplorerPolicy("No Internet Icon", "NoInternetIcon", 1)]
        CurUserExplorer_NoInternetIcon = 320,

        [Name("Explorer No Logoff", "Explorer_NoLogoff")]
        [CurUserExplorerPolicy("No Logoff", "NoLogoff", 1)]
        CurUserExplorer_NoLogoff = 321,

        [Name("Explorer No Manage My Computer Verb", "Explorer_NoManageMyComputerVerb")]
        [CurUserExplorerPolicy("No Manage My Computer Verb", "NoManageMyComputerVerb", 1)]
        CurUserExplorer_NoManageMyComputerVerb = 322,

        [Name("Explorer No Moving Bands", "Explorer_NoMovingBands")]
        [CurUserExplorerPolicy("No Moving Bands", "NoMovingBands", 1)]
        CurUserExplorer_NoMovingBands = 323,

        [Name("Explorer No Net Connect Disconnect", "Explorer_NoNetConnectDisconnect")]
        [CurUserExplorerPolicy("No Net Connect Disconnect", "NoNetConnectDisconnect", 1)]
        CurUserExplorer_NoNetConnectDisconnect = 324,

        [Name("Explorer No Net Hood", "Explorer_NoNetHood")]
        [CurUserExplorerPolicy("No Net Hood", "NoNetHood", 1)]
        CurUserExplorer_NoNetHood = 325,

        [Name("Explorer No Network Connections", "Explorer_NoNetworkConnections")]
        [CurUserExplorerPolicy("No Network Connections", "NoNetworkConnections", 1)]
        CurUserExplorer_NoNetworkConnections = 326,

        [Name("Explorer No Preview Pane", "Explorer_NoPreviewPane")]
        [CurUserExplorerPolicy("No Preview Pane", "NoPreviewPane", 1)]
        CurUserExplorer_NoPreviewPane = 327,

        [Name("Explorer No Properties My Computer", "Explorer_NoPropertiesMyComputer")]
        [CurUserExplorerPolicy("No Properties My Computer", "NoPropertiesMyComputer", 1)]
        CurUserExplorer_NoPropertiesMyComputer = 328,

        [Name("Explorer No Properties My Documents", "Explorer_NoPropertiesMyDocuments")]
        [CurUserExplorerPolicy("No Properties My Documents", "NoPropertiesMyDocuments", 1)]
        CurUserExplorer_NoPropertiesMyDocuments = 329,

        [Name("Explorer No Properties Recycle Bin", "Explorer_NoPropertiesRecycleBin")]
        [CurUserExplorerPolicy("No Properties Recycle Bin", "NoPropertiesRecycleBin", 1)]
        CurUserExplorer_NoPropertiesRecycleBin = 330,

        [Name("Explorer No Reading Pane", "Explorer_NoReadingPane")]
        [CurUserExplorerPolicy("No Reading Pane", "NoReadingPane", 1)]
        CurUserExplorer_NoReadingPane = 331,

        [Name("Explorer No Recent Docs History", "Explorer_NoRecentDocsHistory")]
        [CurUserExplorerPolicy("No Recent Docs History", "NoRecentDocsHistory", 1)]
        CurUserExplorer_NoRecentDocsHistory = 332,

        [Name("Explorer No Recent Docs Menu", "Explorer_NoRecentDocsMenu")]
        [CurUserExplorerPolicy("No Recent Docs Menu", "NoRecentDocsMenu", 1)]
        CurUserExplorer_NoRecentDocsMenu = 333,

        [Name("Explorer No Recent Docs Net Hood", "Explorer_NoRecentDocsNetHood")]
        [CurUserExplorerPolicy("No Recent Docs Net Hood", "NoRecentDocsNetHood", 1)]
        CurUserExplorer_NoRecentDocsNetHood = 334,

        [Name("Explorer No Recycle Files", "Explorer_NoRecycleFiles")]
        [CurUserExplorerPolicy("No Recycle Files", "NoRecycleFiles", 1)]
        CurUserExplorer_NoRecycleFiles = 335,

        [Name("Explorer No Run", "Explorer_NoRun")]
        [CurUserExplorerPolicy("No Run", "NoRun", 1)]
        CurUserExplorer_NoRun = 336,

        [Name("Explorer No Run as Install Prompt", "Explorer_NoRunasInstallPrompt")]
        [CurUserExplorerPolicy("No Run as Install Prompt", "NoRunasInstallPrompt", 1)]
        CurUserExplorer_NoRunasInstallPrompt = 337,

        [Name("Explorer No Save Settings", "Explorer_NoSaveSettings")]
        [CurUserExplorerPolicy("No Save Settings", "NoSaveSettings", 1)]
        CurUserExplorer_NoSaveSettings = 338,

        [Name("Explorer No Search Comm In Start Menu", "Explorer_NoSearchCommInStartMenu")]
        [CurUserExplorerPolicy("No Search Comm In Start Menu", "NoSearchCommInStartMenu", 1)]
        CurUserExplorer_NoSearchCommInStartMenu = 339,

        [Name("Explorer No Search Computer Link In Start Menu", "Explorer_NoSearchComputerLinkInStartMenu")]
        [CurUserExplorerPolicy("No Search Computer Link In Start Menu", "NoSearchComputerLinkInStartMenu", 1)]
        CurUserExplorer_NoSearchComputerLinkInStartMenu = 340,

        [Name("Explorer No Search Files In Start Menu", "Explorer_NoSearchFilesInStartMenu")]
        [CurUserExplorerPolicy("No Search Files In Start Menu", "NoSearchFilesInStartMenu", 1)]
        CurUserExplorer_NoSearchFilesInStartMenu = 341,

        [Name("Explorer No Search Internet In Start Menu", "Explorer_NoSearchInternetInStartMenu")]
        [CurUserExplorerPolicy("No Search Internet In Start Menu", "NoSearchInternetInStartMenu", 1)]
        CurUserExplorer_NoSearchInternetInStartMenu = 342,

        [Name("Explorer No Search Programs In Start Menu", "Explorer_NoSearchProgramsInStartMenu")]
        [CurUserExplorerPolicy("No Search Programs In Start Menu", "NoSearchProgramsInStartMenu", 1)]
        CurUserExplorer_NoSearchProgramsInStartMenu = 343,

        [Name("Explorer No Security Tab", "Explorer_NoSecurityTab")]
        [CurUserExplorerPolicy("No Security Tab", "NoSecurityTab", 1)]
        CurUserExplorer_NoSecurityTab = 344,

        [Name("Explorer No Set Folders", "Explorer_NoSetFolders")]
        [CurUserExplorerPolicy("No Set Folders", "NoSetFolders", 1)]
        CurUserExplorer_NoSetFolders = 345,

        [Name("Explorer No Set Taskbar", "Explorer_NoSetTaskbar")]
        [CurUserExplorerPolicy("No Set Taskbar", "NoSetTaskbar", 1)]
        CurUserExplorer_NoSetTaskbar = 346,

        [Name("Explorer No Shared Documents", "Explorer_NoSharedDocuments")]
        [CurUserExplorerPolicy("No Shared Documents", "NoSharedDocuments", 1)]
        CurUserExplorer_NoSharedDocuments = 347,

        [Name("Explorer No Shell Search Button", "Explorer_NoShellSearchButton")]
        [CurUserExplorerPolicy("No Shell Search Button", "NoShellSearchButton", 1)]
        CurUserExplorer_NoShellSearchButton = 348,

        [Name("Explorer No SM Balloon Tip", "Explorer_NoSMBalloonTip")]
        [CurUserExplorerPolicy("No SM Balloon Tip", "NoSMBalloonTip", 1)]
        CurUserExplorer_NoSMBalloonTip = 349,

        [Name("Explorer No SM Configure Programs", "Explorer_NoSMConfigurePrograms")]
        [CurUserExplorerPolicy("No SM Configure Programs", "NoSMConfigurePrograms", 1)]
        CurUserExplorer_NoSMConfigurePrograms = 350,

        [Name("Explorer No SM Help", "Explorer_NoSMHelp")]
        [CurUserExplorerPolicy("NoSMHelp", "NoSMHelp", 1)]
        CurUserExplorer_NoSMHelp = 351,

        [Name("Explorer No SM My Docs", "Explorer_NoSMMyDocs")]
        [CurUserExplorerPolicy("No SM My Docs", "NoSMMyDocs", 1)]
        CurUserExplorer_NoSMMyDocs = 352,

        [Name("Explorer No SM My Pictures", "Explorer_NoSMMyPictures")]
        [CurUserExplorerPolicy("No SM My Pictures", "NoSMMyPictures", 1)]
        CurUserExplorer_NoSMMyPictures = 353,

        [Name("Explorer No Start Menu Eject PC", "Explorer_NoStartMenuEjectPC")]
        [CurUserExplorerPolicy("No Start Menu Eject PC", "NoStartMenuEjectPC", 1)]
        CurUserExplorer_NoStartMenuEjectPC = 354,

        [Name("Explorer No Start Menu MFU programs List", "Explorer_NoStartMenuMFUprogramsList")]
        [CurUserExplorerPolicy("No Start Menu MFU programs List", "NoStartMenuMFUprogramsList", 1)]
        CurUserExplorer_NoStartMenuMFUprogramsList = 355,

        [Name("Explorer No Start Menu More Programs", "Explorer_NoStartMenuMorePrograms")]
        [CurUserExplorerPolicy("No Start Menu More Programs", "NoStartMenuMorePrograms", 1)]
        CurUserExplorer_NoStartMenuMorePrograms = 356,

        [Name("Explorer No Start Menu My Games", "Explorer_NoStartMenuMyGames")]
        [CurUserExplorerPolicy("No Start Menu My Games", "NoStartMenuMyGames", 1)]
        CurUserExplorer_NoStartMenuMyGames = 357,

        [Name("Explorer No Start Menu My Music", "Explorer_NoStartMenuMyMusic")]
        [CurUserExplorerPolicy("No Start Menu My Music", "NoStartMenuMyMusic", 1)]
        CurUserExplorer_NoStartMenuMyMusic = 358,

        [Name("Explorer No Start Menu Network Places", "Explorer_NoStartMenuNetworkPlaces")]
        [CurUserExplorerPolicy("No Start Menu Network Places", "NoStartMenuNetworkPlaces", 1)]
        CurUserExplorer_NoStartMenuNetworkPlaces = 359,

        [Name("Explorer No Start Menu Pinned List", "Explorer_NoStartMenuPinnedList")]
        [CurUserExplorerPolicy("No Start Menu Pinned List", "NoStartMenuPinnedList", 1)]
        CurUserExplorer_NoStartMenuPinnedList = 360,

        [Name("Explorer No Start Menu SubFolders", "Explorer_NoStartMenuSubFolders")]
        [CurUserExplorerPolicy("No Start Menu SubFolders", "NoStartMenuSubFolders", 1)]
        CurUserExplorer_NoStartMenuSubFolders = 361,

        [Name("Explorer No Thumbnail Cache", "Explorer_NoThumbnailCache")]
        [CurUserExplorerPolicy("No Thumbnail Cache", "NoThumbnailCache", 1)]
        CurUserExplorer_NoThumbnailCache = 362,

        [Name("Explorer No Toolbars On Taskbar", "Explorer_NoToolbarsOnTaskbar")]
        [CurUserExplorerPolicy("No Toolbars On Taskbar", "NoToolbarsOnTaskbar", 1)]
        CurUserExplorer_NoToolbarsOnTaskbar = 363,

        [Name("Explorer No Tray Context Menu", "Explorer_NoTrayContextMenu")]
        [CurUserExplorerPolicy("No Tray Context Menu", "NoTrayContextMenu", 1)]
        CurUserExplorer_NoTrayContextMenu = 364,

        [Name("Explorer No User Folder In Start Menu", "Explorer_NoUserFolderInStartMenu")]
        [CurUserExplorerPolicy("No User Folder In Start Menu", "NoUserFolderInStartMenu", 1)]
        CurUserExplorer_NoUserFolderInStartMenu = 365,

        [Name("Explorer No User Name In Start Menu", "Explorer_NoUserNameInStartMenu")]
        [CurUserExplorerPolicy("No User Name In Start Menu", "NoUserNameInStartMenu", 1)]
        CurUserExplorer_NoUserNameInStartMenu = 366,

        [Name("Explorer No View Context Menu", "Explorer_NoViewContextMenu")]
        [CurUserExplorerPolicy("No View Context Menu", "NoViewContextMenu", 1)]
        CurUserExplorer_NoViewContextMenu = 367,

        [Name("Explorer No View On  Drive", "Explorer_NoViewOnDrive")]
        [CurUserExplorerPolicy("No View On Drive", "NoViewOnDrive", 15)]
        CurUserExplorer_NoViewOnDrive = 368,

        [Name("Explorer No Welcome Screen", "Explorer_NoWelcomeScreen")]
        [CurUserExplorerPolicy("No Welcome Screen", "NoWelcomeScreen", 1)]
        CurUserExplorer_NoWelcomeScreen = 369,

        [Name("Explorer No Windows Update", "Explorer_NoWindowsUpdate")]
        [CurUserExplorerPolicy("No Windows Update", "NoWindowsUpdate", 1)]
        CurUserExplorer_NoWindowsUpdate = 370,

        [Name("Explorer No Win Keys", "Explorer_NoWinKeys")]
        [CurUserExplorerPolicy("No Win Keys", "NoWinKeys", 1)]
        CurUserExplorer_NoWinKeys = 371,

        [Name("Explorer Quick Launch Enabled", "Explorer_QuickLaunchEnabled")]
        [CurUserExplorerPolicy("Quick Launch Enabled", "QuickLaunchEnabled")]
        CurUserExplorer_QuickLaunchEnabled = 372,

        [Name("Explorer Restrict Cpl", "Explorer_RestrictCpl")]
        [CurUserExplorerPolicy("Restrict Cpl", "RestrictCpl")]
        CurUserExplorer_RestrictCpl = 373,

        [Name("Explorer Restrict Welcome Center", "Explorer_RestrictWelcomeCenter")]
        [CurUserExplorerPolicy("Restrict Welcome Center", "RestrictWelcomeCenter", 1)]
        CurUserExplorer_RestrictWelcomeCenter = 374,

        [Name("Explorer Settings Page Visibility", "Explorer_SettingsPageVisibility")]
        [CurUserExplorerPolicy("Settings Page Visibility", "SettingsPageVisibility", "showonly:")]
        CurUserExplorer_SettingsPageVisibility = 375,

        [Name("Explorer Start Menu LogOff", "Explorer_StartMenuLogOff")]
        [CurUserExplorerPolicy("Start Menu LogOff", "StartMenuLogOff", 1)]
        CurUserExplorer_StartMenuLogOff = 376,

        [Name("Explorer Taskbar Lock All", "Explorer_TaskbarLockAll")]
        [CurUserExplorerPolicy("Taskbar Lock All", "TaskbarLockAll", 1)]
        CurUserExplorer_TaskbarLockAll = 377,

        [Name("Explorer Taskbar No Add Remove Toolbar", "Explorer_TaskbarNoAddRemoveToolbar")]
        [CurUserExplorerPolicy("Taskbar No Add Remove Toolbar", "TaskbarNoAddRemoveToolbar", 1)]
        CurUserExplorer_TaskbarNoAddRemoveToolbar = 378,

        [Name("Explorer Taskbar No Drag Toolbar", "Explorer_TaskbarNoDragToolbar")]
        [CurUserExplorerPolicy("Taskbar No Drag Toolbar", "TaskbarNoDragToolbar", 1)]
        CurUserExplorer_TaskbarNoDragToolbar = 379,

        [Name("Explorer Taskbar No Notification", "Explorer_TaskbarNoNotification")]
        [CurUserExplorerPolicy("Taskbar No Notification", "TaskbarNoNotification", 1)]
        CurUserExplorer_TaskbarNoNotification = 380,

        [Name("Explorer Taskbar No Redock", "Explorer_TaskbarNoRedock")]
        [CurUserExplorerPolicy("Taskbar No Redock", "TaskbarNoRedock", 1)]
        CurUserExplorer_TaskbarNoRedock = 381,

        [Name("Explorer Taskbar No Resize", "Explorer_TaskbarNoResize")]
        [CurUserExplorerPolicy("Taskbar No Resize", "TaskbarNoResize", 1)]
        CurUserExplorer_TaskbarNoResize = 382,

        [Name("Explorer Disallow Run powershell", "ExplorerDisallowRun_powershell")]
        [CurUserExplorerPolicy("powershell.exe", "1", "powershell.exe")]
        CurUserExplorerDisallowRunPolicy_powershell = 383,

        [Name("Explorer Disallow Run powershell_ise", "ExplorerDisallowRun_powershell_ise")]
        [CurUserExplorerPolicy("powershell_ise.exe", "2", "powershell_ise.exe")]
        CurUserExplorerDisallowRunPolicy_powershell_ise = 384,

        [Name("Explorer Restrict Cpl mmsys.cpl", "ExplorerRestrictCpl_")]
        [CurUserExplorerPolicy("Explorer Restrict Cpl mmsys.cpl", "1", "mmsys.cpl")]
        CurUserExplorerRestrictCplPolicy_mmsys = 385,

        [Name("Explorer WAU Disabled", "ExplorerWAU_Disabled")]
        [CurUserExplorerWAUPolicy("WAU", "Disabled")]
        CurUserExplorer_WAUDisabled = 386,


        [Name("Explorer Clear Tiles On Exit", "Explorer_ClearTilesOnExit")]
        [CurUserWindowsExplorerPolicy("Clear Tiles On Exit", "ClearTilesOnExit", 1)]
        CurUserWindowsExplorer_ClearTilesOnExit = 387,

        [Name("Explorer Disable Context Menus In Start", "Explorer_DisableContextMenusInStart")]
        [CurUserWindowsExplorerPolicy("Disable Context Menus In Start", "DisableContextMenusInStart", 1)]
        CurUserWindowsExplorer_DisableContextMenusInStart = 388,

        [Name("Explorer Disable Notification Center", "Explorer_DisableNotificationCenter")]
        [CurUserWindowsExplorerPolicy("Disable Notification Center", "DisableNotificationCenter", 1)]
        CurUserWindowsExplorer_DisableNotificationCenter = 389,

        [Name("Explorer Disable Search Box Suggestions", "Explorer_DisableSearchBoxSuggestions")]
        [CurUserWindowsExplorerPolicy("Disable Search Box Suggestions", "DisableSearchBoxSuggestions", 1)]
        CurUserWindowsExplorer_DisableSearchBoxSuggestions = 390,

        [Name("Explorer Disable Thumbs DB On Network Folders", "Explorer_DisableThumbsDBOnNetworkFolders")]
        [CurUserWindowsExplorerPolicy("Disable Thumbs DB On Network Folders", "DisableThumbsDBOnNetworkFolders", 1)]
        CurUserWindowsExplorer_DisableThumbsDBOnNetworkFolders = 391,

        [Name("Explorer Enable Legacy Balloon Notifications", "Explorer_EnableLegacyBalloonNotifications")]
        [CurUserWindowsExplorerPolicy("Enable Legacy Balloon Notifications", "EnableLegacyBalloonNotifications", 1)]
        CurUserWindowsExplorer_EnableLegacyBalloonNotifications = 392,

        [Name("Explorer Explorer Ribbon Starts Minimized", "Explorer_ExplorerRibbonStartsMinimized")]
        [CurUserWindowsExplorerPolicy("Explorer Ribbon Starts Minimized", "ExplorerRibbonStartsMinimized", 1)]
        CurUserWindowsExplorer_ExplorerRibbonStartsMinimized = 393,

        [Name("Explorer Hide Content View Mode Snippets", "Explorer_HideContentViewModeSnippets")]
        [CurUserWindowsExplorerPolicy("Hide Content View Mode Snippets", "HideContentViewModeSnippets", 1)]
        CurUserWindowsExplorer_HideContentViewModeSnippets = 394,

        [Name("Explorer Hide People Bar", "Explorer_HidePeopleBar")]
        [CurUserWindowsExplorerPolicy("Hide People Bar", "HidePeopleBar", 1)]
        CurUserWindowsExplorer_HidePeopleBar = 395,

        [Name("Explorer Hide Recently Added Apps", "Explorer_HideRecentlyAddedApps")]
        [CurUserWindowsExplorerPolicy("Hide Recently Added Apps", "HideRecentlyAddedApps", 1)]
        CurUserWindowsExplorer_HideRecentlyAddedApps = 396,

        [Name("Explorer No Autoplay Fornon Volume", "Explorer_NoAutoplayfornonVolume")]
        [CurUserWindowsExplorerPolicy("No Autoplay Fornon Volume", "NoAutoplayfornonVolume", 1)]
        CurUserWindowsExplorer_NoAutoplayfornonVolume = 397,

        [Name("Explorer No Balloon Feature Advertisements", "Explorer_NoBalloonFeatureAdvertisements")]
        [CurUserWindowsExplorerPolicy("No Balloon Feature Advertisements", "NoBalloonFeatureAdvertisements", 1)]
        CurUserWindowsExplorer_NoBalloonFeatureAdvertisements = 398,

        [Name("Explorer No Pinning Store To Taskbar", "Explorer_NoPinningStoreToTaskbar")]
        [CurUserWindowsExplorerPolicy("No Pinning Store To Taskbar", "NoPinningStoreToTaskbar", 1)]
        CurUserWindowsExplorer_NoPinningStoreToTaskbar = 399,

        [Name("Explorer No Pinning To Destinations", "Explorer_NoPinningToDestinations")]
        [CurUserWindowsExplorerPolicy("No Pinning To Destinations", "NoPinningToDestinations", 1)]
        CurUserWindowsExplorer_NoPinningToDestinations = 400,

        [Name("Explorer No Pinning To Taskbar", "Explorer_NoPinningToTaskbar")]
        [CurUserWindowsExplorerPolicy("No Pinning To Taskbar", "NoPinningToTaskbar", 1)]
        CurUserWindowsExplorer_NoPinningToTaskbar = 401,

        [Name("Explorer No Remote Destinations", "Explorer_NoRemoteDestinations")]
        [CurUserWindowsExplorerPolicy("No Remote Destinations", "NoRemoteDestinations", 1)]
        CurUserWindowsExplorer_NoRemoteDestinations = 402,

        [Name("Explorer No Search Everywhere Link In Start Menu", "Explorer_NoSearchEverywhereLinkInStartMenu")]
        [CurUserWindowsExplorerPolicy("No Search Everywhere Link In Start Menu", "NoSearchEverywhereLinkInStartMenu", 1)]
        CurUserWindowsExplorer_NoSearchEverywhereLinkInStartMenu = 403,

        [Name("Explorer No Search Internet Try Harder Button", "Explorer_NoSearchInternetTryHarderButton")]
        [CurUserWindowsExplorerPolicy("No Search Internet Try Harder Button", "NoSearchInternetTryHarderButton", 1)]
        CurUserWindowsExplorer_NoSearchInternetTryHarderButton = 404,

        [Name("Explorer No Start Menu Downloads", "Explorer_NoStartMenuDownloads")]
        [CurUserWindowsExplorerPolicy("No Start Menu Downloads", "NoStartMenuDownloads", 1)]
        CurUserWindowsExplorer_NoStartMenuDownloads = 405,

        [Name("Explorer No Start Menu Homegroup", "Explorer_NoStartMenuHomegroup")]
        [CurUserWindowsExplorerPolicy("No Start Menu Homegroup", "NoStartMenuHomegroup", 1)]
        CurUserWindowsExplorer_NoStartMenuHomegroup = 406,

        [Name("Explorer No Start Menu Recorded TV", "Explorer_NoStartMenuRecordedTV")]
        [CurUserWindowsExplorerPolicy("No Start Menu Recorded TV", "NoStartMenuRecordedTV", 1)]
        CurUserWindowsExplorer_NoStartMenuRecordedTV = 407,

        [Name("Explorer No Start Menu Videos", "Explorer_NoStartMenuVideos")]
        [CurUserWindowsExplorerPolicy("No Start Menu Videos", "NoStartMenuVideos", 1)]
        CurUserWindowsExplorer_NoStartMenuVideos = 408,

        [Name("Explorer No Systray System Promotion", "Explorer_NoSystraySystemPromotion")]
        [CurUserWindowsExplorerPolicy("No Systray System Promotion", "NoSystraySystemPromotion", 1)]
        CurUserWindowsExplorer_NoSystraySystemPromotion = 409,

        [Name("Explorer No Uninstall From Start", "Explorer_NoUninstallFromStart")]
        [CurUserWindowsExplorerPolicy("No Uninstall From Start", "NoUninstallFromStart", 1)]
        CurUserWindowsExplorer_NoUninstallFromStart = 410,

        [Name("Explorer Show Run As Different User In Start", "Explorer_ShowRunAsDifferentUserInStart")]
        [CurUserWindowsExplorerPolicy("Show Run As Different User In Start", "ShowRunAsDifferentUserInStart")]
        CurUserWindowsExplorer_ShowRunAsDifferentUserInStart = 411,

        [Name("Explorer Show Windows Store Apps On Taskbar", "Explorer_ShowWindowsStoreAppsOnTaskbar")]
        [CurUserWindowsExplorerPolicy("Show Windows Store Apps On Taskbar", "ShowWindowsStoreAppsOnTaskbar", 2)]
        CurUserWindowsExplorer_ShowWindowsStoreAppsOnTaskbar = 412,

        [Name("Explorer Taskbar No Pinned List", "Explorer_TaskbarNoPinnedList")]
        [CurUserWindowsExplorerPolicy("Taskbar No Pinned List", "TaskbarNoPinnedList", 1)]
        CurUserWindowsExplorer_TaskbarNoPinnedList = 413,

        #endregion

        #region Network

        [Name("Network No Entire Network", "Network_NoEntireNetwork")]
        [NetworkPolicy("No Entire Network", "NoEntireNetwork", 1)]
        Network_NoEntireNetwork = 414,

        [Name("Network Connections Allow Advanced TCPIP Config", "NetworkConnections_NC_AllowAdvancedTCPIPConfig")]
        [NetworkConnectionsPolicy("Allow Advanced TCPIP Config", "NC_AllowAdvancedTCPIPConfig")]
        NetworkConnectionsPolicy_NC_AllowAdvancedTCPIPConfig = 415,

        [Name("Network Connections New Connection Wizard", "NetworkConnections_NC_NewConnectionWizard")]
        [NetworkConnectionsPolicy("New Connection Wizard", "NC_NewConnectionWizard")]
        NetworkConnectionsPolicy_NC_NewConnectionWizard = 416,    

        #endregion

        #region NonEnum

        [Name("NonEnum Remove Computer icon on the desktop", "NonEnum_RemoveComputerIconOnTheDesktop")]
        [NonEnumPolicy("NonEnum Remove Computer icon on the desktop", "{20D04FE0-3AEA-1069-A2D8-08002B30309D}", 1)]
        NonEnum_RemoveComputerIconOnTheDesktop = 417,

        [Name("NonEnum Remove My Documents icon on the desktop", "NonEnum_RemoveMyDocumentsIconOnnheDesktop")]
        [NonEnumPolicy("NonEnum Remove My Documents icon on the desktop", "{450D8FBA-AD25-11D0-98A8-0800361B1103}", 1)]
        NonEnum_RemoveMyDocumentsIconOnnheDesktop = 418,

        [Name("NonEnum Remove Recycle Bin icon from desktop", "NonEnum_RemoveRecycleBinIconFromDesktop")]
        [NonEnumPolicy("NonEnum Remove Recycle Bin icon from desktop", "{645FF040-5081-101B-9F08-00AA002F954E}", 1)]
        NonEnum_RemoveRecycleBinIconFromDesktop = 419,

        #endregion

        #region System

        [Name("System Disable Change Password", "System_DisableChangePassword")]
        [CurUserSystemPolicy("Disable Change Password", "DisableChangePassword", 1)]
        CurUserSystem_DisableChangePassword = 420,

        [Name("System Disable Lock Workstation", "System_DisableLockWorkstation")]
        [CurUserSystemPolicy("Disable Lock Workstation", "DisableLockWorkstation", 1)]
        CurUserSystem_DisableLockWorkstation = 421,

        [Name("System Disable Registry Tools", "System_DisableRegistryTools")]
        [CurUserSystemPolicy("Disable Registry Tools", "DisableRegistryTools", 2)]
        CurUserSystem_DisableRegistryTools = 422,

        [Name("System Disable Task Mgr", "System_DisableTaskMgr")]
        [CurUserSystemPolicy("Disable Task Mgr", "DisableTaskMgr", 1)]
        CurUserSystem_DisableTaskMgr = 423,

        [Name("System Disable CMD", "System_DisableCMD")]
        [CurUserWindowsSystemPolicy("Disable CMD", "DisableCMD", 2)]
        CurUserWindowsSystemPolicy_DisableCMD = 424,


        #endregion

        #region Windows

        [Name("Windows TurnOffWinCal", "CurUserWindows_TurnOffWinCal")]
        [CurUserWindowsPolicyAttribute("Turn Off WinCal", "TurnOffWinCal", 1)]
        CurUserWindows_TurnOffWinCal = 425,

        [Name("Windows Prevent Run", "CurUserWindows_PreventRun")]
        [CurUserWindowsMessangerPolicy("Prevent Run", "PreventRun", 1)]
        CurUserWindows_PreventRun = 426,

        [Name("Windows Sound Recorder", "CurUserWindowsSoundRecorder_")]
        [CurUserWindowsSoundRecorderPolicy("Sound Recorder", "Soundrec", 1)]
        CurUserWindowsSoundRecorder_Soundrec = 427,

        [Name("Windows Cloud Content Disable Windows Spotlight Features", "CurUserWindowsCloudContent_DisableWindowsSpotlightFeatures")]
        [CurUserWindowsCloudContentPolicy("Disable Windows Spotlight Features", "DisableWindowsSpotlightFeatures", 1)]
        CurUserWindowsCloudContent_DisableWindowsSpotlightFeatures = 428,

        [Name("Windows Cloud Content Disable Windows Spotlight Windows Welcome Experience", "CurUserWindowsCloudContent_DisableWindowsSpotlightWindowsWelcomeExperience")]
        [CurUserWindowsCloudContentPolicy("Disable Windows Spotlight Windows Welcome Experience", "DisableWindowsSpotlightWindowsWelcomeExperience", 1)]
        CurUserWindowsCloudContent_DisableWindowsSpotlightWindowsWelcomeExperience = 429,

        [Name("Windows CredUI Disable Password Reveal", "CurUserWindowsCredUI_DisablePasswordReveal")]
        [CurUserWindowsCredUIPolicy("Disable Password Reveal", "DisablePasswordReveal", 1)]
        CurUserWindowsCredUI_DisablePasswordReveal = 430,

        #endregion

        #region MMC

        [Name("MMCPolicy Restrict Author Mode", "MMCPolicy_RestrictAuthorMode")]
        [MMCPolicy("Restrict Author Mode", "RestrictAuthorMode", 1)]
        MMCPolicy_RestrictAuthorMode = 431,

        [Name("MMCPolicy Restrict To Permitted Snapins", "MMCPolicy_RestrictToPermittedSnapins")]
        [MMCPolicy("Restrict To Permitted Snapins", "RestrictToPermittedSnapins", 1)]
        MMCPolicy_RestrictToPermittedSnapins = 432,

        [Name("MMC Policy Restrict Security Configuration and Analysis", "MMCPolicyRestrict_SecurityConfigurationAndAnalysis")]
        [MMCSecurityConfigurationAndAnalysisPolicy("MMC Policy Restrict Security Configuration and Analysis", "Restrict_Run", 1)]
        MMCPolicy_SecurityConfigurationAndAnalysis = 433,

        [Name("MMC Policy Restrict SMTP Protocol", "MMCPolicyRestrict_SMTPProtocol")]
        [MMCSMTPProtocolPolicy("MMC Policy Restrict SMTP Protocol", "Restrict_Run", 1)]
        MMCPolicy_SMTPProtocol = 434,

        [Name("MMC Policy Restrict System Properties", "MMCPolicyRestrict_SystemProperties")]
        [MMCSystemPropertiesPolicy("MMC Policy Restrict System Properties", "Restrict_Run", 1)]
        MMCPolicy_SystemProperties = 435,

        [Name("MMC Policy Restrict Administrative Templates (Users)", "MMCPolicyRestrict_AdministrativeTemplatesUsers")]
        [MMCAdministrativeTemplatesUsersMainPolicy("MMC Policy Restrict Administrative Templates (Users)", "Restrict_Run")]
        MMCPolicy_AdministrativeTemplatesUsers = 436,

        [Name("MMC Policy Restrict Administrative Templates (Users) (1)", "MMCPolicyRestrict_AdministrativeTemplatesUsers1")]
        [MMCAdministrativeTemplatesUsers1Policy("MMC Policy Restrict Administrative Templates (Users) (1)", "Restrict_Run")]
        MMCPolicy_AdministrativeTemplatesUsers1 = 437,

        [Name("MMC Policy Restrict Administrative Templates (Users) (2)", "MMCPolicyRestrict_AdministrativeTemplatesUsers2")]
        [MMCAdministrativeTemplatesUsers2Policy("MMC Policy Restrict Administrative Templates (Users) (2)", "Restrict_Run")]
        MMCPolicy_AdministrativeTemplatesUsers2 = 438,

        [Name("MMC Policy Restrict .Net Framework Configuration", "MMCPolicyRestrict_NetFrameworkConfiguration")]
        [MMCNetFrameworkConfigurationPolicy("MMC Policy Restrict .Net Framework Configuration", "Restrict_Run", 1)]
        MMCPolicy_NetFrameworkConfiguration = 439,

        [Name("MMC Policy Restrict Routing and Remote Access", "MMCPolicyRestrict_RoutingandRemoteAccess")]
        [MMCRoutingandRemoteAccessPolicy("MMC Policy Restrict Routing and Remote Access", "Restrict_Run", 1)]
        MMCPolicy_RoutingandRemoteAccess = 440,

        [Name("MMC Policy Restrict AppleTalk Routing", "MMCPolicyRestrict_AppleTalkRouting")]
        [MMCAppleTalkRoutingPolicy("MMC Policy Restrict AppleTalk Routing", "Restrict_Run", 1)]
        MMCPolicy_AppleTalkRouting = 441,

        [Name("MMC Policy Restrict ADSI Edit", "MMCPolicyRestrict_ADSIEdit")]
        [MMCADSIEditPolicy("MMC Policy Restrict ADSI Edit", "Restrict_Run", 1)]
        MMCPolicy_ADSIEdit = 442,

        [Name("MMC Policy Restrict Authorization Manager", "MMCPolicyRestrict_AuthorizationManager")]
        [MMCAuthorizationManagerPolicy("MMC Policy Restrict Authorization Manager", "Restrict_Run", 1)]
        MMCPolicy_AuthorizationManager = 443,

        [Name("MMC Policy Restrict Wireless Monitor", "MMCPolicyRestrict_WirelessMonitor")]
        [MMCWirelessMonitorPolicy("MMC Policy Restrict Wireless Monitor", "Restrict_Run", 1)]
        MMCPolicy_WirelessMonitor = 444,

        [Name("MMC Policy Restrict Removable Storage", "MMCPolicyRestrict_RemovableStorage")]
        [MMCRemovableStoragePolicy("MMC Policy Restrict Removable Storage", "Restrict_Run", 1)]
        MMCPolicy_RemovableStorage = 445,

        [Name("MMC Policy RestrictIAS Logging ", "MMCPolicyRestrict_IASLogging")]
        [MMCIASLoggingPolicy("MMC Policy Restrict IAS Logging", "Restrict_Run", 1)]
        MMCPolicy_IASLogging = 446,

        [Name("MMC Policy Restrict Public Key Policies", "MMCPolicyRestrict_PublicKeyPolicies")]
        [MMCPublicKeyPoliciesPolicy("MMC Policy Restrict Public Key Policies", "Restrict_Run", 1)]
        MMCPolicy_PublicKeyPolicies = 447,

        [Name("MMC Policy Restrict Event Viewer", "MMCPolicyRestrict_EventViewer")]
        [MMCEventViewerPolicy("MMC Policy Restrict Event Viewer", "Restrict_Run", 1)]
        MMCPolicy_EventViewer = 448,

        [Name("MMC Policy Restrict Event Viewer (2)", "MMCPolicyRestrict_EventViewer2")]
        [MMCEventViewer2Policy("MMC Policy Restrict Event Viewer (2)", "Restrict_Run", 1)]
        MMCPolicy_EventViewer2 = 449,

        [Name("MMC Policy Restrict Removable Storage Management", "MMCPolicyRestrict_RemovableStorageManagement")]
        [MMCRemovableStorageManagementPolicy("MMC Policy Restrict Removable Storage Management", "Restrict_Run", 1)]
        MMCPolicy_RemovableStorageManagement = 450,

        [Name("MMC Policy Restrict Remote Desktops", "MMCPolicyRestrict_RemoteDesktops")]
        [MMCRemoteDesktopsPolicy("MMC Policy Restrict Remote Desktops", "Restrict_Run", 1)]
        MMCPolicy_RemoteDesktops = 451,

        [Name("MMC Policy Restrict Certification Authority Policy Settings", "MMCPolicyRestrict_CertificationAuthorityPolicySettings")]
        [MMCCertificationAuthorityPolicySettingsPolicy("MMC Policy Restrict Certification Authority Policy Settings", "Restrict_Run", 1)]
        MMCPolicy_CertificationAuthorityPolicySettings = 452,

        [Name("MMC Policy Restrict Disk Defragmenter", "MMCPolicyRestrict_DiskDefragmenter")]
        [MMCDiskDefragmenterPolicy("MMC Policy Restrict Disk Defragmenter", "Restrict_Run", 1)]
        MMCPolicy_DiskDefragmenter = 453,

        [Name("MMC Policy Restrict System Information", "MMCPolicyRestrict_SystemInformation")]
        [MMCSystemInformationPolicy("MMC Policy Restrict System Information", "Restrict_Run", 1)]
        MMCPolicy_SystemInformation = 454,

        [Name("MMC Policy Restrict Certificates", "MMCPolicyRestrict_Certificates")]
        [MMCCertificatesPolicy("MMC Policy Restrict Certificates", "Restrict_Run", 1)]
        MMCPolicy_Certificates = 455,

        [Name("MMC Policy Restrict IP Security Monitor", "MMCPolicyRestrict_IPSecurityMonitor")]
        [MMCIPSecurityMonitorPolicy("MMC Policy Restrict IP Security Monitor", "Restrict_Run", 1)]
        MMCPolicy_IPSecurityMonitor = 456,

        [Name("MMC Policy Restrict Shared Folders", "MMCPolicyRestrict_SharedFolders")]
        [MMCSharedFoldersPolicy("MMC Policy Restrict SharedFolders", "Restrict_Run", 1)]
        MMCPolicy_SharedFolders = 457,

        [Name("MMC Policy Restrict Services", "MMCPolicyRestrict_Services")]
        [MMCServicesPolicy("MMC Policy Restrict Services", "Restrict_Run", 1)]
        MMCPolicy_Services = 458,

        [Name("MMC Policy Restrict Computer Management", "MMCPolicyRestrict_ComputerManagement")]
        [MMCComputerManagementPolicy("MMC Policy Restrict Computer Management", "Restrict_Run", 1)]
        MMCPolicy_ComputerManagement = 459,

        [Name("MMC Policy Restrict Shared Folders Ext", "MMCPolicyRestrict_SharedFoldersExt")]
        [MMCSharedFoldersExtPolicy("MMC Policy Restrict Shared Folders Ext", "Restrict_Run", 1)]
        MMCPolicy_SharedFoldersExt = 460,

        [Name("MMC Policy Restrict Remote Access", "MMCPolicyRestrict_RemoteAccess")]
        [MMCRemoteAccessPolicy("MMC Policy Restrict Remote Access", "Restrict_Run", 1)]
        MMCPolicy_RemoteAccess = 461,

        [Name("MMC Policy Restrict Security Templates", "MMCPolicyRestrict_SecurityTemplates")]
        [MMCSecurityTemplatesPolicy("MMC Policy Restrict Security Templates", "Restrict_Run", 1)]
        MMCPolicy_SecurityTemplates = 462,

        [Name("MMC Policy Restrict WMI Control", "MMCPolicyRestrict_WMIControl")]
        [MMCWMIControlPolicy("MMC Policy Restrict WMI Control", "Restrict_Run", 1)]
        MMCPolicy_WMIControl = 463,

        [Name("MMC Policy Restrict Local Users and Groups", "MMCPolicyRestrict_LocalUsersandGroups")]
        [MMCLocalUsersandGroupsPolicy("MMC Policy Restrict Local Users and Groups", "Restrict_Run", 1)]
        MMCPolicy_LocalUsersandGroups = 464,

        [Name("MMC Policy Restrict Enterprise PKI", "MMCPolicyRestrict_EnterprisePKI")]
        [MMCEnterprisePKIPolicy("MMC Policy Restrict Enterprise PKI", "Restrict_Run", 1)]
        MMCPolicy_EnterprisePKI = 465,

        [Name("MMC Policy Restrict Distributed File System", "MMCPolicyRestrict_DistributedFileSystem")]
        [MMCDistributedFileSystemPolicy("MMC Policy Restrict Distributed File System", "Restrict_Run", 1)]
        MMCPolicy_DistributedFileSystem = 466,

        [Name("MMC Policy Restrict Logical and Mapped Drives", "MMCPolicyRestrict_LogicalandMappedDrives")]
        [MMCLogicalandMappedDrivesPolicy("MMC Policy Restrict Logical and Mapped Drives", "Restrict_Run", 1)]
        MMCPolicy_LogicalandMappedDrives = 467,

        [Name("MMC Policy Restrict Device Manager", "MMCPolicyRestrict_DeviceManager")]
        [MMCDeviceManagerPolicy("MMC Policy Restrict Device Manager", "Restrict_Run", 1)]
        MMCPolicy_DeviceManager = 468,

        [Name("MMC Policy Restrict Device Manager (2)", "MMCPolicyRestrict_DeviceManager2")]
        [MMCDeviceManager2Policy("MMC Policy Restrict Device Manager (2)", "Restrict_Run", 1)]
        MMCPolicy_DeviceManager2 = 469,

        [Name("MMC Policy Restrict Performance Logs and Alerts", "MMCPolicyRestrict_PerformanceLogsandAlerts")]
        [MMCPerformanceLogsandAlertsPolicy("MMC Policy Restrict Performance Logs and Alerts", "Restrict_Run", 1)]
        MMCPolicy_PerformanceLogsandAlerts = 470,

        [Name("MMC Policy Restrict FAX Service", "MMCPolicyRestrict_FAXService")]
        [MMCFAXServicePolicy("MMC Policy Restrict FAX Service", "Restrict_Run", 1)]
        MMCPolicy_FAXService = 471,

        [Name("MMC Policy Restrict SNMP", "MMCPolicyRestrict_SNMP")]
        [MMCSNMPPolicy("MMC Policy Restrict SNMP", "Restrict_Run", 1)]
        MMCPolicy_SNMP = 472,

        [Name("MMC Policy Restrict Disk Management", "MMCPolicyRestrict_DiskManagement")]
        [MMCDiskManagementPolicy("MMC Policy Restrict Disk Management", "Restrict_Run", 1)]
        MMCPolicy_DiskManagement = 473,

        [Name("MMC Policy Restrict IAS", "MMCPolicyRestrict_IAS")]
        [MMCIASPolicy("MMC Policy Restrict IAS", "Restrict_Run", 1)]
        MMCPolicy_IAS = 474,

        [Name("MMC Policy Restrict Group Policy Object Editor", "MMCPolicyRestrict_GroupPolicyObjectEditor")]
        [MMCGroupPolicyObjectEditorPolicy("MMC Policy Restrict Group Policy Object Editor", "Restrict_Run", 1)]
        MMCPolicy_GroupPolicyObjectEditor = 475,

        [Name("MMC Policy Restrict IPX Routing", "MMCPolicyRestrict_IPXRouting")]
        [MMCIPXRoutingPolicy("MMC Policy Restrict IPX Routing", "Restrict_Run", 1)]
        MMCPolicy_IPXRouting = 476,

        [Name("MMC Policy Restrict IPX RIP Routing", "MMCPolicyRestrict_IPXRIPRouting")]
        [MMCIPXRIPRoutingPolicy("MMC Policy Restrict IPX RIP Routing", "Restrict_Run", 1)]
        MMCPolicy_IPXRIPRouting = 477,

        [Name("MMC Policy Restrict IPX SAP Routing", "MMCPolicyRestrict_IPXSAPRouting")]
        [MMCIPXSAPRoutingPolicy("MMC Policy Restrict IPX SAP Routing", "Restrict_Run", 1)]
        MMCPolicy_IPXSAPRouting = 478,

        [Name("MMC Policy Restrict Indexing Service", "MMCPolicyRestrict_IndexingService")]
        [MMCIndexingServicePolicy("MMC Policy Restrict Indexing Service", "Restrict_Run", 1)]
        MMCPolicy_IndexingService = 479,

        [Name("MMC Policy Restrict DCOM Configuration Extension", "MMCPolicyRestrict_DCOMConfigurationExtension")]
        [MMCDCOMConfigurationExtensionPolicy("MMC Policy Restrict DCOM Configuration Extension", "Restrict_Run", 1)]
        MMCPolicy_DCOMConfigurationExtension = 480,

        [Name("MMC Policy Restrict Internet Information Services", "MMCPolicyRestrict_InternetInformationServices")]
        [MMCInternetInformationServicesPolicy("MMC Policy Restrict Internet Information Services", "Restrict_Run", 1)]
        MMCPolicy_InternetInformationServices = 481,

        [Name("MMC Policy Restrict Certificate Templates", "MMCPolicyRestrict_CertificateTemplates")]
        [MMCCertificateTemplatesPolicy("MMC Policy Restrict Certificate Templates", "Restrict_Run", 1)]
        MMCPolicy_CertificateTemplates = 482,

        [Name("MMC Policy Restrict Send Console Message", "MMCPolicyRestrict_SendConsoleMessage")]
        [MMCSendConsoleMessagePolicy("MMC Policy Restrict Send Console Message", "Restrict_Run", 1)]
        MMCPolicy_SendConsoleMessage = 483,

        [Name("MMC Policy Restrict RAS Dialin - User Node", "MMCPolicyRestrict_RASDialinUserNode")]
        [MMCRASDialinUserNodePolicy("MMC Policy Restrict RAS Dialin - User Node", "Restrict_Run", 1)]
        MMCPolicy_RASDialinUserNode = 484,

        [Name("MMC Policy Restrict Extended View (Web View)", "MMCPolicyRestrict_ExtendedView")]
        [MMCExtendedViewPolicy("MMC Policy Restrict Extended View (Web View)", "Restrict_Run", 1)]
        MMCPolicy_ExtendedView = 485,

        [Name("MMC Policy Restrict Remote Desktop Services Configuration", "MMCPolicyRestrict_RemoteDesktopServicesConfiguration")]
        [MMCRemoteDesktopServicesConfigurationPolicy("MMC Policy Restrict Remote Desktop Services Configuration", "Restrict_Run", 1)]
        MMCPolicy_RemoteDesktopServicesConfiguration = 486,

        [Name("MMC Policy Restrict Service Dependencies", "MMCPolicyRestrict_ServiceDependencies")]
        [MMCServiceDependenciesPolicy("MMC Policy Restrict Service Dependencies", "Restrict_Run", 1)]
        MMCPolicy_ServiceDependencies = 487,

        [Name("MMC Policy Restrict IP Routing", "MMCPolicyRestrict_IPRouting")]
        [MMCIPRoutingPolicy("MMC Policy Restrict IP Routing", "Restrict_Run", 1)]
        MMCPolicy_IPRouting = 488,

        [Name("MMC Policy Restrict DHCP Relay Management", "MMCPolicyRestrict_DHCPRelayManagement")]
        [MMCDHCPRelayManagementPolicy("MMC Policy Restrict DHCP Relay Management", "Restrict_Run", 1)]
        MMCPolicy_DHCPRelayManagement = 489,

        [Name("MMC Policy Restrict RIP Routing", "MMCPolicyRestrict_RIPRouting")]
        [MMCRIPRoutingPolicy("MMC Policy Restrict RIP Routing", "Restrict_Run", 1)]
        MMCPolicy_RIPRouting = 490,

        [Name("MMC Policy Restrict OSPF Routing", "MMCPolicyRestrict_OSPFRouting")]
        [MMCOSPFRoutingPolicy("MMC Policy Restrict OSPF Routing", "Restrict_Run", 1)]
        MMCPolicy_OSPFRouting = 491,

        [Name("MMC Policy Restrict IGMP Routing", "MMCPolicyRestrict_IGMPRouting")]
        [MMCIGMPRoutingPolicy("MMC Policy Restrict IGMP Routing", "Restrict_Run", 1)]
        MMCPolicy_IGMPRouting = 492,

        [Name("MMC Policy Restrict Connection Sharing (NAT)", "MMCPolicyRestrict_ConnectionSharing")]
        [MMCConnectionSharingPolicy("MMC Policy Restrict Connection Sharing (NAT)", "Restrict_Run", 1)]
        MMCPolicy_ConnectionSharing = 493,

        [Name("MMC Policy Restrict ActiveX Control", "MMCPolicyRestrict_ActiveXControl")]
        [MMCActiveXControlPolicy("MMC Policy Restrict ActiveX Control", "Restrict_Run", 1)]
        MMCPolicy_ActiveXControl = 494,

        [Name("MMC Policy Restrict Link to Web Address", "MMCPolicyRestrict_LinktoWebAddress")]
        [MMCLinktoWebAddressPolicy("MMC Policy Restrict Link to Web Address", "Restrict_Run", 1)]
        MMCPolicy_LinktoWebAddress = 495,

        [Name("MMC Policy Restrict Component Services", "MMCPolicyRestrict_ComponentServices")]
        [MMCComponentServicesPolicy("MMC Policy Restrict Component Services", "Restrict_Run", 1)]
        MMCPolicy_ComponentServices = 496,

        [Name("MMC Policy Restrict Active Directory Sites and Services", "MMCPolicyRestrict_ActiveDirectorySitesandServices")]
        [MMCActiveDirectorySitesandServicesPolicy("MMC Policy Restrict Active Directory Sites and Services", "Restrict_Run", 1)]
        MMCPolicy_ActiveDirectorySitesandServices = 497,

        [Name("MMC Policy Restrict Routing", "MMCPolicyRestrict_Routing")]
        [MMCRoutingPolicy("MMC Policy Restrict Routing", "Restrict_Run", 1)]
        MMCPolicy_Routing = 498,

        [Name("MMC Policy Restrict Certification Authority", "MMCPolicyRestrict_CertificationAuthority")]
        [MMCCertificationAuthorityPolicy("MMC Policy Restrict Certification Authority", "Restrict_Run", 1)]
        MMCPolicy_CertificationAuthority = 499,

        [Name("MMC Policy Restrict IP Security Policy Management", "MMCPolicyRestrict_IPSecurityPolicyManagement")]
        [MMCIPSecurityPolicyManagementPolicy("MMC Policy Restrict IP Security Policy Management", "Restrict_Run", 1)]
        MMCPolicy_IPSecurityPolicyManagement = 500,

        [Name("MMC Policy Restrict Group Policy Management", "MMCPolicyRestrict_GroupPolicyManagement")]
        [MMCGroupPolicyManagementPolicy("MMC Policy Restrict Group Policy Management", "Restrict_Run", 1)]
        MMCPolicy_GroupPolicyManagement = 501,

        [Name("MMC Policy Restrict Telephony", "MMCPolicyRestrict_Telephony")]
        [MMCTelephonyPolicy("MMC Policy Restrict Telephony", "Restrict_Run", 1)]
        MMCPolicy_Telephony = 502,

        [Name("MMC Policy Restrict Active Directory Users and Computers", "MMCPolicyRestrict_ActiveDirectoryUsersandComputers")]
        [MMCActiveDirectoryUsersComputersPolicy("MMC Policy Restrict Active Directory Users and Computers", "Restrict_Run", 1)]
        MMCPolicy_ActiveDirectoryUsersandComputers = 503,

        [Name("MMC Policy Restrict Active Directory Domains and Trusts", "MMCPolicyRestrict_ActiveDirectoryDomainsandTrusts")]
        [MMCActiveDirectoryDomainsTrustsPolicy("MMC Policy Restrict Active Directory Domains and Trusts", "Restrict_Run", 1)]
        MMCPolicy_ActiveDirectoryDomainsandTrusts = 504,

        [Name("MMC Policy Restrict QoS Admission Control", "MMCPolicyRestrict_QoSAdmissionControl")]
        [MMCQoSAdmissionControlPolicy("MMC Policy Restrict QoS Admission Control", "Restrict_Run", 1)]
        MMCPolicy_QoSAdmissionControl = 505,

        [Name("MMC Policy Restrict FrontPage Server Extensions", "MMCPolicyRestrict_FrontPageServerExtensions")]
        [MMCFrontPageServerExtensionsPolicy("MMC Policy Restrict FrontPage Server Extensions", "Restrict_Run", 1)]
        MMCPolicy_FrontPageServerExtensions = 506,

        [Name("MMC Policy Restrict Server Manager", "MMCPolicyRestrict_ServerManager")]
        [MMCFXServerManagerPolicy("MMC Policy Restrict Server Manager", "Restrict_Run", 1)]
        MMCFXPolicy_ServerManager = 507,

        [Name("MMC Policy Restrict Network Policy Server", "MMCPolicyRestrict_NetworkPolicyServer")]
        [MMCFXNetworkPolicyServerPolicy("MMC Policy Restrict ", "Restrict_Run", 1)]
        MMCFXPolicy_NetworkPolicyServer = 508,

        [Name("MMC Policy Restrict Online Responder", "MMCPolicyRestrict_OnlineResponder")]
        [MMCFXOnlineResponderPolicy("MMC Policy Restrict Online Responder", "Restrict_Run", 1)]
        MMCFXPolicy_OnlineResponder = 509,

        [Name("MMC Policy Restrict TPM Management", "MMCPolicyRestrict_TPMManagement")]
        [MMCFXTPMManagementPolicy("MMC Policy Restrict TPM Management", "Restrict_Run", 1)]
        MMCFXPolicy_TPMManagement = 510,

        [Name("MMC Policy Restrict Health Registration Authority", "MMCPolicyRestrict_HealthRegistrationAuthority")]
        [MMCFXHealthRegistrationAuthorityPolicy("MMC Policy Restrict Health Registration Authority", "Restrict_Run", 1)]
        MMCFXPolicy_HealthRegistrationAuthority = 511,

        [Name("MMC Policy Restrict NAP Client Configuration", "MMCPolicyRestrict_NAPClientConfiguration")]
        [MMCFXNAPClientConfigurationPolicy("MMC Policy Restrict NAP Client Configuration", "Restrict_Run", 1)]
        MMCFXPolicy_NAPClientConfiguration = 512,

        [Name("MMC Policy Restrict Windows Firewall with Advanced Security", "MMCPolicyRestrict_WindowsFirewallwithAdvancedSecurity")]
        [MMCFXWindowsFirewallAdvancedSecurityPolicy("MMC Policy Restrict Windows Firewall with Advanced Security", "Restrict_Run", 1)]
        MMCFXPolicy_WindowsFirewallwithAdvancedSecurity = 513,

        [Name("MMC Policy Restrict Failover Clusters Manager", "MMCPolicyRestrict_FailoverClustersManager")]
        [MMCFXFailoverClustersManagerPolicy("MMC Policy Restrict Failover Clusters Manager", "Restrict_Run", 1)]
        MMCFXPolicy_FailoverClustersManager = 514,

        #endregion

        #region PowerShell

        [Name("PowerShell Enable Scripts", "PowerShell_EnableScripts")]
        [PowerShellPolicy("Enable Scripts", "EnableScripts", 1)]
        PowerShellPolicy_EnableScripts = 515,

        [Name("PowerShell Execution Policy", "PowerShell_ExecutionPolicy")]
        [PowerShellPolicy("Execution Policy", "ExecutionPolicy", "AllSigned")]
        PowerShellPolicy_ExecutionPolicy = 516,

        #endregion

        #region TaskScheduler

        [Name("Task Scheducler Allow Browse", "TaskScheducler_AllowBrowse")]
        [TaskSchedulerPolicy("Allow Browse", "Allow Browse", 1)]
        TaskScheduclerPolicy_AllowBrowse = 517,

        [Name("Task Scheducler Task Creation", "TaskScheducler_TaskCreation")]
        [TaskSchedulerPolicy("Task Creation", "Task Creation", 1)]
        TaskScheduclerPolicy_TaskCreation = 518,

        #endregion

        #region WindowsErrorReporting

        [Name("Windows Error Reporting Disabled", "WindowsErrorReporting_Disabled")]
        [WindowsErrorReportingPolicy("Windows Error Reporting Disabled", "Disabled", 1)]
        WindowsErrorReportingPolicy_WindowsErrorReporting = 519,

        [Name("Windows Error Reporting Dont Send Additional Data", "WindowsErrorReporting_DontSendAdditionalData")]
        [WindowsErrorReportingPolicy("Dont Send Additional Data", "DontSendAdditionalData", 1)]
        WindowsErrorReportingPolicy_DontSendAdditionalData = 520,

        [Name("Windows Error Reporting Logging Disabled", "WindowsErrorReporting_LoggingDisabled")]
        [WindowsErrorReportingPolicy("Logging Disabled", "LoggingDisabled", 1)]
        WindowsErrorReportingPolicy_LoggingDisabled = 521,

        #endregion

        #region WindowsMediaPlayer

        [Name("Windows Media Player Prevent CD DVD Metadata Retrieval", "WindowsMediaPlayer_PreventCDDVDMetadataRetrieval")]
        [WindowsMediaPlayerPolicy("Prevent CD DVD Metadata Retrieval", "PreventCDDVDMetadataRetrieval", 1)]
        WindowsMediaPlayerPolicy_PreventCDDVDMetadataRetrieval = 522,

        [Name("Windows Media Player Prevent Codec Download", "WindowsMediaPlayer_PreventCodecDownload")]
        [WindowsMediaPlayerPolicy("Prevent Codec Download", "PreventCodecDownload", 1)]
        WindowsMediaPlayerPolicy_PreventCodecDownload = 523,

        [Name("Windows Media Player Prevent Music File Metadata Retrieval", "WindowsMediaPlayer_PreventMusicFileMetadataRetrieval")]
        [WindowsMediaPlayerPolicy("Prevent Music File Metadata Retrieval", "PreventMusicFileMetadataRetrieval", 1)]
        WindowsMediaPlayerPolicy_PreventMusicFileMetadataRetrieval = 524,

        [Name("Windows Media Player Prevent Radio Presets Retrieval", "WindowsMediaPlayer_PreventRadioPresetsRetrieval")]
        [WindowsMediaPlayerPolicy("Prevent Radio Presets Retrieval", "PreventRadioPresetsRetrieval", 1)]
        WindowsMediaPlayerPolicy_PreventRadioPresetsRetrieval = 525,

        #endregion

        #region WindowsStore

        [Name("Windows Store Disable OS Upgrade", "WindowsStore_DisableOSUpgrade")]
        [CurUserWindowsStorePolicy("Disable OS Upgrade", "DisableOSUpgrade", 1)]
        CurUserWindowsStorePolicy_DisableOSUpgrade = 526,

        [Name("Windows Store Remove Windows Store", "WindowsStore_RemoveWindowsStore")]
        [CurUserWindowsStorePolicy("Remove Windows Store", "RemoveWindowsStore", 1)]
        CurUserWindowsStorePolicy_RemoveWindowsStore = 527,

        [Name("Windows Store Require Private Store Only", "WindowsStore_RequirePrivateStoreOnly")]
        [CurUserWindowsStorePolicy("Require Private Store Only", "RequirePrivateStoreOnly", 1)]
        CurUserWindowsStorePolicy_RequirePrivateStoreOnly = 528,

        #endregion

        #endregion
    }
}
