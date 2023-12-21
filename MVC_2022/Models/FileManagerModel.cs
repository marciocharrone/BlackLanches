namespace LanchesMac.Models
{
    public class FileManagerModel
    {
        public FileInfo[] File { get; set; }
        public IFormFile IFormFile { get; set; }
        public List<IFormFile> IFormFiles { get; set; }
        public string PathImagesProduto { get; set; }
        public FileInfo[] Files { get; internal set; }
    }
}
