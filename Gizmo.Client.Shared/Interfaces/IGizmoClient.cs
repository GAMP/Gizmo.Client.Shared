using Gizmo.Web.Api.Models;

namespace Gizmo.Client
{
    /// <summary>
    /// Gizmo client interface.
    /// </summary>
    public interface IGizmoClient
    {
        public Task<PagedList<UserAgreementModel>> GetUserAgreementsAsync(UserAgreementsFilter filter);

        public Task<List<UserAgreementModelState>> GetUserAgreementStatesAsync(int userId);

        public Task<UpdateResult> AcceptUserAgreementForUserAsync(int userAgreementId, int userId);

        public Task<UpdateResult> RejectUserAgreementForUserAsync(int userAgreementId, int userId);

        public Task<PagedList<ProductGroupModel>> GetProductGroupsAsync(ProductGroupsFilter filter);

        public Task<PagedList<ProductModel>> GetProductsAsync(ProductsFilter filter);

        public Task<ProductModel> GetProductByIdAsync(int id, ModelFilterOptions? options = null);

        public Task<PagedList<ProductBundledModel>> GetBundledProductsAsync(int id);

        public Task<PagedList<ApplicationGroupModel>> GetApplicationGroupsAsync(ApplicationGroupsFilter filter);

        public Task<PagedList<ApplicationEnterpriseModel>> GetAppEnterprisesAsync(ApplicationEnterprisesFilter filter);

        public Task<PagedList<ApplicationModel>> GetApplicationsAsync(ApplicationsFilter filter);

        public Task<PagedList<ApplicationExecutableModel>> GetApplicationExecutablesAsync(ApplicationExecutablesFilter filter);

        public Task<ApplicationModelImage> GetApplicationImageAsync(int id);

        public Task<ApplicationExecutableModelImage> GetApplicationExecutableImageAsync(int id);

        public Task<PagedList<PaymentMethodModel>> GetPaymentMethodsAsync(PaymentMethodsFilter filter);

        public Task UserPasswordChange(int userId, string oldPassword, string newPassword);
    }
}