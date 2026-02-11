namespace Gizmo.Client
{
    /// <summary>
    /// User balance change event args.
    /// </summary>
    public sealed class UserBalanceChangeEventArgs : EventArgs
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="userId">User id.</param>
        /// <param name="balance">User balance.</param>
        public UserBalanceChangeEventArgs(int userId)
        {
            UserId = userId;
        }

        /// <summary>
        /// Gets user id.
        /// </summary>
        public int UserId { get; }

        /// <summary>
        /// Balance.
        /// </summary>
        public decimal Balance { get; init; }

        /// <summary>
        /// Deposit balance.
        /// </summary>
        public decimal Deposits { get; init; }

        /// <summary>
        /// Time balance.
        /// </summary>
        public double? Time
        {
            get; init;
        }

        /// <summary>
        /// Credited time balance.
        /// </summary>
        public double? CreditedTime { get; init; }

        /// <summary>
        /// Points balance.
        /// </summary>
        public int Points { get; init; }

        /// <summary>
        /// Current outstanding amount.
        /// </summary>
        public decimal Outstanding { get; init; }
    }
}
