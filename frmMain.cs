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

namespace Game_Mode___FreezeAndFind_By_BISOON
{// (-_-) Why :) .. ?
    public partial class frmMain : Form
    {
        #region RPC
        void Enable_RPC()
        {
            if (PS3.Extension.ReadBytes(functionAddress + 3, 1)[0] != 0x91)
            {
                PS3.SetMemory(functionAddress, new byte[] { 0x4E, 0x80, 0x00, 0x20 });
                System.Threading.Thread.Sleep(20);
                byte[] func = new byte[] { 0x7C, 0x08, 0x02, 0xA6, 0xF8, 0x01, 0x00, 0x80, 0x3C, 0x60, 0x10, 0x05, 0x81, 0x83, 0x00, 0x4C, 0x2C, 0x0C, 0x00, 0x00, 0x41, 0x82, 0x00, 0x64, 0x80, 0x83, 0x00, 0x04, 0x80, 0xA3, 0x00, 0x08, 0x80, 0xC3, 0x00, 0x0C, 0x80, 0xE3, 0x00, 0x10, 0x81, 0x03, 0x00, 0x14, 0x81, 0x23, 0x00, 0x18, 0x81, 0x43, 0x00, 0x1C, 0x81, 0x63, 0x00, 0x20, 0xC0, 0x23, 0x00, 0x24, 0xC0, 0x43, 0x00, 0x28, 0xC0, 0x63, 0x00, 0x2C, 0xC0, 0x83, 0x00, 0x30, 0xC0, 0xA3, 0x00, 0x34, 0xC0, 0xC3, 0x00, 0x38, 0xC0, 0xE3, 0x00, 0x3C, 0xC1, 0x03, 0x00, 0x40, 0xC1, 0x23, 0x00, 0x48, 0x80, 0x63, 0x00, 0x00, 0x7D, 0x89, 0x03, 0xA6, 0x4E, 0x80, 0x04, 0x21, 0x3C, 0x80, 0x10, 0x05, 0x38, 0xA0, 0x00, 0x00, 0x90, 0xA4, 0x00, 0x4C, 0x90, 0x64, 0x00, 0x50, 0xE8, 0x01, 0x00, 0x80, 0x7C, 0x08, 0x03, 0xA6, 0x38, 0x21, 0x00, 0x70, 0x4E, 0x80, 0x00, 0x20 };
                PS3.SetMemory(functionAddress + 0x4, func);
                PS3.SetMemory(0x10050000, new byte[0x2854]);
                PS3.SetMemory(functionAddress, new byte[] { 0xF8, 0x21, 0xFF, 0x91 });
            }
        }
         void Enable()
        {
            byte[] buffer = new byte[]
			{
				63,
				128,
				16,
				5,
				129,
				156,
				0,
				72,
				44,
				12,
				0,
				0,
				65,
				130,
				0,
				120,
				128,
				124,
				0,
				0,
				128,
				156,
				0,
				4,
				128,
				188,
				0,
				8,
				128,
				220,
				0,
				12,
				128,
				252,
				0,
				16,
				129,
				28,
				0,
				20,
				129,
				60,
				0,
				24,
				129,
				92,
				0,
				28,
				129,
				124,
				0,
				32,
				192,
				60,
				0,
				36,
				192,
				92,
				0,
				40,
				192,
				124,
				0,
				44,
				192,
				156,
				0,
				48,
				192,
				188,
				0,
				52,
				192,
				220,
				0,
				56,
				192,
				252,
				0,
				60,
				193,
				28,
				0,
				64,
				193,
				60,
				0,
				68,
				125,
				137,
				3,
				166,
				78,
				128,
				4,
				33,
				56,
				128,
				0,
				0,
				144,
				156,
				0,
				72,
				144,
				124,
				0,
				76,
				208,
				60,
				0,
				80,
				72,
				0,
				0,
				20
			};
            PS3.SetMemory(functionAddress, new byte[]
			{
				65
			});
            PS3.SetMemory(functionAddress + 4u, buffer);
            PS3.SetMemory(functionAddress, new byte[]
			{
				64
			});
        }
         public static int Call(uint func_address, params object[] parameters)
         {
             InUse = true;
             int num_params = parameters.Length;
             uint num_floats = 0;
             for (uint i = 0; i < num_params; i++)
             {
                 if (parameters[i] is int)
                 {
                     byte[] val = BitConverter.GetBytes((int)parameters[i]);
                     Array.Reverse(val);
                     PS3.SetMemory(0x10050000 + (i + num_floats) * 4, val);
                 }
                 else if (parameters[i] is uint)
                 {
                     byte[] val = BitConverter.GetBytes((uint)parameters[i]);
                     Array.Reverse(val);
                     PS3.SetMemory(0x10050000 + (i + num_floats) * 4, val);
                 }
                 else if (parameters[i] is string)
                 {
                     byte[] str = Encoding.UTF8.GetBytes(Convert.ToString(parameters[i]) + "\0");
                     PS3.SetMemory(0x10050054 + i * 0x400, str);
                     uint addr = 0x10050054 + i * 0x400;
                     byte[] address = BitConverter.GetBytes(addr);
                     Array.Reverse(address);
                     PS3.SetMemory(0x10050000 + (i + num_floats) * 4, address);
                 }
                 else if (parameters[i] is float)
                 {
                     num_floats++;
                     byte[] val = BitConverter.GetBytes((float)parameters[i]);
                     Array.Reverse(val);
                     PS3.SetMemory(0x10050024 + ((num_floats - 1) * 0x4), val);
                 }
             }
             byte[] fadd = BitConverter.GetBytes(func_address);
             Array.Reverse(fadd);
             PS3.SetMemory(0x1005004C, fadd);
             System.Threading.Thread.Sleep(20);
             byte[] ret = PS3.GetBytes(0x10050050, 4);
             Array.Reverse(ret);
             InUse = false;
             return BitConverter.ToInt32(ret, 0);
         }
         public static int Call_MW3(uint address, params object[] parameters)
         {
             int num = parameters.Length;
             int i = 0;
             uint num2 = 0u;
             uint num3 = 0u;
             uint num4 = 0u;
             uint num5 = 0u;
             while (i < num)
             {
                 if (parameters[i] is int)
                 {
                     PS3.Extension.WriteInt32(268763136u + num2 * 4u, (int)parameters[i]);
                     num2 += 1u;
                 }
                 else
                 {
                     if (parameters[i] is uint)
                     {
                         PS3.Extension.WriteUInt32(268763136u + num2 * 4u, (uint)parameters[i]);
                         num2 += 1u;
                     }
                     else
                     {
                         if (parameters[i] is short)
                         {
                             PS3.Extension.WriteInt16(268763136u + num2 * 4u, (short)parameters[i]);
                             num2 += 1u;
                         }
                         else
                         {
                             if (parameters[i] is ushort)
                             {
                                 PS3.Extension.WriteUInt16(268763136u + num2 * 4u, (ushort)parameters[i]);
                                 num2 += 1u;
                             }
                             else
                             {
                                 if (parameters[i] is byte)
                                 {
                                     PS3.Extension.WriteByte(268763136u + num2 * 4u, (byte)parameters[i]);
                                     num2 += 1u;
                                 }
                                 else
                                 {
                                     if (parameters[i] is string)
                                     {
                                         uint num6 = 268771328u + num3 * 1024u;
                                         PS3.Extension.WriteString(num6, Convert.ToString(parameters[i]));
                                         PS3.Extension.WriteUInt32(268763136u + num2 * 4u, num6);
                                         num2 += 1u;
                                         num3 += 1u;
                                     }
                                     else
                                     {
                                         if (parameters[i] is float)
                                         {
                                             PS3.Extension.WriteSingle(268763172u + num4 * 4u, (float)parameters[i]);
                                             num4 += 1u;
                                         }
                                         else
                                         {
                                             if (parameters[i] is float[])
                                             {
                                                 float[] array = (float[])parameters[i];
                                                 uint num6 = 268767232u + num5 * 4u;
                                                 PS3.Extension.WriteSingle(num6, array);
                                                 PS3.Extension.WriteUInt32(268763136u + num2 * 4u, num6);
                                                 num2 += 1u;
                                                 num5 += (uint)array.Length;
                                             }
                                         }
                                     }
                                 }
                             }
                         }
                     }
                 }
                 i++;
             }
             PS3.Extension.WriteUInt32(268763208u, address);
             Thread.Sleep(20);
             return PS3.Extension.ReadInt32(268763212u);
         }
        static bool InUse = false;
        void WaitForCall()
        {
            while (InUse)
            {
            }
        }

