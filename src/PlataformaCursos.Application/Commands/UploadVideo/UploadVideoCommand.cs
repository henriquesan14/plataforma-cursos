using MediatR;
using PlataformaCursos.Application.ViewModels;

namespace PlataformaCursos.Application.Commands.UploadVideo
{
    public class UploadVideoCommand : IRequest<VimeoUploadViewModel>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public VideoUploadDto Video { get; set; }
    }

    public class VideoUploadDto
    {
        public string FileName { get; set; }
        public MemoryStream DataStream { get; set; }
        public long Size { get; set; }

        public byte[] ToByteArray()
        {
            return DataStream.ToArray();
        }
    }
}
