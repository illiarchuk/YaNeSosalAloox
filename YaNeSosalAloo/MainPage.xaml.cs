using YaNeSosalAloo;

namespace YaNeSosalAloo;

public partial class MainPage : ContentPage
{
    private int _clickCount = 0;

    public MainPage()
    {
        InitializeComponent();  // Этот вызов связывает код с XAML
    }

    // Метод для обработки нажатия на кнопку
    private void OnCounterClicked(object sender, EventArgs e)
    {
        _clickCount++;
        // Убедись, что CounterLabel доступен в контексте
        CounterLabel.Text = $"Отсосано {_clickCount} раз(а)";
    }
}
