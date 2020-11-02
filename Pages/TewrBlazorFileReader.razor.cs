using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Tewr.Blazor.FileReader;

namespace LCMSMSPWA.Pages
{
    public partial class TewrBlazorFileReader
    {
        private ElementReference inputTypeFileElement;

        [Inject]
        public IFileReaderService fileReaderService { get; set; }

        public async Task ReadFile()
        {
            byte[] buffer = new byte[0];
            foreach (var file in await fileReaderService.CreateReference(inputTypeFileElement).EnumerateFilesAsync())
            {
                // Read into buffer and act (uses less memory)
                await using (Stream stream = await file.OpenReadAsync())
                {
                    buffer = new byte[stream.Length];
                    await stream.ReadAsync(buffer, 0, (int)stream.Length);
                }

            }
            Console.WriteLine($"buffer bytes: {buffer.Length}");
            
        }
    }
}
