#nullable enable

using Gizmo.Web.Api.Models;

namespace Gizmo.Client
{
    /// <summary>
    /// Gizmo client interface.
    /// </summary>
    public interface IGizmoClient
    {
        /// <summary>
        /// Initiates user login.
        /// </summary>
        /// <param name="username">Username.</param>
        /// <param name="password">Optional password.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<LoginResult> UserLoginAsync(string username,string? password, CancellationToken cancellationToken= default);

        /// <summary>
        /// Initiates user logout.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns></returns>
        public Task UserLogoutAsync(CancellationToken cancellationToken= default);

        /// <summary>
        /// Returns all user agreements based on supplied <paramref name="filter"/>.
        /// </summary>
        /// <param name="filter">Filter.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns></returns>
        public Task<PagedList<UserAgreementModel>> UserAgreementsGetAsync(UserAgreementsFilter filter , CancellationToken cancellationToken= default);

        /// <summary>
        /// Gets pending user agreements.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<PagedList<UserAgreementModel>> UserAgreementsPendingGetAsync(UserAgreementsFilter filter , CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns all agreement states for current user.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<List<UserAgreementModelState>> UserAgreementsGetStatesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Accepts user agreement specified by <paramref name="userAgreementId"/> parameter.
        /// </summary>
        /// <param name="userAgreementId">User agreement id.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<UpdateResult> UserAgreementAcceptAsync(int userAgreementId, CancellationToken cancellationToken =default);

        /// <summary>
        /// Rejects user agreement specified by <paramref name="userAgreementId"/> parameter.
        /// </summary>
        /// <param name="userAgreementId">User agreement id.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<UpdateResult> UserAgreementRejectAsync(int userAgreementId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Checks if specified user email exist.
        /// </summary>
        /// <param name="email">User email address.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>True or false.</returns>
        public Task<bool> UserEmailExistAsync(string email, CancellationToken cancellationToken = default);

        /// <summary>
        /// Checks if specified user mobile exist.
        /// </summary>
        /// <param name="mobilePhone">User mobile phone.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>True or false.</returns>
        public Task<bool> UserMobileExistAsync(string mobilePhone, CancellationToken cancellationToken = default);

        /// <summary>
        /// Checks if specified user name exist.
        /// </summary>
        /// <param name="username">User user name.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>True or false.</returns>
        public Task<bool> UsernameExistAsync(string username, CancellationToken cancellationToken = default);

        /// <summary>
        /// Checks if specified token is valid.
        /// </summary>
        /// <param name="tokenType">Token type.</param>
        /// <param name="token">Token value.</param>
        /// <param name="confirmationCode">Confirmation code.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>True or false.</returns>
        public Task<bool> TokenIsValidAsync(TokenType tokenType, string token, string confirmationCode, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets required user info for default user group.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Required info, the value will be null if no default user group exist.</returns>
        public Task<UserModelRequiredInfo?> UserGroupDefaultRequiredInfoGetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Initiates user creation by email address.
        /// </summary>
        /// <param name="email">Email address.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Creation result.</returns>
        public Task<AccountCreationResultModelByEmail> UserCreateByEmailStartAsync(string email, CancellationToken cancellationToken = default);

        /// <summary>
        /// Initiates user creation by mobile phone.
        /// </summary>
        /// <param name="mobilePhone">Mobile phone.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Creation result.</returns>
        public Task<AccountCreationResultModelByMobilePhone> UserCreateByMobileStartAsync(string mobilePhone, CancellationToken cancellationToken = default);

        /// <summary>
        /// Completes user creation.
        /// </summary>
        /// <param name="user">User profile model.</param>
        /// <param name="password">User password.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Completion result.</returns>
        public Task<AccountCreationCompleteResultModel> UserCreateCompleteAsync(UserModelUpdate user, string password, CancellationToken cancellationToken = default);

        /// <summary>
        /// Completes user creation.
        /// </summary>
        /// <param name="token">Token value.</param>
        /// <param name="user">User profile model.</param>
        /// <param name="password">User password.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Completion result.</returns>
        public Task<AccountCreationCompleteResultModelByToken> UserCreateByTokenCompleteAsync(string token, UserModelUpdate user, string password, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets user password recovery methods for specified user.
        /// </summary>
        /// <param name="userNameEmailOrMobile">User name, mobile or email address.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>User password recovery methods result model.</returns>
        public Task<UserRecoveryMethodGetResultModel> UserPasswordRecoveryMethodGetAsync(string userNameEmailOrMobile, CancellationToken cancellationToken = default);

        /// <summary>
        /// Initiates user password recovery by mobile phone.
        /// </summary>
        /// <param name="username">User name.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Result.</returns>
        public Task<PasswordRecoveryStartResultModelByMobile> UserPasswordRecoveryByMobileStartAsync(string username, CancellationToken cancellationToken = default);

        /// <summary>
        /// Initiates user password recovery by email address.
        /// </summary>
        /// <param name="email">User email address.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns></returns>
        public Task<PasswordRecoveryStartResultModelByEmail> UserPasswordRecoveryByEmailStartAsync(string email, CancellationToken cancellationToken = default);

        /// <summary>
        /// Completes user password recovery process.
        /// </summary>
        /// <param name="token">Token value.</param>
        /// <param name="confirmationCode">Confirmation code.</param>
        /// <param name="newPassword">New user password.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Completion result.</returns>
        public Task<PasswordRecoveryCompleteResultCode> UserPasswordRecoveryCompleteAsync(string token, string confirmationCode, string newPassword, CancellationToken cancellationToken = default);


        public Task<UserModel> GetUserProfileAsync();

        public Task<UpdateResult> UpdateUserProfileAsync(UserModelUpdate user);

        public Task<bool> GetUserBalanceAsync();

        #region Top Up

        public Task<PaymentOnlineConfigurationModel> GetOnlinePaymentsConfigurationAsync();

        public Task<PaymentIntentCreateResultModel> CreatePaymentIntentAsync(PaymentIntentCreateParametersDepositModel paymentIntentCreateParametersDeposit);

        #endregion

        #region Password Recovery



        #endregion

        #region User Agreements




        #endregion

        #region Registration





        #endregion

        #region Products

        public Task<PagedList<ProductGroupModel>> GetProductGroupsAsync(ProductGroupsFilter filter);

        public Task<PagedList<ProductModel>> GetProductsAsync(ProductsFilter filter);

        public Task<ProductModel> GetProductByIdAsync(int id, ModelFilterOptions? options = null);

        public Task<PagedList<ProductBundledModel>> GetBundledProductsAsync(int id);

        #endregion

        #region Applications

        public Task<PagedList<ApplicationGroupModel>> GetApplicationGroupsAsync(ApplicationGroupsFilter filter);

        public Task<PagedList<ApplicationEnterpriseModel>> GetAppEnterprisesAsync(ApplicationEnterprisesFilter filter);

        public Task<PagedList<ApplicationModel>> GetApplicationsAsync(ApplicationsFilter filter);

        public Task<PagedList<ApplicationExecutableModel>> GetApplicationExecutablesAsync(ApplicationExecutablesFilter filter);

        public Task<ApplicationModelImage> GetApplicationImageAsync(int id);

        public Task<ApplicationExecutableModelImage> GetApplicationExecutableImageAsync(int id);

        #endregion

        public Task<PagedList<PaymentMethodModel>> GetPaymentMethodsAsync(PaymentMethodsFilter filter);

        

        public Task<CreateResult> CreateUserOrderAsync(int userId, OrderCalculateModelOptions calculateOrderOptions);
    }
}
