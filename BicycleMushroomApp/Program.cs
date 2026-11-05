namespace BicycleMushroomApp;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        // The Login form is the main form: the app lives as long as it does.
        Application.Run(new LoginForm());
    }
}
