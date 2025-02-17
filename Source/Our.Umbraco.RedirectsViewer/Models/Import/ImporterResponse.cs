using System.Collections.Generic;
using System.Linq;
using Skybrud.Umbraco.Redirects.Models.Import.File;

namespace Our.Umbraco.RedirectsViewer.Models.Import
{
    public class ImporterResponse
    {
        public ImporterResponse()
        {
            ImportedItems = Enumerable.Empty<RedirectItem>();
        }

        public IRedirectsFile File { get; set; }

        public IEnumerable<RedirectItem> ImportedItems { get; set;  }
    }
}