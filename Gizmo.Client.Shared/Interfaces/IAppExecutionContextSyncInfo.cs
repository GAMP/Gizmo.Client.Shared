namespace Gizmo.Client
{
    /// <summary>
    /// Executing context deployment sync contract.
    /// </summary>
    public interface IAppExecutionContextSyncInfo
    {
        /// <summary>
        /// Gets total data written.
        /// </summary>
        long TotalWritten { get; }

        /// <summary>
        /// Gets total to be written.
        /// </summary>
        long Total { get; } 
    }
}
