using Gizmo.Web.Api.Models;

namespace Gizmo.Client
{
    /// <summary>
    /// Gizmo client interface.
    /// </summary>
    public interface IGizmoClient
    {
        public Task<PagedList<ProductGroup>> GetProductGroupsAsync(ProductGroupsFilter filter);

        public Task<PagedList<Product>> GetProductsAsync(ProductsFilter filter);

        public Task<PagedList<ApplicationGroup>> GetApplicationGroupsAsync(ApplicationGroupsFilter filter);

        public Task<PagedList<Application>> GetApplicationsAsync(ApplicationsFilter filter);

        public Task<PagedList<ApplicationExecutable>> GetApplicationExecutablesAsync(ApplicationExecutablesFilter filter);
    }
}
