using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Stopwatch st = new Stopwatch();
        public int count = 0;

        ArrayList ar = new ArrayList();
        Hashtable ht = new Hashtable();
        HashSet<string> hashset = new HashSet<string>();
        SortedList sl = new SortedList();
        Stack stack = new Stack();
        Queue queue = new Queue();

        public static string dummy;
        public static string[] array = new string[] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                                                "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                                                "u","v","w","x","y","z"};

        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string inputCount = textBox7.Text;
            count = Convert.ToInt32(inputCount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            st.Reset();
            st.Start();


            for (int i = 0; i < count; i++)
            {
                // ar.Add(Guid.NewGuid().ToString());
                ar.Add(i + "");

            }
            st.Stop();
            textBox1.Text = "" + (st.ElapsedTicks / 10000 + " Milliseconds");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // HashTable은 보류
            st.Reset();
            st.Start();
            Console.WriteLine(ht.Count);
            for (int i = 0; i < count; i++)
            {
                ht.Add(i, Guid.NewGuid().ToString());
            }
            Console.WriteLine(ht.Count);
            st.Stop();
            textBox2.Text = "" + (st.ElapsedTicks / 10000 + " Milliseconds");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // HashSet 보류
            st.Reset();
            st.Start();

            for (int i = 0; i < count; i++)
            {
                hashset.Add("" + i);
            }
            st.Stop();
            textBox3.Text = "" + (st.ElapsedTicks / 10000 + " Milliseconds");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Sorted List
            st.Reset();
            st.Start();
            for (int i = 0; i < count; i++)
            {
                sl.Add(i, Guid.NewGuid().ToString());
            }
            st.Stop();
            textBox4.Text = "" + (st.ElapsedTicks / 10000 + " Milliseconds");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            st.Reset();
            st.Start();
            for (int i = 0; i < count; i++)
            {
                stack.Push(Guid.NewGuid().ToString());
            }
            st.Stop();
            textBox5.Text = "" + (st.ElapsedTicks / 10000 + " Milliseconds");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            st.Reset();
            st.Start();
            for (int i = 0; i < count; i++)
            {
                queue.Enqueue(Guid.NewGuid().ToString());
            }
            st.Stop();

            textBox6.Text = "" + (st.ElapsedTicks / 10000 + " Milliseconds");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // ArrayList Delete
            st.Reset();
            st.Start();
            Console.WriteLine(ar.Count);
            for (int i = 1; i < count; i++)
            {
                ar.RemoveAt(i);
            }
            st.Stop();
            textBox7.Text = "" + (st.ElapsedTicks / 10000 + " Milliseconds");


        }

        private void button8_Click(object sender, EventArgs e)
        {
            // HashTable 삭제
            st.Reset();
            st.Start();
            //
            Console.WriteLine(ht.Count);
            for (int i = 0; i < count; i++)
            {
                ht.Remove(i);
            }
            //

            Console.WriteLine(ht.Count);
            st.Stop();
            textBox9.Text = "" + (st.ElapsedTicks / 10000 + " Milliseconds");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            st.Reset();
            st.Start();
            Console.WriteLine(hashset.Count);
            for (int i = 0; i < count; i++)
            {

                hashset.Remove(i+"");
            }
            Console.WriteLine(hashset.Count);
            st.Stop();
            textBox10.Text = "" + (st.ElapsedTicks / 10000 + " Milliseconds");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            st.Reset();
            st.Start();
            Console.WriteLine(sl.Count);
            for (int i = 0; i < count; i++)
            {

                sl.Remove(i );
            }
            Console.WriteLine(sl.Count);
            st.Stop();
            textBox11.Text = "" + (st.ElapsedTicks / 10000 + " Milliseconds");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            st.Reset();
            st.Start();
            Console.WriteLine(stack.Count);
            for (int i = 0; i < count; i++)
            {

                stack.Pop();
            }
            Console.WriteLine(stack.Count);
            st.Stop();
            textBox12.Text = "" + (st.ElapsedTicks / 10000 + " Milliseconds");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            st.Reset();
            st.Start();
            Console.WriteLine(queue.Count);
            for (int i = 0; i < count; i++)
            {

                queue.Dequeue();
            }
            Console.WriteLine(queue.Count);
            st.Stop();
            textBox13.Text = "" + (st.ElapsedTicks / 10000 + " Milliseconds");
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Switch 테스트
            st.Reset();
            st.Start();
            for (int i = 0; i < count; i++)
            {
                int compare = i%20;

                switch (compare)
                {
                    case 0:
                        dummy = array[0];
                        break;
                    case 1:
                        dummy = array[1];
                        break;
                    case 2:
                        dummy = array[2];
                        break;
                    case 3:
                        dummy = array[3];
                        break;
                    case 4:
                        dummy = array[4];
                        break;
                    case 5:
                        dummy = array[5];
                        break;
                    case 6:
                        dummy = array[6];
                        break;
                    case 7:
                        dummy = array[7];
                        break;
                    case 8:
                        dummy = array[8];
                        break;
                    case 9:
                        dummy = array[9];
                        break;
                    case 10:
                        dummy = array[10];
                        break;
                    case 11:
                        dummy = array[11];
                        break;
                    case 12:
                        dummy = array[12];
                        break;
                    case 13:
                        dummy = array[13];
                        break;
                    case 14:
                        dummy = array[14];
                        break;
                    case 15:
                        dummy = array[15];
                        break;
                    case 16:
                        dummy = array[16];
                        break;
                    case 17:
                        dummy = array[17];
                        break;
                    case 18:
                        dummy = array[18];
                        break;
                    default:
                        dummy = array[19];
                        break;
                }
                st.Stop();
                textBox15.Text = "" + (st.ElapsedTicks / 10000 + " Milliseconds");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // IF 테스트
            st.Reset();
            st.Start();
            for (int i = 0; i < count; i++)
            {
                int compare = i % 20;

                if (compare == 0) { dummy = array[0]; }
                else if (compare == 1) { dummy = array[1]; }
                else if (compare == 2) { dummy = array[2]; }
                else if (compare == 3) { dummy = array[3]; }
                else if (compare == 4) { dummy = array[4]; }
                else if (compare == 5) { dummy = array[5]; }
                else if (compare == 6) { dummy = array[6]; }
                else if (compare == 7) { dummy = array[7]; }
                else if (compare == 8) { dummy = array[8]; }
                else if (compare == 9) { dummy = array[9]; }
                else if (compare == 10) { dummy = array[10]; }
                else if (compare == 11) { dummy = array[11]; }
                else if (compare == 12) { dummy = array[12]; }
                else if (compare == 13) { dummy = array[13]; }
                else if (compare == 14) { dummy = array[14]; }
                else if (compare == 15) { dummy = array[15]; }
                else if (compare == 16) { dummy = array[16]; }
                else if (compare == 17) { dummy = array[17]; }
                else if (compare == 18) { dummy = array[18]; }
                else { dummy = array[19]; }

            }
            st.Stop();
            textBox14.Text = "" + (st.ElapsedTicks / 10000 + " Milliseconds");

        }
    }
}
