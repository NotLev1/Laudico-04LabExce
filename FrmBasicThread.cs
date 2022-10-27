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

namespace LaudicoThread
{
    public partial class FrmBasicThread : Form
    {
        Thread threadA = new Thread(MyThreadClass.Thread1);
        Thread threadB = new Thread(MyThreadClass.Thread1);
        public FrmBasicThread()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            threadA.Name = "Thread A Process";
            threadB.Name = "Thread B Process";

            threadA.Start();
            threadB.Start();

            threadB.Join();
            threadB.Join();

            lblStart.Text = "-End Of Thread-";
            Console.WriteLine("-End of Thread-");

        }


    }
}
