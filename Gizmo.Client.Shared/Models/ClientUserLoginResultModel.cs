namespace Gizmo.Client
{
    /// <summary>
    /// Client user login result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ClientUserLoginResultModel
    {
        /// <summary>
        /// Login result.
        /// </summary>
        [MessagePack.Key(1)]
        public ClientUserLoginResult LoginResult { get; init; }
    }
}
