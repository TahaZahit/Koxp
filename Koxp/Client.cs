using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koxp
{
    public class Client
    {
        public Char Char;
        public IntPtr ClientHandle;
        public string AttackOpCode;
        public string RAttackOpCode;
        public string OpCode;
        public bool Realize;


        private const Int32 PROCESS_ALL_ACCESS = 0x1F0FFF;
        private const Int32 MEM_COMMIT = 0x1000;
        private const Int32 MEM_RELEASE = 0x8000;
        private const Int32 PAGE_READWRITE = 0x04;
        private const Int32 PAGE_EXECUTE_READWRITE = 0x40;

        private byte [] readInt = new byte[4];
        public Client(IntPtr clientHandle)
        {
            ClientHandle = clientHandle;
            Char = new Char(this);
            AttackOpCode = getAttackOpCode();
            RAttackOpCode = getRAttackOpcode();
            OpCode = getOpCode();
        }
        private string getAttackOpCode()=>(ToInt32(ReadMemory(new IntPtr(0x9365ac))) + 0x31).ToString("X");
        private string getRAttackOpcode()=>(ToInt32(ReadMemory(new IntPtr(0x9365ac))) + 0x8).ToString("X");
        private string getOpCode() => ToInt32(ReadMemory(new IntPtr(0x9365ac))).ToString("X");


        public int WriteMemory(IntPtr Address, int Value)
        {
            return WinApi.WriteProcessMemory(ClientHandle, Address, BitConverter.GetBytes(Value), 4L, 0);
        }
        public int WriteMemory(IntPtr Address, float Value)
        {
            return WinApi.WriteProcessMemory(ClientHandle, Address, BitConverter.GetBytes(Value), 4L, 0);
        }
        public byte[] ReadMemory(IntPtr Address)
        {
            WinApi.ReadProcessMemory(ClientHandle, Address, readInt, 4L, 0L);
            return readInt;
        }
        public byte[] ReadMemory(IntPtr Address, bool Float)
        {
            WinApi.ReadProcessMemory(ClientHandle, Address, readInt, 4L, 0L);
            return readInt;
        }
        public byte[] ReadMemory(IntPtr Address, byte[] ReadBytes, long nSize)
        {
            WinApi.ReadProcessMemory(ClientHandle, Address, ReadBytes, nSize, 0L);
            return ReadBytes;
        }
        public int ToInt32(byte[] pBytes)
        {
            return BitConverter.ToInt32(pBytes, 0);
        }

        private IntPtr BytesAddr = IntPtr.Zero;
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
        private void PacketSender(byte[] pPacket)
        {
            long pSize;
            byte[] pCode;
            pSize = pPacket.Length;

            if (BytesAddr == IntPtr.Zero)
                BytesAddr = WinApi.VirtualAllocEx(ClientHandle, IntPtr.Zero, 1024, MEM_COMMIT, PAGE_READWRITE);


            if (BytesAddr != IntPtr.Zero)
            {
                WinApi.WriteProcessMemory(ClientHandle, BytesAddr, pPacket, pSize, 0);
                pCode = Converter.ToByteArray("608B0D" + Converter.AlignDWORD(Addresses.PTR_PKT) + "68" + Converter.AlignDWORD(new IntPtr(pSize)) + "68" + Converter.AlignDWORD(BytesAddr) + "BF" + Converter.AlignDWORD(Addresses.SND_FNC) + "FFD7C605" + Converter.AlignDWORD(new IntPtr(Addresses.PTR_PKT.ToInt32() + 0xC5)) + "0061C3");
                ExecuteRemoteCode(pCode);
                //dc fix denemeleri
                //WinApi.VirtualFreeEx(ClientHandle, BytesAddr, 0, MEM_RELEASE);
            }
        }

        private IntPtr FuncPtr = IntPtr.Zero;


        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
        public void ExecuteRemoteCode(byte[] pCode)
        {
            IntPtr ThreadID = IntPtr.Zero;
            IntPtr Ret = IntPtr.Zero;

            if (FuncPtr == IntPtr.Zero)
                FuncPtr = WinApi.VirtualAllocEx(ClientHandle, IntPtr.Zero, 1024, MEM_COMMIT, PAGE_READWRITE);

            if (FuncPtr != IntPtr.Zero)
            {
                WinApi.WriteProcessMemory(ClientHandle, FuncPtr, pCode, (long)pCode.Length, 0);
                IntPtr hTread =  WinApi.CreateRemoteThread(ClientHandle, 0, 0, FuncPtr, 0, 0, ref ThreadID);
                if (hTread != IntPtr.Zero)
                {
                    Ret = WinApi.WaitForSingleObject(hTread, uint.MaxValue);
                    //dc giderme denemeleri alt iki satır
                    //WinApi.CloseHandle(hTread);
                }
                //WinApi.VirtualFreeEx(ClientHandle, FuncPtr, 0, MEM_RELEASE);
            }
        }
        public void Send(string packet) => PacketSender(Converter.ToByteArray(packet));
    }
}
