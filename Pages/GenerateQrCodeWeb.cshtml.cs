using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace render_qrcode_web.Pages;

public class GenerateQrCodeWebModel : PageModel
{
    private readonly ILogger<GenerateQrCodeWebModel> _logger;

    public GenerateQrCodeWebModel(ILogger<GenerateQrCodeWebModel> logger)
    {
        _logger = logger;
    }

   [Required(ErrorMessage="Favor informar o conteúdo do QR Code!")]
    public string ContentQrCode { get; set; } = null!;

    public void OnGet()
    {
    }
}

