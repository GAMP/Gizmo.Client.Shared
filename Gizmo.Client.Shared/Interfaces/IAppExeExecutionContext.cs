namespace Gizmo.Client
{
    /// <summary>
    /// Represents app exe execution state.
    /// </summary>
    public interface IAppExeExecutionContext
    {
        /// <summary>
        /// Gets if context is alive, effectively if any processes being tracked for this context.
        /// </summary>
        public bool IsAlive { get; }

        /// <summary>
        /// Gets if execution is in progress.<br></br>Esentially if the application being started.
        /// </summary>
        bool IsExecuting
        {
            get;
        }

        /// <summary>
        /// Gets if execution is being aborted.<br></br>Esentially if application start is being canceled.
        /// </summary>
        bool IsAborting
        {
            get;
        }

        /// <summary>
        /// Gets if execution where previously completed with succcess.<br></br>Esentially if application was started normally at least once.
        /// </summary>
        bool HasCompleted { get; }

        /// <summary>
        /// Gets if context is ready for execution.<br></br>Esentially means that we can start the application.
        /// </summary>
        bool IsReady { get; }
    }
}
