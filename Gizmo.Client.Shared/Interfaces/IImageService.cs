using Gizmo.UI;

namespace Gizmo.Client
{
    /// <summary>
    /// Service responsible of obtaining Gizmo images (product,app and such)
    /// </summary>
    public interface IImageService
    {
        /// <summary>
        /// Requests image hash.
        /// </summary>
        /// <param name="imageType">Image type.</param>
        /// <param name="imageId">Image id.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Image hash.</returns>
        Task<string> ImageHashGetAsync(ImageType imageType, int imageId, CancellationToken cancellationToken);

        /// <summary>
        /// Requests image stream.
        /// </summary>
        /// <param name="imageType">Image type.</param>
        /// <param name="imageId">Image id.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Image stream.</returns>
        ValueTask<Stream> ImageStreamGetAsync(ImageType imageType, int imageId, CancellationToken cancellationToken);
    }
}