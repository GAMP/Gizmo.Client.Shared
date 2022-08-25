using Gizmo.Web.Api.Models;
using System.Collections.Generic;

namespace Gizmo.Client
{
    /// <summary>
    /// Gizmo client interface.
    /// </summary>
    public interface IGizmoClient
    {
        public IEnumerable<ProductGroup> GetProductGroups(ProductGroupsFilter filter);

        public IEnumerable<Product> GetProducts(ProductsFilter filter);

        public IEnumerable<Application> GetApplications(ApplicationsFilter filter);

        public IEnumerable<ApplicationExecutable> GetApplicationExecutables(ApplicationExecutablesFilter filter);
    }
}
