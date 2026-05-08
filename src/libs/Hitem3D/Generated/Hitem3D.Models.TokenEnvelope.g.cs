#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Hitem3D
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TokenEnvelope : global::System.IEquatable<TokenEnvelope>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hitem3D.ApiEnvelope? Api { get; init; }
#else
        public global::Hitem3D.ApiEnvelope? Api { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Api))]
#endif
        public bool IsApi => Api != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApi(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Hitem3D.ApiEnvelope? value)
        {
            value = Api;
            return IsApi;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hitem3D.TokenEnvelopeVariant2? TokenEnvelopeVariant2 { get; init; }
#else
        public global::Hitem3D.TokenEnvelopeVariant2? TokenEnvelopeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TokenEnvelopeVariant2))]
#endif
        public bool IsTokenEnvelopeVariant2 => TokenEnvelopeVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTokenEnvelopeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Hitem3D.TokenEnvelopeVariant2? value)
        {
            value = TokenEnvelopeVariant2;
            return IsTokenEnvelopeVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TokenEnvelope(global::Hitem3D.ApiEnvelope value) => new TokenEnvelope((global::Hitem3D.ApiEnvelope?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hitem3D.ApiEnvelope?(TokenEnvelope @this) => @this.Api;

        /// <summary>
        /// 
        /// </summary>
        public TokenEnvelope(global::Hitem3D.ApiEnvelope? value)
        {
            Api = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TokenEnvelope(global::Hitem3D.TokenEnvelopeVariant2 value) => new TokenEnvelope((global::Hitem3D.TokenEnvelopeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hitem3D.TokenEnvelopeVariant2?(TokenEnvelope @this) => @this.TokenEnvelopeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TokenEnvelope(global::Hitem3D.TokenEnvelopeVariant2? value)
        {
            TokenEnvelopeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TokenEnvelope(
            global::Hitem3D.ApiEnvelope? api,
            global::Hitem3D.TokenEnvelopeVariant2? tokenEnvelopeVariant2
            )
        {
            Api = api;
            TokenEnvelopeVariant2 = tokenEnvelopeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TokenEnvelopeVariant2 as object ??
            Api as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Api?.ToString() ??
            TokenEnvelopeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApi && IsTokenEnvelopeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Hitem3D.ApiEnvelope, TResult>? api = null,
            global::System.Func<global::Hitem3D.TokenEnvelopeVariant2, TResult>? tokenEnvelopeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApi && api != null)
            {
                return api(Api!);
            }
            else if (IsTokenEnvelopeVariant2 && tokenEnvelopeVariant2 != null)
            {
                return tokenEnvelopeVariant2(TokenEnvelopeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Hitem3D.ApiEnvelope>? api = null,

            global::System.Action<global::Hitem3D.TokenEnvelopeVariant2>? tokenEnvelopeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApi)
            {
                api?.Invoke(Api!);
            }
            else if (IsTokenEnvelopeVariant2)
            {
                tokenEnvelopeVariant2?.Invoke(TokenEnvelopeVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Hitem3D.ApiEnvelope>? api = null,
            global::System.Action<global::Hitem3D.TokenEnvelopeVariant2>? tokenEnvelopeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApi)
            {
                api?.Invoke(Api!);
            }
            else if (IsTokenEnvelopeVariant2)
            {
                tokenEnvelopeVariant2?.Invoke(TokenEnvelopeVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Api,
                typeof(global::Hitem3D.ApiEnvelope),
                TokenEnvelopeVariant2,
                typeof(global::Hitem3D.TokenEnvelopeVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(TokenEnvelope other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Hitem3D.ApiEnvelope?>.Default.Equals(Api, other.Api) &&
                global::System.Collections.Generic.EqualityComparer<global::Hitem3D.TokenEnvelopeVariant2?>.Default.Equals(TokenEnvelopeVariant2, other.TokenEnvelopeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TokenEnvelope obj1, TokenEnvelope obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TokenEnvelope>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TokenEnvelope obj1, TokenEnvelope obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TokenEnvelope o && Equals(o);
        }
    }
}
