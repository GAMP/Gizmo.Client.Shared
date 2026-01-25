namespace Gizmo.Client
{
    /// <summary>
    /// Client user lock change args.
    /// </summary>
    public sealed class UserLockStateChangeEventArgs : EventArgs
    {
        /// <summary>
        /// Current lock status.
        /// </summary>
        public bool IsLocked
        {
            get;
            init;
        }
    }
}
