
#nullable enable

namespace Hitem3D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitTaskRequest
    {
        /// <summary>
        /// 1: geometry only, 2: texture an existing mesh, 3: geometry plus texture.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_type")]
        public int? RequestType { get; set; }

        /// <summary>
        /// Hitem3D model version, such as hitem3dv2.1 or scene-portraitv2.1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Single image input for image-to-3D.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public byte[]? Images { get; set; }

        /// <summary>
        /// Single image input for image-to-3D.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagesname")]
        public string? Imagesname { get; set; }

        /// <summary>
        /// Repeat this multipart field for multi-view image input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_images")]
        public byte[]? MultiImages { get; set; }

        /// <summary>
        /// Repeat this multipart field for multi-view image input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_imagesname")]
        public string? MultiImagesname { get; set; }

        /// <summary>
        /// Four-character bitmap indicating which multi-view images were supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_images_bit")]
        public string? MultiImagesBit { get; set; }

        /// <summary>
        /// Output resolution, such as 512, 1024, 1536, 1536pro, 1536fast, or 1536profast.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public string? Resolution { get; set; }

        /// <summary>
        /// Existing GLB mesh URL used for staged texture generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mesh_url")]
        public string? MeshUrl { get; set; }

        /// <summary>
        /// Existing GLB mesh upload used for staged texture generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mesh")]
        public byte[]? Mesh { get; set; }

        /// <summary>
        /// Existing GLB mesh upload used for staged texture generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meshname")]
        public string? Meshname { get; set; }

        /// <summary>
        /// PBR texture toggle. 0 disables PBR, 1 enables PBR.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pbr")]
        public int? Pbr { get; set; }

        /// <summary>
        /// Target face count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face")]
        public int? Face { get; set; }

        /// <summary>
        /// Output format. 1 obj, 2 glb, 3 stl, 4 fbx, 5 usdz.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public int? Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitTaskRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitTaskRequest(
            int? requestType,
            string? model,
            byte[]? images,
            string? imagesname,
            byte[]? multiImages,
            string? multiImagesname,
            string? multiImagesBit,
            string? resolution,
            string? meshUrl,
            byte[]? mesh,
            string? meshname,
            int? pbr,
            int? face,
            int? format,
            string? callbackUrl)
        {
            this.RequestType = requestType;
            this.Model = model;
            this.Images = images;
            this.Imagesname = imagesname;
            this.MultiImages = multiImages;
            this.MultiImagesname = multiImagesname;
            this.MultiImagesBit = multiImagesBit;
            this.Resolution = resolution;
            this.MeshUrl = meshUrl;
            this.Mesh = mesh;
            this.Meshname = meshname;
            this.Pbr = pbr;
            this.Face = face;
            this.Format = format;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitTaskRequest" /> class.
        /// </summary>
        public SubmitTaskRequest()
        {
        }
    }
}