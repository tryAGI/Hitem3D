#nullable enable

namespace Hitem3D
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// Query account balance
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hitem3D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hitem3D.BalanceEnvelope> GetBalanceAsync(
            global::Hitem3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query account balance
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hitem3D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hitem3D.AutoSDKHttpResponse<global::Hitem3D.BalanceEnvelope>> GetBalanceAsResponseAsync(
            global::Hitem3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}