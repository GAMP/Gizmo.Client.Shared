namespace Gizmo.Client
{
    /// <summary>
    /// Client user login model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ClientUserLoginModel
    {
        /// <summary>
        /// Username.
        /// </summary>
        [MessagePack.Key(0)]
        public required string UserName { get; init; }

        /// <summary>
        /// Optional password.
        /// </summary>
        /// <remarks>
        /// In case of password reset users will be created with empty password, so password is optional for login.<br></br>
        /// If password is empty, user will be logged in without password check.<br></br>
        /// This allows users to log in with temporary password and then change it after login.
        /// </remarks>
        [MessagePack.Key(1)]
        public string? Password { get; init; }

        /// <summary>
        /// Optional pin code.
        /// </summary>
        /// <remarks>
        /// Currently only used for confirming user as part of reservation upon login, but may be used for other purposes in the future.
        /// </remarks>
        [MessagePack.Key(2)]
        public string? PinCode { get; init; }
    }
}
