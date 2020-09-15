using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TestCode
            /*   Person p1 = new Person(1, "a");
            Person p6 = new Person(6, "a");
            Person p5 = new Person(5, "a");
            Person p4 = new Person(4, "a");
            Person p3 = new Person(3, "a");
            Person p2 = new Person(2, "a");
            List<Availability> alist = new List<Availability>();
            //sets the start time for now
            DateTime start = DateTime.Now;
            DateTime end = start.AddHours(5);
            DateTime test = DateTime.Parse(start.ToString());
            Console.WriteLine(start.ToString());
            Console.WriteLine(test.ToString());
            TimeMethods time = new TimeMethods(start, end);
            alist.Add(new Availability(p1, start, start.AddHours(1), 0));
            alist.Add(new Availability(p2, start, start.AddMinutes(90), 0));
            alist.Add(new Availability(p3, start.AddMinutes(75), start.AddMinutes(150), 0));
            alist.Add(new Availability(p4, start.AddHours(1), start.AddHours(3), 1));
            alist.Add(new Availability(p1, start.AddMinutes(135), start.AddMinutes(225), 0));
            alist.Add(new Availability(p2, start.AddMinutes(135), start.AddMinutes(255), 0));
            alist.Add(new Availability(p5, start.AddMinutes(195), end, 0));
            alist.Add(new Availability(p6, start.AddMinutes(210), end, 0));
            Graph g = new Graph(alist, time);
            List<Vertex> sched = g.makeSchedule();
            foreach(Vertex s in sched)
            {
                Console.WriteLine(s.getPersonID() + " start time: " + s.getStartTime() + " end time: " + s.getEndTime());
            }
            */
        }

        private void btnCreateSched_Click(object sender, EventArgs e)
        {
            AvailabilityForm test = new AvailabilityForm();
            test.Show();
            Console.WriteLine(DateTime.Now.ToString());
        }
    }
}