        void iPrintlnBold(int ClientID, string Message)
        {
            SV_GameSendServerCommand(ClientID, "\"" + centersvPri + "\"" + " \"" + Message + "\"");
        }
        void iPrintln(int client, string txt)
        {
            SV_GameSendServerCommand(client, "\"" + svPri + "\"" + "\"" + txt + "\"");
        }
        void SV_GameSendServerCommand(int ClientID, string Command)
        {
            if (gameCombo.SelectedIndex == 3)
            {
                Call_MW3(sv_command, ClientID, 0, Command);
                return;
            }
            Call(sv_command, ClientID, 0, Command);
        }
        void Cbuf_AddText(UInt32 Client, String Command)
        {
            if (gameCombo.SelectedIndex == 3)
            {
                Call_MW3(cbuf_Addtext, Client, Command);
                return;
            }
            Call(cbuf_Addtext, Client, Command);
        }
        #endregion

        public void Delay(double dblSecs)
        {
            DateTime.Now.AddSeconds(1.15740740740741E-05);
            DateTime dateTime2 = DateTime.Now.AddSeconds(1.15740740740741E-05).AddSeconds(dblSecs);
            while (DateTime.Now < dateTime2)
                Application.DoEvents();
        }

        #region Variable
        uint name = 0,
            freez = 0,
            functionAddress = 0,
            sv_command = 0,
            cbuf_Addtext = 0,
            Client_interval = 0;
        char? centersvPri = null;
        char? svPri = null;
        #endregion
        public frmMain()
        {
            InitializeComponent();
        }
        void Dis( bool Button, bool Combo)
        {
            startBtn.Enabled = Button;
            gameCombo.Enabled = Combo;
        }
        private void onLoad(object sender, EventArgs e)
        {
            Dis(false, false);
            ToolTip tip = new ToolTip();
            tip.SetToolTip(conBtn, "Connection Button\nHere You Can Also Attach Process\nIf you use DEX you need a Debug EBOOT");
            tip.SetToolTip(startBtn, "Make Sure You've Selected Your Correct Game From Above\nRight Click On The Button To Get More Options ..");
            tip.SetToolTip(endNum, "Duration After Selecting An Player");
            tip.SetToolTip(sINum, "Duration Before Selecting An Player");
            tip.SetToolTip(gameCombo, "Choose your game");
        }

