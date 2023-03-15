namespace Mylab1
{
    // Клас абстрактної кнопки
    public abstract class Button
    {
        public abstract void Render();
    }

    // Клас абстрактної фабрики кнопок
    public abstract class ButtonFactory
    {
        public abstract Button CreateButton();
    }

    // Класи конкретних фабрик кнопок
    public class WindowsButtonFactory : ButtonFactory
    {
        public override Button CreateButton()
        {
            return new WindowsButton();
        }
    }

    public class MacButtonFactory : ButtonFactory
    {
        public override Button CreateButton()
        {
            return new MacButton();
        }
    }

    public class LinuxButtonFactory : ButtonFactory
    {
        public override Button CreateButton()
        {
            return new LinuxButton();
        }
    }

    // Класи конкретних кнопок
    public class WindowsButton : Button
    {
        public override void Render()
        {
            Console.WriteLine("Rendering Windows button");
        }
    }

    public class MacButton : Button
    {
        public override void Render()
        {
            Console.WriteLine("Rendering Mac button");
        }
    }

    public class LinuxButton : Button
    {
        public override void Render()
        {
            Console.WriteLine("Rendering Linux button");
        }
    }

}