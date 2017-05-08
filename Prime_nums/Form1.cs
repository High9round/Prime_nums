using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;


namespace Prime_nums
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button_excute_Click(object sender, EventArgs e)
        {
            Thread prime_task = new Thread(new ThreadStart(thread_task));
            textBox_result.Text = "Loading...";

            prime_task.Start();
       
        }

        public void thread_task()
        {
            int max_num = Convert.ToInt32(numericUpDown_maxNum.Value);
            List<int> list = new List<int>();

            for (int i = 2; i <= max_num; i++)
            {
                list.Add(i);
            }
            for (int factor = 2; factor <= max_num; factor++)
            {
                list.RemoveAll(delegate (int x) { return x > factor && x % factor == 0; });
            }

            string result = "";
            for (int i = 0; i < list.Count; i++)
            {
                result += (list[i].ToString() + ", ");
            }
            result = result.Remove(result.Length - 2);

            this.Invoke(new Action(delegate () {
                textBox_result.Text = result;    
            }));

            
        }
    }
}
