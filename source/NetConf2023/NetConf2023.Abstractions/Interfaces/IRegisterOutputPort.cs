namespace NetConf2023.Abstractions.Interfaces;
public interface IRegisterOutputPort
{
    // Id + Correo en Base 64???
    string RegisterId { get; }
    Task HandleAsync(int attendantId);
}
