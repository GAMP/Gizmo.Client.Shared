namespace Gizmo.Client
{
    /// <summary>
    /// Lock state change event args.
    /// </summary>
    public sealed class LockStateChangeEventArgs : EventArgs
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="isLocked">Indicates if locked.</param>
        public LockStateChangeEventArgs(bool isLocked)
        {
            IsLocked = isLocked;
        }

        /// <summary>
        /// Gets if the lock is active.
        /// </summary>
        public bool IsLocked
        {
            get;
            init;
        }
    }
}
