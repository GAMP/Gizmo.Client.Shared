namespace Gizmo.Client
{
    public sealed class PersonalFileChangedEventArgs : ModificationEventArgs
    {
        public PersonalFileChangedEventArgs(int entityId, ModificationType modificationType) : base(entityId, modificationType)
        {
        }
    }
}
