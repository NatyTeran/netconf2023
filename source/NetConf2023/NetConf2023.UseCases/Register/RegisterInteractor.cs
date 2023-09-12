namespace NetConf2023.UseCases.Register;
internal class RegisterInteractor : IRegisterInputPort
{
	readonly IRepository Repository;
	readonly IRegisterOutputPort OutputPort;

	public RegisterInteractor(IRepository repository,
		IRegisterOutputPort outputPort)
	{
		Repository = repository;
		OutputPort = outputPort;
	}

	public async Task RegisterAsync(AttendeeDto attendant)
	{
		int AttendantId = await Repository.RegisterAsync(attendant);
		await OutputPort.HandleAsync(AttendantId);
	}
}