        private void conBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("CEX","API",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PS3.Connections.CCAPI();
            }
            if (PS3.Connections.Connect() && PS3.Connections.Attach())
            {
                MessageBox.Show("Successfully Connected", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Dis(false, true);
            }
           
        }
        private void gameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            uint[] N = { 0x1A6F5BC, 0xF47A1C, 0x178646C, 0x0110D694, 0x139784C };
            uint[] F = { 0x1A6F82F, 0xF47C9F, 0x17865BF, 0x0110d87f, 0x1397880 };
            uint[] FA = { 0x6207F0, 0x4A0700, 0x7aa050, 0x277208, 0x7A21E0 };
            uint[] SV = { 0x44C36C, 0x672444, 0x349f6c, 0x228FA8, 0x003E95F0 };
            uint[] CA = { 0x3A4CFC, 0x2B1C14, 0x313c18, 0x1DB240, 0x4555 };
            uint[] IV = { 0x3900, 0x3700, 0x5808, 0x3980, 0x2A38 };
            char[] center_svchar = { 'c', 'c', '<', 'c', 'c' };
            char[] svchar = { 'e', 'e', 'O', 'f', 'f' };
            name = N[gameCombo.SelectedIndex];
            freez = F[gameCombo.SelectedIndex];
            functionAddress = FA[gameCombo.SelectedIndex];
            sv_command = SV[gameCombo.SelectedIndex];
            cbuf_Addtext = CA[gameCombo.SelectedIndex];
            Client_interval = IV[gameCombo.SelectedIndex];
            centersvPri = center_svchar[gameCombo.SelectedIndex];
            svPri = svchar[gameCombo.SelectedIndex];
            Dis(true, true);
            if (gameCombo.SelectedIndex == 3)
            {
                Enable();
                return;
            }
            Enable_RPC();
            
        }
        public static bool IsAlive(int Client)
        {
            return PS3.Extension.ReadBool(0x178634B + 0x5808 * (uint)Client);
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            if (gameCombo.SelectedIndex == 2)
            {
                int loadingGM = 12;
                Cbuf_AddText(0, "gametype_setting playerNumlives 1;wait 10;fast_restart");
                Delay(2);
                while (loadingGM > 0)
                {
                    loadingGM--;
                    iPrintln(-1, "Reading & Setting Up The Game Mode : ^2" + loadingGM);
                    Delay(1);
                }

                    for (int i = 0; i < 12; i++)
                    {
                        PS3.SetMemory(0x1781170 + (0x5808 * (uint)i), new byte[0x188]);
                    }
            }
            for (int i = 0; i < 12; i++)
            {
                Freeze(i, false);
            }
            if (startBtn.Text == "Start Game Mode")
            {
                startBtn.Text = "Stop";
                StartGameMode((int)sINum.Value + 1, (int)endNum.Value + 1);
            }
            else if (startBtn.Text == "Stop")
            {
                Start = false;
                startBtn.Text = "Start Game Mode";
            }
        }

