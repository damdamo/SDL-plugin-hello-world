using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.DefaultLocations;
using Sdl.Desktop.IntegrationApi.Extensions;

namespace Ribbon.HelloWorld
{
    /// <summary>
    /// The ribbon group where we will put our icon
    /// </summary>
    [RibbonGroup("HelloWorldRibbonGroup", Name = "Hey ! That's Hello !")]
    [RibbonGroupLayout(LocationByType = typeof(StudioDefaultRibbonTabs.AddinsRibbonTabLocation))]
    public class HelloWorldTemplateRibbonGroup : AbstractRibbonGroup
    {
    }
}
