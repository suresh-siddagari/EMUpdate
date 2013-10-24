﻿using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace EPiServer.Templates.Alloy.Models.Blocks
{
    /// <summary>
    /// Used to provide a stylized entry point to a page on the site
    /// </summary>
    [SiteContentType(GUID = "EB67A99A-E239-41B8-9C59-20EAA5936047")] // BEST PRACTICE TIP: Always assign a GUID explicitly when creating a new block type
    [SiteImageUrl] // Use site's default thumbnail
    public class TeaserBlock : SiteBlockData
    {
        // BEST PRACTICE TIP: To easily allow for page type-specific localizations, append property names with the name of the block type

        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string TeaserHeading { get; set; }
        
        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual string TeaserText { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [UIHint(UIHint.Image)]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual Url TeaserImage { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual PageReference TeaserLink { get; set; }

        [Display(
            GroupName = SystemTabNames.Settings)]
        public virtual bool UseWideLayout { get; set; }
    }
}
