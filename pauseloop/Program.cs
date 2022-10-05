// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Runtime.InteropServices;

[DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0; // hide window
        const int SW_SHOW = 5; // show window
var handle = GetConsoleWindow();
            ShowWindow(handle, SW_SHOW); //hide application
            

            //run the task async in order to avoid the high cpu usage
            async Task IFloop()
            {
                try
                {
                    while (true) // infinite loop
                    {
                        await Task.Delay(5100); // loop the code with delay for low cpu usage.
                    }
                }
                catch { }
            }

            try
            {
                await IFloop(); //scan the processes infinitely.
            }
            catch { }
