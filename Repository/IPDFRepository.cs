using System.Threading.Tasks;
using LCMSMSPWA.Models;

namespace LCMSMSPWA.Repository
{
    public interface IPDFRepository
    {
        Task<string> UploadPDFAsync(PDFCreation pdfCreation, byte[] fileBytes);

        Task DeletePDFAsync(int pdfID);
    }
}