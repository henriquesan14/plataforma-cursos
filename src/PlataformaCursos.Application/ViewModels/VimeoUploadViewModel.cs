namespace PlataformaCursos.Application.ViewModels
{
    public class VimeoUploadViewModel
    {
        public VimeoUploadViewModel(long clipId, string clipUrl)
        {
            ClipId = clipId;
            ClipUrl = clipUrl;
        }

        public long ClipId { get; set; }
        public string ClipUrl { get; set; }
    }
}
