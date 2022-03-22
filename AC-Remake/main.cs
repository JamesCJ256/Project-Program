using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using OpenHardwareMonitor;
using OpenHardwareMonitor.Hardware;
using Project_Program;
using System.IO;

namespace AC_Remake
{
    public partial class main : UserControl
    {
        public main()
        {
            InitializeComponent();

            thisPC = new Computer()
            {
                CPUEnabled = true,
                GPUEnabled = true,
                RAMEnabled = true
            };
            thisPC.Open();
        }

        public static main _instance;
        public static main Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new main();
                return _instance;
            }
        }

        public static Computer thisPC;

        string director;
        bool isOpen = false;

        public ChromiumWebBrowser browser;
        int i = 0;

        string CPUName = "";
        string GPUName = "";
        string GPUName2 = "";

        private void timer1_Tick(object sender, EventArgs e)
        {
            //CPU and and format RAM useage variables
            float fcpu = CPU.NextValue();
            float dram = RAM.NextValue();

            //set CPU usage
            cpbCPU.Value = (int)fcpu;
            cpbCPU.Text = string.Format("{0:0.0}%", fcpu);

            //set and format RAM useage
            cpbRAM.Value = (int)dram;
            cpbRAM.Text = string.Format("{0:0}%", dram);


        }

        public void CPUDetails()
        {
            ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");
            //get CPU name
            foreach (ManagementObject obj in myProcessorObject.Get())
            {
                lblCPU.Text = "CPU: " + obj["Name"];
                CPUName = obj["Name"].ToString();
            }
        }

        public void GPUDetails()
        {
            ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");
            int i = 1;
            //get GPU details
            foreach (ManagementObject obj in myVideoObject.Get())
            {
                if (i > 1)
                {
                    lblGPU2.Visible = true;
                    lblGPU2.Text = "GPU: " + obj["Name"];
                    GPUName2 = obj["Name"].ToString();
                }

                lblGPU1.Text = "GPU: " + obj["Name"];
                lblGPU2.Visible = false;
                GPUName = obj["Name"].ToString();
                i++;
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            //get system info
            CPUDetails();
            GPUDetails();
            director = Directory.GetCurrentDirectory();
            web();
        }

        public void web()
        {
            //browser = new ChromiumWebBrowser("http://google.co.uk");
            //pnMain.Controls.Add(browser);
            //Dock = DockStyle.Fill;
        }

        private void btnBench1_Click(object sender, EventArgs e)
        {
            string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            path = path + "\\benchmarks\\ForestDemo\\ProjectAssignment.exe";
            //MessageBox.Show(path);
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = path;
            startInfo.Arguments = "-force-dx12 -screen-quality HighQuality -screen-fullscreen 1";
            Process.Start(startInfo);

            getStats("ProjectAssignment.exe");
        }

        private void btnBench2_Click(object sender, EventArgs e)
        {
            string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            path = path + "\\benchmarks\\ForestDemo\\ProjectAssignment.exe";
            //MessageBox.Show(path);
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = path;
            startInfo.Arguments = "-force-dx12 -screen-quality HighQualityw/FSR -screen-fullscreen 1";
            Process.Start(startInfo);

            getStats("ProjectAssignment.exe");
        }

        private void btnBench3_Click(object sender, EventArgs e)
        {
            string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            path = path + "\\benchmarks\\SpaceshipRT\\SpaceshipDemo.exe";
            //MessageBox.Show(path);
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = path;
            startInfo.Arguments = "-force-vulkan";
            Process.Start(startInfo);
        }

        public void getStats(string pName)
        {
            isOpen = true;
        }

        public class UpdateVisitor : IVisitor
        {
            public void VisitComputer(IComputer computer)
            {
                computer.Traverse(this);
            }
            public void VisitHardware(IHardware hardware)
            {
                hardware.Update();
                foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
            }
            public void VisitSensor(ISensor sensor) { }
            public void VisitParameter(IParameter parameter) { }
        }


        int avCPUTemp = 0, avCPUClock = 0, avCPUUsage = 0, avCPUPower = 0, avRAMUsage = 0;
        int maxCPUTemp = 0, maxCPUClock = 0, maxCPUUsage = 0, maxCPUPower = 0, maxRAMUsage = 0;
        int minCPUTemp = 9999, minCPUClock = 9999, minCPUUsage = 9999, minCPUPower = 9999, minRAMUsage = 9999;

        private void hasOpen_Tick(object sender, EventArgs e)
        {
            if (isOpen == true)
            {
                Process[] pname1 = Process.GetProcessesByName("ProjectAssignment");
                if (pname1.Length < 1)
                {
                    avCPUTemp = avCPUTemp / i;
                    avCPUClock = avCPUClock / i;
                    avCPUPower = avCPUPower / i;
                    avCPUUsage = avCPUUsage / i;
                    avRAMUsage = avRAMUsage / i;    

                    string content = $"\n\nCPU Averages:\n{avCPUTemp}\n{avCPUClock}\n{avCPUPower}\n{avCPUUsage}";
                    content = content + $"\n\nCPU Mins:\n{minCPUTemp}\n{minCPUClock}\n{minCPUPower}\n{minCPUUsage}";
                    content = content + $"\n\nCPU Maxs:\n{maxCPUTemp}\n{maxCPUClock}\n{maxCPUPower}\n{maxCPUUsage}";

                    content = content + $"\n\nRAM:\n{avRAMUsage}\n{maxRAMUsage}\n{minRAMUsage}";
                    content = content + $"\n\nCPU + GPU Used:\n{GPUName}\n{GPUName2}\n{CPUName}";
                    content = content + $"\n\nDate and Time:\n{DateTime.Now}";
                    string path = Directory.GetCurrentDirectory() + "\\benchmarks\\ForestDemo\\ProjectAssignment_Data\\results.txt";

                    File.AppendAllText(path, content);
                    isOpen = false;
                    Form2 frm2 = new Form2();
                    frm2.Show();
                }
                else
                {
                    getCPUInfo();
                }
            }

        }

        private void getCPUInfo()
        {
            foreach (var hardware in thisPC.Hardware)
            {
                hardware.Update();
                    if (hardware.HardwareType == HardwareType.CPU)
                    {
                        foreach (var sensor in hardware.Sensors)
                        {
                            if (sensor.SensorType == SensorType.Temperature && sensor.Name.Contains("Package"))
                        {
                            avCPUTemp = avCPUTemp + (int)sensor.Value.GetValueOrDefault(); // CPU Package Temp

                            if ((int)sensor.Value.GetValueOrDefault() > maxCPUTemp)
                            {
                                maxCPUTemp = (int)sensor.Value.GetValueOrDefault();
                            }

                            if ((int)sensor.Value.GetValueOrDefault() < minCPUTemp)
                            {
                                minCPUTemp = (int)sensor.Value.GetValueOrDefault();
                            }
                        }

                        if (sensor.SensorType == SensorType.Clock && sensor.Name.Contains("#1"))
                        {
                            avCPUClock = avCPUClock + (int)sensor.Value.GetValueOrDefault(); // CPU Core 1 Clock

                            if ((int)sensor.Value.GetValueOrDefault() > maxCPUClock)
                            {
                                maxCPUClock = (int)sensor.Value.GetValueOrDefault();
                            }

                            if ((int)sensor.Value.GetValueOrDefault() < minCPUClock)
                            {
                                minCPUClock = (int)sensor.Value.GetValueOrDefault();
                            }
                        }

                        if (sensor.SensorType == SensorType.Load && sensor.Name.Contains("Total"))
                        {
                            avCPUUsage = avCPUUsage + (int)sensor.Value.GetValueOrDefault(); // CPU Usage

                            if ((int)sensor.Value.GetValueOrDefault() > maxCPUUsage)
                            {
                                maxCPUUsage = (int)sensor.Value.GetValueOrDefault();
                            }

                            if ((int)sensor.Value.GetValueOrDefault() < minCPUUsage)
                            {
                                minCPUUsage = (int)sensor.Value.GetValueOrDefault();
                            }
                        }

                        if (sensor.SensorType == SensorType.Power && sensor.Name.Contains("Package"))
                        {
                            avCPUPower = avCPUPower + (int)sensor.Value.GetValueOrDefault(); // CPU Package Power

                            if ((int)sensor.Value.GetValueOrDefault() > maxCPUPower)
                            {
                                maxCPUPower = (int)sensor.Value.GetValueOrDefault();
                            }

                            if ((int)sensor.Value.GetValueOrDefault() < minCPUPower)
                            {
                                minCPUPower = (int)sensor.Value.GetValueOrDefault();
                            }
                        }
                    }
                }
                if (hardware.HardwareType == HardwareType.RAM)
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load)
                        {
                            avRAMUsage = avRAMUsage + (int)sensor.Value.GetValueOrDefault(); // RAM Usage

                            if ((int)sensor.Value.GetValueOrDefault() > maxRAMUsage)
                            {
                                maxRAMUsage = (int)sensor.Value.GetValueOrDefault();
                            }

                            if ((int)sensor.Value.GetValueOrDefault() < minRAMUsage)
                            {
                                minRAMUsage = (int)sensor.Value.GetValueOrDefault();
                            }
                        }
                    }
                }
            }
            i++;
        }
    }
}