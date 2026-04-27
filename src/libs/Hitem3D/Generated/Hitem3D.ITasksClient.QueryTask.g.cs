#nullable enable

namespace Hitem3D
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Query a task
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hitem3D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hitem3D.TaskEnvelope> QueryTaskAsync(
            string taskId,
            global::Hitem3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}