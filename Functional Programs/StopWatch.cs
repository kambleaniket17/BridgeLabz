// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="StopWatch.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Functional_Programs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Calculate timer
    /// </summary>
    public class StopWatch
    {
        /// <summary>
        /// The start timer
        /// </summary>
        private long startTimer = 0;

        /// <summary>
        /// The stop timer
        /// </summary>
        private long stopTimer = 0;

        /// <summary>
        /// The elapsed
        /// </summary>
         private long elapsed;

        /// <summary>
        /// Starts this instance.
        /// </summary>
        public void Start()
        {
            this.startTimer = DateTime.UtcNow.Millisecond;
            Console.WriteLine("Start Time is: " + this.startTimer);
        }

        /// <summary>
        /// Stops this instance.
        /// </summary>
        public void Stop()
        {
            this.stopTimer = DateTime.UtcNow.Millisecond;
            Console.WriteLine("Stop Time is: " + this.stopTimer);
        }

        /// <summary>
        /// Gets the elapsed time.
        /// </summary>
        /// <returns>Elapsed Time</returns>
        public long GetElapsedTime()
        {
            this.elapsed = this.stopTimer - this.startTimer;
            return this.elapsed;
        }

        /// <summary>
        /// Calculates the stop watch.
        /// </summary>
        public void CalculateStopWatch()
        {
            StopWatch sw = new StopWatch();
            Console.WriteLine("Press '1' to Start Time: ");
            int a = Convert.ToInt32(Console.ReadLine());
            sw.Start(); ////Calculate Starting Time

            Console.WriteLine();
            Console.WriteLine("Press '2' to Stop Time: ");
            int b = Convert.ToInt32(Console.ReadLine());
            sw.Stop(); ////Calculate ending Time
            long l = sw.GetElapsedTime(); ////Calculate Elapsed Time
            Console.WriteLine();
            Console.WriteLine("Total Time Elapsed(in millisec) is:" + l);
            Console.WriteLine();
            Console.WriteLine("Converting millisec to seconds: " + ((double)l / 1000) + " sec");
            Console.ReadKey();
        }
    }
}
