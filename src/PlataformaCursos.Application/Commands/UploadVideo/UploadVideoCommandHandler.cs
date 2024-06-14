using MediatR;
using Microsoft.Extensions.Configuration;
using PlataformaCursos.Application.ViewModels;
using VimeoDotNet;
using VimeoDotNet.Net;

namespace PlataformaCursos.Application.Commands.UploadVideo
{
    public class UploadVideoCommandHandler : IRequestHandler<UploadVideoCommand, VimeoUploadViewModel>
    {
        private readonly VimeoClient _vimeoClient;
        private readonly IConfiguration _configuration;

        public UploadVideoCommandHandler(IConfiguration configuration)
        {
            _configuration = configuration;
            _vimeoClient = new VimeoClient(_configuration["VimeoSettings:Token"]);
        }

        public async Task<VimeoUploadViewModel> Handle(UploadVideoCommand request, CancellationToken cancellationToken)
        {
            if (request.Video == null || request.Video.DataStream.Length == 0)
            {
                throw new Exception("Nenhum arquivo enviado.");
            }


            try
            {
                using var fileStream = request.Video.DataStream;
                var video = await _vimeoClient.UploadEntireFileAsync(new BinaryContent(fileStream, request.Video.FileName));
                return new VimeoUploadViewModel(video.ClipId.Value, video.ClipUri);   
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
