using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Tewr.Blazor.FileReader;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using LCMSMSPWA.Models;
using System.Text.Json;
using System.Text;
using BlazorInputFile;
using LCMSMSPWA.Repository;

namespace LCMSMSPWA.Components
{
    public partial class OrphanProfilePic
    {
        [Inject]
        public IFileReaderService fileReader { get; set; }

        //[Inject]
        //public HttpClient client { get; set; }

        [Inject]
        public IPictureRepository picHttpRepository { get; set; }

        [Parameter]
        public OrphanDetailsModel Orphan { get; set; }

        ElementReference inputReference;

        string fileName = string.Empty;
        string type = string.Empty;
        string size = string.Empty;

        Stream fileStream = null;

        private async Task HandleFileSelected()
        {
            fileStream = await OpenFileAsync();
            await UploadFileAsync(fileStream);
            StateHasChanged();
        }

        private async Task<Stream> OpenFileAsync()
        {
            // Read the files
            var file = (await fileReader.CreateReference(inputReference).EnumerateFilesAsync()).FirstOrDefault();

            if (file == null)
                return null;

            // Get the info of that files
            var fileInfo = await file.ReadFileInfoAsync();
            fileName = fileInfo.Name;
            size = $"{fileInfo.Size}b";
            type = fileInfo.Type;

            using (var ms = await file.CreateMemoryStreamAsync((int)fileInfo.Size))
            {
                return new MemoryStream(ms.ToArray());
            }
        }

        private async Task UploadFileAsync(Stream fileStream)
        {
            var picCreation = new PictureCreation
            {
                PictureFileName = fileName,
                SetAsProfilePic = true,
                OrphanID = Orphan.OrphanID
            };

            // string result = await picHttpRepository.UploadImageAsync(picCreation, fileStream);
            //
            // if (!string.IsNullOrWhiteSpace(result))
            // {
            //     Orphan.ProfilePicUri = result; 
            // }          
            
        }
    }
}
