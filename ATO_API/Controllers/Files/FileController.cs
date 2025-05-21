using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using Microsoft.AspNetCore.Mvc;

namespace ATO_API.Controllers.Files
{
    [Route("api/file")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly string _uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");

        private readonly string _bucketName = "arms-acdfc.appspot.com";
        private readonly StorageClient _storageClient;
        public FileController()
        {
            string basePath = Directory.GetCurrentDirectory();

            string credentialPath = Path.Combine(basePath, "Auth", "arms-acdfc-firebase-adminsdk-k69jb-5769670d14.json");

            GoogleCredential credential = GoogleCredential.FromFile(credentialPath);
            _storageClient = StorageClient.Create(credential);
        }

        // POST api/file/upload
        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("No file uploaded.");
            }

            // Generate a unique filename
            var uniqueFileName = System.Guid.NewGuid().ToString() + Path.GetExtension(file.FileName).ToLower();
            var filePath = Path.Combine(_uploadFolder, uniqueFileName);

            // Save the file to the uploads folder
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            // Return the link to the uploaded file
            var fileUrl = $"/uploads/{uniqueFileName}";
            return Ok(new { success = true, fileUrl });
        }
        [HttpPost("upload-image")]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("Không có file nào được upload.");
            }

            string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName).ToLower();

            using (var stream = file.OpenReadStream())
            {
                await _storageClient.UploadObjectAsync(_bucketName, uniqueFileName, file.ContentType, stream);
            }

            var fileUrl = $"https://firebasestorage.googleapis.com/v0/b/{_bucketName}/o/{Uri.EscapeDataString(uniqueFileName)}?alt=media";
            return Ok(new { success = true, fileUrl });
        }
    }
}
