namespace ImmesAPI.DTOs;

public class BaseResponse(string mensagem)
{
    public string Mensagem { get; set; } = mensagem;
}