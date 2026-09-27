using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Helpers.Email
{
    public interface IEmailHelper
    {
        void SendMessage(EmailViewModel email);

    }
}
