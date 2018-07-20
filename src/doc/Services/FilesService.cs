using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

using Markdig;

using Skittles.Extensions;

namespace Skittles.Services
{
    public class FilesService
    {
        private static IEnumerable<MarkdownFile> _files;

        public void Load()
        {
            _files = Directory.GetFiles(DocRootPath, "*.md", SearchOption.AllDirectories)
                .Select(s => new FileInfo(s))
                .Select(LoadMarkdownFile)
                .ToList();
        }

        public MarkdownFile Read(string path)
        {
            var content = _files.FirstOrDefault(f => f.UrlPath.Equals(path, StringComparison.InvariantCultureIgnoreCase));
            if (content == null)
            {
                return null;
            }

            var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
            content.Content = Markdown.ToHtml(File.ReadAllText(content.File), pipeline);

            return content;
        }

        public static string DocRootPath =>
            new FileInfo(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "..\\..\\..\\doc\\")).FullName;

        private MarkdownFile LoadMarkdownFile(FileInfo file)
        {
            var x = DocRootPath;
            return new MarkdownFile
                       {
                           File = file.FullName,
                           UrlPath = file.FullName.Replace(x, "").SanityFilename().JustFilename(),
                           Title = file.Name.JustFilename().ToUpperFirst()
                       };
        }
    }
}