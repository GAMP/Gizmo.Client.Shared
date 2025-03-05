namespace Microsoft.GroupPolicy
{
    /// <summary>
    /// Policy attribute delete value object.
    /// </summary>
    /// <remarks>
    /// Should be returned in order to signal policy code that the value should be deleted.
    /// </remarks>
    public readonly struct PolicyValueDeleteResult
    {
        public static PolicyValueDeleteResult Instance = new();
    }
}
