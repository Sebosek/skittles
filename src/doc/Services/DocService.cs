using System.IO;
using System.Reflection;

using Markdig;

namespace Skittles.Services
{
    public class DocService
    {
        public string Index()
        {
            var content = File.ReadAllText(Path.Combine(DocRootPath(), "index.md"));

            var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
            return Markdown.ToHtml(content, pipeline);
        }

        private string DocRootPath() =>
            Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "..\\..\\..\\doc");
    }
}