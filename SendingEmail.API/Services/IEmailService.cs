namespace SendingEmail.API.Services;

public interface IEmailService
{
    void SendEmail(EmailDto request);
}