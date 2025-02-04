namespace Microsoft.GroupPolicy
{
    #region LocalMachine

    #region EdgePolicyAttributes

    public class EdgeMainPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public EdgeMainPolicyAttribute(string description, string valueName = "", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\MicrosoftEdge\Main", description, valueName)
        {
            Category = GroupPolicyGroup.Edge;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
        }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            return enable ? "no" : PolicyValueDeleteResult.Instance;
        }
        #endregion
    }

    #endregion

    #region OneDrive
    public class OneDrivePolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public OneDrivePolicyAttribute(string description, string valueName = "", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\OneDrive", description, valueName)
        {
            Category = GroupPolicyGroup.OneDrive;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
        }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            return enable ? 1 : PolicyValueDeleteResult.Instance;
        }
        #endregion
    }
    #endregion

    #region Explorer

    public class ExplorerPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        public ExplorerPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer", description, valueName)
        {
            Category = GroupPolicyGroup.Edge;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue >= 0)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class ExplorerWAUPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        public ExplorerWAUPolicyAttribute(string description, string valueName = "", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer\WAU", description, valueName)
        {
            Category = GroupPolicyGroup.Explorer;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
        }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            return enable ? 1 : PolicyValueDeleteResult.Instance;
        }
        #endregion
    }

    public class WindowsExplorerPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsExplorerPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\Explorer", description, valueName)
        {
            Category = GroupPolicyGroup.Explorer;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    #endregion

    #region System

    public class SystemPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public SystemPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", description, valueName)
        {
            Category = GroupPolicyGroup.System;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class WindowsSystemPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsSystemPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\System", description, valueName)
        {
            Category = GroupPolicyGroup.System;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    #endregion

    #region Windows
    public class WindowsPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsPolicyAttribute(string description, string valueName = "", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Windows", description, valueName)
        {
            Category = GroupPolicyGroup.Windows;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
        }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            return enable ? 1 : PolicyValueDeleteResult.Instance;
        }
        #endregion
    }

    public class WindowsSidebarPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsSidebarPolicyAttribute(string description, string valueName = "", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Windows\Sidebar", description, valueName)
        {
            Category = GroupPolicyGroup.Windows;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
        }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            return enable ? 1 : PolicyValueDeleteResult.Instance;
        }
        #endregion
    }

    public class WindowsFileHistoryPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsFileHistoryPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\FileHistory", description, valueName)
        {
            Category = GroupPolicyGroup.Windows;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class WindowsGameDVRPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsGameDVRPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\GameDVR", description, valueName)
        {
            Category = GroupPolicyGroup.Windows;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class WindowsHomeGroupPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsHomeGroupPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\HomeGroup", description, valueName)
        {
            Category = GroupPolicyGroup.Windows;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class WindowsMapsPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsMapsPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\Maps", description, valueName)
        {
            Category = GroupPolicyGroup.Windows;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class WindowsPersonalizationPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsPersonalizationPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\Personalization", description, valueName)
        {
            Category = GroupPolicyGroup.Windows;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class WindowsPowerShellPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsPowerShellPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\policies\microsoft\windows\powershell", description, valueName)
        {
            Category = GroupPolicyGroup.Windows;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledIntValue = enableValue;
            DefaultIntValue = disabledValue;
            ValueIsString = false;
        }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. Empty or "PolicyValueDeleteResult" if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsPowerShellPolicyAttribute(string description, string valueName, string enableValue, string disabledValue = "PolicyValueDeleteResult", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\policies\microsoft\windows\powershell", description, valueName)
        {
            Category = GroupPolicyGroup.Windows;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledStringValue = enableValue;
            DefaultStringValue = disabledValue;
            ValueIsString = true;
        }

        #endregion

        #region PROPERTIES
        public bool ValueIsString { get; protected set; }
        public string EnabledStringValue { get; protected set; } = string.Empty;
        public string DefaultStringValue { get; protected set; } = string.Empty;
        public int DefaultIntValue { get; protected set; }
        public int EnabledIntValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (ValueIsString)
            {
                if (DefaultStringValue != "PolicyValueDeleteResult")
                {
                    return enable ? EnabledStringValue : DefaultStringValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
            else
            {
                if (DefaultIntValue != -1)
                {
                    return enable ? EnabledIntValue : DefaultIntValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
        }
        #endregion
    }

    public class WindowsSearchPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsSearchPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\policies\microsoft\windows\windows search", description, valueName)
        {
            Category = GroupPolicyGroup.Windows;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledIntValue = enableValue;
            DefaultIntValue = disabledValue;
            ValueIsString = false;
        }
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. Empty or "PolicyValueDeleteResult" if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsSearchPolicyAttribute(string description, string valueName, string enableValue, string disabledValue = "PolicyValueDeleteResult", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\policies\microsoft\windows\windows search", description, valueName)
        {
            Category = GroupPolicyGroup.Windows;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledStringValue = enableValue;
            DefaultStringValue = disabledValue;
            ValueIsString = true;
        }
        #endregion

        #region PROPERTIES
        public bool ValueIsString { get; protected set; }
        public string EnabledStringValue { get; protected set; } = string.Empty;
        public string DefaultStringValue { get; protected set; } = string.Empty;
        public int DefaultIntValue { get; protected set; }
        public int EnabledIntValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (ValueIsString)
            {
                if (DefaultStringValue != "PolicyValueDeleteResult")
                {
                    return enable ? EnabledStringValue : DefaultStringValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
            else
            {
                if (DefaultIntValue != -1)
                {
                    return enable ? EnabledIntValue : DefaultIntValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
        }
        #endregion
    }

    #endregion

    #region ChromePolicyAttributes
    public class ChromePolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public ChromePolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Google\Chrome", description, valueName)
        {
            Category = GroupPolicyGroup.Chrome;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledIntValue = enableValue;
            DefaultIntValue = disabledValue;
            ValueIsString = false;
        }
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. Empty or "PolicyValueDeleteResult" if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public ChromePolicyAttribute(string description, string valueName, string enableValue, string disabledValue = "PolicyValueDeleteResult", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Google\Chrome", description, valueName)
        {
            Category = GroupPolicyGroup.Chrome;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledStringValue = enableValue;
            DefaultStringValue = disabledValue;
            ValueIsString = true;
        }
        #endregion

        #region PROPERTIES
        public bool ValueIsString { get; protected set; }
        public string EnabledStringValue { get; protected set; } = string.Empty;
        public string DefaultStringValue { get; protected set; } = string.Empty;
        public int DefaultIntValue { get; protected set; }
        public int EnabledIntValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (ValueIsString)
            {
                if (DefaultStringValue != "PolicyValueDeleteResult")
                {
                    return enable ? EnabledStringValue : DefaultStringValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
            else
            {
                if (DefaultIntValue != -1)
                {
                    return enable ? EnabledIntValue : DefaultIntValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
        }
        #endregion
    }

    #endregion

    #region Miscellaneous
    public class WindowsAssistancePolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsAssistancePolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Assistance\Client\1.0", description, valueName)
        {
            Category = GroupPolicyGroup.Miscellaneous;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class CameraPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public CameraPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Camera", description, valueName)
        {
            Category = GroupPolicyGroup.Miscellaneous;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class EventViewerPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public EventViewerPolicyAttribute(string description, string valueName, string enableValue = "", string disabledValue = "PolicyValueDeleteResult", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\policies\microsoft\eventviewer", description, valueName)
        {
            Category = GroupPolicyGroup.Miscellaneous;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledStringValue = enableValue;
            DefaultStringValue = disabledValue;
        }
        #endregion

        #region PROPERTIES

        public string EnabledStringValue { get; protected set; }
        public string DefaultStringValue { get; protected set; }

        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {

            if (DefaultStringValue != "PolicyValueDeleteResult")
            {
                return enable ? EnabledStringValue : DefaultStringValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }

        }
        #endregion
    }

    public class MessengerClientPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MessengerClientPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Messenger\Client", description, valueName)
        {
            Category = GroupPolicyGroup.Miscellaneous;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class SoundRecorderPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public SoundRecorderPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\SoundRecorder", description, valueName)
        {
            Category = GroupPolicyGroup.Miscellaneous;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class SpeechPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public SpeechPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Speech", description, valueName)
        {
            Category = GroupPolicyGroup.Miscellaneous;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class WindowsNTMYSPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsNTMYSPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows NT\CurrentVersion\MYS", description, valueName)
        {
            Category = GroupPolicyGroup.Miscellaneous;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class WindowsNTIISPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsNTIISPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows NT\IIS]", description, valueName)
        {
            Category = GroupPolicyGroup.Miscellaneous;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class PushNotificationsPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public PushNotificationsPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\CurrentVersion\PushNotifications]", description, valueName)
        {
            Category = GroupPolicyGroup.Miscellaneous;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class ProtectedEventLoggingPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public ProtectedEventLoggingPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\policies\microsoft\windows\eventlog\protectedeventlogging", description, valueName)
        {
            Category = GroupPolicyGroup.Miscellaneous;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledIntValue = enableValue;
            DefaultIntValue = disabledValue;
            ValueIsString = false;
        }
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. Empty or "PolicyValueDeleteResult" if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public ProtectedEventLoggingPolicyAttribute(string description, string valueName, string enableValue, string disabledValue = "PolicyValueDeleteResult", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\policies\microsoft\windows\eventlog\protectedeventlogging", description, valueName)
        {
            Category = GroupPolicyGroup.Miscellaneous;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledStringValue = enableValue;
            DefaultStringValue = disabledValue;
            ValueIsString = true;
        }
        #endregion

        #region PROPERTIES
        public bool ValueIsString { get; protected set; }
        public string EnabledStringValue { get; protected set; } = string.Empty;
        public string DefaultStringValue { get; protected set; } = string.Empty;
        public int DefaultIntValue { get; protected set; }
        public int EnabledIntValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (ValueIsString)
            {
                if (DefaultStringValue != "PolicyValueDeleteResult")
                {
                    return enable ? EnabledStringValue : DefaultStringValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
            else
            {
                if (DefaultIntValue != -1)
                {
                    return enable ? EnabledIntValue : DefaultIntValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
        }
        #endregion
    }

    public class WindowsInkWorkspacePolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsInkWorkspacePolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\WindowsInkWorkspace]", description, valueName)
        {
            Category = GroupPolicyGroup.Miscellaneous;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    #endregion

    #region WindowsDefender

    public class WindowsDefenderPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsDefenderPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\policies\microsoft\windows defender", description, valueName)
        {
            Category = GroupPolicyGroup.WindowsDefender;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledIntValue = enableValue;
            DefaultIntValue = disabledValue;
            ValueIsString = false;
        }
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. Empty or "PolicyValueDeleteResult" if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsDefenderPolicyAttribute(string description, string valueName, string enableValue, string disabledValue = "PolicyValueDeleteResult", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\policies\microsoft\windows defender", description, valueName)
        {
            Category = GroupPolicyGroup.WindowsDefender;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledStringValue = enableValue;
            DefaultStringValue = disabledValue;
            ValueIsString = true;
        }
        #endregion

        #region PROPERTIES
        public bool ValueIsString { get; protected set; }
        public string EnabledStringValue { get; protected set; } = string.Empty;
        public string DefaultStringValue { get; protected set; } = string.Empty;
        public int DefaultIntValue { get; protected set; }
        public int EnabledIntValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (ValueIsString)
            {
                if (DefaultStringValue != "PolicyValueDeleteResult")
                {
                    return enable ? EnabledStringValue : DefaultStringValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
            else
            {
                if (DefaultIntValue != -1)
                {
                    return enable ? EnabledIntValue : DefaultIntValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
        }
        #endregion
    }

    public class WindowsDefenderRealTimeProtectionPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsDefenderRealTimeProtectionPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", description, valueName)
        {
            Category = GroupPolicyGroup.WindowsDefender;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class WindowsDefenderScanPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsDefenderScanPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows Defender\Scan", description, valueName)
        {
            Category = GroupPolicyGroup.WindowsDefender;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    #endregion

    #region RemovableStorageDevices

    public class WindowsRemovableStorageDevicesPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsRemovableStorageDevicesPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\RemovableStorageDevices", description, valueName)
        {
            Category = GroupPolicyGroup.RemovableStorageDevices;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class WindowsRemovableStorageDevicesCDDVDPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsRemovableStorageDevicesCDDVDPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\RemovableStorageDevices\{53f56308-b6bf-11d0-94f2-00a0c91efb8b}", description, valueName)
        {
            Category = GroupPolicyGroup.RemovableStorageDevices;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class WindowsRemovableStorageDevicesTapeDrivesPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsRemovableStorageDevicesTapeDrivesPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\RemovableStorageDevices\{53f5630b-b6bf-11d0-94f2-00a0c91efb8b}", description, valueName)
        {
            Category = GroupPolicyGroup.RemovableStorageDevices;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class WindowsRemovableStorageDevicesRemovableDisksPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsRemovableStorageDevicesRemovableDisksPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\RemovableStorageDevices\{53f5630d-b6bf-11d0-94f2-00a0c91efb8b}", description, valueName)
        {
            Category = GroupPolicyGroup.RemovableStorageDevices;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class WindowsRemovableStorageDevicesFloppyDrivesPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsRemovableStorageDevicesFloppyDrivesPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\RemovableStorageDevices\{53f56311-b6bf-11d0-94f2-00a0c91efb8b}", description, valueName)
        {
            Category = GroupPolicyGroup.RemovableStorageDevices;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    #endregion

    #region WindowsUpdate

    public class WindowsUpdatePolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsUpdatePolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\policies\microsoft\windows\windowsupdate", description, valueName)
        {
            Category = GroupPolicyGroup.WindowsUpdate;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledIntValue = enableValue;
            DefaultIntValue = disabledValue;
            ValueIsString = false;
        }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. Empty or "PolicyValueDeleteResult" if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsUpdatePolicyAttribute(string description, string valueName, string enableValue, string disabledValue = "PolicyValueDeleteResult", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\policies\microsoft\windows\windowsupdate", description, valueName)
        {
            Category = GroupPolicyGroup.WindowsUpdate;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledStringValue = enableValue;
            DefaultStringValue = disabledValue;
            ValueIsString = true;
        }
        #endregion

        #region PROPERTIES
        public bool ValueIsString { get; protected set; }
        public string EnabledStringValue { get; protected set; } = string.Empty;
        public string DefaultStringValue { get; protected set; } = string.Empty;
        public int DefaultIntValue { get; protected set; }
        public int EnabledIntValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (ValueIsString)
            {
                if (DefaultStringValue != "PolicyValueDeleteResult")
                {
                    return enable ? EnabledStringValue : DefaultStringValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
            else
            {
                if (DefaultIntValue != -1)
                {
                    return enable ? EnabledIntValue : DefaultIntValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
        }
        #endregion
    }

    public class WindowsUpdateAuPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsUpdateAuPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\policies\microsoft\windows\windowsupdate\au", description, valueName)
        {
            Category = GroupPolicyGroup.WindowsUpdate;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledIntValue = enableValue;
            DefaultIntValue = disabledValue;
            ValueIsString = false;
        }
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. Empty or "PolicyValueDeleteResult" if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsUpdateAuPolicyAttribute(string description, string valueName, string enableValue, string disabledValue = "PolicyValueDeleteResult", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\policies\microsoft\windows\windowsupdate\au", description, valueName)
        {
            Category = GroupPolicyGroup.WindowsUpdate;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledStringValue = enableValue;
            DefaultStringValue = disabledValue;
            ValueIsString = true;
        }
        #endregion

        #region PROPERTIES
        public bool ValueIsString { get; protected set; }
        public string EnabledStringValue { get; protected set; } = string.Empty;
        public string DefaultStringValue { get; protected set; } = string.Empty;
        public int DefaultIntValue { get; protected set; }
        public int EnabledIntValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (ValueIsString)
            {
                if (DefaultStringValue != "PolicyValueDeleteResult")
                {
                    return enable ? EnabledStringValue : DefaultStringValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
            else
            {
                if (DefaultIntValue != -1)
                {
                    return enable ? EnabledIntValue : DefaultIntValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
        }
        #endregion
    }

    #endregion

    #region WindowsFirewall

    public class WindowsFirewallDomainPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsFirewallDomainPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\WindowsFirewall\DomainProfile", description, valueName)
        {
            Category = GroupPolicyGroup.WindowsFirewall;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class WindowsFirewallStandardPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsFirewallStandardPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\WindowsFirewall\StandardProfile", description, valueName)
        {
            Category = GroupPolicyGroup.WindowsFirewall;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    #endregion

    #region WindowsStore

    public class WindowsStorePolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsStorePolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\WindowsStore]", description, valueName)
        {
            Category = GroupPolicyGroup.WindowsStore;
            TargetOperatingSystem = targetOperatingSystem;
            Hive = Microsoft.Win32.RegistryHive.LocalMachine;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    #endregion

    #endregion

    #region CurrentUser  

    #region ActiveDesktop

    public class ActiveDesktopPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public ActiveDesktopPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\ActiveDesktop", description, valueName)
        {
            Category = GroupPolicyGroup.ActiveDesktop;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    #endregion

    #region Attachments

    public class AttachmentsPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public AttachmentsPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Attachments", description, valueName)
        {
            Category = GroupPolicyGroup.ActiveDesktop;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    #endregion

    #region Comdlg32

    public class Comdlg32PolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public Comdlg32PolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Comdlg32", description, valueName)
        {
            Category = GroupPolicyGroup.Comdlg32;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    #endregion

    #region Explorer

    public class CurUserExplorerPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public CurUserExplorerPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer", description, valueName)
        {
            Category = GroupPolicyGroup.Explorer;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledIntValue = enableValue;
            DefaultIntValue = disabledValue;
            ValueIsString = false;
        }
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. Empty or "PolicyValueDeleteResult" if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public CurUserExplorerPolicyAttribute(string description, string valueName, string enableValue, string disabledValue = "PolicyValueDeleteResult", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer", description, valueName)
        {
            Category = GroupPolicyGroup.Explorer;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledStringValue = enableValue;
            DefaultStringValue = disabledValue;
            ValueIsString = true;
        }
        #endregion

        #region PROPERTIES
        public bool ValueIsString { get; protected set; }
        public string EnabledStringValue { get; protected set; } = string.Empty;
        public string DefaultStringValue { get; protected set; } = string.Empty;
        public int DefaultIntValue { get; protected set; }
        public int EnabledIntValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (ValueIsString)
            {
                if (DefaultStringValue != "PolicyValueDeleteResult")
                {
                    return enable ? EnabledStringValue : DefaultStringValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
            else
            {
                if (DefaultIntValue != -1)
                {
                    return enable ? EnabledIntValue : DefaultIntValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
        }
        #endregion
    }

    public class CurUserExplorerDisallowRunPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public CurUserExplorerDisallowRunPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun", description, valueName)
        {
            Category = GroupPolicyGroup.Explorer;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledIntValue = enableValue;
            DefaultIntValue = disabledValue;
            ValueIsString = false;
        }
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. Empty or "PolicyValueDeleteResult" if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public CurUserExplorerDisallowRunPolicyAttribute(string description, string valueName, string enableValue, string disabledValue = "PolicyValueDeleteResult", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun", description, valueName)
        {
            Category = GroupPolicyGroup.Explorer;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledStringValue = enableValue;
            DefaultStringValue = disabledValue;
            ValueIsString = true;
        }
        #endregion

        #region PROPERTIES
        public bool ValueIsString { get; protected set; }
        public string EnabledStringValue { get; protected set; } = string.Empty;
        public string DefaultStringValue { get; protected set; } = string.Empty;
        public int DefaultIntValue { get; protected set; }
        public int EnabledIntValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (ValueIsString)
            {
                if (DefaultStringValue != "PolicyValueDeleteResult")
                {
                    return enable ? EnabledStringValue : DefaultStringValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
            else
            {
                if (DefaultIntValue != -1)
                {
                    return enable ? EnabledIntValue : DefaultIntValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
        }
        #endregion
    }

    public class CurUserExplorerRestrictCplPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public CurUserExplorerRestrictCplPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer\RestrictCpl", description, valueName)
        {
            Category = GroupPolicyGroup.Explorer;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledIntValue = enableValue;
            DefaultIntValue = disabledValue;
            ValueIsString = false;
        }
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. Empty or "PolicyValueDeleteResult" if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public CurUserExplorerRestrictCplPolicyAttribute(string description, string valueName, string enableValue, string disabledValue = "PolicyValueDeleteResult", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer\RestrictCpl", description, valueName)
        {
            Category = GroupPolicyGroup.Explorer;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledStringValue = enableValue;
            DefaultStringValue = disabledValue;
            ValueIsString = true;
        }
        #endregion

        #region PROPERTIES
        public bool ValueIsString { get; protected set; }
        public string EnabledStringValue { get; protected set; } = string.Empty;
        public string DefaultStringValue { get; protected set; } = string.Empty;
        public int DefaultIntValue { get; protected set; }
        public int EnabledIntValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (ValueIsString)
            {
                if (DefaultStringValue != "PolicyValueDeleteResult")
                {
                    return enable ? EnabledStringValue : DefaultStringValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
            else
            {
                if (DefaultIntValue != -1)
                {
                    return enable ? EnabledIntValue : DefaultIntValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
        }
        #endregion
    }

    public class CurUserExplorerWAUPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

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
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            return enable ? 1 : PolicyValueDeleteResult.Instance;
        }
        #endregion
    }

    public class CurUserWindowsExplorerPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public CurUserWindowsExplorerPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\Explorer", description, valueName)
        {
            Category = GroupPolicyGroup.Explorer;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    #endregion

    #region Network

    public class NetworkPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public NetworkPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Network", description, valueName)
        {
            Category = GroupPolicyGroup.Network;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class NetworkConnectionsPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public NetworkConnectionsPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\Network Connections", description, valueName)
        {
            Category = GroupPolicyGroup.Network;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }
    #endregion

    #region NonEnum

    public class NonEnumPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public NonEnumPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\NonEnum", description, valueName)
        {
            Category = GroupPolicyGroup.NonEnum;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledIntValue = enableValue;
            DefaultIntValue = disabledValue;
            ValueIsString = false;
        }
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. Empty or "PolicyValueDeleteResult" if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public NonEnumPolicyAttribute(string description, string valueName, string enableValue, string disabledValue = "PolicyValueDeleteResult", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\NonEnum", description, valueName)
        {
            Category = GroupPolicyGroup.NonEnum;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledStringValue = enableValue;
            DefaultStringValue = disabledValue;
            ValueIsString = true;
        }
        #endregion

        #region PROPERTIES
        public bool ValueIsString { get; protected set; }
        public string EnabledStringValue { get; protected set; } = string.Empty;
        public string DefaultStringValue { get; protected set; } = string.Empty;
        public int DefaultIntValue { get; protected set; }
        public int EnabledIntValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (ValueIsString)
            {
                if (DefaultStringValue != "PolicyValueDeleteResult")
                {
                    return enable ? EnabledStringValue : DefaultStringValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
            else
            {
                if (DefaultIntValue != -1)
                {
                    return enable ? EnabledIntValue : DefaultIntValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
        }
        #endregion
    }

    #endregion

    #region System

    public class CurUserSystemPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public CurUserSystemPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", description, valueName)
        {
            Category = GroupPolicyGroup.System;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class CurUserWindowsSystemPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public CurUserWindowsSystemPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\System", description, valueName)
        {
            Category = GroupPolicyGroup.System;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }


    #endregion

    #region Windows

    public class CurUserWindowsPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public CurUserWindowsPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Windows", description, valueName)
        {
            Category = GroupPolicyGroup.Windows;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class CurUserWindowsMessangerPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public CurUserWindowsMessangerPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Messenger\Client", description, valueName)
        {
            Category = GroupPolicyGroup.Windows;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class CurUserWindowsSoundRecorderPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public CurUserWindowsSoundRecorderPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\SoundRecorder", description, valueName)
        {
            Category = GroupPolicyGroup.Windows;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class CurUserWindowsCloudContentPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public CurUserWindowsCloudContentPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\CloudContent", description, valueName)
        {
            Category = GroupPolicyGroup.Windows;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class CurUserWindowsCredUIPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public CurUserWindowsCredUIPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\CredUI", description, valueName)
        {
            Category = GroupPolicyGroup.Windows;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    #endregion

    #region MMC

    public class MMCPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCSecurityConfigurationAndAnalysisPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCSecurityConfigurationAndAnalysisPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{011BE22D-E453-11D1-945A-00C04FB984F9}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCSMTPProtocolPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCSMTPProtocolPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{03f1f940-a0f2-11d0-bb77-00aa00a1eab7}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCSystemPropertiesPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCSystemPropertiesPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{0F3621F1-23C6-11D1-AD97-00AA00B88E5A}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCAdministrativeTemplatesUsersMainPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCAdministrativeTemplatesUsersMainPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{0F6B957E-509E-11D1-A7CC-0000F87571E3}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCAdministrativeTemplatesUsers1PolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCAdministrativeTemplatesUsers1PolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{84DE202E-5D95-4764-9014-A46F994CE856}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCAdministrativeTemplatesUsers2PolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCAdministrativeTemplatesUsers2PolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{D02B1F73-3407-48ae-BA88-E8213C6761F1}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCNetFrameworkConfigurationPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCNetFrameworkConfigurationPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{18BA7139-D98B-43c2-94DA-2604E34E175D}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCRoutingandRemoteAccessPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCRoutingandRemoteAccessPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{1AA7F839-C7F5-11D0-A376-00C04FC9DA04}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCAppleTalkRoutingPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCAppleTalkRoutingPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{1AA7F83C-C7F5-11D0-A376-00C04FC9DA04}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCADSIEditPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCADSIEditPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{1C5DACFA-16BA-11D2-81D0-0000F87A7AA3}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCAuthorizationManagerPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCAuthorizationManagerPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{1F5EEC01-1214-4D94-80C5-4BDCD2014DDD}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCWirelessMonitorPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCWirelessMonitorPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{23DC5869-BD9F-46fd-AADD-1F869BA64FC3}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCRemovableStoragePolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCRemovableStoragePolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{243E20B0-48ED-11D2-97DA-00A024D77700}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCIASLoggingPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCIASLoggingPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{2E19B602-48EB-11d2-83CA-00104BCA42CF}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCPublicKeyPoliciesPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCPublicKeyPoliciesPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{34AB8E82-C27E-11D1-A6C0-00C04FB94F17}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCEventViewerPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCEventViewerPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{394C052E-B830-11D0-9A86-00C04FD8DBF7}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCEventViewer2PolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCEventViewer2PolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{975797FC-4E2A-11D0-B702-00C04FD8DBF7}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCRemovableStorageManagementPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCRemovableStorageManagementPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{3CB6973D-3E6F-11D0-95DB-00A024D77700}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCRemoteDesktopsPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCRemoteDesktopsPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCCertificationAuthorityPolicySettingsPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCCertificationAuthorityPolicySettingsPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{3F276EB4-70EE-11D1-8A0F-00C04FB93753}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCDiskDefragmenterPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCDiskDefragmenterPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{43668E21-2636-11D1-A1CE-0080C88593A5}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCSystemInformationPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCSystemInformationPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{45ac8c63-23e2-11d1-a696-00c04fd58bc3}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCCertificatesPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCCertificatesPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{53D6AB1D-2488-11D1-A28C-00C04FB94F17}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCIPSecurityMonitorPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCIPSecurityMonitorPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{57C596D0-9370-40C0-BA0D-AB491B63255D}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCSharedFoldersPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCSharedFoldersPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{58221C65-EA27-11CF-ADCF-00AA00A80033}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCServicesPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCServicesPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{58221C66-EA27-11CF-ADCF-00AA00A80033}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCComputerManagementPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCComputerManagementPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{58221C67-EA27-11CF-ADCF-00AA00A80033}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCSharedFoldersExtPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCSharedFoldersExtPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{58221C69-EA27-11CF-ADCF-00AA00A80033}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCRemoteAccessPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCRemoteAccessPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{5880CD5C-8EC0-11d1-9570-0060B0576642}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCSecurityTemplatesPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCSecurityTemplatesPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{5ADF5BF6-E452-11D1-945A-00C04FB984F9}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCWMIControlPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCWMIControlPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{5C659257-E236-11D2-8899-00104B2AFB46}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCLocalUsersandGroupsPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCLocalUsersandGroupsPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{5D6179C8-17EC-11D1-9AA9-00C04FD8FE93}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCEnterprisePKIPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCEnterprisePKIPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{634BDE40-E5E1-49A1-B2CD-140FFFC830F9}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCDistributedFileSystemPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCDistributedFileSystemPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{677A2D94-28D9-11D1-A95B-008048918FB1}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCLogicalandMappedDrivesPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCLogicalandMappedDrivesPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{6E8E0081-19CD-11D1-AD91-00AA00B8E05A}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCDeviceManagerPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCDeviceManagerPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{74246bfc-4c96-11d0-abef-0020af6b0b7a}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCDeviceManager2PolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCDeviceManager2PolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{90087284-d6d6-11d0-8353-00a0c90640bf}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCPerformanceLogsandAlertsPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCPerformanceLogsandAlertsPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{7478EF61-8C46-11d1-8D99-00A0C913CAD4}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCFAXServicePolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCFAXServicePolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{753EDB4D-2E1B-11D1-9064-00A0C90AB504}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCSNMPPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCSNMPPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{7AF60DD3-4979-11D1-8A6C-00C04FC33566}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCDiskManagementPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCDiskManagementPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{8EAD3A12-B2C1-11d0-83AA-00A0C92C9D5D}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCIASPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCIASPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{8F8F8DC0-5713-11D1-9551-0060B0576642}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCGroupPolicyObjectEditorPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCGroupPolicyObjectEditorPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCIPXRoutingPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCIPXRoutingPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{90810500-38F1-11D1-9345-00C04FC9DA04}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCIPXRIPRoutingPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCIPXRIPRoutingPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{90810502-38F1-11D1-9345-00C04FC9DA04}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCIPXSAPRoutingPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCIPXSAPRoutingPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{90810504-38F1-11D1-9345-00C04FC9DA04}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCIndexingServicePolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCIndexingServicePolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{95AD72F0-44CE-11D0-AE29-00AA004B9986}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCDCOMConfigurationExtensionPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCDCOMConfigurationExtensionPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{9EC88934-C774-11d1-87F4-00C04FC2C17B}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCInternetInformationServicesPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCInternetInformationServicesPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{A841B6C2-7577-11D0-BB1F-00A0C922E79C}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCCertificateTemplatesPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCCertificateTemplatesPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{A994E107-6854-4F3D-917C-E6F01670F6D3}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCSendConsoleMessagePolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCSendConsoleMessagePolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{B1AFF7D0-0C49-11D1-BB12-00C04FC9A3A3}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCRASDialinUserNodePolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCRASDialinUserNodePolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{B52C1E50-1DD2-11D1-BC43-00C04FC31FD3}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCExtendedViewPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCExtendedViewPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{B708457E-DB61-4C55-A92F-0D4B5E9B1224}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCRemoteDesktopServicesConfigurationPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCRemoteDesktopServicesConfigurationPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{B91B6008-32D2-11D2-9888-00A0C925F917}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCServiceDependenciesPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCServiceDependenciesPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{BD95BA60-2E26-AAD1-AD99-00AA00B8E05A}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCIPRoutingPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCIPRoutingPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{C2FE4500-D6C2-11D0-A37B-00C04FC9DA04}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCDHCPRelayManagementPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCDHCPRelayManagementPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\C2FE4502-D6C2-11D0-A37B-00C04FC9DA04}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCRIPRoutingPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCRIPRoutingPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{C2FE4504-D6C2-11D0-A37B-00C04FC9DA04}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCOSPFRoutingPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCOSPFRoutingPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{C2FE4506-D6C2-11D0-A37B-00C04FC9DA04}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCIGMPRoutingPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCIGMPRoutingPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{C2FE4508-D6C2-11D0-A37B-00C04FC9DA04}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCConnectionSharingPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCConnectionSharingPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{C2FE450B-D6C2-11D0-A37B-00C04FC9DA04}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCActiveXControlPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCActiveXControlPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{C96401CF-0E17-11D3-885B-00C04F72C717}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCLinktoWebAddressPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCLinktoWebAddressPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{C96401D1-0E17-11D3-885B-00C04F72C717}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCComponentServicesPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCComponentServicesPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{C9BC92DF-5B9A-11D1-8F00-00C04FC2C17B}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCActiveDirectorySitesandServicesPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCActiveDirectorySitesandServicesPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{D967F824-9968-11D0-B936-00C04FD8D5B0}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCRoutingPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCRoutingPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{DAB1A262-4FD7-11D1-842C-00C04FB6C218}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCCertificationAuthorityPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCCertificationAuthorityPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{de751566-4cc6-11d1-8ca0-00c04fc297eb}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCIPSecurityPolicyManagementPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCIPSecurityPolicyManagementPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{DEA8AFA2-CC85-11d0-9CE2-0080C7221EBD}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCGroupPolicyManagementPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCGroupPolicyManagementPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{E12BBB5D-D59D-4E61-947A-301D25AE8C23}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCTelephonyPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCTelephonyPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{E26D02A0-4C1F-11D1-9AA1-00C04FC3357A}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCActiveDirectoryUsersComputersPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCActiveDirectoryUsersComputersPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{E355E538-1C2E-11D0-8C37-00C04FD8FE93}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCActiveDirectoryDomainsTrustsPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCActiveDirectoryDomainsTrustsPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{EBC53A38-A23F-11D0-B09B-00C04FD8DCA6}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCQoSAdmissionControlPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCQoSAdmissionControlPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{FD57D297-4FD9-11D1-854E-00C04FC31FD3}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCFrontPageServerExtensionsPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCFrontPageServerExtensionsPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\{FF5903A8-78D6-11D1-92F6-006097B01056}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCFXServerManagerPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCFXServerManagerPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\FX:{18ea3f92-d6aa-41d9-a205-2023400c8fbb}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCFXNetworkPolicyServerPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCFXNetworkPolicyServerPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\FX:{6630f2d7-bd52-4072-bfa7-863f3d0c5da0}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCFXOnlineResponderPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCFXOnlineResponderPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\FX:{6d8880af-e518-43a8-986c-1ad21c4c976e}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCFXTPMManagementPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCFXTPMManagementPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\FX:{7d3830aa-e69e-4e17-8bd1-1b87b97099da}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCFXHealthRegistrationAuthorityPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCFXHealthRegistrationAuthorityPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\FX:{89cc9588-7628-4d29-8e4a-6550d0087059}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCFXNAPClientConfigurationPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCFXNAPClientConfigurationPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\FX:{a1bc4eca-66b2-44e8-9915-be02e84438ba}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCFXWindowsFirewallAdvancedSecurityPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCFXWindowsFirewallAdvancedSecurityPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\FX:{b05566ac-fe9c-4368-be02-7a4cbb7cbe11}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    public class MMCFXFailoverClustersManagerPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public MMCFXFailoverClustersManagerPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11) : base(@"SOFTWARE\Policies\Microsoft\MMC\FX:{D2779945-405B-4ACE-8618-508F3E3054AC}", description, valueName)
        {
            Category = GroupPolicyGroup.MMC;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    #endregion

    #region PowerShell

    public class PowerShellPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public PowerShellPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\PowerShell", description, valueName)
        {
            Category = GroupPolicyGroup.PowerShell;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledIntValue = enableValue;
            DefaultIntValue = disabledValue;
            ValueIsString = false;
        }
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. Empty or "PolicyValueDeleteResult" if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public PowerShellPolicyAttribute(string description, string valueName, string enableValue, string disabledValue = "PolicyValueDeleteResult", GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\PowerShell", description, valueName)
        {
            Category = GroupPolicyGroup.PowerShell;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledStringValue = enableValue;
            DefaultStringValue = disabledValue;
            ValueIsString = true;
        }
        #endregion

        #region PROPERTIES
        public bool ValueIsString { get; protected set; }
        public string EnabledStringValue { get; protected set; } = string.Empty;
        public string DefaultStringValue { get; protected set; } = string.Empty;
        public int DefaultIntValue { get; protected set; }
        public int EnabledIntValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (ValueIsString)
            {
                if (DefaultStringValue != "PolicyValueDeleteResult")
                {
                    return enable ? EnabledStringValue : DefaultStringValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
            else
            {
                if (DefaultIntValue != -1)
                {
                    return enable ? EnabledIntValue : DefaultIntValue;
                }
                else
                {
                    return PolicyValueDeleteResult.Instance;
                }
            }
        }
        #endregion
    }

    #endregion

    #region TaskScheducler

    public class TaskSchedulerPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public TaskSchedulerPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\Task Scheduler5.0", description, valueName)
        {
            Category = GroupPolicyGroup.TaskScheduler;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    #endregion

    #region WindowsErrorReporting

    public class WindowsErrorReportingPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsErrorReportingPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\Windows\Windows Error Reporting", description, valueName)
        {
            Category = GroupPolicyGroup.WindowsErrorReporting;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    #endregion

    #region WindowsMediaPlayer

    public class WindowsMediaPlayerPolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public WindowsMediaPlayerPolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\WindowsMediaPlayer", description, valueName)
        {
            Category = GroupPolicyGroup.WindowsMediaPlayer;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    #endregion

    #region WindowsStore

    public class CurUserWindowsStorePolicyAttribute : PolicyAttribute
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="enableValue">Enabled value.</param>
        /// <param name="disabledValue">Default value. -1 if it doesn't exist</param>
        /// <param name="targetOperatingSystem">targetOperatingSystem value</param>
        public CurUserWindowsStorePolicyAttribute(string description, string valueName = "", int enableValue = 0, int disabledValue = -1, GroupPolicyTargetOperatingSystem targetOperatingSystem = GroupPolicyTargetOperatingSystem.Windows10and11)
            : base(@"SOFTWARE\Policies\Microsoft\WindowsStore", description, valueName)
        {
            Category = GroupPolicyGroup.WindowsStore;
            TargetOperatingSystem = targetOperatingSystem;
            EnabledValue = enableValue;
            DefaultValue = disabledValue;
        }
        #endregion

        #region PROPERTIES
        public int DefaultValue { get; protected set; }
        public int EnabledValue { get; protected set; }
        #endregion

        #region OVERRIDES
        public override object GetValueForAttribute(bool enable)
        {
            if (DefaultValue != -1)
            {
                return enable ? EnabledValue : DefaultValue;
            }
            else
            {
                return PolicyValueDeleteResult.Instance;
            }
        }
        #endregion
    }

    #endregion

    #endregion
}
