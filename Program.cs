using System;
using System.Collections.Generic;
using System.Windows.Forms;

using SampleSupport;
using SampleQueries;
using System.IO;


namespace SampleQueries
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            List<SampleHarness> harnesses = new List<SampleHarness>();

            LinqSamples linqHarness = new LinqSamples();
            harnesses.Add(linqHarness);

            if (args.Length >= 1 && args[0] == "/runall")
            {
                foreach (SampleHarness harness in harnesses)
                {
                    harness.RunAllSamples();
                }
            }
            else
            {
                Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);

                using (SampleForm form = new SampleForm("LINQ Project Sample Query Explorer", harnesses))
                {
                    form.ShowDialog();
                }
            }
            
        }
    }
}
