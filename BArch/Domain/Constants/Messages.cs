namespace Domain.Constants;

/// <summary>
/// Contains Domain-wide constant values and messages.
/// </summary>
public static class Messages
{
    /// <summary>
    /// Represents a generic "Not Found" message.
    /// </summary>
    public const string NotFound = nameof(NotFound);

    /// <summary>
    /// Contains constants specifically related to users.
    /// </summary>
    public static class User
    {
        /// <summary>
        /// Message used when a user is not found.
        /// </summary>
        public const string NotFound = "User not found.";
        /// <summary>
        /// Message used when a user is not created.
        /// </summary>
        public const string NotCreated = "User not created.";
        /// <summary>
        /// Message used when a user is  created.
        /// </summary>
        public const string Created = "User created.";
    }
   
    /// <summary>
    /// Contains constants specifically related to AIModel.
    /// </summary>
    public static class AIModel
    {
        /// <summary>
        /// Message used when a AIModel is not found.
        /// </summary>
        public const string NotFound = "AI Model not found.";
    }

    /// <summary>
    /// Contains constants related to AI model checkers.
    /// </summary>
    public static class ModelChecker
    {
        /// <summary>
        /// Default AI model name used in the application (e.g., "GaussianNB").
        /// </summary>
        public const string Name = "GaussianNB";
    }
}