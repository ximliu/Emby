﻿using System.Collections.Generic;
using MediaBrowser.Common.Net;
using MediaBrowser.Controller;
using MediaBrowser.Model.Entities;

namespace MediaBrowser.Api.HttpHandlers
{
    /// <summary>
    /// Gets all items within containing a studio
    /// </summary>
    public class StudioHandler : ItemListHandler
    {
        public StudioHandler(RequestContext ctx)
            : base(ctx)
        {
        }

        protected override IEnumerable<BaseItem> ItemsToSerialize
        {
            get
            {
                Folder parent = ApiService.GetItemById(QueryString["id"]) as Folder;

                return Kernel.Instance.GetItemsWithStudio(parent, QueryString["name"], UserId);
            }
        }
    }
}
