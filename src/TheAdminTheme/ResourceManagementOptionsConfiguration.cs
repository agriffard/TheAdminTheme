using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace TheAdminTheme
{
    public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
    {
        private static ResourceManifest _manifest;

        static ResourceManagementOptionsConfiguration()
        {
            _manifest = new ResourceManifest();

            //_manifest
            //    .DefineStyle("admin")
            //    .SetUrl("~/ThisAdminTheme/Styles/theme.min.css", "~/ThisAdminTheme/Styles/theme.css")
            //    .SetDependencies("jQuery-ui")
            //    .SetVersion("0.0.1");
        }

        public void Configure(ResourceManagementOptions options)
        {
            options.ResourceManifests.Add(_manifest);
        }
    }
}
