using MyTecCoursePWA.Layout;

namespace MyTecCoursePWA.Services
{
    public static class LinkManagerService
    {
        public static async Task LinkManagerHandler(string link, MainLayout layout)
        {
            if (layout != null)
            {
                layout.HandleMessageFromPage(link);
            }
        }
    }
}
