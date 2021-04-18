namespace AppointmentsData.Web.Application.Commands
{
    //interfejs "hadlera" komend, użyty został tu typ generyczny <T> który musi być typem implementującym interfejs ICommand
    //oznacza to, że jesli klasa będzie implementowala interfejs ICommandHandler<NazwaTypu> to będzie ona musiała implementować metodę Handle(NazwaTypu)
    public interface ICommandHandler<T> where T : ICommand
    {
        int Handle(T command);
    }
}