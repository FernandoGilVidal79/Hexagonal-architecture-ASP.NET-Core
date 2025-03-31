using System.ComponentModel.DataAnnotations;

namespace $safeprojectname$.DomainApi
{
    public class BaseEntity<TKey>
    {
        [Key]
        public TKey Id { get; set; }
    }
}