        string GetName(int Client)
        {
            return PS3.Extension.ReadString(name + Client_interval * (uint)Client);
        }
        void Freeze(int Client, bool True)
        {
            if (gameCombo.SelectedIndex == 4)
            {
                    if (True)
                    {
                        PS3.SetMemory(freez + Client_interval * (uint)Client, new byte[] { 0x00, 0x00 });
                    }
                    else
                    {
                        PS3.SetMemory(freez + Client_interval * (uint)Client, new byte[] { 0x3f, 0x80 });
                    }
                   
                return;
            }
            if (True)
            {
                PS3.SetMemory(freez + Client_interval * (uint)Client, new byte[] { 0x04 });
            }
            else
            {
                PS3.SetMemory(freez + Client_interval * (uint)Client, new byte[] { 0x00 });
            }
        }
        Random random = new Random();
        int SelectedClient;
        bool Start;
        void StartGameMode(int Time, int endTime)
        {

            Start = true;
            while (Start == true)
            {
                while (Time > 0)
                {
                    Time--;
                    iPrintlnBold(-1, "Hide Yourself  before : ^2" + Time);
                    Delay(1.0);
                }
                SelectedClient = random.Next(0, 11);
                Start = false;
                while (GetName(SelectedClient) == "")
                {
                    SelectedClient = random.Next(0, 11);
                }

                for (int i = 0; i < 12; i++)
                {
                    Freeze(i, true);
                }
                Freeze(SelectedClient, false);
                if (gameCombo.SelectedIndex == 2)
                {
                    byte[] buffer = new byte[4];
                    buffer[3] = 0x60;
                    PS3.Extension.WriteBytes(0x17811e0 + 0x5808 * (uint)SelectedClient, buffer);
                    PS3.SetMemory(0x1781327 + 0x5808 * (uint)SelectedClient, new byte[] { 0x20 });
                    PS3.SetMemory(0x1781363 + 0x5808 * (uint)SelectedClient, new byte[] { 0x10 });
                }
                iPrintlnBold(-1, "^2Freeze !!   ||   ^1" + GetName(SelectedClient) + " ^7 Trying To Kill You ");
                iPrintlnBold(SelectedClient, " ^ 2 You Are Free Go Find & Kill Them  ");
                Delay(2.0);
                while (endTime > 0)
                {
                    endTime--;
                    iPrintln(-1, "Game Ending In  : ^1" + endTime);
                    Delay(1.0);
                }
                startBtn.Text = "Start Game Mode";
                startBtn.Refresh();
                for (int i = 0; i < 12; i++)
                {
                    Freeze(i, false);
                }
            }
        }

        private void optionClick(object sender, EventArgs e)
        {
            ToolStripMenuItem tS = (ToolStripMenuItem)sender;
            if (tS.Text == "Fast Restart")
            {
                if (gameCombo.SelectedIndex == 2)
                {
                    Cbuf_AddText(0, "map_restart");
                }
                else if (gameCombo.SelectedIndex == 0)
                {
                    Call(0x4459E8);
                }
                else if (gameCombo.SelectedIndex == 3)
                {
                    Call_MW3(0x00223B20, 0, 0, "sv_maprestart_f");
                }

            }
            else if (tS.Text == "Set Time")
            {
                if (gameCombo.SelectedIndex == 2)
                {
                    Cbuf_AddText(0, "gametype_setting timelimit " + int.Parse(timeBox.Text));
                    return;
                }

                if (MapName(0x1072868, 2) != "" || MapName(0x00DDD871, 2) != "" || MapName(0X008360d5, 2) != "")
                {
                    if (gameCombo.SelectedIndex == 1)
                    {

                        Cbuf_AddText(0, "set scr_" + MapName(0x1072868, 2) + "_timelimit " + int.Parse(timeBox.Text));
                        return;
                    }
                    else if (gameCombo.SelectedIndex == 3)
                    {
                        Cbuf_AddText(0, "scr_" + MapName(0X008360d5, 2) + "_timelimit " + int.Parse(timeBox.Text));
                        return;
                    }
                }
                Cbuf_AddText(0, "scr_" + MapName(0x00DDD871, 2) + "_timelimit " + int.Parse(timeBox.Text));
            }
        }
        string MapName(uint Offset, int index)
        {
            string map = "";
            try
            {
                map = PS3.Extension.ReadString(Offset).Replace(@"\", "*").Split('*')[index];
            }
            catch { }
            return map;
        }

        private void adLbl(object sender, EventArgs e)
        {
            LinkLabel lL = (LinkLabel)sender;
            if (lL.Text == "YouTube")
                System.Diagnostics.Process.Start("https://www.youtube.com/c/bisoon");
            else if (lL.Text == "ArabModding")
                System.Diagnostics.Process.Start("http://arabmodding.com/ar/");
        }
    }
}
