using System.Collections.Generic;
using System.IO;
using System.Linq;

using Skittles.Extensions;

namespace Skittles.Services
{
    public class MenuService
    {
        public static IEnumerable<Menu> Components() =>
            Directory.GetFiles(Path.Combine(FilesService.DocRootPath, "components")).Select(s => new FileInfo(s)).Select(
                s => new Menu
                         {
                             UrlPath = s.Name.SanityFilename().JustFilename(),
                             FileName = s.Name,
                             Label = s.Name.JustFilename().ToUpperFirst()
                         });
    }
}