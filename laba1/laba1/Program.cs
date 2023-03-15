
using Mylab1;

ButtonFactory windowsFactory = new WindowsButtonFactory();
Button windowsButton = windowsFactory.CreateButton();
windowsButton.Render();


ButtonFactory macFactory = new MacButtonFactory();
Button macButton = macFactory.CreateButton();
macButton.Render();


ButtonFactory linuxFactory = new LinuxButtonFactory();
Button linuxButton = linuxFactory.CreateButton();
linuxButton.Render();
