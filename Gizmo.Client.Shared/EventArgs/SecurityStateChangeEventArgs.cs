namespace Gizmo.Client
{
    /// <summary>
    /// Security state change event args.
    /// </summary>
    public sealed class SecurityStateChangeEventArgs : EventArgs
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="isEnabled">Indicates if enabled.</param>
        /// <param name="wasEnabled">Indicates if was enabled.</param>
        public SecurityStateChangeEventArgs(bool isEnabled, bool wasEnabled)
        {
            IsEnabled = isEnabled;
            WasEnabled = wasEnabled;
        }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="isEnabled">Indicates if enabled.</param>
        /// <param name="wasEnabled">Indicates if was enabled.</param>
        /// <param name="activeProfile">Indicates if caused by active security profile.</param>
        public SecurityStateChangeEventArgs(bool isEnabled, bool wasEnabled, bool activeProfile = false) : this(isEnabled, wasEnabled)
        {
            ActiveProfileChanged = activeProfile;
        }

        /// <summary>
        /// Gets if security is currently enabled.
        /// </summary>
        public bool IsEnabled
        {
            get;
            init;
        }

        /// <summary>
        /// Gets if security was previously enabled.
        /// </summary>
        public bool WasEnabled
        {
            get;
            init;
        }

        /// <summary>
        /// Gets if active security profile change caused this event.
        /// </summary>
        public bool ActiveProfileChanged
        {
            get;
            init;
        }
    }
}
