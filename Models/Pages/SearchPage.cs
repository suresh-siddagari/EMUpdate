﻿using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EPiServer.Templates.Alloy.Models.Pages
{
    /// <summary>
    /// Used to provide on-site search
    /// </summary>
    [SiteContentType(
        GUID = "AAC25733-1D21-4F82-B031-11E626C91E30",
        GroupName = Global.GroupNames.Specialized)]
    [SiteImageUrl]
    public class SearchPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 310)]
        [CultureSpecific]
        public virtual ContentArea RelatedContentArea { get; set; }
    }
}