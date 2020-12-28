using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boar_Base_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string dec_to_base(long input, int basee)
        {
            //Recieves a int that represents a deco,aç  number and converts it to a basee string

            IDictionary<long, char> numbers = new Dictionary<long, char>(){
                {0,'0'},{1,'1'},{2,'2'},{3,'3'},{4,'4'},{5,'5'},{6,'6'},{7,'7'},
                {8,'8'},{9,'9'},{10,'A'},{11,'B'},{12,'C'},{13,'D'},{14,'E'},{15,'F'},
            };

            string remains = "";
            string output = "";
            while (true)
            {
                Console.WriteLine(input);
                Console.WriteLine(basee);
                remains += numbers[input % basee];
                input = input / basee;
                if (input < basee)
                {
                    output += input.ToString();
                    break;
                };
            }
            for (int i = remains.Length - 1; i >= 0; i--)
            {
                output += remains[i];
            }

            return output;
        }
        static long base_to_dec(string input, int basee)
        {
            //Recieves a string that represents a basee number and converts it to a decimal int

            IDictionary<char, int> numbers = new Dictionary<char, int>(){
                {'0',0},{'1',1},{'2',2},{'3',3},{'4',4},{'5',5},{'6',6},{'7',7},
                {'8',8},{'9',9},{'A',10},{'B',11},{'C',12},{'D',13},{'E',14},{'F',15},
            };


            long output = 0;
            for (int i = 0; i < input.Length; i++)
            {


                if (numbers[input[input.Length - i - 1]] >= basee)
                {
                    throw new System.ArgumentException("The given number is not valid for the selected numerical base", "input");
                }

                long h = (long)((numbers[input[input.Length - i - 1]]) * Math.Pow(basee, i));
                output += h;
            }
            return output;

        }

        bool avoid_stack = false;

        private void Oct_TextChanged(object sender, EventArgs e)
        {
            if (!avoid_stack) avoid_stack = true;
            else return;

            Console.WriteLine("Octing");

            char[] universe = new char[8] { '0','1', '2', '3', '4', '5', '6', '7' };

            foreach (var ch in Oct.Text)
            {   
                if (!universe.Contains(ch)) Oct.Text = Oct.Text.Replace(ch.ToString(), "");
            
            }



            long dec = base_to_dec(Oct.Text,8);
            Dec.Text = dec.ToString();
            Bin.Text = dec_to_base(dec,2);
            Hex.Text = dec_to_base(dec, 16);

            avoid_stack = false;
        }

        private void Hex_TextChanged(object sender, EventArgs e)
        {
            if (!avoid_stack) avoid_stack = true;
            else return;

            Console.WriteLine("Hexing");

            Hex.Text = Hex.Text.ToUpper();
            char[] universe = new char[16] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9','A','B','C','D','E','F'};

            foreach (var ch in Hex.Text)
            {
                if (!universe.Contains(ch)) Hex.Text = Hex.Text.Replace(ch.ToString(), "");

            }
            long dec = base_to_dec(Hex.Text, 16);
            Dec.Text = dec.ToString();
            Bin.Text = dec_to_base(dec, 2);
            Oct.Text = dec_to_base(dec, 8);

            avoid_stack = false;
        }

        private void Bin_TextChanged(object sender, EventArgs e)

        {

            if (!avoid_stack) avoid_stack = true;
            else return;
            Console.WriteLine("Binaring");

            char[] universe = new char[2] { '0', '1'};

            foreach (var ch in Bin.Text)
            {
                if (!universe.Contains(ch)) Bin.Text = Bin.Text.Replace(ch.ToString(), "");

            }
            long dec = base_to_dec(Bin.Text, 2);
            Dec.Text = dec.ToString();
            Oct.Text = dec_to_base(dec, 8);
            Hex.Text = dec_to_base(dec, 16);

            avoid_stack = false;
        }

        private void Dec_TextChanged(object sender, EventArgs e)
        {
            if (!avoid_stack) avoid_stack = true;
            else return;

            Console.WriteLine("Decing");


            char[] universe = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7' ,'8','9'};

            foreach (var ch in Dec.Text)
            {
                if (!universe.Contains(ch)) Dec.Text = Dec.Text.Replace(ch.ToString(), "");
            }

            if (Dec.Text == "") Dec.Text = "0";
            long dec = Convert.ToInt64(Dec.Text);
            Dec.Text = dec.ToString();
            Bin.Text = dec_to_base(dec, 2);
            Oct.Text = dec_to_base(dec, 8);
            Hex.Text = dec_to_base(dec, 16);

            avoid_stack = false;
        }


    }
}
