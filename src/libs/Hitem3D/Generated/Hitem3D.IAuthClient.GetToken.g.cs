#nullable enable

namespace Hitem3D
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Get an access token
        /// </summary>
        /// <param name="authorization">
        /// Example: Basic Y2xpZW50X2lkOmNsaWVudF9zZWNyZXQ=
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hitem3D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hitem3D.TokenEnvelope> GetTokenAsync(
            string authorization,

            global::Hitem3D.GetTokenRequest request,
            global::Hitem3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an access token
        /// </summary>
        /// <param name="authorization">
        /// Example: Basic Y2xpZW50X2lkOmNsaWVudF9zZWNyZXQ=
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Hitem3D.TokenEnvelope> GetTokenAsync(
            string authorization,
            global::Hitem3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}