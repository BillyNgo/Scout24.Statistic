using System.Linq;

namespace Scout24.Statistic
{
    internal static class ApiErrorExtensions
    {
        public static string FirstErrorMessageSafe(this ApiError apiError)
        {
            if (apiError == null) return null;
            if (apiError.Errors == null) return apiError.Message;
            var firstError = apiError.Errors.FirstOrDefault();
            return firstError == null ? null : firstError.Message;
        }
    }
}
