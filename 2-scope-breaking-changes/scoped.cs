namespace _2_scope_breaking_changes
{
    // Used @ to escape disallowed class name. Only need to escape here, still valid as "scope" everywhere else
    internal class @scoped
    {
        public string Message { get; set; }
        internal scoped(string message)
        {
            Message = message;
        }
    }
}
