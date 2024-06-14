namespace PlataformaCursos.Infra.Models.Response
{
    public class VimeoUploadResponse
    {
        public string Uri { get; set; }
        public VimeoUploadLink Upload { get; set; }
    }

    public class VimeoUploadLink
    {
        public string UploadLink { get; set; }
    }
}
