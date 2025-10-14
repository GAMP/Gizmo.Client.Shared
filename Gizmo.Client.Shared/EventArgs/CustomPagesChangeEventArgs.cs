namespace Gizmo.Client
{
    /// <summary>
    /// Server data change args.
    /// </summary>
    public class CustomPagesChangeEventArgs : ModificationEventArgs
    {
        public CustomPagesChangeEventArgs(int entityId, ModificationType modificationType) : base(entityId, modificationType)
        {
        }
    }
}