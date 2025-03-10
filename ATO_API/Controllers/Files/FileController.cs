using Microsoft.AspNetCore.Mvc;

namespace ATO_API.Controllers.Files
{
    [Route("api/file")]
    [ApiController]
    public class FileController : ControllerBase
    {
        // Folder where files will be uploaded (can be adjusted)
        private readonly string _uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");

        public FileController()
        {
            // Ensure the upload folder exists
            if (!Directory.Exists(_uploadFolder))
            {
                Directory.CreateDirectory(_uploadFolder);
            }
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
    }
}
