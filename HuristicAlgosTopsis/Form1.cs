using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;

namespace HuristicAlgosTopsis
{

    public partial class Form1 : Form
    {

        Program Owner;
        private const int ROWS = 31;
        private const int COLS = 26;
        public double[] weights = new double[ROWS];
        public int[] values = new int[ROWS];
        public string[] stats = new string[ROWS];
        public static int MAX_PRICE = 4100;
        public static int MAX_BATTARY = 400;
        public static int MAX_YEAR = 19;
        public static int MAX_SCREEN_SIZE = 20;
        public static int MAX_WEIGHT = 4;
        public static int MAX_MICROPHONE = 120;
        public static int MAX_OP = 10;
        public static int MAX_PROCESSOR = 7;
        public static int MAX_GRAPHICS = 1200;
        public static int MAX_RAM = 16;
        public static int MAX_STORAGE = 1000;
        public static int MAX_CAMERA = 16;
        public static int MAX_LIGHTB = 1;
        public static int MAX_FLASH = 1;
        public static int MAX_USB = 3;
        public static int MAX_HDMI = 1;
        public static int MAX_TOUCHSCREEN = 1;
        public static int MAX_NIC = 1;
        public static int MAX_FINGERPRINT = 1;
        public static int MAX_CELLULARMODEM = 1;
        public static int MAX_EARPHONES = 1;
        public static int MAX_BLUTOOTH = 1;
        public static int MAX_SPEAKERS = 1000;
        public Form1(Program obj)
        {
            Owner = obj;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            targetcombobox.SelectedIndex = 0;

            pricerule.SelectedIndex = 0;
            PriceValue.Text = "0";
            priceweight.SelectedIndex = 0;

            battaryrule.SelectedIndex = 0;
            battaryvalue.Text = "0";
            battaryweight.SelectedIndex = 0;

            yearrule.SelectedIndex = 0;
            yearvalue.Text = "0";
            yearweight.SelectedIndex = 0;

            weightrule.SelectedIndex = 0;
            weightvalue.Text = "0";
            weightweight.SelectedIndex = 0;

            microphonrule.SelectedIndex = 0;
            microphonevalue.Text = "0";
            microphoneweight.SelectedIndex = 0;

            osrule.SelectedIndex = 0;
            osvalue.Text = "0";
            osweight.SelectedIndex = 0;

            processorrule.SelectedIndex = 0;
            processvalue.Text = "0";
            processorweight.SelectedIndex = 0;

            speakersrule.SelectedIndex = 0;
            speakersvalue.Text = "0";
            speakersweight.SelectedIndex = 0;

            graphicsrule.SelectedIndex = 0;
            graphicsvalue.Text = "0";
            graphicsweight.SelectedIndex = 0;

            earphonesrule.SelectedIndex = 0;
            earphonevalue.Text = "0";
            earslotweight.SelectedIndex = 0;

            screensizerule.SelectedIndex = 0;
            screensizevalue.Text = "0";
            screensizeweight.SelectedIndex = 0;

            ramrule.SelectedIndex = 0;
            ramvalue.Text = "0";
            ramweight.SelectedIndex = 0;

            storagerule.SelectedIndex = 0;
            storagevalue.Text = "0";
            storageweight.SelectedIndex = 0;

            brandrule.SelectedIndex = 0;
            dellvalue.Text = "0";
            acervalue.Text = "0";
            asusvalue.Text = "0";
            hpvalue.Text = "0";
            applevalue.Text = "0";
            lenovovalue.Text = "0";
            brandweight.SelectedIndex = 0;

            camerarule.SelectedIndex = 0;
            cameravalue.Text = "0";
            cameraweight.SelectedIndex = 0;

            keylightrule.SelectedIndex = 0;
            keylightvalue.Text = "0";
            keylightweight.SelectedIndex = 0;

            flashrule.SelectedIndex = 0;
            flashvalue.Text = "2";
            flashweight.SelectedIndex = 0;

            usbrule.SelectedIndex = 0;
            usbvalue.Text = "0";
            usbweight.SelectedIndex = 0;

            hdmirule.SelectedIndex = 0;
            hdmivalue.Text = "0";
            hdmiweight.SelectedIndex = 0;

            touchscreenrule.SelectedIndex = 0;
            touchscreenvalue.Text = "0";
            touchscreenweight.SelectedIndex = 0;

            nicrule.SelectedIndex = 0;
            nicvalue.Text = "0";
            nicweight.SelectedIndex = 0;

            blutoothrule.SelectedIndex = 0;
            blutootvalue.Text = "0";
            blutoothweight.SelectedIndex = 0;

            fingerprintrule.SelectedIndex = 0;
            fingerprintvalue.Text = "0";
            fingerprintweight.SelectedIndex = 0;

            cellularmodemrule.SelectedIndex = 0;
            cellularmodemvalue.Text = "0";
            cellularmodemweight.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //determine presets!!!


            if (targetcombobox.Text.Equals("Children"))
            {

                pricerule.SelectedIndex = 1;
                PriceValue.Text = "0";
                priceweight.SelectedIndex = 4;

                battaryrule.SelectedIndex = 3;
                battaryvalue.Text = "180";
                battaryweight.SelectedIndex = 2;

                yearrule.SelectedIndex = 2;
                yearvalue.Text = "0";
                yearweight.SelectedIndex = 0;

                weightrule.SelectedIndex = 1;
                weightvalue.Text = "0";
                weightweight.SelectedIndex = 4;

                screensizerule.SelectedIndex = 3;
                screensizevalue.Text = "12";
                screensizeweight.SelectedIndex = 3;

                microphonrule.SelectedIndex = 0;
                microphonevalue.Text = "0";
                microphoneweight.SelectedIndex = 2;

                osrule.SelectedIndex = 3;
                osvalue.Text = "8";
                osweight.SelectedIndex = 4;

                processorrule.SelectedIndex = 3;
                processvalue.Text = "3";
                processorweight.SelectedIndex = 1;

                speakersrule.SelectedIndex = 3;
                speakersvalue.Text = "1";
                speakersweight.SelectedIndex = 4;

                graphicsrule.SelectedIndex = 3;
                graphicsvalue.Text = "720";
                graphicsweight.SelectedIndex = 4;

                earphonesrule.SelectedIndex = 3;
                earphonevalue.Text = "1";
                earslotweight.SelectedIndex = 1;


                ramrule.SelectedIndex = 0;
                ramvalue.Text = "0";
                ramweight.SelectedIndex = 0;

                storagerule.SelectedIndex = 3;
                storagevalue.Text = "500";
                storageweight.SelectedIndex = 2;

                brandrule.SelectedIndex = 0;
                dellvalue.Text = "2";
                acervalue.Text = "3";
                asusvalue.Text = "5";
                hpvalue.Text = "1";
                applevalue.Text = "4";
                lenovovalue.Text = "5";
                brandweight.SelectedIndex = 2;

                camerarule.SelectedIndex = 3;
                cameravalue.Text = "1";
                cameraweight.SelectedIndex = 4;

                keylightrule.SelectedIndex = 1;
                keylightvalue.Text = "0";
                keylightweight.SelectedIndex = 1;

                flashrule.SelectedIndex = 1;
                flashvalue.Text = "0";
                flashweight.SelectedIndex = 0;

                usbrule.SelectedIndex = 3;
                usbvalue.Text = "2";
                usbweight.SelectedIndex = 0;

                hdmirule.SelectedIndex = 0;
                hdmivalue.Text = "0";
                hdmiweight.SelectedIndex = 0;

                touchscreenrule.SelectedIndex = 2;
                touchscreenvalue.Text = "0";
                touchscreenweight.SelectedIndex = 0;

                nicrule.SelectedIndex = 0;
                nicvalue.Text = "0";
                nicweight.SelectedIndex = 0;

                blutoothrule.SelectedIndex = 2;
                blutootvalue.Text = "0";
                blutoothweight.SelectedIndex = 0;

                fingerprintrule.SelectedIndex = 2;
                fingerprintvalue.Text = "0";
                fingerprintweight.SelectedIndex = 0;

                cellularmodemrule.SelectedIndex = 2;
                cellularmodemvalue.Text = "0";
                cellularmodemweight.SelectedIndex = 0;


            }
            if (targetcombobox.Text.Equals("Gamers"))
            {

                pricerule.SelectedIndex = 2;
                PriceValue.Text = "3200";
                priceweight.SelectedIndex = 3;

                battaryrule.SelectedIndex = 0;
                battaryvalue.Text = "400";
                battaryweight.SelectedIndex = 4;

                yearrule.SelectedIndex = 2;
                yearvalue.Text = "0";
                yearweight.SelectedIndex = 3;

                screensizerule.SelectedIndex = 0;
                screensizevalue.Text = "16";
                screensizeweight.SelectedIndex = 4;

                weightrule.SelectedIndex = 3;
                weightvalue.Text = "2";
                weightweight.SelectedIndex = 2;

                microphonrule.SelectedIndex = 0;
                microphonevalue.Text = "1";
                microphoneweight.SelectedIndex = 2;

                osrule.SelectedIndex = 0;
                osvalue.Text = "0";
                osweight.SelectedIndex = 4;

                processorrule.SelectedIndex = 0;
                processvalue.Text = "0";
                processorweight.SelectedIndex = 4;

                speakersrule.SelectedIndex = 0;
                speakersvalue.Text = "0";
                speakersweight.SelectedIndex = 0;

                graphicsrule.SelectedIndex = 0;
                graphicsvalue.Text = "1200";
                graphicsweight.SelectedIndex = 4;

                earphonesrule.SelectedIndex = 0;
                earphonevalue.Text = "1";
                earslotweight.SelectedIndex = 3;


                ramrule.SelectedIndex = 3;
                ramvalue.Text = "16";
                ramweight.SelectedIndex = 4;

                storagerule.SelectedIndex = 3;
                storagevalue.Text = "1000";
                storageweight.SelectedIndex = 2;

                brandrule.SelectedIndex = 0;
                dellvalue.Text = "1";
                acervalue.Text = "2";
                asusvalue.Text = "3";
                hpvalue.Text = "5";
                applevalue.Text = "5";
                lenovovalue.Text = "4";
                brandweight.SelectedIndex = 4;

                camerarule.SelectedIndex = 0;
                cameravalue.Text = "1";
                cameraweight.SelectedIndex = 1;

                keylightrule.SelectedIndex = 0;
                keylightvalue.Text = "1";
                keylightweight.SelectedIndex = 0;

                flashrule.SelectedIndex = 0;
                flashvalue.Text = "5";
                flashweight.SelectedIndex = 3;

                usbrule.SelectedIndex = 2;
                usbvalue.Text = "0";
                usbweight.SelectedIndex = 0;

                hdmirule.SelectedIndex = 0;
                hdmivalue.Text = "1";
                hdmiweight.SelectedIndex = 2;

                touchscreenrule.SelectedIndex = 0;
                touchscreenvalue.Text = "1";
                touchscreenweight.SelectedIndex = 1;

                nicrule.SelectedIndex = 0;
                nicvalue.Text = "1";
                nicweight.SelectedIndex = 4;

                blutoothrule.SelectedIndex = 0;
                blutootvalue.Text = "1";
                blutoothweight.SelectedIndex = 3;

                fingerprintrule.SelectedIndex = 2;
                fingerprintvalue.Text = "0";
                fingerprintweight.SelectedIndex = 0;

                cellularmodemrule.SelectedIndex = 2;
                cellularmodemvalue.Text = "0";
                cellularmodemweight.SelectedIndex = 0;
            }
            if (targetcombobox.Text.Equals("Pensioners"))
            {
               

                pricerule.SelectedIndex = 3;
                PriceValue.Text = "2100";
                priceweight.SelectedIndex = 2;

                battaryrule.SelectedIndex = 0;
                battaryvalue.Text = "0";
                battaryweight.SelectedIndex = 3;

                yearrule.SelectedIndex = 2;
                yearvalue.Text = "0";
                yearweight.SelectedIndex = 0;

                weightrule.SelectedIndex = 3;
                weightvalue.Text = "2";
                weightweight.SelectedIndex = 3;

                screensizerule.SelectedIndex = 0;
                screensizevalue.Text = "0";
                screensizeweight.SelectedIndex = 4;

                microphonrule.SelectedIndex = 0;
                microphonevalue.Text = "0";
                microphoneweight.SelectedIndex = 1;

                osrule.SelectedIndex = 2;
                osvalue.Text = "0";
                osweight.SelectedIndex = 2;

                processorrule.SelectedIndex = 3;
                processvalue.Text = "3";
                processorweight.SelectedIndex = 1;

                speakersrule.SelectedIndex = 0;
                speakersvalue.Text = "1";
                speakersweight.SelectedIndex = 4;

                graphicsrule.SelectedIndex = 2;
                graphicsvalue.Text = "0";
                graphicsweight.SelectedIndex = 0;

                earphonesrule.SelectedIndex = 0;
                earphonevalue.Text = "0";
                earslotweight.SelectedIndex = 4;


                ramrule.SelectedIndex = 3;
                ramvalue.Text = "8";
                ramweight.SelectedIndex = 3;

                storagerule.SelectedIndex = 3;
                storagevalue.Text = "1000";
                storageweight.SelectedIndex = 1;

                brandrule.SelectedIndex = 0;
                dellvalue.Text = "3";
                acervalue.Text = "2";
                asusvalue.Text = "1";
                hpvalue.Text = "4";
                applevalue.Text = "1";
                lenovovalue.Text = "5";
                brandweight.SelectedIndex = 0;

                camerarule.SelectedIndex = 0;
                cameravalue.Text = "1";
                cameraweight.SelectedIndex = 2;

                keylightrule.SelectedIndex = 0;
                keylightvalue.Text = "1";
                keylightweight.SelectedIndex = 3;

                flashrule.SelectedIndex = 0;
                flashvalue.Text = "5";
                flashweight.SelectedIndex = 4;

                usbrule.SelectedIndex = 2;
                usbvalue.Text = "0";
                usbweight.SelectedIndex = 0;

                hdmirule.SelectedIndex = 2;
                hdmivalue.Text = "0";
                hdmiweight.SelectedIndex = 0;

                touchscreenrule.SelectedIndex = 0;
                touchscreenvalue.Text = "1";
                touchscreenweight.SelectedIndex = 4;

                nicrule.SelectedIndex = 0;
                nicvalue.Text = "1";
                nicweight.SelectedIndex = 3;

                blutoothrule.SelectedIndex = 0;
                blutootvalue.Text = "1";
                blutoothweight.SelectedIndex = 2;

                fingerprintrule.SelectedIndex = 0;
                fingerprintvalue.Text = "1";
                fingerprintweight.SelectedIndex = 3;

                cellularmodemrule.SelectedIndex = 0;
                cellularmodemvalue.Text = "1";
                cellularmodemweight.SelectedIndex = 3;
            }
        }

