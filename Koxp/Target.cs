using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koxp
{
    public class Target
    {
        private Client Client;
        private Char Char;

        public Target(Client _client, Char _character)
        {
            Client = _client;
            Char = _character;
        }

        public string Id { get => EnemyId(); }
        public string Name { get => EnemyName(); }
        public int Hp { get => EnemyHp(); }
        public int X { get => EnemyX(); }
        public int Y { get => EnemyY(); }
        public int Z { get => EnemyZ(); }
        public int Distance { get => EnemyDistance(); }



        public string EnemyId() => AlignDWORD(new IntPtr(ToInt32(ReadMemory(new IntPtr(Char.CharBase + Addresses.OFF_MOB))))).Substring(0, 4).ToUpper();
        public int EnemyHp() => ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(Addresses.PTR_DLG)) + 0x54))) + 0xBC))) + 0xE4)));
        public int EnemyX() => Convert.ToInt32(BitConverter.ToSingle(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(Addresses.PTR_DLG)) + 0x1C8))) + 0x48)), 0));
        public int EnemyY() => Convert.ToInt32(BitConverter.ToSingle(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(Addresses.PTR_DLG)) + 0x1C8))) + 0x50)), 0));
        public int EnemyZ() => Convert.ToInt32(BitConverter.ToSingle(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(Addresses.PTR_DLG)) + 0x1c8))) + 0x4C)), 0));
        public int EnemyDistance()=>Convert.ToInt32(Math.Round(Math.Pow((((EnemyX() - BitConverter.ToSingle(ReadMemory(new IntPtr(Char.CharBase + Addresses.OFF_X)), 0)) * (EnemyX() - BitConverter.ToSingle(ReadMemory(new IntPtr(Char.CharBase + Addresses.OFF_X)), 0))) + ((EnemyY() - BitConverter.ToSingle(ReadMemory(new IntPtr(Char.CharBase + Addresses.OFF_Y)), 0)) * (EnemyY() - BitConverter.ToSingle(ReadMemory(new IntPtr(Char.CharBase + Addresses.OFF_Y)), 0)))), 0.5) / 4));
        public string EnemyName()
        {
            byte[] pBytes = new byte[50];
            string Name = Convert.ToString(Encoding.ASCII.GetString(
                
                ReadMemory(new IntPtr
                    (
                        ToInt32(ReadMemory(new IntPtr
                        (
                                ToInt32(ReadMemory(new IntPtr
                                (
                                    ToInt32(ReadMemory(new IntPtr
                                    (
                                        ToInt32(ReadMemory(new IntPtr
                                        (
                                            ToInt32(ReadMemory(Addresses.PTR_DLG)) + 0x54
                                        ))) + 0xCC
                                    ))) + 0xBC
                                ))) + 0x1C
                        ))) 
                    ), pBytes, 50L)));
            for (int i = 0; i < Name.Length; i++)
                if ((int)Name[i] == 0)
                    return Name.Substring(0, i);
            return "";
        }
        #region Helper
        public int WriteMemory(IntPtr Address, int Value) => Client.WriteMemory(Address, Value);
        private byte[] ReadMemory(IntPtr Address) => Client.ReadMemory(Address);
        private byte[] ReadMemory(IntPtr Address, bool Float) => Client.ReadMemory(Address, Float);
        private byte[] ReadMemory(IntPtr Address, byte[] ReadBytes, long nSize) => Client.ReadMemory(Address, ReadBytes, nSize);
        private int ToInt32(byte[] pBytes) => Converter.ToInt32(pBytes);
        private string AlignDWORD(IntPtr intPtr) => Converter.AlignDWORD(intPtr);
        #endregion
    }
}
