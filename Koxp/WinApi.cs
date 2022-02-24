using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Koxp
{
    public unsafe static class WinApi
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern bool ReleaseCapture();
        [DllImport("kernel32.dll")]
        public static extern int ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, long nSize, long lpNumberOfBytesRead);
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);
        [DllImport("kernel32.dll", SetLastError = false)]
        public static extern bool CloseHandle(IntPtr hObject);
        [DllImport("kernel32.dll")]
        public static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, long size, uint lpNumberOfBytesWritten);
        [DllImport("kernel32.dll")]
        public static extern IntPtr VirtualAllocEx(IntPtr hpProcess, IntPtr lpAddress, int dwSize, int flAllocationType, int flProtect);
        [DllImport("kernel32", SetLastError = true)]
        public static extern IntPtr CreateRemoteThread(IntPtr hProcess, int lpThreadAttributes, int dwStackSize, IntPtr lpStartAddress, int lpparameter, int deCreationFlags, ref IntPtr lpThreadID);
        [DllImport("kernel32")]
        public static extern IntPtr WaitForSingleObject(IntPtr hProcess, uint dwMilliseconds);
        [DllImport("kernel32.dll")]
        public static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, int dwFreeType);
    }
    

}
