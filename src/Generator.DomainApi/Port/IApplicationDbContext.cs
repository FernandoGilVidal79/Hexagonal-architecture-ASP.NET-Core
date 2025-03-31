namespace $safeprojectname$.DomainApi.Port
{
    public interface IApplicationDbContext
    {
        public IDealSet Deals { get; set; }
    }
}
