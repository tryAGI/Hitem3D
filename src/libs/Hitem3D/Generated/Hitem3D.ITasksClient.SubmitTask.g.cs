#nullable enable

namespace Hitem3D
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Submit a 3D generation task<br/>
        /// Creates an asynchronous image-to-3D, multi-view-to-3D, or staged texture task.<br/>
        /// Hitem3D expects multipart/form-data and returns a task_id that can be polled<br/>
        /// with the query-task endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hitem3D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hitem3D.SubmitTaskEnvelope> SubmitTaskAsync(

            global::Hitem3D.SubmitTaskRequest request,
            global::Hitem3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a 3D generation task<br/>
        /// Creates an asynchronous image-to-3D, multi-view-to-3D, or staged texture task.<br/>
        /// Hitem3D expects multipart/form-data and returns a task_id that can be polled<br/>
        /// with the query-task endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hitem3D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hitem3D.AutoSDKHttpResponse<global::Hitem3D.SubmitTaskEnvelope>> SubmitTaskAsResponseAsync(

            global::Hitem3D.SubmitTaskRequest request,
            global::Hitem3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a 3D generation task<br/>
        /// Creates an asynchronous image-to-3D, multi-view-to-3D, or staged texture task.<br/>
        /// Hitem3D expects multipart/form-data and returns a task_id that can be polled<br/>
        /// with the query-task endpoint.
        /// </summary>
        /// <param name="requestType">
        /// 1: geometry only, 2: texture an existing mesh, 3: geometry plus texture.
        /// </param>
        /// <param name="model">
        /// Hitem3D model version, such as hitem3dv2.1 or scene-portraitv2.1.
        /// </param>
        /// <param name="images">
        /// Single image input for image-to-3D.
        /// </param>
        /// <param name="imagesname">
        /// Single image input for image-to-3D.
        /// </param>
        /// <param name="multiImages">
        /// Repeat this multipart field for multi-view image input.
        /// </param>
        /// <param name="multiImagesname">
        /// Repeat this multipart field for multi-view image input.
        /// </param>
        /// <param name="multiImagesBit">
        /// Four-character bitmap indicating which multi-view images were supplied.
        /// </param>
        /// <param name="resolution">
        /// Output resolution, such as 512, 1024, 1536, 1536pro, 1536fast, or 1536profast.
        /// </param>
        /// <param name="meshUrl">
        /// Existing GLB mesh URL used for staged texture generation.
        /// </param>
        /// <param name="mesh">
        /// Existing GLB mesh upload used for staged texture generation.
        /// </param>
        /// <param name="meshname">
        /// Existing GLB mesh upload used for staged texture generation.
        /// </param>
        /// <param name="pbr">
        /// PBR texture toggle. 0 disables PBR, 1 enables PBR.
        /// </param>
        /// <param name="face">
        /// Target face count.
        /// </param>
        /// <param name="format">
        /// Output format. 1 obj, 2 glb, 3 stl, 4 fbx, 5 usdz.
        /// </param>
        /// <param name="callbackUrl"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Hitem3D.SubmitTaskEnvelope> SubmitTaskAsync(
            int? requestType = default,
            string? model = default,
            byte[]? images = default,
            string? imagesname = default,
            byte[]? multiImages = default,
            string? multiImagesname = default,
            string? multiImagesBit = default,
            string? resolution = default,
            string? meshUrl = default,
            byte[]? mesh = default,
            string? meshname = default,
            int? pbr = default,
            int? face = default,
            int? format = default,
            string? callbackUrl = default,
            global::Hitem3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Submit a 3D generation task<br/>
        /// Creates an asynchronous image-to-3D, multi-view-to-3D, or staged texture task.<br/>
        /// Hitem3D expects multipart/form-data and returns a task_id that can be polled<br/>
        /// with the query-task endpoint.
        /// </summary>
        /// <param name="requestType">
        /// 1: geometry only, 2: texture an existing mesh, 3: geometry plus texture.
        /// </param>
        /// <param name="model">
        /// Hitem3D model version, such as hitem3dv2.1 or scene-portraitv2.1.
        /// </param>
        /// <param name="images">
        /// Single image input for image-to-3D.
        /// </param>
        /// <param name="imagesname">
        /// Single image input for image-to-3D.
        /// </param>
        /// <param name="multiImages">
        /// Repeat this multipart field for multi-view image input.
        /// </param>
        /// <param name="multiImagesname">
        /// Repeat this multipart field for multi-view image input.
        /// </param>
        /// <param name="multiImagesBit">
        /// Four-character bitmap indicating which multi-view images were supplied.
        /// </param>
        /// <param name="resolution">
        /// Output resolution, such as 512, 1024, 1536, 1536pro, 1536fast, or 1536profast.
        /// </param>
        /// <param name="meshUrl">
        /// Existing GLB mesh URL used for staged texture generation.
        /// </param>
        /// <param name="mesh">
        /// Existing GLB mesh upload used for staged texture generation.
        /// </param>
        /// <param name="meshname">
        /// Existing GLB mesh upload used for staged texture generation.
        /// </param>
        /// <param name="pbr">
        /// PBR texture toggle. 0 disables PBR, 1 enables PBR.
        /// </param>
        /// <param name="face">
        /// Target face count.
        /// </param>
        /// <param name="format">
        /// Output format. 1 obj, 2 glb, 3 stl, 4 fbx, 5 usdz.
        /// </param>
        /// <param name="callbackUrl"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hitem3D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hitem3D.SubmitTaskEnvelope> SubmitTaskAsync(
            int? requestType = default,
            string? model = default,
            global::System.IO.Stream? images = default,
            string? imagesname = default,
            global::System.IO.Stream? multiImages = default,
            string? multiImagesname = default,
            string? multiImagesBit = default,
            string? resolution = default,
            string? meshUrl = default,
            global::System.IO.Stream? mesh = default,
            string? meshname = default,
            int? pbr = default,
            int? face = default,
            int? format = default,
            string? callbackUrl = default,
            global::Hitem3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a 3D generation task<br/>
        /// Creates an asynchronous image-to-3D, multi-view-to-3D, or staged texture task.<br/>
        /// Hitem3D expects multipart/form-data and returns a task_id that can be polled<br/>
        /// with the query-task endpoint.
        /// </summary>
        /// <param name="requestType">
        /// 1: geometry only, 2: texture an existing mesh, 3: geometry plus texture.
        /// </param>
        /// <param name="model">
        /// Hitem3D model version, such as hitem3dv2.1 or scene-portraitv2.1.
        /// </param>
        /// <param name="images">
        /// Single image input for image-to-3D.
        /// </param>
        /// <param name="imagesname">
        /// Single image input for image-to-3D.
        /// </param>
        /// <param name="multiImages">
        /// Repeat this multipart field for multi-view image input.
        /// </param>
        /// <param name="multiImagesname">
        /// Repeat this multipart field for multi-view image input.
        /// </param>
        /// <param name="multiImagesBit">
        /// Four-character bitmap indicating which multi-view images were supplied.
        /// </param>
        /// <param name="resolution">
        /// Output resolution, such as 512, 1024, 1536, 1536pro, 1536fast, or 1536profast.
        /// </param>
        /// <param name="meshUrl">
        /// Existing GLB mesh URL used for staged texture generation.
        /// </param>
        /// <param name="mesh">
        /// Existing GLB mesh upload used for staged texture generation.
        /// </param>
        /// <param name="meshname">
        /// Existing GLB mesh upload used for staged texture generation.
        /// </param>
        /// <param name="pbr">
        /// PBR texture toggle. 0 disables PBR, 1 enables PBR.
        /// </param>
        /// <param name="face">
        /// Target face count.
        /// </param>
        /// <param name="format">
        /// Output format. 1 obj, 2 glb, 3 stl, 4 fbx, 5 usdz.
        /// </param>
        /// <param name="callbackUrl"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hitem3D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hitem3D.AutoSDKHttpResponse<global::Hitem3D.SubmitTaskEnvelope>> SubmitTaskAsResponseAsync(
            int? requestType = default,
            string? model = default,
            global::System.IO.Stream? images = default,
            string? imagesname = default,
            global::System.IO.Stream? multiImages = default,
            string? multiImagesname = default,
            string? multiImagesBit = default,
            string? resolution = default,
            string? meshUrl = default,
            global::System.IO.Stream? mesh = default,
            string? meshname = default,
            int? pbr = default,
            int? face = default,
            int? format = default,
            string? callbackUrl = default,
            global::Hitem3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}