        // battary
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                if (battaryrule.Text.Equals("Highest Better") || battaryrule.Text.Equals("Lowest Better") || battaryrule.Text.Equals("Not Important"))
                {
                    battaryvalue.Enabled = false;
                    battaryvalue.Text = "0";
                }
                else
                {
                    battaryvalue.Enabled = true;
                    battaryvalue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        // year
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                if (yearrule.Text.Equals("Highest Better") || yearrule.Text.Equals("Lowest Better") || yearrule.Text.Equals("Not Important"))
                {
                    yearvalue.Enabled = false;
                    yearvalue.Text = "0";

                }
                else
                {
                    yearvalue.Enabled = true;
                    yearvalue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        // screen size
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                if (screensizerule.Text.Equals("Highest Better") || screensizerule.Text.Equals("Lowest Better") || screensizerule.Text.Equals("Not Important"))
                {
                    screensizevalue.Enabled = false;
                    screensizevalue.Text = "0";
                }
                else
                {
                    screensizevalue.Enabled = true;
                    screensizevalue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        // weight
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                if (weightrule.Text.Equals("Highest Better") || weightrule.Text.Equals("Lowest Better") || weightrule.Text.Equals("Not Important"))
                {
                    weightvalue.Enabled = false;
                    weightvalue.Text = "0";
                }
                else
                {
                    weightvalue.Enabled = true;
                    weightvalue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        // operation system
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                if (osrule.Text.Equals("Highest Better") || osrule.Text.Equals("Lowest Better") || osrule.Text.Equals("Not Important"))
                {
                    osvalue.Enabled = false;
                    osvalue.Text = "0";
                }
                else
                {
                    osvalue.Enabled = true;
                    osvalue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        // processor
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                if (processorrule.Text.Equals("Highest Better") || processorrule.Text.Equals("Lowest Better") || processorrule.Text.Equals("Not Important"))
                {
                    processvalue.Enabled = false;
                    processvalue.Text = "0";
                }
                else
                {
                    processvalue.Enabled = true;
                    processvalue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        // graphics
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                if (graphicsrule.Text.Equals("Highest Better") || graphicsrule.Text.Equals("Lowest Better") || graphicsrule.Text.Equals("Not Important"))
                {
                    graphicsvalue.Enabled = false;
                    graphicsvalue.Text = "0";
                }
                else
                {
                    graphicsvalue.Enabled = true;
                    graphicsvalue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        // ram
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                if (ramrule.Text.Equals("Highest Better") || ramrule.Text.Equals("Lowest Better") || ramrule.Text.Equals("Not Important"))
                {
                    ramvalue.Enabled = false;
                    ramvalue.Text = "0";
                }
                else
                {
                    ramvalue.Enabled = true;
                    ramvalue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        //storage
        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                if (storagerule.Text.Equals("Highest Better") || storagerule.Text.Equals("Lowest Better") || storagerule.Text.Equals("Not Important"))
                {
                    storagevalue.Enabled = false;
                    storagevalue.Text = "0";
                }
                else
                {
                    storagevalue.Enabled = true;
                    storagevalue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //reset to default values
            targetcombobox.SelectedIndex = 0;

            pricerule.SelectedIndex = 0;
            PriceValue.Text = "0";
            priceweight.SelectedIndex = 0;

            battaryrule.SelectedIndex = 0;
            battaryvalue.Text = "0";
            battaryweight.SelectedIndex = 0;

            yearrule.SelectedIndex = 0;
            yearvalue.Text = "0";
            yearweight.SelectedIndex = 0;

            weightrule.SelectedIndex = 0;
            weightvalue.Text = "0";
            weightweight.SelectedIndex = 0;

            microphonrule.SelectedIndex = 0;
            microphonevalue.Text = "0";
            microphoneweight.SelectedIndex = 0;

            osrule.SelectedIndex = 0;
            osvalue.Text = "0";
            osweight.SelectedIndex = 0;

            processorrule.SelectedIndex = 0;
            processvalue.Text = "0";
            processorweight.SelectedIndex = 0;

            speakersrule.SelectedIndex = 0;
            speakersvalue.Text = "0";
            speakersweight.SelectedIndex = 0;

            graphicsrule.SelectedIndex = 0;
            graphicsvalue.Text = "0";
            graphicsweight.SelectedIndex = 0;

            earphonesrule.SelectedIndex = 0;
            earphonevalue.Text = "0";
            earslotweight.SelectedIndex = 0;

            screensizerule.SelectedIndex = 0;
            screensizevalue.Text = "0";
            screensizeweight.SelectedIndex = 0;

            ramrule.SelectedIndex = 0;
            ramvalue.Text = "0";
            ramweight.SelectedIndex = 0;

            storagerule.SelectedIndex = 0;
            storagevalue.Text = "0";
            storageweight.SelectedIndex = 0;

            brandrule.SelectedIndex = 0;
            dellvalue.Text = "0";
            acervalue.Text = "0";
            asusvalue.Text = "0";
            hpvalue.Text = "0";
            applevalue.Text = "0";
            lenovovalue.Text = "0";
            brandweight.SelectedIndex = 0;

            camerarule.SelectedIndex = 0;
            cameravalue.Text = "0";
            cameraweight.SelectedIndex = 0;

            keylightrule.SelectedIndex = 0;
            keylightvalue.Text = "0";
            keylightweight.SelectedIndex = 0;

            flashrule.SelectedIndex = 0;
            flashvalue.Text = "0";
            flashweight.SelectedIndex = 0;

            usbrule.SelectedIndex = 0;
            usbvalue.Text = "0";
            usbweight.SelectedIndex = 0;

            hdmirule.SelectedIndex = 0;
            hdmivalue.Text = "0";
            hdmiweight.SelectedIndex = 0;

            touchscreenrule.SelectedIndex = 0;
            touchscreenvalue.Text = "0";
            touchscreenweight.SelectedIndex = 0;

            nicrule.SelectedIndex = 0;
            nicvalue.Text = "0";
            nicweight.SelectedIndex = 0;

            blutoothrule.SelectedIndex = 0;
            blutootvalue.Text = "0";
            blutoothweight.SelectedIndex = 0;

            fingerprintrule.SelectedIndex = 0;
            fingerprintvalue.Text = "0";
            fingerprintweight.SelectedIndex = 0;

            cellularmodemrule.SelectedIndex = 0;
            cellularmodemvalue.Text = "0";
            cellularmodemweight.SelectedIndex = 0;



        }

        private void calcbutton_Click_1(object sender, EventArgs e)
        {
            string[] _s = new string[COLS];
            double[,] results;
            DateTime start = DateTime.Now;
            TimeSpan timeItTook;

            try
            {
                weights[0] = double.Parse(brandweight.Text);
                weights[1] = double.Parse(priceweight.Text);
                weights[2] = double.Parse(battaryweight.Text);
                weights[3] = double.Parse(yearweight.Text);
                weights[4] = double.Parse(screensizeweight.Text);
                weights[5] = double.Parse(weightweight.Text);
                weights[6] = double.Parse(microphoneweight.Text);
                weights[7] = double.Parse(osweight.Text);
                weights[8] = double.Parse(processorweight.Text);
                weights[9] = double.Parse(graphicsweight.Text);
                weights[10] = double.Parse(ramweight.Text);
                weights[11] = double.Parse(storageweight.Text);
                weights[12] = double.Parse(cameraweight.Text);
                weights[13] = double.Parse(keylightweight.Text);
                weights[14] = double.Parse(flashweight.Text);
                weights[15] = double.Parse(usbweight.Text);
                weights[16] = double.Parse(hdmiweight.Text);
                weights[17] = double.Parse(touchscreenweight.Text);
                weights[18] = double.Parse(nicweight.Text);
                weights[19] = double.Parse(fingerprintweight.Text);
                weights[20] = double.Parse(cellularmodemweight.Text);
                weights[21] = double.Parse(speakersweight.Text);
                weights[22] = double.Parse(earslotweight.Text);
                weights[23] = double.Parse(blutoothweight.Text);





                values[0] = 3;
                values[1] = (int)Math.Floor(double.Parse(PriceValue.Text) / MAX_PRICE * 10);
                values[2] = (int)Math.Floor(double.Parse(battaryvalue.Text) / MAX_BATTARY * 10);
                values[3] = (int)Math.Floor(double.Parse(yearvalue.Text) / MAX_YEAR * 10);
                values[4] = (int)Math.Floor(double.Parse(screensizevalue.Text) / MAX_SCREEN_SIZE * 10);
                values[5] = (int)Math.Floor(double.Parse(weightvalue.Text) / MAX_WEIGHT * 10);

                values[6] = (int)Math.Floor(double.Parse(microphonevalue.Text) / MAX_MICROPHONE * 10);
                values[7] = (int)Math.Floor(double.Parse(osvalue.Text) / MAX_OP * 10);
                values[8] = (int)Math.Floor(double.Parse(processvalue.Text) / MAX_PROCESSOR * 10);
                values[9] = (int)Math.Floor(double.Parse(graphicsvalue.Text) / MAX_GRAPHICS * 10);
                values[10] = (int)Math.Floor(double.Parse(ramvalue.Text) / MAX_RAM * 10);
                values[11] = (int)Math.Floor(double.Parse(storagevalue.Text) / MAX_STORAGE * 10);
                values[12] = (int)Math.Floor(double.Parse(cameravalue.Text) / MAX_CAMERA * 10);
                values[13] = (int)Math.Floor(double.Parse(keylightvalue.Text) / MAX_LIGHTB * 10);
                values[14] = (int)Math.Floor(double.Parse(flashvalue.Text) / MAX_FLASH * 10);
                values[15] = (int)Math.Floor(double.Parse(usbvalue.Text) / MAX_USB * 10);
                values[16] = (int)Math.Floor(double.Parse(hdmivalue.Text) / MAX_HDMI * 10);
                values[17] = (int)Math.Floor(double.Parse(touchscreenvalue.Text) / MAX_TOUCHSCREEN * 10);
                values[18] = (int)Math.Floor(double.Parse(nicvalue.Text) / MAX_NIC * 10);
                values[19] = (int)Math.Floor(double.Parse(fingerprintvalue.Text) / MAX_FINGERPRINT * 10);
                values[20] = (int)Math.Floor(double.Parse(cellularmodemvalue.Text) / MAX_CELLULARMODEM * 10);
                values[21] = (int)Math.Floor(double.Parse(speakersvalue.Text) / MAX_SPEAKERS * 10);
                values[22] = (int)Math.Floor(double.Parse(earphonevalue.Text) / MAX_EARPHONES * 10);
                values[23] = (int)Math.Floor(double.Parse(blutootvalue.Text) / MAX_BLUTOOTH * 10);

                for (int i = 0; i < values.Length; i++)
                {
                    if (values[i] > 9)
                    {
                        values[i] = 9;
                    }
                }



                stats[0] = pricerule.Text;
                stats[1] = battaryrule.Text;
                stats[2] = yearrule.Text;
                stats[3] = screensizerule.Text;
                stats[4] = weightrule.Text;
                stats[5] = microphonrule.Text;
                stats[6] = osrule.Text;
                stats[7] = processorrule.Text;
                stats[8] = graphicsrule.Text;
                stats[9] = ramrule.Text;
                stats[10] = storagerule.Text;
                stats[11] = camerarule.Text;
                stats[12] = keylightrule.Text;
                stats[13] = flashrule.Text;
                stats[14] = usbrule.Text;
                stats[15] = hdmirule.Text;
                stats[16] = touchscreenrule.Text;
                stats[17] = nicrule.Text;
                stats[18] = fingerprintrule.Text;
                stats[19] = cellularmodemrule.Text;
                stats[20] = speakersrule.Text;
                stats[21] = earphonesrule.Text;
                stats[22] = blutoothrule.Text;
                stats[23] = brandrule.Text;

                Owner.A_Claculations.setStats(stats);
                Owner.A_Claculations.setValues(values);
                Owner.A_Claculations.setWeights(weights);
                string s = Owner.A_Claculations.LaptopData[0, 0];
                Owner.A_Claculations.normalize();
                Owner.A_Claculations.NormalizeAccordingToStats();

                // call algorithm functions
                if (topsisalgo.Checked)
                {
                    results = Owner.A_Claculations.Topsis();
                }
                else
                {
                    results = Owner.A_Claculations.Borda();
                }

                datagridresults.Rows.Clear();


                for (int i = 0; i < ROWS - 1; i++)
                {
                    for (int j = 0; j < COLS; j++)
                    {
                        _s[j] = Owner.A_Claculations.LaptopData[j, (int)results[i, 1]].ToString();
                    }
                    datagridresults.Rows.Add(_s);
                }
                timeItTook = DateTime.Now - start;
                runtimelabel.Text = timeItTook.TotalSeconds.ToString();
                foreach (DataGridViewColumn column in datagridresults.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }




            }
            catch(Exception ex)
            {

            }
        }

        private void bordaAlgo_CheckedChanged(object sender, EventArgs e)
        {
            battaryweight.Enabled = false;
            yearweight.Enabled = false;
            weightweight.Enabled = false;
            microphoneweight.Enabled = false;
            screensizeweight.Enabled = false;
            osweight.Enabled = false;
            processorweight.Enabled = false;
            speakersweight.Enabled = false;
            graphicsweight.Enabled = false;
            earslotweight.Enabled = false;
            ramweight.Enabled = false;
            storageweight.Enabled = false;
            screensizeweight.Enabled = false;
            cameraweight.Enabled = false;
            keylightweight.Enabled = false;
            flashweight.Enabled = false;
            usbweight.Enabled = false;
            hdmiweight.Enabled = false;
            touchscreenweight.Enabled = false;
            nicweight.Enabled = false;
            blutoothweight.Enabled = false;
            usbweight.Enabled = false ;
            priceweight.Enabled = false;
            brandweight.Enabled = false;
            fingerprintweight.Enabled = false;
            cellularmodemweight.Enabled = false;

        }

        private void topsisalgo_CheckedChanged(object sender, EventArgs e)
        {
            battaryweight.Enabled = true;
            yearweight.Enabled = true;
            weightweight.Enabled = true;
            screensizeweight.Enabled = true;
            microphoneweight.Enabled = true;
            osweight.Enabled = true;
            processorweight.Enabled = true;
            speakersweight.Enabled = true;
            graphicsweight.Enabled = true;
            earslotweight.Enabled = true;
            ramweight.Enabled = true;
            storageweight.Enabled = true;
            screensizeweight.Enabled = true;
            cameraweight.Enabled = true;
            keylightweight.Enabled = true;
            flashweight.Enabled = true;
            usbweight.Enabled = true;
            hdmiweight.Enabled = true;
            touchscreenweight.Enabled = true;
            nicweight.Enabled = true;
            blutoothweight.Enabled = true;
            usbweight.Enabled = true;
            priceweight.Enabled = true;
            brandweight.Enabled = true;
            fingerprintweight.Enabled = true;
            cellularmodemweight.Enabled = true;
        }

        private void pricerule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                if (pricerule.Text.Equals("Highest Better") || pricerule.Text.Equals("Lowest Better") || pricerule.Text.Equals("Not Important"))
                {
                    PriceValue.Enabled = false;
                    PriceValue.Text = "0";
                }
                else
                {
                    PriceValue.Enabled = true;
                    PriceValue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void battaryrule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                if (battaryrule.Text.Equals("Highest Better") || battaryrule.Text.Equals("Lowest Better") || battaryrule.Text.Equals("Not Important"))
                {
                    battaryvalue.Enabled = false;
                    battaryvalue.Text = "0";
                }
                else
                {
                    battaryvalue.Enabled = true;
                    battaryvalue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void microphonrule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                if (microphonrule.Text.Equals("Highest Better") || microphonrule.Text.Equals("Lowest Better") || microphonrule.Text.Equals("Not Important"))
                { 
                    microphonevalue.Enabled = false;
                     microphonevalue.Text = "0";
                }
                else
                {
                microphonevalue.Enabled = true;
                microphonevalue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void speakersrule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (speakersrule.Text.Equals("Highest Better") || speakersrule.Text.Equals("Lowest Better") || speakersrule.Text.Equals("Not Important"))
                {
                    speakersvalue.Enabled = false;
                    speakersvalue.Text = "0";
                }
                else
                {
                    speakersvalue.Enabled = true;
                    speakersvalue.Text = "";
                }
             }
            catch (Exception ex)
            {

            }
        }

        private void earphonesrule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (earphonesrule.Text.Equals("Highest Better") || earphonesrule.Text.Equals("Lowest Better") || earphonesrule.Text.Equals("Not Important"))
                {
                    earphonevalue.Enabled = false;
                    earphonevalue.Text = "0";
                }
                else
                {
                    earphonevalue.Enabled = true;
                    earphonevalue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void brandrule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (brandrule.Text.Equals("Not Important"))
                {
                    dellvalue.Enabled = false;
                    dellvalue.Text = "0";
                    acervalue.Enabled = false;
                    acervalue.Text = "0";
                    applevalue.Enabled = false;
                    applevalue.Text = "0";
                    hpvalue.Enabled = false;
                    hpvalue.Text = "0";
                    asusvalue.Enabled = false;
                    asusvalue.Text = "0";
                    lenovovalue.Enabled = false;
                    lenovovalue.Text = "0";
                    
                }
                else
                {
                    dellvalue.Enabled = true;
                    dellvalue.Text = "0";
                    acervalue.Enabled = true;
                    acervalue.Text = "0";
                    applevalue.Enabled = true;
                    applevalue.Text = "0";
                    hpvalue.Enabled = true;
                    hpvalue.Text = "0";
                    asusvalue.Enabled = true;
                    asusvalue.Text = "0";
                    lenovovalue.Enabled = true;
                    lenovovalue.Text = "0";
                }
            }
            catch (Exception ex)
            {

            }
        }
        

        private void camerarule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (camerarule.Text.Equals("Highest Better") || camerarule.Text.Equals("Lowest Better") || camerarule.Text.Equals("Not Important"))
                {
                    cameravalue.Enabled = false;
                    cameravalue.Text = "0";
                }
                else
                {
                    cameravalue.Enabled = true;
                    cameravalue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void keylightrule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (keylightrule.Text.Equals("Highest Better") || keylightrule.Text.Equals("Lowest Better") || keylightrule.Text.Equals("Not Important"))
                {
                    keylightvalue.Enabled = false;
                    keylightvalue.Text = "0";
                }
                else
                {
                    keylightvalue.Enabled = true;
                    keylightvalue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void flashrule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (flashrule.Text.Equals("Highest Better") || flashrule.Text.Equals("Lowest Better") || flashrule.Text.Equals("Not Important"))
                {
                    flashvalue.Enabled = false;
                    flashvalue.Text = "0";
                }
                else
                {
                    flashvalue.Enabled = true;
                    flashvalue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void usbrule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (usbrule.Text.Equals("Highest Better") || usbrule.Text.Equals("Lowest Better") || usbrule.Text.Equals("Not Important"))
                {
                    usbvalue.Enabled = false;
                    usbvalue.Text = "0";
                }
                else
                {
                    usbvalue.Enabled = true;
                    usbvalue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void hdmirule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (hdmirule.Text.Equals("Highest Better") || hdmirule.Text.Equals("Lowest Better") || hdmirule.Text.Equals("Not Important"))
                {
                    hdmivalue.Enabled = false;
                    hdmivalue.Text = "0";
                }
                else
                {
                    hdmivalue.Enabled = true;
                    hdmivalue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void touchscreenrule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (touchscreenrule.Text.Equals("Highest Better") || touchscreenrule.Text.Equals("Lowest Better") || touchscreenrule.Text.Equals("Not Important"))
                {
                    touchscreenvalue.Enabled = false;
                    touchscreenvalue.Text = "0";
                }
                else
                {
                    touchscreenvalue.Enabled = true;
                    touchscreenvalue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void nicrule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (nicrule.Text.Equals("Highest Better") || nicrule.Text.Equals("Lowest Better") || nicrule.Text.Equals("Not Important"))
                {
                    nicvalue.Enabled = false;
                    nicvalue.Text = "0";
                }
                else
                {
                    nicvalue.Enabled = true;
                    nicvalue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void blutoothrule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (blutoothrule.Text.Equals("Highest Better") || blutoothrule.Text.Equals("Lowest Better") || blutoothrule.Text.Equals("Not Important"))
                {
                    blutootvalue.Enabled = false;
                    blutootvalue.Text = "0";
                }
                else
                {
                    blutootvalue.Enabled = true;
                    blutootvalue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void fingerprintrule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (fingerprintrule.Text.Equals("Highest Better") || fingerprintrule.Text.Equals("Lowest Better") || fingerprintrule.Text.Equals("Not Important"))
                {
                    fingerprintvalue.Enabled = false;
                    fingerprintvalue.Text = "0";
                }
                else
                {
                    fingerprintvalue.Enabled = true;
                    fingerprintvalue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void cellularmodemrule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cellularmodemrule.Text.Equals("Highest Better") || cellularmodemrule.Text.Equals("Lowest Better") || cellularmodemrule.Text.Equals("Not Important"))
                {
                    cellularmodemvalue.Enabled = false;
                    cellularmodemvalue.Text = "0";
                }
                else
                {
                    cellularmodemvalue.Enabled = true;
                    cellularmodemvalue.Text = "";
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void datagridresults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

