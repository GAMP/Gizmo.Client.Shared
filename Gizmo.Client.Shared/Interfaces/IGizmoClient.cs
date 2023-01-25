using Gizmo.Web.Api.Models;

namespace Gizmo.Client
{
    /// <summary>
    /// Gizmo client interface.
    /// </summary>
    public interface IGizmoClient
    {
        #region Registration

        public Task<bool> AccountCreationByEmailStartAsync(string email);

        public Task<bool> AccountCreationByMobilePhoneStartAsync(string mobilePhone);

        #endregion

        #region Password Recovery

        public Task<bool> UserRecoveryMethodGetAsync(string username);

        public Task<bool> UserRecoveryByMobileStartAsync(string username);

        public Task<bool> UserRecoveryByEmailStartAsync(string email);

        public Task<bool> UserRecoveryPasswordCompleteAsync(string token, string confirmationCode, string newPassword);

        #endregion

        #region User Agreements

        public Task<PagedList<UserAgreementModel>> GetUserAgreementsAsync(UserAgreementsFilter filter);

        public Task<List<UserAgreementModelState>> GetUserAgreementStatesAsync(int userId);

        public Task<UpdateResult> AcceptUserAgreementForUserAsync(int userAgreementId, int userId);

        public Task<UpdateResult> RejectUserAgreementForUserAsync(int userAgreementId, int userId);

        #endregion

        #region Registration

        public Task<bool> EmailExistAsync(string email);

        public Task<bool> MobileExistAsync(string mobilePhone);

        public Task<bool> TokenIsValidAsync(int tokenType, string token, string confirmationCode);

        public Task<bool> UsernameExistAsync(string username);

        public Task<UserModelRequiredInfo> GetDefaultUserGroupRequiredInfoAsync();

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

        public Task ChangeUserPasswordAsync(int userId, string oldPassword, string newPassword);

        public Task<CreateResult> CreateUserOrderAsync(int userId, OrderCalculateModelOptions calculateOrderOptions);
    }
}