using QRCoder;
using System.Drawing;

public static class QrCodeServices
{
    public static Bitmap GenerateImage(string content)
    {
        var qrGenerator = new QRCodeGenerator();
        var qrCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
        var qrCode = new QRCode(qrCodeData);
        var qrCodeImage = qrCode.GetGraphic(20);

        return qrCodeImage;
    }

    public static string BitpmapToImageSource(string content)
    {
        var bitmap = GenerateImage(content);
        var imageSource = string.Empty;
        
        using (MemoryStream memoryStream = new MemoryStream())
        {
            bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);

            byte[] imageBytes = memoryStream.ToArray();

            imageSource = $"data:image/png;base64,{Convert.ToBase64String(imageBytes)}";
        }

        return imageSource;
    }
}