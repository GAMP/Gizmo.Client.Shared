﻿using Gizmo.UI;

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
        /// <remarks>
        /// The function should never throw, empty string is returned in case of an error or in case image hash cant be obtained.
        /// </remarks>
        /// <exception cref="OperationCanceledException"></exception>
        Task<string> ImageHashGetAsync(ImageType imageType, int imageId, CancellationToken cancellationToken);

        /// <summary>
        /// Requests image stream.
        /// </summary>
        /// <param name="imageType">Image type.</param>
        /// <param name="imageId">Image id.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Image stream.</returns>
        /// <remarks>
        /// The <paramref name="imageId"/> depends on ImageType, in case of executable or application the <paramref name="imageId"/> should be equal to application or executable id.<br></br>
        /// Since single product can have multiple images in case of product it should be equal to product image id instead of product id itself.<br></br>
        /// The function should never throw, empty stream is returned in case of an error or in case image data cant be obtained.
        /// </remarks>
        /// <exception cref="OperationCanceledException"></exception>
        ValueTask<Stream> ImageStreamGetAsync(ImageType imageType, int imageId, CancellationToken cancellationToken);
    }
}
