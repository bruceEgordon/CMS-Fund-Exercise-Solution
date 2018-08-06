using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Standard", GUID = "87dd598a-924f-4ca1-9656-73235530a72f",
        Description = "Use this page type unless you need something more specialized",
        GroupName = SiteGroupNames.Common)]
    [SitePageIcon]
    [AvailableContentTypes(Include = new[] { typeof(StandardPage)}, Exclude = new[] { typeof(ProductPage)})]
    public class StandardPage : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 150)]
        public virtual XhtmlString MainBody { get; set; }

    }
}