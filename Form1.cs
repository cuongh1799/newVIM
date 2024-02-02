using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Diagnostics;

namespace newVIM
{
    public partial class Form1 : Form
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0X0101;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;


        public Form1()
        {
            _hookID = SetHook(_proc);
            InitializeComponent();
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                Keys key = (Keys)vkCode;
                int moveAmount = 30; // Change this to the amount you want the cursor to move

                switch (key)
                {
                    case Keys.W:
                        Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y - moveAmount);
                        break;
                    case Keys.A:
                        Cursor.Position = new Point(Cursor.Position.X - moveAmount, Cursor.Position.Y);
                        break;
                    case Keys.S:
                        Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + moveAmount);
                        break;
                    case Keys.D:
                        Cursor.Position = new Point(Cursor.Position.X + moveAmount, Cursor.Position.Y);
                        break;
                    case Keys.Enter:
                        // Simulate right click
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        break;
                }
            }
            else if (nCode >= 0 && wParam == (IntPtr)WM_KEYUP)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                Keys key = (Keys)vkCode;

                switch (key)
                {
                    case Keys.Enter:
                        // Simulate release of mouse button
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        break;
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }


        // Importing function from Windows API
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);



        private void Form1_Load(object sender, EventArgs e)
        {
            // This constantly activates the cursorTracker()
            // Thus keeps the cursorTracker X and Y updated
            Thread trackerThread = new Thread(cursorTracker);
            trackerThread.Start();
        }

        // Track the cursor's position X and Y
        private void cursorTracker()
        {
            while (true)
            {
                int cursorX = MousePosition.X;
                int cursorY = MousePosition.Y;
                cursorXLabel.Text = cursorX.ToString();
                cursorYLabel.Text = cursorY.ToString();
            }
        } 
    }
}
