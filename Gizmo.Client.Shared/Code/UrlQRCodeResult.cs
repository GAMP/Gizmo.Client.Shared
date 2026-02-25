namespace Gizmo.Client
{
    /// <summary>
    /// Url qr code generation result.
    /// </summary>
    public sealed class UrlQRCodeResult
    {
        /// <summary>
        /// Generated QR code.
        /// </summary>
        public string QRCode { get; init; } = null!;
    }
}
