namespace NetConf2023.Abstractions.Interfaces;
public interface IRegisterInputPort
{
    Task RegisterAsync(AttendantDto attendant);
}
