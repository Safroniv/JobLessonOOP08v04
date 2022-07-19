namespace JobLessonOOP08v04Part01.ElementsFileSystem
{
    public abstract class BaseElementOfFileSystem
    {
        public string? Name { get; set; }
        public string? Path { get; set; }
        public DateTime? CreateDate { get; set; }
        public abstract TypeElementOfFileSystem Type { get; }
    }
}