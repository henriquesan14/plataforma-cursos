namespace PlataformaCursos.Infra.Models.Request
{
    public class VimeoUploadRequest
    {
        public VimeoUpload Upload { get; set; }
    }
    public class VimeoUpload
    {
        public string Approach { get; set; }
        public long Size { get; set; }
    }    
}
