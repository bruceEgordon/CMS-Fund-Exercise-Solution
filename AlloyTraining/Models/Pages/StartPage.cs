using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Start", GUID = "71a87d09-f47a-4a98-9a05-7dbd6b2149d4",
        Description = "The home page for a website with an area for blocks and partial pages.", GroupName = SiteGroupNames.Specialized,
        Order = 10)]
    [SiteStartIcon]
    [AvailableContentTypes(Include = new[] { typeof(StandardPage)})]
    public class StartPage : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(Name = "Heading", Order = 10,
            Description = "If the Headings is not set the page falls back to showing the name.")]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(Name = "Footer text", Description = "The footer text will be shown at the bottom of every page.",
            GroupName = SiteTabNames.SiteSettings, Order = 10)]
        public virtual string FooterText { get; set; }

        [CultureSpecific]
        [Display(Name = "Main content area", Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
            GroupName = SystemTabNames.Content, Order = 30)]
        [AllowedTypes(typeof(StandardPage), typeof(BlockData), typeof(ImageData), typeof(ContentFolder))]
        public virtual ContentArea MainContentArea { get; set; }
    }
}