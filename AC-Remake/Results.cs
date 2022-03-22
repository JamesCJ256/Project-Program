using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Program
{
    public partial class Results : UserControl
    {
        public Results()
        {
            InitializeComponent();
        }

        public static Results _instance;
        public static Results Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Results();
                return _instance;
            }
        }


        string path = Directory.GetCurrentDirectory() + "\\benchmarks\\ForestDemo\\ProjectAssignment_Data\\results.txt";
        string[] results;
        int gpuScore = 0;

        private void Results_Load(object sender, EventArgs e)
        {
            update();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void updateResults_Tick(object sender, EventArgs e)
        {
            update();
        }

        public void update()
        {
            if (File.Exists(path))
            {
                results = File.ReadAllLines(path);
                lblGPUScore.Text = "GPU Score: " + Math.Round(Convert.ToDouble(results[0])).ToString() + " Points";
                cpbResult.Value = (int)Math.Round(Convert.ToDouble(results[0]));
                cpbResult.Text = Math.Round(Convert.ToDouble(results[0])).ToString() + " Points";
                lblAvFPS.Text = "Average FPS: " + Math.Round(Convert.ToDouble(results[1])).ToString() + " FPS";
                gpuScore = (int)Math.Round(Convert.ToDouble(results[0]));

                lblAvFrame.Text = "Average: " + Math.Round(Convert.ToDouble(results[1])).ToString() + " FPS";
                lblMinFrame.Text = "Min: " + Math.Round(Convert.ToDouble(results[3])).ToString() + " FPS";
                lblMaxFrame.Text = "Max: " + Math.Round(Convert.ToDouble(results[2])).ToString() + " FPS";

                lblRes.Text = "Resolution: " + results[4];

                int min = 100 - (int)Math.Round(Convert.ToDouble(results[45]));
                int av = 100 - (int)Math.Round(Convert.ToDouble(results[39]));
                lblCPUScore.Text = "CPU Score: " + min * av + " Points";

                lblGPUAvCore.Text = "Average: " + Math.Round(Convert.ToDouble(results[9])).ToString() + " MHz";
                lblGPUAvMem.Text = "Average: " + Math.Round(Convert.ToDouble(results[10])).ToString() + " MHz";
                lblGPUAvHotspot.Text = "Average: " + Math.Round(Convert.ToDouble(results[11])).ToString() + " °C";
                lblGPUAvTemp.Text = "Average: " + Math.Round(Convert.ToDouble(results[12])).ToString() + " °C";
                lblGPUAvUsage.Text = "Average: " + Math.Round(Convert.ToDouble(results[13])).ToString() + " %";
                lblGPUAvVRAMUsage.Text = "Average: " + Math.Round(Convert.ToDouble(results[14])).ToString() + " %";
                lblGPUAvPower.Text = "Average: " + Math.Round(Convert.ToDouble(results[15])).ToString() + " W";

                lblGPUMinCore.Text = "Min: " + Math.Round(Convert.ToDouble(results[18])).ToString() + " MHz";
                lblGPUMinMem.Text = "Min: " + Math.Round(Convert.ToDouble(results[19])).ToString() + " MHz";
                lblGPUMinHotspot.Text = "Min: " + Math.Round(Convert.ToDouble(results[20])).ToString() + " °C";
                lblGPUMinTemp.Text = "Min: " + Math.Round(Convert.ToDouble(results[21])).ToString() + " °C";
                lblGPUMinUsage.Text = "Min: " + Math.Round(Convert.ToDouble(results[22])).ToString() + " %";
                lblGPUMinVRAMUsage.Text = "Min: " + Math.Round(Convert.ToDouble(results[23])).ToString() + " %";
                lblGPUMinPower.Text = "Min: " + Math.Round(Convert.ToDouble(results[24])).ToString() + " W";

                lblGPUMaxCore.Text = "Max: " + Math.Round(Convert.ToDouble(results[27])).ToString() + " MHz";
                lblGPUMaxMem.Text = "Max: " + Math.Round(Convert.ToDouble(results[28])).ToString() + " MHz";
                lblGPUMaxHotspot.Text = "Max: " + Math.Round(Convert.ToDouble(results[29])).ToString() + " °C";
                lblGPUMaxTemp.Text = "Max: " + Math.Round(Convert.ToDouble(results[30])).ToString() + " °C";
                lblGPUMaxUsage.Text = "Max: " + Math.Round(Convert.ToDouble(results[31])).ToString() + " %";
                lblGPUMaxVRAMUsage.Text = "Max: " + Math.Round(Convert.ToDouble(results[32])).ToString() + " %";
                lblGPUMaxPower.Text = "Max: " + Math.Round(Convert.ToDouble(results[33])).ToString() + " W";


                lblCPUAvTemp.Text = "Average: " + Math.Round(Convert.ToDouble(results[36])).ToString() + " °C";
                lblCPUAvClock.Text = "Average: " + Math.Round(Convert.ToDouble(results[37])).ToString() + " MHz";
                lblCPUAvPower.Text = "Average: " + Math.Round(Convert.ToDouble(results[38])).ToString() + " W";
                lblCPUAvUsage.Text = "Average: " + Math.Round(Convert.ToDouble(results[39])).ToString() + " %";

                if (Math.Round(Convert.ToDouble(results[39])) >= Math.Round(Convert.ToDouble(results[51])))
                {
                    lblCPUAvUsage.Text = "Average: " + Math.Round(Convert.ToDouble(results[51])).ToString() + " %";
                }

                lblCPUMinTemp.Text = "Min: " + Math.Round(Convert.ToDouble(results[42])).ToString() + " °C";
                lblCPUMinClock.Text = "Min: " + Math.Round(Convert.ToDouble(results[43])).ToString() + " MHz";
                lblCPUMinPower.Text = "Min: " + Math.Round(Convert.ToDouble(results[44])).ToString() + " W";
                lblCPUMinUsage.Text = "Min: " + Math.Round(Convert.ToDouble(results[45])).ToString() + " %";

                lblCPUMaxTemp.Text = "Max: " + Math.Round(Convert.ToDouble(results[48])).ToString() + " °C";
                lblCPUMaxClock.Text = "Max: " + Math.Round(Convert.ToDouble(results[49])).ToString() + " MHz";
                lblCPUMaxPower.Text = "Max: " + Math.Round(Convert.ToDouble(results[50])).ToString() + " W";
                lblCPUMaxUsage.Text = "Max: " + Math.Round(Convert.ToDouble(results[51])).ToString() + " %";


                lblRAMAvUsage.Text = "Average: " + Math.Round(Convert.ToDouble(results[54])).ToString() + " %";
                lblRAMMinUsage.Text = "Min: " + Math.Round(Convert.ToDouble(results[56])).ToString() + " %";
                lblRAMMaxUsage.Text = "Max: " + Math.Round(Convert.ToDouble(results[55])).ToString() + " %";

                if (results[6].Contains("w/FSR"))
                {

                    lblBench.Text = "Forest Demo ("+ results[5] + " w/FSR)";

                }
                else
                {

                    lblBench.Text = "Forest Demo ("+ results[5] + ")";

                }

                if (gpuScore < 400)
                {
                    lblActualScore.Text = "Ranking: Abysmal";

                }
                else if (gpuScore <= 600)
                {
                    lblActualScore.Text = "Ranking: Very Bad";

                }
                else if (gpuScore <= 1000)
                {
                    lblActualScore.Text = "Ranking: Bad";
                }
                else if (gpuScore <= 2000)
                {
                    lblActualScore.Text = "Ranking: Mediocre";
                }
                else if (gpuScore > 2000 && gpuScore <= 3500)
                {
                    lblActualScore.Text = "Ranking: Good";
                }
                else if (gpuScore > 3500 && gpuScore <= 8000)
                {
                    lblActualScore.Text = "Ranking: Very Good";
                }
                else if (gpuScore > 8000 && gpuScore <= 14000)
                {
                    lblActualScore.Text = "Ranking: Legendary";
                }
                else if (gpuScore > 14000)
                {
                    lblActualScore.Text = "Ranking: God Tier";
                }
                lbSum.Items.Add("System Specs:");
                lbSum.Items.Add("       CPU: " + results[61]);
                
                if(results[60] != "")
                {
                    lbSum.Items.Add("       GPU 1: " + results[59]);
                    lbSum.Items.Add("       GPU 2: " + results[60]);
                }
                else
                {
                    lbSum.Items.Add("       GPU: " + results[59]);
                }

                lbSum.Items.Add("       Benchmark Date: " + results[64]);
                lbSum.Items.Add("");
                lbSum.Items.Add("CPU:");
                if (Math.Round(Convert.ToDouble(results[39])) > 91 && Math.Round(Convert.ToDouble(results[51])) > 91)
                {
                    lbSum.Items.Add("       CPU bottleneck detected, try removing any bloat running in the background and/or try overclocking the CPU core if possible");
                    lbSum.Items.Add("       and thermals permit.");
                }
                else if (Math.Round(Convert.ToDouble(results[51])) > 91)
                {
                    lbSum.Items.Add("       Possible CPU bottleneck detected, try removing any bloat running in the background and/or try overclocking the CPU core if possible");
                    lbSum.Items.Add("       and thermals permit.");
                }
                else
                {
                    lbSum.Items.Add("       No CPU bottleneck detected.");
                }

                if (Math.Round(Convert.ToDouble(results[36])) > 88 && Math.Round(Convert.ToDouble(results[48])) > 88)
                {
                    lbSum.Items.Add("       High CPU temperatures detected, try increase cooling capcity by adding more fans to PC or using a cooling pad if using a laptop.");
                    lbSum.Items.Add("       Undervolting the CPU may also help if possible.");
                }
                else if (Math.Round(Convert.ToDouble(results[48])) > 88)
                {
                    lbSum.Items.Add("       Possible CPU thermal issue detected, try increase cooling capcity by adding more fans to PC or using a cooling pad if using a laptop.");
                    lbSum.Items.Add("       Undervolting the CPU may also help if possible.");
                }
                else
                {
                    lbSum.Items.Add("       No CPU temperature issues detected.");
                }

                lbSum.Items.Add("");
                lbSum.Items.Add("GPU:");
                if (Math.Round(Convert.ToDouble(results[13])) > 91 &&  Math.Round(Convert.ToDouble(results[31])) > 91)
                {
                    lbSum.Items.Add("       GPU core bottleneck detected, try removing any bloat running in the background and/or try overclocking the GPU core");
                    lbSum.Items.Add("       if possible and thermals permit.");
                }
                else if (Math.Round(Convert.ToDouble(results[31])) > 91)
                {
                    lbSum.Items.Add("       Possible GPU core bottleneck detected, try removing any bloat running in the background and/or try overclocking the GPU core");
                    lbSum.Items.Add("       if possible and thermals permit.");
                }
                else
                {
                    lbSum.Items.Add("       No GPU core bottleneck detected.");
                }

                if (Math.Round(Convert.ToDouble(results[14])) > 91 &&  Math.Round(Convert.ToDouble(results[32])) > 91)
                {
                    lbSum.Items.Add("       GPU VRAM bottleneck detected, try removing any bloat running in the background.");
                }
                else if (Math.Round(Convert.ToDouble(results[32])) > 91)
                {
                    lbSum.Items.Add("       Possible GPU VRAM bottleneck detected, try removing bloat running in the background.");
                }
                else
                {
                    lbSum.Items.Add("       No GPU VRAM bottleneck detected.");
                }

                if (Math.Round(Convert.ToDouble(results[11])) > 100 && Math.Round(Convert.ToDouble(results[29])) > 100)
                {
                    lbSum.Items.Add("       High GPU hotspot temperatures detected, try increase cooling capcity by adding more fans to PC or using a cooling pad if");
                    lbSum.Items.Add("       using a laptop. Undervolting the GPU may also help if possible.");
                }
                else if (Math.Round(Convert.ToDouble(results[29])) > 100)
                {
                    lbSum.Items.Add("       Possible GPU hotspot thermal issue detected, try increase cooling capcity by adding more fans to PC or using a cooling pad");
                    lbSum.Items.Add("       if using a laptop. Undervolting the GPU may also help if possible.");
                }
                else
                {
                    lbSum.Items.Add("       No GPU hotspot temperature issues detected.");
                }

                if (Math.Round(Convert.ToDouble(results[12])) > 90 && Math.Round(Convert.ToDouble(results[30])) > 90)
                {
                    lbSum.Items.Add("       High GPU edge temperatures detected, try increase cooling capcity by adding more fans to PC or using a cooling pad");
                    lbSum.Items.Add("       if using a laptop. Undervolting the GPU may also help if possible.");
                }
                else if (Math.Round(Convert.ToDouble(results[30])) > 90)
                {
                    lbSum.Items.Add("       Possible GPU edge thermal issue detected, try increase cooling capcity by adding more fans to PC or using a cooling pad");
                    lbSum.Items.Add("       if using a laptop. Undervolting the GPU may also help if possible.");
                }
                else
                {
                    lbSum.Items.Add("       No GPU edge temperature issues detected.");
                }

                lbSum.Items.Add("");
                lbSum.Items.Add("RAM:");
                if (Math.Round(Convert.ToDouble(results[54])) > 91 &&  Math.Round(Convert.ToDouble(results[55])) > 91)
                {
                    lbSum.Items.Add("       Possible RAM bottleneck detected, try removing any bloat running in the background and/or if RAM is upgradable buy");
                    lbSum.Items.Add("       higher capacity RAM sticks to increase total system RAM.");
                }
                else if (Math.Round(Convert.ToDouble(results[55])) > 91)
                {
                    lbSum.Items.Add("       RAM bottleneck detected, try removing any bloat running in the background and/or if RAM is upgradable buy");
                    lbSum.Items.Add("       higher capacity RAM sticks to increase total system RAM.");
                }
                else
                {
                    lbSum.Items.Add("       No RAM bottleneck detected.");
                }
            }
        }

        private void CB_Tick(object sender, EventArgs e)
        {
            if (cbFrame.Checked == true)
            {
                pnFrameStats.Visible = true;
            }
            else
            {
                pnFrameStats.Visible = false;
            }

            if (cbCPU.Checked == true)
            {
                pnCPU.Visible = true;
            }
            else
            {
                pnCPU.Visible = false;
            }

            if (cbRAM.Checked == true)
            {
                pnRAM.Visible = true;
            }
            else
            {
                pnRAM.Visible = false;
            }

            if (cbGPU.Checked == true)
            {
                pnGPU.Visible = true;
            }
            else
            {
                pnGPU.Visible = false;
            }
        }
    }
}
