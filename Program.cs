using PhotinoNET;
using System.Drawing;

namespace HelloPhotino
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string windowTitle = "Gamepad Test";
            var window = new PhotinoWindow()
                .SetTitle(windowTitle)
                .SetUseOsDefaultSize(false)
                .SetSize(new Size(700, 525))
                .Center()
                .SetResizable(false)
                .Load("wwwroot/index.html"); // <-- can also try with "https://gamepad-tester.com/"
            window.WaitForClose();
        }
    }
}