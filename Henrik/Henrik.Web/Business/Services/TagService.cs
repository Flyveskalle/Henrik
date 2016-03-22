using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Logging;
using Umbraco.Core.Models;

namespace Henrik.Web.Business.Services
{
    public class TagService
    {
        private readonly Umbraco.Core.Services.TagService tagService;
        private IEnumerable<ITag> allTags;

        private IEnumerable<ITag> AllTags
        {
            get
            {
                if (allTags == null)
                {
                    tagService.GetAllTags(Constants.TagGroupName);
                }
                return allTags;
            }
            set { allTags = value; }
        }

        public TagService(Umbraco.Core.Services.TagService tagService)
        {
            this.tagService = tagService;
        }

        public ITag GetTag(string tag)
        {
            if (!string.IsNullOrEmpty(tag))
            {
                return AllTags.FirstOrDefault(x => x.Text.ToLower().Equals(tag.ToLower()));
            }
            return null;
        }

        public ITag GetTag(int tagId)
        {
            if (tagId > 0)
            {
                return AllTags.FirstOrDefault(x => x.Id.Equals(tagId));
            }
            return null;
        }

        
    }
}