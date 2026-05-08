#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Hitem3D
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SubmitTaskEnvelope : global::System.IEquatable<SubmitTaskEnvelope>
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
        public global::Hitem3D.SubmitTaskEnvelopeVariant2? SubmitTaskEnvelopeVariant2 { get; init; }
#else
        public global::Hitem3D.SubmitTaskEnvelopeVariant2? SubmitTaskEnvelopeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubmitTaskEnvelopeVariant2))]
#endif
        public bool IsSubmitTaskEnvelopeVariant2 => SubmitTaskEnvelopeVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSubmitTaskEnvelopeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Hitem3D.SubmitTaskEnvelopeVariant2? value)
        {
            value = SubmitTaskEnvelopeVariant2;
            return IsSubmitTaskEnvelopeVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SubmitTaskEnvelope(global::Hitem3D.ApiEnvelope value) => new SubmitTaskEnvelope((global::Hitem3D.ApiEnvelope?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hitem3D.ApiEnvelope?(SubmitTaskEnvelope @this) => @this.Api;

        /// <summary>
        /// 
        /// </summary>
        public SubmitTaskEnvelope(global::Hitem3D.ApiEnvelope? value)
        {
            Api = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SubmitTaskEnvelope(global::Hitem3D.SubmitTaskEnvelopeVariant2 value) => new SubmitTaskEnvelope((global::Hitem3D.SubmitTaskEnvelopeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hitem3D.SubmitTaskEnvelopeVariant2?(SubmitTaskEnvelope @this) => @this.SubmitTaskEnvelopeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SubmitTaskEnvelope(global::Hitem3D.SubmitTaskEnvelopeVariant2? value)
        {
            SubmitTaskEnvelopeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SubmitTaskEnvelope(
            global::Hitem3D.ApiEnvelope? api,
            global::Hitem3D.SubmitTaskEnvelopeVariant2? submitTaskEnvelopeVariant2
            )
        {
            Api = api;
            SubmitTaskEnvelopeVariant2 = submitTaskEnvelopeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SubmitTaskEnvelopeVariant2 as object ??
            Api as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Api?.ToString() ??
            SubmitTaskEnvelopeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApi && IsSubmitTaskEnvelopeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Hitem3D.ApiEnvelope, TResult>? api = null,
            global::System.Func<global::Hitem3D.SubmitTaskEnvelopeVariant2, TResult>? submitTaskEnvelopeVariant2 = null,
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
            else if (IsSubmitTaskEnvelopeVariant2 && submitTaskEnvelopeVariant2 != null)
            {
                return submitTaskEnvelopeVariant2(SubmitTaskEnvelopeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Hitem3D.ApiEnvelope>? api = null,

            global::System.Action<global::Hitem3D.SubmitTaskEnvelopeVariant2>? submitTaskEnvelopeVariant2 = null,
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
            else if (IsSubmitTaskEnvelopeVariant2)
            {
                submitTaskEnvelopeVariant2?.Invoke(SubmitTaskEnvelopeVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Hitem3D.ApiEnvelope>? api = null,
            global::System.Action<global::Hitem3D.SubmitTaskEnvelopeVariant2>? submitTaskEnvelopeVariant2 = null,
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
            else if (IsSubmitTaskEnvelopeVariant2)
            {
                submitTaskEnvelopeVariant2?.Invoke(SubmitTaskEnvelopeVariant2!);
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
                SubmitTaskEnvelopeVariant2,
                typeof(global::Hitem3D.SubmitTaskEnvelopeVariant2),
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
        public bool Equals(SubmitTaskEnvelope other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Hitem3D.ApiEnvelope?>.Default.Equals(Api, other.Api) &&
                global::System.Collections.Generic.EqualityComparer<global::Hitem3D.SubmitTaskEnvelopeVariant2?>.Default.Equals(SubmitTaskEnvelopeVariant2, other.SubmitTaskEnvelopeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SubmitTaskEnvelope obj1, SubmitTaskEnvelope obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SubmitTaskEnvelope>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SubmitTaskEnvelope obj1, SubmitTaskEnvelope obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SubmitTaskEnvelope o && Equals(o);
        }
    }
}
