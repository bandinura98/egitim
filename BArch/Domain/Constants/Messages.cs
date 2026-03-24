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
        /// <summary>
        /// Message used when a username contains empty space or special characters.
        /// </summary>
        public const string CantContainError = "Username can not contain special characters or empty spaces created.";
        /// <summary>
        /// Message used when a username is empty.
        /// </summary>
        public const string Empty = "Username can not be empty.";
        /// <summary>
        /// Message used when a userId is not guid.
        /// </summary>
        public const string FormatInconsistency = "UserID must be GUID.";
        /// <summary>
        /// Message used when a username is empty.
        /// </summary>
        public const string Getted = "Users getted succesfully.";
        /// <summary>
        /// Message used when a username minimum length.
        /// </summary>
        public static string MinimumLength(int x){
            return "Username must contain minimum of " + x + " characters.";
        }
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