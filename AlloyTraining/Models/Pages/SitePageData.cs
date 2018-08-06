using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlloyTraining.Models.Pages
{
    public abstract class SitePageData : PageData
    {
        [Display(GroupName = SiteTabNames.SEO, Order = 100, Name = "Meta Title")]
        [StringLength(60, MinimumLength = 5)]
        [CultureSpecific]
        public virtual string MetaTitle { get; set; }

        [Display(GroupName = SiteTabNames.SEO, Order = 200, Name = "Meta Keywords")]
        [CultureSpecific]
        public virtual string MetaKeywords { get; set; }

        [Display(GroupName = SiteTabNames.SEO, Order = 300, Name = "Meta Description")]
        [CultureSpecific]
        [UIHint(UIHint.Textarea)]
        public virtual string MetaDescription { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 100, Name = "Page Image")]
        [UIHint(UIHint.Image)]
        public virtual ContentReference PageImage { get; set; }
    }
}