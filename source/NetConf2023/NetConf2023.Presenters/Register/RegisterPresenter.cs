namespace NetConf2023.Presenters.Register;
internal class RegisterPresenter : IRegisterOutputPort
{
	public string RegisterId { get; private set; }

	public async Task HandleAsync(int attendantId)
	{
		// Id + Correo en Base 64???
		RegisterId = Convert.ToBase64String(
			Encoding.UTF8.GetBytes(attendantId.ToString()));
	}
}
