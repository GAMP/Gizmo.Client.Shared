namespace Microsoft.GroupPolicy
{
    /// <summary>
    /// Policy attribute.
    /// </summary>
    public abstract class PolicyAttribute : Attribute
    {
        /// <summary>
        /// Creates new instance of the attribute.
        /// </summary>
        /// <param name="registryPath">Registry path.</param>
        /// <param name="valueName">Value name.</param>
        /// <param name="description">Description.</param>
        public PolicyAttribute(string registryPath,
            string description,
            string valueName)
        {
            if (string.IsNullOrWhiteSpace(registryPath))
                throw new ArgumentException("Registry path may not be null or empty.", nameof(registryPath));

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Description may not be null or empty.", nameof(description));

            //registry path of restriction
            RegistryPath = registryPath;

            //if value name is empty enum value should be used
            ValueName = valueName;

            //set description
            Description = description;
        }

        private Win32.RegistryHive _hive = Win32.RegistryHive.CurrentUser;

        /// <summary>
        /// Gets registry path of restriction attribute.
        /// </summary>
        public string RegistryPath
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets value name of security attribute.
        /// </summary>
        public string ValueName
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets the restrictions description.
        /// </summary>
        public string Description
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets the restrictions category string.
        /// </summary>
        public GroupPolicyGroup Category
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets target operating system.
        /// </summary>
        public GroupPolicyTargetOperatingSystem TargetOperatingSystem
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets registry hive.
        /// </summary>
        public Win32.RegistryHive Hive
        {
            get { return _hive; }
            protected set { _hive = value; }
        }

        /// <summary>
        /// Converts enable flag to registry value object.
        /// </summary>
        /// <param name="enable">Enable flag.</param>
        /// <returns>Returns converted object value.</returns>
        public virtual object GetValueForAttribute(bool enable)
        {
            return enable ? 1 : 0;
        }
    }
}
