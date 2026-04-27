
#nullable enable

namespace Hitem3D
{
    /// <summary>
    /// 
    /// </summary>
    public enum TaskDataState
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Queueing,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskDataStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskDataState value)
        {
            return value switch
            {
                TaskDataState.Created => "created",
                TaskDataState.Failed => "failed",
                TaskDataState.Processing => "processing",
                TaskDataState.Queueing => "queueing",
                TaskDataState.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskDataState? ToEnum(string value)
        {
            return value switch
            {
                "created" => TaskDataState.Created,
                "failed" => TaskDataState.Failed,
                "processing" => TaskDataState.Processing,
                "queueing" => TaskDataState.Queueing,
                "success" => TaskDataState.Success,
                _ => null,
            };
        }
    }
}