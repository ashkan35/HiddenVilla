using Microsoft.AspNetCore.Components.Forms;

namespace HiddenVilla_Server.Services;

public interface IFileService
{
    Task<string> UploadFile(IBrowserFile file);

    bool DeleteFile(string fileName);
}