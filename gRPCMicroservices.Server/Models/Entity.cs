namespace gRPCMicroservices.Server.Models
{
    public class Entity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public DateTime UpdateDate { get; set; } = DateTime.UtcNow;
        public bool isDeleted { get; set; }
    }
}
