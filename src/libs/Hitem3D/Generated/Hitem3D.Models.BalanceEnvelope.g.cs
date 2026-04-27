#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Hitem3D
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BalanceEnvelope : global::System.IEquatable<BalanceEnvelope>
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
#if NET6_0_OR_GREATER
        public global::Hitem3D.BalanceEnvelopeVariant2? BalanceEnvelopeVariant2 { get; init; }
#else
        public global::Hitem3D.BalanceEnvelopeVariant2? BalanceEnvelopeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BalanceEnvelopeVariant2))]
#endif
        public bool IsBalanceEnvelopeVariant2 => BalanceEnvelopeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BalanceEnvelope(global::Hitem3D.ApiEnvelope value) => new BalanceEnvelope((global::Hitem3D.ApiEnvelope?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hitem3D.ApiEnvelope?(BalanceEnvelope @this) => @this.Api;

        /// <summary>
        /// 
        /// </summary>
        public BalanceEnvelope(global::Hitem3D.ApiEnvelope? value)
        {
            Api = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BalanceEnvelope(global::Hitem3D.BalanceEnvelopeVariant2 value) => new BalanceEnvelope((global::Hitem3D.BalanceEnvelopeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hitem3D.BalanceEnvelopeVariant2?(BalanceEnvelope @this) => @this.BalanceEnvelopeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public BalanceEnvelope(global::Hitem3D.BalanceEnvelopeVariant2? value)
        {
            BalanceEnvelopeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BalanceEnvelope(
            global::Hitem3D.ApiEnvelope? api,
            global::Hitem3D.BalanceEnvelopeVariant2? balanceEnvelopeVariant2
            )
        {
            Api = api;
            BalanceEnvelopeVariant2 = balanceEnvelopeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BalanceEnvelopeVariant2 as object ??
            Api as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Api?.ToString() ??
            BalanceEnvelopeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApi && IsBalanceEnvelopeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Hitem3D.ApiEnvelope?, TResult>? api = null,
            global::System.Func<global::Hitem3D.BalanceEnvelopeVariant2?, TResult>? balanceEnvelopeVariant2 = null,
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
            else if (IsBalanceEnvelopeVariant2 && balanceEnvelopeVariant2 != null)
            {
                return balanceEnvelopeVariant2(BalanceEnvelopeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Hitem3D.ApiEnvelope?>? api = null,
            global::System.Action<global::Hitem3D.BalanceEnvelopeVariant2?>? balanceEnvelopeVariant2 = null,
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
            else if (IsBalanceEnvelopeVariant2)
            {
                balanceEnvelopeVariant2?.Invoke(BalanceEnvelopeVariant2!);
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
                BalanceEnvelopeVariant2,
                typeof(global::Hitem3D.BalanceEnvelopeVariant2),
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
        public bool Equals(BalanceEnvelope other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Hitem3D.ApiEnvelope?>.Default.Equals(Api, other.Api) &&
                global::System.Collections.Generic.EqualityComparer<global::Hitem3D.BalanceEnvelopeVariant2?>.Default.Equals(BalanceEnvelopeVariant2, other.BalanceEnvelopeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BalanceEnvelope obj1, BalanceEnvelope obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BalanceEnvelope>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BalanceEnvelope obj1, BalanceEnvelope obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BalanceEnvelope o && Equals(o);
        }
    }
}
