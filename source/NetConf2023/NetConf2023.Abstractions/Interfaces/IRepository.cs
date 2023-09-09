namespace NetConf2023.Abstractions.Interfaces;
public interface IRepository
{
    Task<int> RegisterAsync(AttendantDto attendant);
}
