using Microsoft.AspNetCore.Mvc.RazorPages;

namespace render_qrcode_web.Pages;

public class RenderQrCodeWebModel : PageModel
{
    private readonly ILogger<RenderQrCodeWebModel> _logger;

    public RenderQrCodeWebModel(ILogger<RenderQrCodeWebModel> logger)
    {
        _logger = logger;
    }

    public string imageSource = "";

    public void OnPost(string content)
    {
        imageSource = QrCodeServices.BitpmapToImageSource(Request.Form["ContentQrCode"]);
    }
}

