
#nullable enable

namespace Hitem3D
{
    public partial class TasksClient
    {


        private static readonly global::Hitem3D.EndPointSecurityRequirement s_SubmitTaskSecurityRequirement0 =
            new global::Hitem3D.EndPointSecurityRequirement
            {
                Authorizations = new global::Hitem3D.EndPointAuthorizationRequirement[]
                {                    new global::Hitem3D.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "BearerAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Hitem3D.EndPointSecurityRequirement[] s_SubmitTaskSecurityRequirements =
            new global::Hitem3D.EndPointSecurityRequirement[]
            {                s_SubmitTaskSecurityRequirement0,
            };
        partial void PrepareSubmitTaskArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Hitem3D.SubmitTaskRequest request);
        partial void PrepareSubmitTaskRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Hitem3D.SubmitTaskRequest request);
        partial void ProcessSubmitTaskResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSubmitTaskResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::Hitem3D.SubmitTaskEnvelope> SubmitTaskAsync(

            global::Hitem3D.SubmitTaskRequest request,
            global::Hitem3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSubmitTaskArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Hitem3D.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SubmitTaskSecurityRequirements,
                operationName: "SubmitTaskAsync");

            using var __timeoutCancellationTokenSource = global::Hitem3D.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Hitem3D.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Hitem3D.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::Hitem3D.PathBuilder(
                                path: "/open-api/v1/submit-task",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Hitem3D.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            if (request.RequestType != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.RequestType}"),
                                    name: "\"request_type\"");
                            } 
                            if (request.Model != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.Model}"),
                                    name: "\"model\"");
                            } 
                            if (request.Images != default)
                            {

                                var __contentImages = new global::System.Net.Http.ByteArrayContent(request.Images ?? global::System.Array.Empty<byte>());
                                __httpRequestContent.Add(
                                    content: __contentImages,
                                    name: "\"images\"",
                                    fileName: request.Imagesname != null ? $"\"{request.Imagesname}\"" : string.Empty);
                                if (__contentImages.Headers.ContentDisposition != null)
                                {
                                    __contentImages.Headers.ContentDisposition.FileNameStar = null;
                                }
                            } 
                            if (request.MultiImages != default)
                            {

                                var __contentMultiImages = new global::System.Net.Http.ByteArrayContent(request.MultiImages ?? global::System.Array.Empty<byte>());
                                __httpRequestContent.Add(
                                    content: __contentMultiImages,
                                    name: "\"multi_images\"",
                                    fileName: request.MultiImagesname != null ? $"\"{request.MultiImagesname}\"" : string.Empty);
                                if (__contentMultiImages.Headers.ContentDisposition != null)
                                {
                                    __contentMultiImages.Headers.ContentDisposition.FileNameStar = null;
                                }
                            } 
                            if (request.MultiImagesBit != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.MultiImagesBit}"),
                                    name: "\"multi_images_bit\"");
                            } 
                            if (request.Resolution != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.Resolution}"),
                                    name: "\"resolution\"");
                            } 
                            if (request.MeshUrl != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.MeshUrl}"),
                                    name: "\"mesh_url\"");
                            } 
                            if (request.Mesh != default)
                            {

                                var __contentMesh = new global::System.Net.Http.ByteArrayContent(request.Mesh ?? global::System.Array.Empty<byte>());
                                __httpRequestContent.Add(
                                    content: __contentMesh,
                                    name: "\"mesh\"",
                                    fileName: request.Meshname != null ? $"\"{request.Meshname}\"" : string.Empty);
                                if (__contentMesh.Headers.ContentDisposition != null)
                                {
                                    __contentMesh.Headers.ContentDisposition.FileNameStar = null;
                                }
                            } 
                            if (request.Pbr != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.Pbr}"),
                                    name: "\"pbr\"");
                            } 
                            if (request.Face != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.Face}"),
                                    name: "\"face\"");
                            } 
                            if (request.Format != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.Format}"),
                                    name: "\"format\"");
                            } 
                            if (request.CallbackUrl != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.CallbackUrl}"),
                                    name: "\"callback_url\"");
                            }
                            __httpRequest.Content = __httpRequestContent;
                global::Hitem3D.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareSubmitTaskRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Hitem3D.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Hitem3D.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SubmitTask",
                                methodName: "SubmitTaskAsync",
                                pathTemplate: "\"/open-api/v1/submit-task\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Hitem3D.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Hitem3D.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SubmitTask",
                                methodName: "SubmitTaskAsync",
                                pathTemplate: "\"/open-api/v1/submit-task\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Hitem3D.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Hitem3D.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Hitem3D.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Hitem3D.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SubmitTask",
                                methodName: "SubmitTaskAsync",
                                pathTemplate: "\"/open-api/v1/submit-task\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Hitem3D.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessSubmitTaskResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Hitem3D.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Hitem3D.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SubmitTask",
                                methodName: "SubmitTaskAsync",
                                pathTemplate: "\"/open-api/v1/submit-task\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Hitem3D.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Hitem3D.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SubmitTask",
                                methodName: "SubmitTaskAsync",
                                pathTemplate: "\"/open-api/v1/submit-task\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessSubmitTaskResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Hitem3D.SubmitTaskEnvelope.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::Hitem3D.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::Hitem3D.SubmitTaskEnvelope.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::Hitem3D.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
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
        public async global::System.Threading.Tasks.Task<global::Hitem3D.SubmitTaskEnvelope> SubmitTaskAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Hitem3D.SubmitTaskRequest
            {
                RequestType = requestType,
                Model = model,
                Images = images,
                Imagesname = imagesname,
                MultiImages = multiImages,
                MultiImagesname = multiImagesname,
                MultiImagesBit = multiImagesBit,
                Resolution = resolution,
                MeshUrl = meshUrl,
                Mesh = mesh,
                Meshname = meshname,
                Pbr = pbr,
                Face = face,
                Format = format,
                CallbackUrl = callbackUrl,
            };

            return await SubmitTaskAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}