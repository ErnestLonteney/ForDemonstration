namespace EntityProblem
{
    class Document : IEntity<string>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public DateOnly Date { get; set; }
    }
}
