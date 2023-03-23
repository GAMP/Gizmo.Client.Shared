namespace Gizmo.Client
{
    public sealed class AppLinkChangedEventArgs : ModificationEventArgs
    {
        public AppLinkChangedEventArgs(int entityId, ModificationType modificationType) : base(entityId, modificationType)
        {
        }
    }
}
