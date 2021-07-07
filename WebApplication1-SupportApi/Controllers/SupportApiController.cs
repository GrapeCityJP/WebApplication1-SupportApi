using Microsoft.AspNetCore.Mvc;
using SupportApi.Controllers;

namespace WebApplication1_SupportApi.Controllers
{
    [Route("api/pdf-viewer")]
    [ApiController]
    public class SupportApiController : GcPdfViewerController
    {
    }
}
