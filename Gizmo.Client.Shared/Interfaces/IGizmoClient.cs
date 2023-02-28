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
        public Task<LoginResult> UserLoginAsync(string username, string? password, CancellationToken cancellationToken = default);

        /// <summary>
        /// Initiates user logout.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns></returns>
        public Task UserLogoutAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns all user agreements based on supplied <paramref name="filter"/>.
        /// </summary>
        /// <param name="filter">Filter.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns></returns>
        public Task<PagedList<UserAgreementModel>> UserAgreementsGetAsync(UserAgreementsFilter filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets pending user agreements.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<PagedList<UserAgreementModel>> UserAgreementsPendingGetAsync(UserAgreementsFilter filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns all agreement states for current user.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<List<UserAgreementModelState>> UserAgreementsStatesGetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Accepts user agreement specified by <paramref name="userAgreementId"/> parameter.
        /// </summary>
        /// <param name="userAgreementId">User agreement id.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<UpdateResult> UserAgreementAcceptAsync(int userAgreementId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Rejects user agreement specified by <paramref name="userAgreementId"/> parameter.
        /// </summary>
        /// <param name="userAgreementId">User agreement id.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<UpdateResult> UserAgreementRejectAsync(int userAgreementId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set user agreement state.
        /// </summary>
        /// <param name="userAgreementId">User agreement id.</param>
        /// <param name="state">State.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<UpdateResult> UserAgreementStateSetAsync(int userAgreementId, Gizmo.UserAgreementAcceptState state, CancellationToken cancellationToken = default);

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
        /// Checks if specified user exist.
        /// </summary>
        /// <param name="userNameEmailOrMobile">User user name, email or mobile phone.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <remarks>
        /// <b>The function will return true if user with username, email or mobile phone specified by <paramref name="userNameEmailOrMobile"/> exists.</b>
        /// </remarks>
        /// <returns>True or false.</returns>
        public Task<bool> UserExistAsync(string userNameEmailOrMobile, CancellationToken cancellationToken = default);

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
        /// <param name="confirmationCodeDeliveryMethod">Confirmation code delivery method.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Creation result.</returns>
        public Task<AccountCreationResultModelByMobilePhone> UserCreateByMobileStartAsync(string mobilePhone, Gizmo.ConfirmationCodeDeliveryMethod confirmationCodeDeliveryMethod = Gizmo.ConfirmationCodeDeliveryMethod.Undetermined, CancellationToken cancellationToken = default);

        /// <summary>
        /// Completes user creation.
        /// </summary>
        /// <param name="user">User profile model.</param>
        /// <param name="password">User password.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Completion result.</returns>
        public Task<AccountCreationCompleteResultModel> UserCreateCompleteAsync(UserProfileModelCreate user, string password, CancellationToken cancellationToken = default);

        /// <summary>
        /// Completes user creation.
        /// </summary>
        /// <param name="token">Token value.</param>
        /// <param name="user">User profile model.</param>
        /// <param name="password">User password.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Completion result.</returns>
        public Task<AccountCreationCompleteResultModelByToken> UserCreateByTokenCompleteAsync(string token, UserProfileModelCreate user, string password, CancellationToken cancellationToken = default);

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
        /// <param name="confirmationCodeDeliveryMethod">Confirmation code delivery method.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Recovery procedure result.</returns>
        public Task<PasswordRecoveryStartResultModelByMobile> UserPasswordRecoveryByMobileStartAsync(string username, Gizmo.ConfirmationCodeDeliveryMethod confirmationCodeDeliveryMethod = Gizmo.ConfirmationCodeDeliveryMethod.Undetermined, CancellationToken cancellationToken = default);

        /// <summary>
        /// Initiates user password recovery by email address.
        /// </summary>
        /// <param name="email">User email address.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Recovery procedure result.</returns>
        public Task<PasswordRecoveryStartResultModelByEmail> UserPasswordRecoveryByEmailStartAsync(string email, CancellationToken cancellationToken = default);

        /// <summary>
        /// Completes user password recovery process.
        /// </summary>
        /// <param name="token">Token value.</param>
        /// <param name="confirmationCode">Confirmation code.</param>
        /// <param name="newPassword">New user password.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Recovery procedure completion result.</returns>
        public Task<PasswordRecoveryCompleteResultCode> UserPasswordRecoveryCompleteAsync(string token, string confirmationCode, string newPassword, CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets user balance.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Current user balance.</returns>
        public Task<UserBalanceModel> UserBalanceGetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets current user profile.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Current user profile.</returns>
        public Task<UserProfileModel> UserProfileGetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates current user profile.
        /// </summary>
        /// <param name="user">User profile.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<UpdateResult> UserProfileUpdateAsync(UserProfileModelUpdate user, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates current user password.
        /// </summary>
        /// <param name="oldPassword">Old user password.</param>
        /// <param name="newPassword">New user password.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<UpdateResult> UserPasswordUpdateAsync(string oldPassword, string newPassword, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates deposit payment intent.
        /// </summary>
        /// <param name="parameters">Deposit intent parameters.</param>
        /// <param name="cancellationToken">>Cancellation token.</param>
        /// <returns>Creation result.</returns>
        public Task<PaymentIntentCreateResultModel> PaymentIntentCreateAsync(PaymentIntentCreateParametersDepositModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets online deposit configuration.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Online deposit configuration.</returns>
        public Task<PaymentOnlineConfigurationModel> OnlinePaymentsConfigurationGetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets user usage session.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<UserUsageSessionModel> UserUsageSessionGetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets client reservation.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<ClientReservationModel> ClientReservationGetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns all news based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<PagedList<NewsModel>> NewsGetAsync(NewsFilter filters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns all feeds based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<PagedList<FeedModel>> FeedsGetAsync(FeedsFilter filters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns the user product group specified by <paramref name="id"/>.
        /// </summary>
        /// <param name="id">Id of the product to get.</param>
        /// <param name="cToken">Cancellation token.</param>
        Task<UserProductGroupModel?> UserProductGroupGetAsync(int id, CancellationToken cToken = default);

        /// <summary>
        /// Returns all user product groups based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cToken">Cancellation token.</param>
        public Task<PagedList<UserProductGroupModel>> UserProductGroupsGetAsync(UserProductGroupsFilter filters, CancellationToken cToken = default);

        /// <summary>
        /// Returns the user product specified by <paramref name="id"/>.
        /// </summary>
        /// <param name="id">Id of the product to get.</param>
        /// <param name="cToken">Cancellation token.</param>
        public Task<UserProductModel?> UserProductGetAsync(int id, CancellationToken cToken = default);

        /// <summary>
        /// Returns all user products based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cToken">Cancellation token.</param>
        public Task<PagedList<UserProductModel>> UserProductsGetAsync(UserProductsFilter filters, CancellationToken cToken = default);

        /// <summary>
        /// Returns the product specified by <paramref name="id"/>.
        /// </summary>
        /// <param name="id">Id of the product to get.</param>
        /// <param name="cToken">Cancellation token.</param>
        public Task<ProductModel?> ProductGetAsync(int id, ModelFilterOptions? options = null, CancellationToken cToken = default);

        /// <summary>
        /// Returns all products based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cToken">Cancellation token.</param>
        public Task<PagedList<ProductModel>> ProductsGetAsync(ProductsFilter filters, CancellationToken cToken = default);

        /// <summary>
        /// Returns all user payment methods based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<PagedList<UserPaymentMethodModel>> UserPaymentMethodsGetAsync(UserPaymentMethodsFilter filters, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns all user application enterprises based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<PagedList<UserApplicationEnterpriseModel>> UserApplicationEnterprisesGetAsync(UserApplicationEnterprisesFilter filters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns all user application categories based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<PagedList<UserApplicationCategoryModel>> UserApplicationCategoriesGetAsync(UserApplicationCategoriesFilter filters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns all user applications based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<PagedList<UserApplicationModel>> UserApplicationsGetAsync(UserApplicationsFilter filters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns all user executables based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<PagedList<UserExecutableModel>> UserApplicationExecutablesGetAsync(UserExecutablesFilter filters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns all user application links based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<PagedList<UserApplicationLinkModel>> UserApplicationLinksGetAsync(UserApplicationLinksFilter filters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns all user executable personal files based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<PagedList<UserExecutablePersonalFileModel>> UserExecutablePersonalFilesGetAsync(UserExecutablePersonalFilesFilter filters, CancellationToken cancellationToken = default);

        #region UNDER REVIEW 

        public Task<CreateResult> UserOrderCreateAsync(int userId, OrderCalculateModelOptions calculateOrderOptions, CancellationToken cancellationToken = default);

        #region Applications

        public Task<PagedList<ApplicationGroupModel>> ApplicationGroupsGetAsync(ApplicationGroupsFilter filter, CancellationToken cancellationToken = default);

        public Task<PagedList<ApplicationEnterpriseModel>> EnterprisesGetAsync(ApplicationEnterprisesFilter filter, CancellationToken cancellationToken = default);

        public Task<PagedList<ApplicationModel>> ApplicationsGetAsync(ApplicationsFilter filter, CancellationToken cancellationToken = default);

        public Task<PagedList<ApplicationExecutableModel>> ExecutablesGetAsync(ApplicationExecutablesFilter filter, CancellationToken cancellationToken = default);
                        
        Task<PagedList<ProductBundledModel>> ProductsBundleGetAsync(int id, CancellationToken cToken);

        #endregion


        #endregion

    }
}
