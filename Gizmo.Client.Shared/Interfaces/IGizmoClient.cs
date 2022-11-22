using Gizmo.Web.Api.Models;

namespace Gizmo.Client
{
    /// <summary>
    /// Gizmo client interface.
    /// </summary>
    public interface IGizmoClient
    {
        public Task<PagedList<UserAgreement>> GetUserAgreementsAsync(UserAgreementsFilter filter);

        public Task<List<UserAgreementState>> GetUserAgreementStatesAsync(int userId);

        public Task<UpdateResult> AcceptUserAgreementForUserAsync(int userAgreementId, int userId);

        public Task<UpdateResult> RejectUserAgreementForUserAsync(int userAgreementId, int userId);

        public Task<PagedList<ProductGroup>> GetProductGroupsAsync(ProductGroupsFilter filter);

        public Task<PagedList<Product>> GetProductsAsync(ProductsFilter filter);

        public Task<Product> GetProductByIdAsync(int id, GetOptions? options = null);

        public Task<PagedList<BundledProduct>> GetBundledProductsAsync(int id);

        public Task<PagedList<ApplicationGroup>> GetApplicationGroupsAsync(ApplicationGroupsFilter filter);

        public Task<PagedList<ApplicationEnterprise>> GetAppEnterprisesAsync(ApplicationEnterprisesFilter filter);
        
        public Task<PagedList<Application>> GetApplicationsAsync(ApplicationsFilter filter);

        public Task<PagedList<ApplicationExecutable>> GetApplicationExecutablesAsync(ApplicationExecutablesFilter filter);

        public Task<ApplicationImage> GetApplicationImageAsync(int id);

        public Task<ApplicationExecutableImage> GetApplicationExecutableImageAsync(int id);

        public Task<PagedList<PaymentMethod>> GetPaymentMethodsAsync(PaymentMethodsFilter filter);
    }
}
