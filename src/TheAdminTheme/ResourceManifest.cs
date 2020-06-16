using OrchardCore.ResourceManagement;

namespace TheAdminTheme
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            //manifest
            //    .DefineStyle("admin")
            //    .SetUrl("~/ThisAdminTheme/Styles/theme.min.css", "~/ThisAdminTheme/Styles/theme.css")
            //    .SetDependencies("jQuery-ui")
            //    .SetVersion("0.0.1");
        }
    }
}
