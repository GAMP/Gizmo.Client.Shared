namespace Gizmo.Client
{
    /// <summary>
    /// User login state change event args.
    /// </summary>
    public class UserLoginStateChangeEventArgs : EventArgs
    { 
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="profile">User profile.</param>
        /// <param name="state">State.</param>
        /// <param name="oldState">Old state.</param>
        /// <param name="failReason">Fail reason.</param>
        /// <param name="requiredInfo">Required info.</param>
        public UserLoginStateChangeEventArgs(Gizmo.IUserProfile profile,
            LoginState state,
            LoginState oldState = LoginState.LoggedOut,
            Web.Api.Models.LoginResult failReason = Web.Api.Models.LoginResult.Success,
            Web.Api.Models.UserInfoTypes requiredInfo = Web.Api.Models.UserInfoTypes.None)
        {
            UserProfile = profile;
            State = state;
            OldState = oldState;
            FailReason = failReason;
            RequiredUserInformation = requiredInfo;
        }   

        /// <summary>
        /// Gets the user profile that caused the event.
        /// </summary>
        public IUserProfile UserProfile
        {
            get;
            init;
        }

        /// <summary>
        /// Gets the new user state.
        /// </summary>
        public LoginState State
        {
            get;
            init;
        }

        /// <summary>
        /// Gets the old user state.
        /// </summary>
        public LoginState OldState
        {
            get;
            init;
        }

        /// <summary>
        /// Gets the failure reason.
        /// <remarks>
        /// This value is only set if error occurred otherwise equals to success.
        /// </remarks>
        /// </summary>
        public Web.Api.Models.LoginResult FailReason
        {
            get;
            init;
        }

        /// <summary>
        /// Gets the information types required for this profile.
        /// <remarks>
        /// This property is only set when State property equals to LoggedIn.
        /// </remarks>
        /// </summary>
        public Web.Api.Models.UserInfoTypes RequiredUserInformation
        {
            get;
            init;
        }

        /// <summary>
        /// Gets if user info input required for user.
        /// <remarks>
        /// This property will return false if only password input required.
        /// </remarks>
        /// </summary>
        public bool IsUserInfoRequired
        {
            get
            {
                return !(RequiredUserInformation == Web.Api.Models.UserInfoTypes.None) & !(RequiredUserInformation == Web.Api.Models.UserInfoTypes.Password);
            }
        }

        /// <summary>
        /// Gets if user password input required for user.
        /// </summary>
        public bool IsUserPasswordRequired
        {
            get
            {
                return (RequiredUserInformation & Web.Api.Models.UserInfoTypes.Password) == Web.Api.Models.UserInfoTypes.Password;
            }
        }
    }
}
