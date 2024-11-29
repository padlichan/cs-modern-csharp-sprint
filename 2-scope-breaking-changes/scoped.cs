namespace _2_scope_breaking_changes
{
    internal class scoped
    {
        public string Message { get; set; }
        internal scoped(string message)
        {
            Message = message;
        }
    }
}
