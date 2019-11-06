using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuristicAlgosTopsis
{
    public class Claculations
    {
        Program owner;
        public const int COLS = 31;
        public const int ROWS = 26;
        public string[,] LaptopData = new string[ROWS, COLS];
        public double[,] NumericData = new double[ROWS, COLS-1];
        public double[,] score_per_id = new double[COLS - 1, 2];
        private const int MAX_VALUE = 9;
      
        
        public string[] stats = new string[ROWS];
        public int[] values = new int[ROWS];
        public double[] weights = new double[ROWS];
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



        public Claculations(Program obj)
        {
            owner = obj;
            
        }

        public void NormalizeAccordingToStats()
        {
            try
            {


                for (int i = 2; i < ROWS; i++)
                {
                    for (int j = 0; j < COLS; j++)
                    {
                        switch (stats[j])
                        {
                            case "Optimal Value":
                                NumericData[i, j] = (double)(MAX_VALUE - Math.Abs(values[j-1] - NumericData[i, j]));
                                break;
                            case "Constant Scale":
                                NumericData[i, j] = (double)(MAX_VALUE - Math.Abs(values[j] - NumericData[i, j]));
                                break;
                            case "Not Important":
                                NumericData[i, j] = 0;
                                // equals zero
                                break;
                            case "Lowest Better":
                                NumericData[i, j] = (double)(MAX_VALUE - NumericData[i, j]);
                                break;
                        }
                        if (i > 1)
                        {
                            if (NumericData[i, j] == 0 && !stats[j].Equals("Not Important"))
                            {
                                NumericData[i, j] = 1;
                            }
                        }
                    }
                }
                
            }
            catch (Exception e)
            {
                
            }
        }

        public void setWeights(double[] wght)
        {
            this.weights = wght;
        }

        public void setValues(int[] Vlues)
        {
            this.values = Vlues;
        }

        public void setStats(string[] _stats)
        {
            this.stats = _stats;
        }

        public void normalize()
        {
            try
            {
                for (int i = 0; i < ROWS; i++)
                {
                    for (int j = 1; j < COLS; j++)
                    {
                        switch (LaptopData[i, 0])
                        {
                            case "price":
                                NumericData[i, j - 1] = (double)Math.Floor((double.Parse(LaptopData[i, j]) / MAX_PRICE) * 10);

                                if (NumericData[i, j - 1] > 9)
                                {
                                    NumericData[i, j - 1] = 9;
                                }

                                break;

                            case "battary":
                                NumericData[i, j - 1] = (double)Math.Floor((double.Parse(LaptopData[i, j]) / MAX_BATTARY) * 10);
                                if (NumericData[i, j - 1] > 9)
                                {
                                    NumericData[i, j - 1] = 9;
                                }
                                break;
                            case "year":
                                NumericData[i, j - 1] = (double)Math.Floor((double.Parse(LaptopData[i, j]) / MAX_YEAR) * 10);
                                if (NumericData[i, j - 1] > 9)
                                {
                                    NumericData[i, j - 1] = 9;
                                }
                                break;
                            case "screen size":
                                NumericData[i, j - 1] = (double)Math.Floor((double.Parse(LaptopData[i, j]) / MAX_SCREEN_SIZE) * 10);
                                if (NumericData[i, j - 1] > 9)
                                {
                                    NumericData[i, j - 1] = 9;
                                }
                                break;
                            case "weight":
                                NumericData[i, j - 1] = (double)Math.Floor((double.Parse(LaptopData[i, j]) / MAX_WEIGHT) * 10);
                                if (NumericData[i, j - 1] > 9)
                                {
                                    NumericData[i, j - 1] = 9;
                                }
                                break;
                            case "Microphone":
                                NumericData[i, j - 1] = (double)Math.Floor((double.Parse(LaptopData[i, j]) / MAX_MICROPHONE) * 10);
                                if (NumericData[i, j - 1] > 9)
                                {
                                    NumericData[i, j - 1] = 9;
                                }
                                break;
                            case "Operation System":
                                if (LaptopData[i, j].Equals("macos"))
                                {
                                    NumericData[i, j - 1] = 9;
                                }
                                else
                                {
                                    NumericData[i, j - 1] = (double)(int.Parse(LaptopData[i, j]) - 2);
                                }
                                break;
                            case "Processor":
                                if (LaptopData[i, j - 1].Equals("i3"))
                                {
                                    NumericData[i, j - 1] = 3;
                                }
                                if (LaptopData[i, j].Equals("i5"))
                                {
                                    NumericData[i, j - 1] = 5;
                                }
                                if (LaptopData[i, j].Equals("i7"))
                                {
                                    NumericData[i, j - 1] = 7;
                                }
                                break;
                            case "Graphics Card":
                                NumericData[i, j - 1] = (double)Math.Floor((double.Parse(LaptopData[i, j]) / MAX_GRAPHICS) * 10);
                                if (NumericData[i, j - 1] > 9)
                                {
                                    NumericData[i, j - 1] = 9;
                                }
                                break;
                            case "RAM Memory":
                                NumericData[i, j - 1] = (double)Math.Floor((double.Parse(LaptopData[i, j]) / MAX_RAM) * 10);
                                if (NumericData[i, j - 1] > 9)
                                {
                                    NumericData[i, j - 1] = 9;
                                }
                                break;
                            case "HDMI":
                                NumericData[i, j - 1] = (double)Math.Floor((double.Parse(LaptopData[i, j]) / MAX_HDMI) * 10);
                                if (NumericData[i, j - 1] > 9)
                                {
                                    NumericData[i, j - 1] = 9;
                                }
                                break;
                            case "Storage":
                                NumericData[i, j - 1] = (double)Math.Floor((double.Parse(LaptopData[i, j]) / MAX_STORAGE) * 10);
                                if (NumericData[i, j - 1] > 9)
                                {
                                    NumericData[i, j - 1] = 9;
                                }
                                break;
                            case "camera":
                                NumericData[i, j - 1] = (double)Math.Floor((double.Parse(LaptopData[i, j]) / MAX_CAMERA) * 10);
                                if (NumericData[i, j - 1] > 9)
                                {
                                    NumericData[i, j - 1] = 9;
                                }
                                break;
                            case "Keyboard light":
                                NumericData[i, j - 1] = (double)Math.Floor((double.Parse(LaptopData[i, j]) / MAX_LIGHTB) * 10);
                                if (NumericData[i, j - 1] > 9)
                                {
                                    NumericData[i, j - 1] = 9;
                                }
                                break;
                            case "Flash":
                                NumericData[i, j - 1] = (double)Math.Floor((double.Parse(LaptopData[i, j]) / MAX_FLASH) * 10);
                                if (NumericData[i, j - 1] > 9)
                                {
                                    NumericData[i, j - 1] = 9;
                                }
                                break;
                            case "USB slots":
                                NumericData[i, j - 1] = (double)Math.Floor((double.Parse(LaptopData[i, j]) / MAX_USB) * 10);
                                if (NumericData[i, j - 1] > 9)
                                {
                                    NumericData[i, j - 1] = 9;
                                }
                                break;
                            case "Touch Screen":
                                NumericData[i, j - 1] = (double)Math.Floor((double.Parse(LaptopData[i, j]) / MAX_TOUCHSCREEN) * 10);
                                if (NumericData[i, j - 1] > 9)
                                {
                                    NumericData[i, j - 1] = 9;
                                }
                                break;
                            case "Network Intefrace":
                                NumericData[i, j - 1] = (double)Math.Floor((double.Parse(LaptopData[i, j]) / MAX_NIC) * 10);
                                if (NumericData[i, j - 1] > 9)
                                {
                                    NumericData[i, j - 1] = 9;
                                }
                                break;
                            case "Fingerprint":
                                NumericData[i, j - 1] = (double)Math.Floor((double.Parse(LaptopData[i, j]) / MAX_FINGERPRINT) * 10);
                                if (NumericData[i, j - 1] > 9)
                                {
                                    NumericData[i, j - 1] = 9;
                                }
                                break;
                            case "Cellular Modem":
                                NumericData[i, j - 1] = (double)Math.Floor((double.Parse(LaptopData[i, j]) / MAX_CELLULARMODEM) * 10);
                                if (NumericData[i, j - 1] > 9)
                                {
                                    NumericData[i, j - 1] = 9;
                                }
                                break;
                            case "speakers":
                                NumericData[i, j - 1] = (double)Math.Floor((double.Parse(LaptopData[i, j]) / MAX_SPEAKERS) * 10);
                                if (NumericData[i, j - 1] > 9)
                                {
                                    NumericData[i, j - 1] = 9;
                                }
                                break;
                            case "earphones slot":
                                NumericData[i, j - 1] = (double)Math.Floor((double.Parse(LaptopData[i, j]) / MAX_EARPHONES) * 10);
                                if (NumericData[i, j - 1] > 9)
                                {
                                    NumericData[i, j - 1] = 9;
                                }
                                break;
                            case "blutooth":
                                NumericData[i, j - 1] = (double)Math.Floor((double.Parse(LaptopData[i, j]) / MAX_BLUTOOTH) * 10);
                                if (NumericData[i, j - 1] > 9)
                                {
                                    NumericData[i, j - 1] = 9;
                                }
                                break;
                            case "id":
                                NumericData[i, j - 1] = double.Parse(LaptopData[i, j]);
                                break;
                            case "brand":
                                switch (LaptopData[i, j])
                                {
                                    case "ACER":
                                        NumericData[i, j - 1] = 1;
                                        break;
                                    case "DELL":
                                        NumericData[i, j - 1] = 2;
                                        break;
                                    case "Apple":
                                        NumericData[i, j - 1] = 3;
                                        break;
                                    case "Asus":
                                        NumericData[i, j - 1] = 4;
                                        break;
                                    case "HP":
                                        NumericData[i, j - 1] = 5;
                                        break;
                                    case "Lenovo":
                                        NumericData[i, j - 1] = 6;
                                        break;
                                }
                                break;
                            case "model":
                                NumericData[i, j - 1] = (double)double.Parse(LaptopData[0, j]);
                                break;
                            default:
                                NumericData[i, j - 1] = 0;
                                break;
                        }

                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        public void loadData(string filepath)
        {

            string[] currentline;
            int k = 0;

            try
            {

            

            if (!File.Exists(filepath))
            {
                // Create a file to write to.
                Console.WriteLine("data file doesnt exist!");
            }
            else
            {
                string[] readText = File.ReadAllLines(filepath);
                foreach (string s in readText)
                {
                    currentline = s.Split(',');
                    
                    for(int i=0;i<currentline.Length;i++)
                    {
                        LaptopData[k,i] = currentline[i];
                    }

                    //Console.WriteLine(s);
                    k++;
                }
            }
                // This text is always added, making the file longer over time
                // if it is not deleted.
                // Open the file to read from.
            }
            catch(Exception ex)
            {

            }
        }

        public void your2dArray(double[,] n)
        {
            try
            {


                for (int i = 0; i < n.GetLength(0) - 1; i++)
                {
                    for (int j = i; j < n.GetLength(0); j++)
                    {
                        if (n[i, 0] > n[j, 0]) // sort by ascending by first index of each row
                        {
                            for (int k = 0; k < n.GetLength(1); k++)
                            {
                                var temp = n[i, k];
                                n[i, k] = n[j, k];
                                n[j, k] = temp;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
               
            }
        }
        public double[,] Sorted_matrix(double[] id_arr, double[] Score)
        {

            double[,] temp_mat = new double[id_arr.Length, 2];

            try
            {


                for (int j = 0; j < id_arr.Length; j++)
                {
                    temp_mat[j, 0] = id_arr[j];
                }
                for (int j = 0; j < id_arr.Length; j++)
                {
                    temp_mat[j, 1] = Score[j];
                }

                //your2dArray(temp_mat);
                for (int j = 0; j < id_arr.Length; j++)
                {
                    Console.Write(temp_mat[j, 0]);
                    Console.Write("|");
                    Console.WriteLine(temp_mat[j, 1]);

                }
            }
            catch (Exception e)
            {
                return null;
            }
            return temp_mat;
        }


        public void print_matrix(double[,] mat)
        {
            try
            {

                for (int i = 0; i < ROWS - 2; i++)
                {
                    for (int j = 0; j < COLS - 1; j++)
                    {
                        Console.Write("|");
                        Console.Write(mat[i, j].ToString("#.000000"));
                    }
                    Console.WriteLine("");
                }
            }
            catch (Exception e)
            {
                
            }
        }
        public int Find_max(double[] arr)
        {
            double temp = -5;
            int temp_index = 0;

            try
            {


                for (int i = 0; i < arr.Length; i++)
                {
                    if (temp < arr[i] && arr[i] != -1)
                    {
                        temp = arr[i];
                        temp_index = i;
                    }
                }
            }
            catch (Exception e)
            {
                
            }
            return temp_index;
        }
        public double[,] Borda()
        {
            double temp;
            const int rows = ROWS;
            const int cols = COLS - 1;
            double[,] Table2 = new double[rows, cols];
            double[,] Table3 = new double[rows, cols];
            double[] temp_arr = new double[cols];
            double[] Scores = new double[COLS - 1];
            double[] id = new double[COLS - 1];
            int temp_index;
            int so_far;
            int new_num;

            try
            {
                Console.WriteLine("table 1:");
                print_matrix(NumericData);
                for (int i = 0; i < rows; i++)//creating table 2
                {
                    so_far = 1;
                    for (int j = 0; j < cols; j++)
                    {
                        temp_arr[j] = NumericData[i, j];
                    }
                    for (int k = 1; k <= cols; k++)
                    {
                        temp_index = Find_max(temp_arr);
                        temp = temp_arr[temp_index];
                        temp_arr[temp_index] = -1;
                        if (i == 0)
                        {
                            Console.WriteLine(so_far);
                        }
                        if (temp != temp_arr[Find_max(temp_arr)])
                        {
                            new_num = 0;
                            for (int j = 0; j < so_far; j++)
                            {
                                new_num += k - j;
                            }
                            for (int j = 0; j < so_far; j++)
                            {
                                Table2[i, temp_index - j] = (double)new_num / so_far;
                            }
                            so_far = 1;
                        }
                        else
                        {
                            so_far++;
                        }


                    }

                }
                Console.WriteLine("table 2:");
                print_matrix(Table2);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Table3[i, j] = cols - Table2[i, j];
                        Scores[j] += Table3[i, j];
                    }

                }
                for (int j = 0; j < cols; j++)
                {
                    id[j] = NumericData[0, j];
                }
                score_per_id = Sorted_matrix(Scores, id);

                for (int i = 0; i < cols; i++)
                {
                    for (int j = i + 1; j < cols; j++)
                    {
                        if (score_per_id[i, 0] > score_per_id[ j,0])
                        {
                            temp = score_per_id[i, 1];

                            score_per_id[i, 1] = score_per_id[j, 1];

                            score_per_id[j, 1] = temp;
                            temp = score_per_id[i, 0];

                            score_per_id[i, 0] = score_per_id[j, 0];

                            score_per_id[j, 0] = temp;
                        }
                    }
                }

                return score_per_id;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public double[,] Topsis()
        {
           
            
            print_matrix(NumericData);
            Console.WriteLine("");
            double temp;
            double[] step1_arr = new double[ROWS];
            double[,] step1_matrix = new double[ROWS, COLS -1];
            double[,] step2_matrix = new double[ROWS, COLS - 1];
            double[] step3_arr_plus = new double[ROWS];
            double[] step3_arr_minus = new double[ROWS];
            double[] step4_arr_plus = new double[COLS - 1];
            double[] step4_arr_minus = new double[COLS - 1];
            double[,] step4_matrix_plus = new double[ROWS, COLS - 1];
            double[,] step4_matrix_minus = new double[ROWS, COLS - 1];
            double[] step5_arr = new double[COLS - 1];
            double[] id = new double[COLS - 1];


            try
            {



                ////////////////////////////////////////////////////////////////////step1
                for (int i = 0; i < ROWS; i++)// initialize array to 0
                    step1_arr[i] = 0;
                for (int i = 0; i < ROWS; i++)//sum of square
                {
                    for (int j = 0; j < COLS - 1; j++)
                    {
                        step1_arr[i] += NumericData[i, j] * NumericData[i, j];
                    }
                }
                for (int i = 0; i < ROWS; i++)// squareroot
                {
                    step1_arr[i] = Math.Sqrt(step1_arr[i]);
                }
                Console.WriteLine("");
                for (int i = 0; i < ROWS; i++)
                {
                    for (int j = 0; j < COLS - 1; j++)
                    {
                        if (step1_arr[i] != 0)
                            step1_matrix[i, j] = NumericData[i, j] / step1_arr[i];
                        else
                            step1_matrix[i, j] = 0;
                    }
                }
                Console.WriteLine("step 1:");
                print_matrix(step1_matrix);//print matrix

                ////////////////////////////////////////////////////////////////////end step 1
                ///////////////////////////////////////////////////////////////////step 2
                for (int i = 0; i < ROWS; i++)//mul by weights
                {
                    for (int j = 0; j < COLS - 1; j++)
                    {

                        step2_matrix[i, j] = step1_matrix[i, j] * weights[i];
                    }
                }
                Console.WriteLine("step 2:");
                print_matrix(step2_matrix);
                ////////////////////////////////////////////////////////////////////// end step 2
                ////////////////////////////////////////////////////////////////////////step 3
                for (int i = 0; i < ROWS; i++)
                {
                    step3_arr_plus[i] = step2_matrix[i, 0];
                    step3_arr_minus[i] = step2_matrix[i, 0];

                    for (int j = 1; j < COLS - 1; j++)//find optimal and negative  optimal
                    {

                        if (step3_arr_plus[i] < step2_matrix[i, j])
                        {
                            step3_arr_plus[i] = step2_matrix[i, j];
                        }
                        if (step3_arr_minus[i] > step2_matrix[i, j])
                        {
                            step3_arr_minus[i] = step2_matrix[i, j];
                        }

                    }


                }

                Console.WriteLine("step 3 arr plus:");// printing

                for (int i = 0; i < ROWS; i++)
                {
                    Console.Write("|");
                    Console.Write(step3_arr_plus[i].ToString("#.000"));

                }
                Console.WriteLine("");
                Console.WriteLine("step 3 arr minus:");
                for (int i = 0; i < ROWS; i++)
                {
                    Console.Write("|");
                    Console.Write(step3_arr_minus[i].ToString("#.000"));
                }
                Console.WriteLine("");
                ////////////////////////////////////////////////////////////////////////////end step 3
                ////////////////////////////////////////////////////////////////////////////step 4
                for (int i = 0; i < ROWS; i++)// creating new matrix according to step 4 
                {
                    for (int j = 0; j < COLS - 1; j++)
                    {
                        step4_matrix_minus[i, j] = (step2_matrix[i, j] - step3_arr_minus[i]) * (step2_matrix[i, j] - step3_arr_minus[i]);
                        step4_matrix_plus[i, j] = (step2_matrix[i, j] - step3_arr_plus[i]) * (step2_matrix[i, j] - step3_arr_plus[i]);
                    }
                }
                Console.WriteLine("part 4 plus:");
                print_matrix(step4_matrix_plus);
                Console.WriteLine("part 4 minus:");
                print_matrix(step4_matrix_minus);
                for (int j = 0; j < COLS - 1; j++)
                {
                    for (int i = 0; i < ROWS ; i++)
                    {
                        step4_arr_plus[j] += step4_matrix_plus[i, j];
                        step4_arr_minus[j] += step4_matrix_minus[i, j];

                    }
                }
                for (int i = 0; i < COLS - 1; i++)
                {
                    step4_arr_plus[i] = Math.Sqrt(step4_arr_plus[i]);
                    step4_arr_minus[i] = Math.Sqrt(step4_arr_minus[i]);

                }
                Console.Write("step 4 arr_plus:");
                for (int i = 0; i < COLS - 1; i++)
                {
                    Console.Write("|");
                    Console.Write(step4_arr_plus[i].ToString("#.00000"));
                }
                Console.WriteLine("");
                Console.Write("step 4 arr_minus:");
                for (int i = 0; i < COLS - 1; i++)
                {
                    Console.Write("|");
                    Console.Write(step4_arr_minus[i].ToString("#.00000"));
                }
                Console.WriteLine("");
                ///////////////////////////////////////////////////////////////////////////////////end step 4
                ///////////////////////////////////////////////////////////////////////////////////step 5
                for (int i = 0; i < COLS - 1; i++)
                {
                    double curr = (step4_arr_plus[i] + step4_arr_minus[i]);
                    if (curr != 0)
                        step5_arr[i] = step4_arr_minus[i] / curr;
                    else
                        step5_arr[i] = 0;
                }
                for (int i = 0; i < COLS - 1; i++)
                {
                    id[i] = NumericData[1, i];
                }
                score_per_id = Sorted_matrix(step5_arr, id);

                for (int i = 0; i < COLS - 1; i++)
                {
                    for (int j = i + 1; j < COLS - 1; j++)
                    {
                        if (score_per_id[i, 0] > score_per_id[j, 0])
                        {
                            temp = score_per_id[i, 1];

                            score_per_id[i, 1] = score_per_id[j, 1];

                            score_per_id[j, 1] = temp;
                            temp = score_per_id[i, 0];

                            score_per_id[i, 0] = score_per_id[j, 0];

                            score_per_id[j, 0] = temp;
                        }
                    }
                }

                return score_per_id;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        
    }
}
