#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Hitem3D
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TaskEnvelope : global::System.IEquatable<TaskEnvelope>
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
        public global::Hitem3D.TaskEnvelopeVariant2? TaskEnvelopeVariant2 { get; init; }
#else
        public global::Hitem3D.TaskEnvelopeVariant2? TaskEnvelopeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TaskEnvelopeVariant2))]
#endif
        public bool IsTaskEnvelopeVariant2 => TaskEnvelopeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TaskEnvelope(global::Hitem3D.ApiEnvelope value) => new TaskEnvelope((global::Hitem3D.ApiEnvelope?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hitem3D.ApiEnvelope?(TaskEnvelope @this) => @this.Api;

        /// <summary>
        /// 
        /// </summary>
        public TaskEnvelope(global::Hitem3D.ApiEnvelope? value)
        {
            Api = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TaskEnvelope(global::Hitem3D.TaskEnvelopeVariant2 value) => new TaskEnvelope((global::Hitem3D.TaskEnvelopeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hitem3D.TaskEnvelopeVariant2?(TaskEnvelope @this) => @this.TaskEnvelopeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TaskEnvelope(global::Hitem3D.TaskEnvelopeVariant2? value)
        {
            TaskEnvelopeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TaskEnvelope(
            global::Hitem3D.ApiEnvelope? api,
            global::Hitem3D.TaskEnvelopeVariant2? taskEnvelopeVariant2
            )
        {
            Api = api;
            TaskEnvelopeVariant2 = taskEnvelopeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TaskEnvelopeVariant2 as object ??
            Api as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Api?.ToString() ??
            TaskEnvelopeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApi && IsTaskEnvelopeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Hitem3D.ApiEnvelope?, TResult>? api = null,
            global::System.Func<global::Hitem3D.TaskEnvelopeVariant2?, TResult>? taskEnvelopeVariant2 = null,
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
            else if (IsTaskEnvelopeVariant2 && taskEnvelopeVariant2 != null)
            {
                return taskEnvelopeVariant2(TaskEnvelopeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Hitem3D.ApiEnvelope?>? api = null,
            global::System.Action<global::Hitem3D.TaskEnvelopeVariant2?>? taskEnvelopeVariant2 = null,
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
            else if (IsTaskEnvelopeVariant2)
            {
                taskEnvelopeVariant2?.Invoke(TaskEnvelopeVariant2!);
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
                TaskEnvelopeVariant2,
                typeof(global::Hitem3D.TaskEnvelopeVariant2),
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
        public bool Equals(TaskEnvelope other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Hitem3D.ApiEnvelope?>.Default.Equals(Api, other.Api) &&
                global::System.Collections.Generic.EqualityComparer<global::Hitem3D.TaskEnvelopeVariant2?>.Default.Equals(TaskEnvelopeVariant2, other.TaskEnvelopeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TaskEnvelope obj1, TaskEnvelope obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TaskEnvelope>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TaskEnvelope obj1, TaskEnvelope obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TaskEnvelope o && Equals(o);
        }
    }
}
