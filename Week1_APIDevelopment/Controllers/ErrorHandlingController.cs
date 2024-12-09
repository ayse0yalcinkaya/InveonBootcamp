using Microsoft.AspNetCore.Mvc;
using System;
using Week1_APIDevelopment.Models;

namespace Week1_APIDevelopment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ErrorHandlingController : ControllerBase
    {
        [HttpGet("cause-error")]
        public IActionResult CauseError(int errorType)
        {
            try
            {
                if (errorType == 1)
                    throw new KeyNotFoundException("İstenilen ürün bulunamadı!");
                if (errorType == 2)
                    throw new UnauthorizedAccessException("Erişilemez! Yetkiniz bulunmamakta.");
                throw new Exception("Beklenmeyen bir hata oluştu.");
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new ErrorResponse { StatusCode = 404, Message = ex.Message });
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new ErrorResponse { StatusCode = 401, Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse { StatusCode = 500, Message = ex.Message });
            }
        }
    }
}

