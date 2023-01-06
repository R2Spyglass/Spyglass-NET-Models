namespace SpyglassNET.Utilities
{
    public static class SpyglassUtils
    {
        /// <summary>
        /// Checks if the given unique id (UID) is valid.
        /// </summary>
        /// <param name="uniqueId">The unique id to validate based on known possible unique ids.</param>
        /// <returns> True if the unique id is formatted correctly, false if not. </returns>
        public static bool ValidateUniqueId(string? uniqueId)
        {
            if (string.IsNullOrWhiteSpace(uniqueId))
            {
                return false;
            }

            if (uniqueId.Length > 20)
            {
                return false;
            }

            return ulong.TryParse(uniqueId, out ulong parsed);
        }
        
        /// <summary>
        /// Returns a string representation of the time left for a time span.
        /// </summary>
        /// <param name="span"> The timespan to return the string form for. </param>
        public static string GetTimespanString(TimeSpan span)
        {
            var duration = span.Duration();
            // Amount of displayed time left components (year, month, day etc). We only want at most 3.
            var weeks = Convert.ToInt32(Math.Floor(duration.Days / 7.0d));
            var componentAmount = 0;
            var components = new[] { weeks, duration.Days - weeks * 7, duration.Hours, duration.Minutes, duration.Seconds };
            var singular = new[] { "week", "day", "hour", "minute", "second" };
            var plural = new[] { "weeks", "days", "hours", "minutes", "seconds" };

            var formatted = string.Empty;
            for (int i = 0; i < components.Length; ++i)
            {
                var amount = components[i];
                if (amount > 0)
                {
                    formatted += $"{amount:0} {(amount == 1 ? singular[i] : plural[i])}, ";
                    componentAmount++;
                }

                if (componentAmount == 2)
                {
                    break;
                }
            }

            if (formatted.EndsWith(", "))
            {
                formatted = formatted.Substring(0, formatted.Length - 2);
            }

            if (string.IsNullOrEmpty(formatted))
            {
                formatted = "0 seconds";
            }

            return formatted;
        }
    }
}

